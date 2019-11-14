using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionsSystem.BussinessLogic
{
    class PressElectionDay:PressDecorator
    {
        public PressElectionDay(Press P):base (P) {
        
        }

        public override bool ElectionStatus()
        {

            Database db = Database.Instance;
         
            bool x = false;
            x = db.ElectionStatus();
            return x;
        }
    
    }
}
