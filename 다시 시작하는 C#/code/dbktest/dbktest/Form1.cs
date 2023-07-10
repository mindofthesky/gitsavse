using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbktest
{
    public partial class Form1 : Form
    {
        string _Server = "localhost";
        string _Database = "test";
        string _port = "3306";
        string _id = "root";
        string _pwd = "1234";
        string _Connections = "";
        public Form1()
        {
            InitializeComponent();
            _Connections = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};", _Server, _port, _Database, _id, _pwd);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) //리스트뷰 
        {
            ListView listview = sender as ListView;

            int index = listview.FocusedItem.Index;
            listView1.View = View.Details;
            textBox1.Text = listview.Items[index].SubItems[1].Text;
            textBox2.Text = listview.Items[index].SubItems[2].Text;
        }
        private void button1_Click(object sender, EventArgs e) //초기화
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        #region update
        private void button2_Click(object sender, EventArgs e) //수정
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection())
                {
                    mysql.Open();
                    int pos = listView1.SelectedItems[0].Index;
                    int index = Convert.ToInt32(listView1.Items[0].Text);
                    string updateQuery = string.Format("UPDATE dbk set name = '{1}', phone='{2}' WHERE = {0};", index, textBox1.Text, textBox2.Text);
                    MySqlCommand command = new MySqlCommand(updateQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("error");
                    textBox1.Text = "";
                    textBox2.Text = "";

                    selectable();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("ex 에러");
            }

        }
        #endregion

        #region select
        private void button5_Click(object sender, EventArgs e) //조회
        {
            selectable();
        }

        private void selectable() // 조회 
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_Connections))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT * FROM dbk");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("error");
                    listView1.Items.Clear();

                    while (table.Read())
                    {   
                        ListViewItem item = new ListViewItem();
                        item.Text = table["id"].ToString();
                        item.SubItems.Add(table["name"].ToString());
                        item.SubItems.Add(table["phone"].ToString());

                        listView1.Items.Add(item);
                    }
                   

                    table.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region insert
        private void button2_Click_1(object sender, EventArgs e) //삽입
        {
            try {
                using (MySqlConnection mysql = new MySqlConnection(_Connections))
                {
                    mysql.Open();
                    string insertQuery = string.Format("INSERT INTO dbk (name, phone) VALUES('{0}', '{1}');", textBox1.Text, textBox2.Text);
                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Erorr");
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";

                    selectable();

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Delect
        private void button4_Click(object sender, EventArgs e) //삭제
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_Connections))
                {
                    mysql.Open();
                    int pos = listView1.SelectedItems[0].Index;
                    int index = Convert.ToInt32(listView1.Items[pos].Text);
                    string DelectQuery = string.Format("DELETE FORM dbk Where id={0};", index);
                    MySqlCommand command = new MySqlCommand(DelectQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("에러");
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";

                    selectable();
                }

            }catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
        }
    }

}
