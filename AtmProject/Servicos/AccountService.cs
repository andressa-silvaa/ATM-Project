using AtmProject.Banco;
using AtmProject.Entidades;
using AtmProject.Repositorio;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace AtmProject.Servicos
{
    public class AccountService
    {
        #region Fields
        private readonly AccountRepository _repository;
        private readonly TransactionsRepository _repositoryTransactions;
        #endregion
        #region Constructor
        private AccountService()
        {
            this._repository = new AccountRepository();
            this._repositoryTransactions = new TransactionsRepository();
        }
        #endregion
        #region Singleton Pattern
        private static AccountService instance;

        public static AccountService Instance
        {
            get
            {
                return instance ?? (instance = new AccountService());
            }
        }
        #endregion


        #region Methods
        #region Publics
        public void RegisterAccount(Account account)
        {
            this.ValidateAccount(account);
            this.ThrowExceptionIfAccountExist(account.AccNum);

            this._repository.Create(account);
        }

        public void ValidateAccount(Account account)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(account, null, null);
            bool isValid = Validator.TryValidateObject(account, validationContext, validationResults, true);

            if (!isValid)
            {
                // Agregando todas as mensagens de erro em uma única string
                var errors = new List<string>();
                foreach (var validationResult in validationResults)
                {
                    errors.Add(validationResult.ErrorMessage!);
                }

                // Lançando uma exceção com todas as mensagens de erro
                string errorMessage = string.Join("\n", errors);
                throw new ValidationException(errorMessage);
            }
        }

        public bool Login(int accNum, int pin)
        {
            this.ThrowExceptionIfAccountDoesNotExist(accNum);
            this.ThrowExceptionPinFormatValue(pin);

            return this._repository.Login(accNum, pin);
        }

        public bool UpdatePin(int accNum, int pin, int confirmPin)
        {
            if (!this.AccountExists(accNum))
                throw new Exception("Não existe essa conta para ser alterado o pin!");

            this.ThrowExceptionPinFormatValue(pin);

            if (pin != confirmPin)
                throw new Exception("Os campos pin devem ser iguais!");

            return this._repository.UpdatePin(accNum, pin);
        }

        public void ThrowExceptionPinFormatValue(int pin)
        {
            if (pin < 1000 || pin > 9999)
                throw new Exception("Por favor, informe um pin de 4 dígitos");
        }

        public bool AccountExists(int accNum)
        {
            return this._repository.GetByAcc(accNum) != null;
        }

        public bool Deposit(int accNum, decimal value, string? description = null)
        {
            this.ThrowExceptionIfAccountDoesNotExist(accNum);
            this.ThrowExceptionIfLimitExceeded(accNum, value);
            return this._repository.Deposit(accNum, value, description);
        }

        public bool Withdrawal(int accNum, decimal value, string? description = null)
        {
            this.ThrowExceptionIfAccountDoesNotExist(accNum);

            this.ThrowExceptionIfAccountDoesNotHaveSufficientBalance(accNum, value);

            if (Math.Round(value, 2, MidpointRounding.ToZero) <= 0) throw new Exception("por favor informe um valor maior que zero para realizar o saque.");

            return this._repository.Withdrawal(accNum, value, description);
        }
        #endregion

        #region Privates
        private void ThrowExceptionIfAccountExist(int accNum)
        {
            if (this.AccountExists(accNum))
                throw new Exception("Número de Conta já existe!");
        }
        private void ThrowExceptionIfAccountDoesNotExist(int accNum)
        {
            if (!this.AccountExists(accNum))
                throw new Exception("Conta não existe!");
        }
        private void ThrowExceptionIfAccountDoesNotHaveSufficientBalance(int accNum, decimal value)
        {
            var balance = this._repository.GetBalance(accNum);
            if (balance - value < decimal.Zero)
                throw new Exception($"Conta não possui saldo suficiente para a retirada!\nSaldo Atual:{balance:C2}");
        }
        private void ThrowExceptionIfLimitExceeded(int accNum, decimal value)
        {
            var diaryTransactionLimit = 10;

            if (value > 1_000_000)
                throw new Exception("Limite de valor do deposito foi atingido, por favor realize apenas transações abaixo de 1 milhão!");

            var transactions = this._repositoryTransactions.GetAllTransactions(accNum)
                .Where(transaction => transaction.TDate.Date == DateTime.Today);

            if (transactions.Count() >= diaryTransactionLimit)
                throw new Exception($"Limite de {diaryTransactionLimit} depósitos diários foi atingido!");

            if (value <= 0) throw new Exception("Informe um valor válido para o deposito!");

        }
        #endregion
        #endregion
    }
}
