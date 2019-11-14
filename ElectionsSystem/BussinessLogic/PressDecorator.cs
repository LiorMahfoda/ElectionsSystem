using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionsSystem.BussinessLogic
{
   abstract class PressDecorator : Citizen
    {
        public string workPlace;

        Press basePress = null;
        protected PressDecorator(Press P) :
            base(P.id, P.name, P.street, P.gender, P.pass, P.neigborhood, P.house, P.bDate)
        {
            basePress = P;
        }
        public abstract bool ElectionStatus();
       
    }
}