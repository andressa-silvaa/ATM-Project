using AtmProject.Attibutes;
using System.ComponentModel.DataAnnotations;

namespace AtmProject.Entidades
{
    public class Account
    {
        public Account()
        {
            this.Balance = 0;
        }
        public int AccNum { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
        public string Name { get; set; }

        [Phone(ErrorMessage = "Número de telefone inválido.")]
        public string Phone { get; set; }

        [StringLength(255, ErrorMessage = "O endereço não pode exceder 255 caracteres.")]
        public string Address { get; set; }

        [StringLength(100, ErrorMessage = "A descrição da educação não pode exceder 100 caracteres.")]
        public string Education { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Data de nascimento é obrigatória.")]
        [CheckAge(18, ErrorMessage = "Você deve ter pelo menos 18 anos.")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "PIN é obrigatório.")]
        [Range(1000, 9999, ErrorMessage = "O PIN deve ser um número de 4 dígitos.")]
        public int Pin { get; set; }

        public decimal Balance { get; set; }
    }

}
