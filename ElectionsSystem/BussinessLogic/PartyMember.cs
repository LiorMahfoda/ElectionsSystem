using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionsSystem.BussinessLogic
{
    public class PartyMember:Citizen
    {


        public string partyName;
       public PartyMember(string id, string name, string street, string gender, string pass, string neigborhood, int house, DateTime bDate, string partyName) : 
           base(id,name,street,gender,pass,neigborhood,house,bDate) {
               this.partyName = partyName;
       }
    }
}
