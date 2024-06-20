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
    public partial class Join : Form
    {
        public Join()
        {
            InitializeComponent();
        }

        private void Join_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_pw.Text == txtbox_pw2.Text)
                {
                    MySqlConnection conn = new MySqlConnection("Server = localhost;Database=testdb;Uid=root;Pwd=0000");
                    conn.Open();
                    string insertQuery = "INSERT INTO account (user_name, user_id, user_pw, user_rank, user_team) VALUES ('" + txtbox_name.Text + "', '" + txtbox_id.Text + "', '" + EncryptSHA256_EUCKR(txtbox_pw.Text) + "', '" + combo_rank.Text + "', '" + combo_team.Text + "');";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("(" + combo_team.Text + ") " + txtbox_name.Text+ " " + combo_rank.Text + "님 반갑습니다, 아이디는 " + txtbox_id.Text + " 입니다.");
                        conn.Close();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("다시 확인해 주세요.");
                    }
                }
                else
                {
                    MessageBox.Show("비밀번호가 같지 않습니다.");
                }
                
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
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
