

namespace Solution_2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;
                          
        
        public void GatherInformation()
        {
            System.Console.Write("Enter your first name: ");
            FirstName = System.Console.ReadLine();

            System.Console.Write("Enter your last name: ");
            LastName = System.Console.ReadLine();

            System.Console.Write("Enter your age: ");
            Age = int.Parse(System.Console.ReadLine());
            Person.SumOfAllAges += Age;
                                                
            Spouse = new Person();

            System.Console.Write("Enter your Spouse's first name: ");
            Spouse.FirstName = System.Console.ReadLine();

            Spouse.LastName = LastName;

            System.Console.Write("Enter your Spouse's age: ");
            Spouse.Age = int.Parse(System.Console.ReadLine());
            Person.SumOfAllAges += Age;

          }

                      

        public string GetFullName()
        {
            string FullName = LastName + "," + FirstName;
            return FullName;

        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(GetFullName() + "  " + "(" + Age + ")");
        }

        
        public static double SumOfAllAges;
        
    
        
        
         
        
       
    }
}
