//mine

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ElectionsSystem

{
    using BussinessLogic;
    class Database
    {
        private static Database instance;

        public static Database Instance
   {
      get 
      {
         if (instance == null)
         {
             instance = new Database();
         }
         return instance;
      }
   }

        private string connetionString = null;
        private SqlConnection con;

        private Database() // ctor
        {
            initializeConnection();
        }

        public void initializeConnection()
        {
            connetionString = "Data Source=LiorPC\\SQLEXPRESS;Initial Catalog=ElectionsProject;Integrated Security=SSPI;Server = localhost/sqlexpress";
            con = new SqlConnection(connetionString);
        }

        public Boolean OpenConn()
        {
            try
            {
                con.Open();
                //MessageBox.Show ("Connection Open ! ");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                return false;
            }

        }

        public void CloseConn(Boolean ConnStatus)
        {
            if (ConnStatus == true)
            {
                con.Close();
            }

        }



        public DataTable getOnlyCitizens()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT ID , NAME FROM CITIZENS WHERE ID IN(SELECT Citizens.id FROM CITIZENS EXCEPT ((SELECT id FROM ADMINS) UNION (SELECT id FROM PRESSMEMBERS)UNION (SELECT id FROM CONTENDERS) UNION (SELECT memberId FROM PartyMember)UNION(SELECT Partyleader FROM Parties))) ";
            //cmd.CommandText = "SELECT Citizens.id,name FROM CITIZENS EXCEPT ((SELECT id FROM ADMINS WHERH ADMINS.id=Citizens.id) UNION (SELECT id FROM PRESSMEMBERS WHERE PRESSMWMBER.id=Citizens.id)UNION (SELECT id FROM CONTENDERS WHERE CONTENDERS.id=Citizens.id) UNION (SELECT memberid FROM PartyMember WHERE PartyMember.memberid=Citizens.id)UNION(SELECT partyleader FROM PARTY WHERE PARTY.paeryleader=Citizens.id)) ";
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            //List<string> ids = new List<string>();
            //foreach (DataRow row in ds.Tables[0].Rows)
            //{
            //    ids.Add(row["id"].ToString());
            //}
            //return ids;
            return ds.Tables[0];
        }

        internal DataTable getAdminsName_Id()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Citizens.id,name FROM Admins, Citizens WHERE Admins.id=Citizens.id";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            return ds.Tables[0];
        }
        
        internal DataTable getPressName_Ids()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Citizens.id,name FROM PressMembers, Citizens WHERE PressMembers.id=Citizens.id";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            return ds.Tables[0];
        }

        public DataTable getCitizensNames_Ids()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT id,name FROM CITIZENS";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
           return ds.Tables[0];
        }
        public DataTable getContendersName_Ids()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Citizens.id,name FROM Contenders, Citizens WHERE Contenders.id=Citizens.id";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            return ds.Tables[0];
        }

        public DataTable getPartyMembers(string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT memberId,name FROM PartyMember,Citizens WHERE partyName='" + name+"' and memberId=Citizens.id";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
           
            return ds.Tables[0];
        }


        // help function for the function above
        public bool isCitizenExist(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Citizens WHERE id=" + id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            return true;
        }

        // help function for the function above
        public string getPassword(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT pass FROM CITIZENS WHERE id=" + id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            if (ds.Tables[0].Rows.Count == 0)
                return null;
            else
                return ds.Tables[0].Rows[0]["pass"].ToString();
        } 

        public List<string> getParties()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT name FROM Parties";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            List<string> parties = new List<string>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                parties.Add(row["name"].ToString());
            }
            return parties;
        }

        internal List<string> getAdmins()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT id FROM Admins";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            List<string> admins = new List<string>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                admins.Add(row["id"].ToString());
            }
            return admins;
        }

        internal List<string> getPress()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT id FROM PressMembers";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            List<string> admins = new List<string>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                admins.Add(row["id"].ToString());
            }
            return admins;
        }

        public List<string> getCitizens()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT id FROM CITIZENS";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            List<string> ids = new List<string>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ids.Add(row["id"].ToString());
            }
            return ids;
        }
        public List<string> getContendersIds() {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT id FROM Contenders";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            List<string> ids = new List<string>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ids.Add(row["id"].ToString());
            }
            return ids;
        }

        public List<string> getContenders()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT id FROM Contenders";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            List<string> contenders = new List<string>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                contenders.Add(getName(row["id"].ToString()));
            }
            return contenders;
        }





        public bool AddNewParty(string Partyname, string platform, List<String> members, string partyleader)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO Parties "
                                + "VALUES('" + Partyname + "','" + platform + "','" + partyleader + "')";
                cmd.ExecuteNonQuery();

                foreach (string id in members)
                {
                    cmd.CommandText = "INSERT INTO PartyMember "
                                + "VALUES(" + "'" + Partyname + "','" + id + "')";
                    cmd.ExecuteNonQuery();
                }


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddNewCitizen(string id, string name, string birthdate, string street, int house, string gender, string password, string neighborhood,string today,string status)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO CITIZENS "
                                + "VALUES(" + id + "," + "'" + name + "','" + birthdate + "','" + street + "'," + house + ",'" + gender + "'," + password + ",'" + neighborhood + "','"+today+"','"+status+"')";
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool isCitizen(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT id FROM citizens WHERE id=" + id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            if (ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }

        public bool isAdmin(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT id FROM ADMINS WHERE id=" + id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            if (ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }

        public bool isLeader(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT partyleader FROM Parties WHERE partyleader=" + id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            if (ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }
        public bool isContender(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT id FROM CONTENDERS WHERE id=" + id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            if (ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }

        public DataTable getTableParties()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Parties";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            return ds.Tables[0];


        }

        public DataTable getTableContender()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM contenders";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            return ds.Tables[0];


        }

        public DataTable getTablePress()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM pressMembers";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            return ds.Tables[0];


        }
       

        internal bool isPartyMember(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT memberId FROM PartyMember WHERE memberId=" + id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            if (ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }

        internal bool isPress(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT id FROM PressMembers WHERE id=" + id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            if (ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }



        internal bool ElectionStatus()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Eneble FROM ELECTION WHERE Eneble=" + "'True'";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            if (ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }











        internal string getName(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT name FROM Citizens WHERE id=" + id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            return ds.Tables[0].Rows[0]["name"].ToString();
        }

        internal bool deleteCitizen(string id)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "Delete from Citizens where id=" + id;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal bool deleteContender(string id)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "Delete from Contenders where id=" + id;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal bool deleteAdmin(string id)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "Delete from Admins where id=" + id;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal bool deletePartyMember(string id)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "Delete from PartyMember where memberId=" + id;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
/// <summary>
/// //////////////////////////////////////////////////___01/05/15 by igor
/// </summary>
/// <param name="id"></param>
/// <returns></returns>
        internal string getPartyName(string id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT partyName FROM PartyMember WHERE memberID=" + id;

                SqlDataAdapter sda = new SqlDataAdapter();
                DataSet ds = new DataSet();
                sda.SelectCommand = cmd;
                sda.Fill(ds, "Conn_DB");
                //MessageBox.Show(ds.Tables[0].Rows[0]["partyName"].ToString());
                return ds.Tables[0].Rows[0]["partyName"].ToString();
            }
            catch(Exception e)
            {
                return null;
            }
        }


        internal bool deletePartyLeaderMember(string id)
        {
            try
            {
                
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
       
                cmd.CommandText = "Delete from PartyMember where memberID=" + id;
                cmd.ExecuteNonQuery();
                    return true;
                 }
            catch (Exception ex)
            {
                return false;
            }

        }
/// <summary>
/// //////////////////////////////
/// </summary>
/// <param name="id"></param>
/// <returns></returns>
        internal bool deletePress(string id)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "Delete from PressMembers where id='"+id+"'" ;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal bool deleteParty(string name)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "Delete from PartyMember where partyname=" + name;
                cmd.ExecuteNonQuery();

                cmd.CommandText = "Delete from Parties where name=" + name;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal bool addVote(string id, string party, string contender)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO vote "
                                + "VALUES(" + id + "," + "'" + contender + "'" + ",'" + party + "')";
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }  
        }

        internal bool ChangePartyName(string text, string id, string name)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd = new SqlCommand("ALTER TABLE `PartyMember` DROP FOREIGN KEY `partyName`;", con);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE PartyMember SET partyName ='" + text + "' WHERE partyName= '" + name + "'";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE Parties SET name ='" + text + "' WHERE partyleader='" + id + "'";
                cmd.ExecuteNonQuery();
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool changeVote(string id, string party, string contender) {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "UPDATE Vote SET contender= '" + contender + "',party= '" + party + "' WHERE id= " + id;
                                   
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            } 
        }

        public bool AddPress(string id, string work_place)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO PRESSmembers "
                                + "VALUES(" + id + "," + "'" + work_place + "'" + ")";
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddAdmin(string id)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO Admins "
                                + "VALUES(" + id + ")";
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal bool AddPartyMember( string id,string partyname)
        {
            try
            {              
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
               
                cmd.CommandText = "INSERT INTO PartyMember "
                                + "VALUES('" +partyname+ "'," + "'" +id+ "')";
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal DataTable getMessagesTo(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Messege where [to]=" + id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row[1] = getName(row[1].ToString());
            }
            return ds.Tables[0];

        }
        internal DataTable getMessagesFrom(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Messege where [from]=" + id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row[2] = getName(row[2].ToString());
            }
            return ds.Tables[0];

        }
        internal bool markAsRead(string id)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "Update Messege set isread='True' where serialNo=" + id;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal bool createMessage(string from, string to, string subject, string message, string isRead)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO Messege "
                                + "VALUES(" + from + "," + "'" + to + "'" + ",'" + subject + "','" + message + "','" + isRead + "')";
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

      /*  internal int getAge(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT birthDate FROM Citizens WHERE id=" + id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            DateTime bday=Convert.ToDateTime(ds.Tables[0].Rows[0]["birthDate"].ToString());

            DateTime today = DateTime.Today;
            int age = today.Year - bday.Year;
            if (bday > today.AddYears(-age)) age--;

            return age;
        }
       */

        internal bool addNewContender(string id, string platform)
        {
            try
            {
                //DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                //cmd.CommandText = "SELECT partyName FROM PartyMember WHERE memberid=" + id;

                //SqlDataAdapter sda = new SqlDataAdapter();
                //sda.SelectCommand = cmd;
               // sda.Fill(ds, "Conn_DB");
                //if (ds.Tables[0].Rows.Count == 0||ds.Tables[0].Rows[0][0].ToString()!=party)
                //{
                   // MessageBox.Show("The contender is not a member in the specified party");
                   // return false;
                //}
                cmd.CommandText = "INSERT INTO Contenders "
                                + "VALUES(" + id + "," + "'" + platform + "')";
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal bool AddPartyLeaderMember(string id, string partyName)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "UPDATE Parties SET partyLeader= '" + id + " ' WHERE name= '" + partyName+"'";
                   
                    cmd.ExecuteNonQuery();
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable getPartyMembersTable(string party_name)
        {//return all the members of the party.(party_name)

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT name,DATEDIFF(yy,Citizens.birthdate,GETDATE()) AS Age,gender FROM PartyMember,Citizens Where partyName='" + party_name + "' and PartyMember.memberID= Citizens.id";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            return ds.Tables[0];

        }//end getPartyMembers


        public string getplat(string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT platform FROM Parties WHERE  name= '" + name + "'";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            if (ds.Tables[0].Rows.Count == 0)
                return null;
            else
                return ds.Tables[0].Rows[0]["platform"].ToString();
        }


        public string getContenderplat(string name)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = cmd.CommandText = "SELECT platform FROM Contenders where id = (SELECT id FROM Citizens WHERE  name= '" + name + "')";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            if (ds.Tables[0].Rows.Count == 0)
                return null;
            else
                return ds.Tables[0].Rows[0]["platform"].ToString();

        }

        public DataTable getTableContenders()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT name from Contenders,Citizens WHERE Contenders.id=Citizens.id  ";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            return ds.Tables[0];


        }

        public DataTable isVoted(string id,out bool voted){
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Vote WHERE id=" + id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            if (ds.Tables[0].Rows.Count > 0)
            {
                voted = true;
                return ds.Tables[0];
            }


            voted=false;
            return null;
        
        }
        ///////////////
        public Citizen getCitizen(string id) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Citizens WHERE id=" + id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            DataRow row= ds.Tables[0].Rows[0];
            Citizen c = new Citizen(id, row[1].ToString(), row[3].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), int.Parse(row[4].ToString()), Convert.ToDateTime(row[2].ToString()));
            return c;
        }
        
        public Admin getAdmin(string id) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Citizens WHERE id=" + id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            DataRow row = ds.Tables[0].Rows[0];
            Admin a = new Admin(id, row[1].ToString(), row[3].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), int.Parse(row[4].ToString()), Convert.ToDateTime(row[2].ToString()));
            return a;
        
        }

        internal Contender getContender(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Citizens.name,Citizens.birthdate,Citizens.street,Citizens.house,Citizens.gender,Citizens.pass,Citizens.neighborhood , Contenders.platform FROM Citizens,Contenders  WHERE Citizens.id=" + id + "and Contenders.id=Citizens.id";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            DataRow row = ds.Tables[0].Rows[0];
            Contender c = new Contender(id, row[0].ToString(), row[2].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), Int32.Parse(row[3].ToString()), Convert.ToDateTime(row[1].ToString()), row[7].ToString());
            return c;
        }

        internal PartyMember getPartyMember(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Citizens.name,Citizens.birthdate,Citizens.street,Citizens.house,Citizens.gender,Citizens.pass,Citizens.neighborhood , PartyMember.PartyName FROM Citizens,PartyMember  WHERE Citizens.id=" + id + "and PartyMember.memberID=Citizens.id";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            DataRow row = ds.Tables[0].Rows[0];
            PartyMember p = new PartyMember(id, row[0].ToString(), row[2].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), Int32.Parse(row[3].ToString()), Convert.ToDateTime(row[1].ToString()), row[7].ToString());
            return p;
        }

        internal PartyLeader getPartyLeader(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Citizens.name,Citizens.birthdate,Citizens.street,Citizens.house,Citizens.gender,Citizens.pass,Citizens.neighborhood , Parties.name FROM Citizens,Parties  WHERE Citizens.id=" + id + "and Parties.partyleader=Citizens.id";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            DataRow row = ds.Tables[0].Rows[0];
            PartyLeader p = new PartyLeader(id, row[0].ToString(), row[2].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), Int32.Parse(row[3].ToString()), Convert.ToDateTime(row[1].ToString()), row[7].ToString());
            return p;
        }

        internal Press getPress(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            //cmd.CommandText = "SELECT Citizens.*,PressMembers.WorkPlace FROM Citizens,PressMembers  WHERE id=" + id + "and PressMembers.id=Citizens.id";
            cmd.CommandText = "SELECT Citizens.name,Citizens.birthdate,Citizens.street,Citizens.house,Citizens.gender,Citizens.pass,Citizens.neighborhood , PressMembers.workplace FROM Citizens,PressMembers  WHERE Citizens.id=" + id + " and PressMembers.id=Citizens.id";
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            DataRow row = ds.Tables[0].Rows[0];
            Press p = new Press(id, row[0].ToString(), row[2].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), Int32.Parse(row[3].ToString()), Convert.ToDateTime(row[1].ToString()), row[7].ToString());
            return p;
        }

        public DataTable getTableCitizens()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Citizens";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            return ds.Tables[0];
        }




        internal void changeStatus(string id, string stat)
        {
            try
            {

                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "UPDATE Citizens SET status= '" + stat + "' WHERE id= '" + id + "'";

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
        }

  internal void addToDeletedCitizens(string id)
        {
            
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO DeletedCitizens "
                                + "VALUES('"  + id + "')";
                cmd.ExecuteNonQuery();

            
        }


 internal bool isDeleted(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT id FROM DeletedCitizens WHERE id=" + id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            if (ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }

 internal void changeLogDate(string id)
        {
            try
            {

                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "UPDATE Citizens SET lastLogin= '" + DateTime.Today.ToString("yyyy-MM-dd") + "' WHERE id= '" + id + "'";

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
        }

 internal string getStatus(string id)
 {
     SqlCommand cmd = new SqlCommand();
     cmd.CommandType = CommandType.Text;
     cmd.Connection = con;
     cmd.CommandText = cmd.CommandText = "SELECT status FROM Citizens where id = '" + id + "'";
     SqlDataAdapter sda = new SqlDataAdapter();
     DataSet ds = new DataSet();
     sda.SelectCommand = cmd;
     sda.Fill(ds, "Conn_DB");
     if (ds.Tables[0].Rows.Count == 0)
         return "deleted";
     else
         return ds.Tables[0].Rows[0]["status"].ToString();
 }
 internal bool isPartyLeader(string selectedId)
 {
     SqlCommand cmd = new SqlCommand();
     cmd.CommandType = CommandType.Text;
     cmd.Connection = con;
     cmd.CommandText = "SELECT partyLeader FROM Parties WHERE partyLeader=" + selectedId;
     SqlDataAdapter sda = new SqlDataAdapter();
     DataSet ds = new DataSet();
     sda.SelectCommand = cmd;
     sda.Fill(ds, "Conn_DB");
     if (ds.Tables[0].Rows.Count > 0)
         return true;
     return false;
 }
 internal bool changePartyLeaderMember(string partyName, string member_id)
 {
     try
     {

         DataSet ds = new DataSet();
         SqlCommand cmd = new SqlCommand();
         cmd.CommandType = CommandType.Text;
         cmd.Connection = con;
         cmd.CommandText = "UPDATE Parties SET partyLeader= '" + member_id + "' WHERE name= '" + partyName + "'";

         cmd.ExecuteNonQuery();
         return true;
     }
     catch (Exception ex)
     {
         return false;
     }
 }


 internal bool ChangeElectionStatus()
 {
     try
     {

         DataSet ds = new DataSet();
         SqlCommand cmd = new SqlCommand();
         cmd.CommandType = CommandType.Text;
         cmd.Connection = con;
         cmd.CommandText = "UPDATE ELECTION SET eneble= '" + !ElectionStatus() + "'";

         cmd.ExecuteNonQuery();
         return true;
     }
     catch (Exception ex)
     {
         return false;
     }
 }
 internal void changePassword(string password, string id)
 {
     try
     {

         DataSet ds = new DataSet();
         SqlCommand cmd = new SqlCommand();
         cmd.CommandType = CommandType.Text;
         cmd.Connection = con;

         cmd.CommandText = "UPDATE Citizens SET pass= '" + password + "' WHERE id= '" + id + "'";

         cmd.ExecuteNonQuery();

     }
     catch (Exception ex)
     {

     }
 }


 internal bool deleteVote()
 {
     try
     {
         DataSet ds = new DataSet();
         SqlCommand cmd = new SqlCommand();
         cmd.CommandType = CommandType.Text;
         cmd.Connection = con;

         cmd.CommandText = "Delete FROM Vote";
         cmd.ExecuteNonQuery();

         return true;
     }
     catch (Exception ex)
     {
         return false;
     }
 }

 internal bool changePlat(string id, string plat)
 {
     try
     {

         DataSet ds = new DataSet();
         SqlCommand cmd = new SqlCommand();
         cmd.CommandType = CommandType.Text;
         cmd.Connection = con;

         cmd.CommandText = "UPDATE Contenders SET platform= '" + plat + "' WHERE id= '" + id + "'";

         cmd.ExecuteNonQuery();
         return true;

     }
     catch (Exception ex)
     {
         return false;
     }
 }
    }
}
