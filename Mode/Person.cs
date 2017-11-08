using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mode
{
    public class Person
    {
        public string name = "aa";
        public int age = 20;
        private string test = "tt";

        [testAttribute(isDisplay =true)]
        [My(IsDisplay =true)]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        [test(isDisplay =false)]
        [My(IsDisplay = true)]
        public string Test
        {
            get
            {
                return test;
            }

            set
            {
                test = value;
            }
        }


        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

      

        public string SayHi(string str)
        {
            return name + " hello " + str;
        }

       
    }
}
