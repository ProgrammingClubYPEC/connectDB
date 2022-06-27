using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connectDB.databases
{
    public class Instance
    {
        private static Entities entities;
        public static Entities GetContext()
        {
            if (entities == null)
                entities = new Entities();
            return entities;
        }
    }
}
