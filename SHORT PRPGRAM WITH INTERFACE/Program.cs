namespace SHORT_PROGRAM_WITH_ABSTRACT_CLASS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank obj = new BankImplementation();
            obj.Credit(12000);
            obj.CheckBalance();
            obj.Debit(10000);
            obj.CheckBalance();
        }
    }
}
