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
    public partial class Form4 : Form
    {
        private string _database = "test";
        private string _port = "3306";
        private string _id = "root";
        private string _pwd = "1234";
        private string _server = "localhost";
        string Conn = "";
        public Form4()
        {
            InitializeComponent();
            Conn = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pwd);
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection Mysql = new MySqlConnection(Conn))
                {
                    string updateQuery = "UPDATE game_id_pass set pwd =" +change_pass.Text + "where id = ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("코드 에러 발생");
            }
        }
    }
}
