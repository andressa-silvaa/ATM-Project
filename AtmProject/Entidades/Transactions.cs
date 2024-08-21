namespace AtmProject.Entidades
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int AccNum { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime TDate { get; set; }
    }

}
