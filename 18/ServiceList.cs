using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    public static class ServiceList
    {
        public static List<Service> services = new List<Service>
            {
                new Service(1, "Первый", DateTime.Now),
                new Service(2, "Второй", DateTime.Now),
                new Service(3, "Третий", DateTime.Now)
            };
    }
}
