using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinMan.Model
{
    public class Jincome
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }

    public class Jincomes
    {
        public List<Jincome> jins { get; set; }
    }

    public class Action
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }


}
