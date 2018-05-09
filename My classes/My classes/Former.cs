using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_classes
{
    
        public class Former
        {
            string Name;
            string FirstName;
            int Age;
            string Specialisation;

            public string NAME { get; set; }
            public string FIRSTNAME { get; set; }
            public int AGE { get; set; }
            public string SPECIALISATION { get; set; }

            public Former() { }

            public Former(string name, string firstname, int age, string specialisation)
            {
                this.Name = name;
                this.FirstName = firstname;
                this.Age = age;
                this.Specialisation = specialisation;
            }
        }
    
}
