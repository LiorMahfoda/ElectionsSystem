using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionsSystem.BussinessLogic
{
    public class Citizen
    {
       public string id;
       public string name;
       public string street;
       public string gender;
       public string pass;
       public string neigborhood;
       public int house;
       public DateTime bDate;

       public Citizen( string id, string name, string street, string gender, string pass, string neigborhood, int house,DateTime bDate) {
           this.id = id;
           this.name = name;
           this.street = street;
           this.pass = pass;
           this.gender = gender;
           this.neigborhood = neigborhood;
           this.bDate = bDate;
           this.house = house;
       }
       public int getAge() {
           DateTime today = DateTime.Today;
           int age = today.Year - bDate.Year;
           if (bDate > today.AddYears(-age)) age--;

           return age;
       }

    }
}
