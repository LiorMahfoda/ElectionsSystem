using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionsSystem.BussinessLogic
{
   public class Press:Citizen
    {
       public string workPlace;
       public Press(string id, string name, string street, string gender, string pass, string neigborhood, int house, DateTime bDate,string workPlace) : 
           base(id,name,street,gender,pass,neigborhood,house,bDate) {
               this.workPlace = workPlace;
       }
    }
}
