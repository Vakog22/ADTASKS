using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime date { get; set; }
        public Service(int a, string b, DateTime c)
        {
            Id = a;
            Name = b;
            date = c;
        }
    }
}
