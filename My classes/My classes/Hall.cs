using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_classes
{
    public class Hall
    {
        int Id;
        string Type;
        Tools Tools;
        Former Former;

        public int ID { get; set; }
        public string TYPE { get; set; }
        public Tools TOOLS { get; set; }
        public Former FORMER { get; set; }

        public Hall() { }

        public Hall(int id, string type, Tools tools, Former former)
        {
            this.Id = id;
            this.Type = type;
            this.Tools = tools;
            this.Former = former;
        }
    }
}
