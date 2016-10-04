

namespace Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
                        
            System.Console.WriteLine("[ Enter Information for p1 ]");
            
            p1.GatherInformation();

            System.Console.WriteLine("[ Enter Information for p2 ]");

            p2.GatherInformation();                              

            System.Console.WriteLine("[ Printing Results ] ");

            p1.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();
                        
            double AverageAge = Person.SumOfAllAges / 4;
            System.Console.WriteLine("Average Age =" + AverageAge);                       
            System.Console.WriteLine("Press any key to continue...");

            System.Console.ReadKey();

            
        }
    }
}
