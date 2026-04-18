using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamespace
{
    public class StudentInfo
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string studentNo { get; set; }

        public StudentInfo(string firstN)
        {
            this.firstName = firstN;
        }

        public StudentInfo(string firstN, string lastN) : this(firstN)
        {
            this.lastName = lastN;
        }

        public StudentInfo(string firstN, string lastN, string stuNo) : this(firstN, lastN)
        {
            this.studentNo = stuNo;
        }

    }
}
