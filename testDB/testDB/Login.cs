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
using System.Security.Cryptography;

namespace testDB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("Server = localhost;Database=testdb;Uid=root;Pwd=0000;");
                conn.Open();

                int login_status = 0;

                string login_id = id.Text;
                string login_pw = EncryptSHA256_EUCKR(pw.Text);
                string login_name = "";
                string login_rank = "";
                string login_team = "";
                string login_last = "";

                string selectQuery = "SELECT * FROM account WHERE user_id = \'" + login_id + "\'";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader user_account = cmd.ExecuteReader();

                while (user_account.Read())
                {
                    if (login_id == (string)user_account["user_id"] && login_pw == (string)user_account["user_pw"])
                    {
                        login_status = 1;
                        login_name = user_account["user_name"].ToString();
                        login_rank = user_account["user_rank"].ToString();
                        login_team = user_account["user_team"].ToString();
                        login_last = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                        string insertQuery = "INSERT INTO account last_login VALUES ('" + login_last + "');";
                        MySqlCommand insert = new MySqlCommand(insertQuery, conn);
                    }
                }
                conn.Close();

                if (login_status == 1)
                {
                    MessageBox.Show("로그인 성공");
                    Main main = new Main();
                    main.Show();
                    main.label_userinfo.Text = "(" + login_team + ") " + login_name + " " + login_rank + "님 반갑습니다.";
                    main.label_lastlogin.Text = "마지막 로그인 시각 : " + login_last;
                }
                else
                {
                    MessageBox.Show("로그인 실패");
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            Join join = new Join();
            join.ShowDialog();
        }

        public string EncryptSHA256_EUCKR(string phrase)
        {
            int euckrCodepage = 51949;
            Encoding encoder = Encoding.GetEncoding(euckrCodepage);

            SHA256CryptoServiceProvider sha256hasher = new SHA256CryptoServiceProvider();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(phrase));

            string hashString = string.Empty;

            foreach (byte x in hashedDataBytes)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return Convert.ToBase64String(encoder.GetBytes(hashString));
        }
    }
}
