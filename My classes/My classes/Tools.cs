using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_classes
{
    public class Tools
    {
        int id;
        string name;
        int NbrTools;
        string Description;

        public int ID { get; set; }
        public string NAME { get; set; }
        public int NBRTOOLS { get; set; }
        public string DESCRIPTION { get; set; }

        public Tools() { }

        public Tools(int id,string name,int nbrtools,string description)
        {
            this.id = id;
            this.name = name;
            this.NbrTools = nbrtools;
            this.Description = description;
        }
    }
}
