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

            try
            {
                MySqlConnection conn = new MySqlConnection("Server = localhost;Database=testdb;Uid=root;Pwd=0000;");

                conn.Open();
                string selectQuery = "SELECT * FROM account order by num asc;";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(selectQuery, conn);
                da.Fill(dt);

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
            }
            sql_connect.Enabled = false;
            
        }
    }
}
