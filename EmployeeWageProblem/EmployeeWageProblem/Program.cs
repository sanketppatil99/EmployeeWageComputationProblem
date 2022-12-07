namespace EmployeeWageProblem
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program ");
            MultipleCompanies multipleCompanies = new MultipleCompanies();
            multipleCompanies.multipleCompanies("TCS",10,13,50);
            multipleCompanies.multipleCompanies("IBM", 15, 18, 40);
        }
    }
}
