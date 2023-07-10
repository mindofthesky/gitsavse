using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myphtolo
{
    public partial class Form1 : Form
    {
        private string _database = "test";
        private string _port = "3306";
        private string _id = "root";
        private string _pwd = "1234";
        private string _server = "localhost";
        string Conn = "";



        public Form1()
        {
            InitializeComponent();
            Conn = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pwd);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtcheck()
        {
            if (txtid.Text == "")
            {
                txtid.Focus();

            }
            else if (txtpass.Text == "")
            {
                txtpass.Focus();
            }
        }

        private void login_Click(object sender, EventArgs e)
        {

            txtcheck();
            try
            {

                using (MySqlConnection Mysql = new MySqlConnection(Conn))
                {
                    Mysql.Open();

                    int log_state = 0;
                    string loginid = txtid.Text;
                    string loginps = txtpass.Text;

                    string SelectQurey = "SELECT * FROM game_id_pass where id = \'" + loginid + "\'";
                    MySqlCommand command = new MySqlCommand(SelectQurey, Mysql);
                    MySqlDataReader R = command.ExecuteReader();

                    while (R.Read())
                    {
                        if (loginid == (string)R["id"] && loginps == (string)R["pwd"])
                        {
                            log_state = 1;

                            Form3 mypage = new Form3();
                            mypage.ShowDialog();


                        }


                    }

                    if (log_state == 1)
                    {

                     //   MessageBox.Show("로그인 성공");


                    }
                    else
                    {
                       // MessageBox.Show("로그인 실패");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("코드 에러발생");
            }


        }


        private void newMember_Click(object sender, EventArgs e)
        {

            Form2 showform2 = new Form2();
            showform2.ShowDialog();
            Form1 showform1 = new Form1();

        }
    }
}