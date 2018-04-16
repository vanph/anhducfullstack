using System.Collections.Generic;

namespace OverloadMethods
{
    class EmployeeManager
    {
        public IEnumerable<Employee> Search(string keyword, int orgId )
        {
            //todo: implement logic here
            return new List<Employee>();
        }

        public IEnumerable<Employee> Search(bool isActive)
        {
            //todo: implement logic here
            return new List<Employee>();
        }

        public IEnumerable<Employee> Search(int orgId)
        {
            //todo: implement logic here
            return new List<Employee>();
        }

        public IEnumerable<Employee> Search(string code)
        {
            //todo: implement logic here
            return new List<Employee>();
        }

    }
}
