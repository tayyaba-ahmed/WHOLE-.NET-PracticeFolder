namespace overhiding_and_overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // overhiding me jiska reference dengy uska
            // function work krega.. in this case billing ka func work krega
            Billing obj = new BillingNew();
            Console.WriteLine(obj.calcbill(100));
        }
    }
}
