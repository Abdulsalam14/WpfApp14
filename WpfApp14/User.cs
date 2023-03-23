using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14
{
    public class User
    {
        public User(string name, string surName, DateOnly birth)
        {
            Name = name;
            SurName = surName;
            Birth = birth;
        }

        public string Name { get; set; }
        public string SurName { get; set; }

        public DateOnly Birth { get; set; }

    }
}
