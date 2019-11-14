using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionsSystem.BussinessLogic
{
    public  class AdminAdapter:Citizen
    {

        public AdminAdapter(Admin P) : base(P.id, P.name, P.street, P.gender, P.pass, P.neigborhood, P.house, P.bDate)
        {
        
        }

        public  bool ElectionStatus()
        {

            Database db = Database.Instance;
         
            bool x = false;
            x = db.ElectionStatus();
            if (x == true) {
                System.Windows.Forms.MessageBox.Show("You Cannot do it at Elecion day!!");
           
            }
            return x;
        }
    }
}
