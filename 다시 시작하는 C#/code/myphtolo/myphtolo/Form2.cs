using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myphtolo
{

    public partial class Form2 : Form
    {
        private string _database = "test";
        private string _port = "3306";
        private string _id = "root";
        private string _pwd = "1234";
        private string _server = "localhost";
        string Conn = "";
        int logindata = 0;
        public Form2()
        {
            InitializeComponent();
            Conn = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pwd);
        }
        private void txtcheck()
        {
            if (txtnewid.Text == "")
            {
                txtnewid.Focus();

            }
            else if (txtnewpwd.Text == "")
            {
                txtnewpwd.Focus();
            }
        }
        
        private void newok_Click(object sender, EventArgs e)
        {   
            try
            {
                
                
                txtcheck();
                using (MySqlConnection mysql = new MySqlConnection(Conn))
                {
                    mysql.Open();
                    string insertQuery = "INSERT INTO game_id_pass (id, pwd) VALUES ('" + txtnewid.Text + "', '" + txtnewpwd.Text + "');";
                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show(txtnewid.Text + " 님"+ "회원가입 성공");
                        mysql.Close();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("에러 발생 재가입 요망");
                    } 
                }
            }catch (Exception ex)
            {
                MessageBox.Show("코드에러발생");
            }
        }
        private void DataRecevieEvent(int data)
        {
            logindata = data;
        }
    }
}
