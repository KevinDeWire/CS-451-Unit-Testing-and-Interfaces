using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Benefits.Entities
{
    public class Employee
    {
        public int Employee_ID { get; set; }
        public int Employee_Type { get; set; }
        public int Employee_Retirement_Matching { get; set; }
        public int Employee_Medical_Benefits { get; set; }
        public int Employee_PTO { get; set; }
    }
}
