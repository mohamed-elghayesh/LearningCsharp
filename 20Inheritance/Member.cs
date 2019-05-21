using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus
{
    class Member
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Department { get; set; }
    }

    enum Gender
    {
        Male, Female
    }
}
