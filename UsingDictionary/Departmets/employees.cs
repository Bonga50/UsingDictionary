using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDictionary.Departmets
{
    internal class employees
    {
        public int empNum { get; set; }
        public string empName { get; set;}

        public employees()
        {
                
        }

        public employees(int empNum, string empName)
        {
            this.empNum = empNum;
            this.empName = empName;
        }
    }
}
