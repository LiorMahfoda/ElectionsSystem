using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionsSystem.BussinessLogic
{
    public class Contender:Citizen
    {
          public string platform;
          public Contender(string id, string name, string street, string gender, string pass, string neigborhood, int house, DateTime bDate, string platform) : 
           base(id,name,street,gender,pass,neigborhood,house,bDate) {
               this.platform = platform;
       }
    }
}
