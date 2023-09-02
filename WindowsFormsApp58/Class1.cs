using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp58
{
    public class cEmployee
    {
        public string firstname;
        public string lastname;
        public string identity;

        public cEmployee()
        {
            firstname = "ali";
            lastname = "yahyavi";
        }

        public cEmployee(string s1, string s2)
        {

        }

        public string Concatinate()
        {
            return firstname + ' ' + lastname;
        }

        public string Concatinate(string s)
        {
            return firstname + ' ' + lastname + ' ' + s;
        }


    }
}
