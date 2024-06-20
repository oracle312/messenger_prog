using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace testDB
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        public Main(Login login)
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            sql_connect.Enabled = true;
        }

        private void sql_connect_Tick(object sender, EventArgs e)
        {
            tree_member.Nodes.Clear();

            MySqlConnection conn = new MySqlConnection("Server = localhost;Database=testdb;Uid=root;Pwd=0000;");
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM account", conn);
            da.Fill(dt);

            /*foreach (DataRow dr in dt.Rows)
            {
                TreeNode nod = tree_member.Nodes.Find(dr["user_team"].ToString(), false);
                if (nod == null)
                {
                    nod = new TreeNode(dr["user_team"].ToString());
                    tree_member.Nodes.Add(nod);
                }
                nod.Nodes.Add(dr["user_name"].ToString());
            }*/

            

            int i = 0;
            foreach (IGrouping<string, string> user_team in dt.Rows.Cast<DataRow>().GroupBy(dr => dr["user_team"].ToString(), dr => dr["user_name"].ToString()))
            {
                TreeNode nod = new TreeNode(user_team.Key);

                foreach (string user_name in user_team)
                    nod.Nodes.Add(user_name);

                tree_member.Nodes.Add(nod);
                i++; 
            }

            /*try
            {
                MySqlConnection conn = new MySqlConnection("Server = localhost;Database=testdb;Uid=root;Pwd=0000;");

                conn.Open();
                string selectQuery = "SELECT * FROM account order by num asc;";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                

                while (dr.Read())
                {



                    TreeNode tn = new TreeNode(dr["user_team"].ToString());
                    tn.Nodes.Add(dr["user_name"].ToString() + " " + dr["user_rank"].ToString());
                    tree_member.Nodes.Add(tn);

                    
                }
                conn.Close();
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }*/
            sql_connect.Enabled = false;
            
        }

      
        
    }
}
