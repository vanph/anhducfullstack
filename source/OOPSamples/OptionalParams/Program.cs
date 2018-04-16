namespace OverloadMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var empManager = new EmployeeManager();
            empManager.Search("van");
            empManager.Search("van", 2);
        }
    }
}
