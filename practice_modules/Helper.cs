using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;       
using System.Text;
using System.Threading.Tasks;
using practice_modules.models;

namespace practice_modules
{
    public class Helper
    {
        private static AEROPORT_ModulesEntities3 s_firstDBEntities;

 

        public static AEROPORT_ModulesEntities3 GetContext()
        {
            if (s_firstDBEntities == null)
            {
                s_firstDBEntities = new AEROPORT_ModulesEntities3();
            }
            return s_firstDBEntities;
        }
    }
}
