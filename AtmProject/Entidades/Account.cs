namespace AtmProject.Entidades
{
    public class Account
    {
        public Account()
        {
            this.Balance = 0;
        }
        public int AccNum { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Education { get; set; }
        public DateTime Dob { get; set; }
        public int Pin { get; set; }
        public decimal Balance { get; set; }
    }

}
