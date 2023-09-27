using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPri
{
    class Manager
    {
        private static dbLibraryEntities entities = null;
        public static int userId = -1;
        public static dbLibraryEntities GetEntities()
        {
            if (entities == null)
            {
                entities = new dbLibraryEntities();
            }
            return entities;
        }
    }
}
