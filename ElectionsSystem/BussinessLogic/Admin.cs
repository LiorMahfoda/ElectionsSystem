using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionsSystem.BussinessLogic
{
    public class Admin:Citizen
    {
         
         public Admin(string id, string name, string street, string gender, string pass, string neigborhood, int house, DateTime bDate) : 
           base(id,name,street,gender,pass,neigborhood,house,bDate) {
               
       }
        public  bool ElectionStatus()
        {

            Database db = Database.Instance;
         
            bool x = false;
            x = db.ElectionStatus();
            return x;
        }
    }
}
