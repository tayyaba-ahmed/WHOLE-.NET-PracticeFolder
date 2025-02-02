namespace exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter first digit");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second digit");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
            }
            //catch(Exception ex) 
            //{
            //    //Console.WriteLine(ex.Message);
            //    Console.WriteLine("Incorrect Input");
            //}
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Denominator cannot be zero");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Enter only numeric data");
            }
            finally
            {
                Console.WriteLine("It will print in both condition");
            }
        }
    }
}
