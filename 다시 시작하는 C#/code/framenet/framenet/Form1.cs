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

namespace framenet
{
    public partial class Form1 : Form
    {
        private string _server = "localhost";
        private string _database = "test";
        private string _port = "3306";
        private string _uid = "root";
        private string _pass = "1234";
        string Conn = "";
        public Form1()
        {
            InitializeComponent();
            Conn = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _uid, _pass);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvlist_OleDb_view();
        }
        private void lvlist_OleDb_view()
        {
            lvlist.View = View.Details; 
            lvlist.Items.Clear();
            
            try
            {
                
                using (MySqlConnection  Mysql = new MySqlConnection(Conn))
                {
                    Mysql.Open();
                    string SelectQurey = string.Format("SELECT * from t_info", Mysql);
                    MySqlCommand command = new MySqlCommand(SelectQurey, Mysql);
                    MySqlDataReader table =  command.ExecuteReader();
                    //if (command.ExecuteNonQuery() != 1) MessageBox.Show("데이터베이스 에러"); // 현재 인식못함 
                    ListViewItem lvi = new ListViewItem();
                    
                    while (table.Read())
                    {
                        this.lvlist.Items.Add(new ListViewItem(new string[] { table[0].ToString(), table[1].ToString(), table[2].ToString(), table[3].ToString(), table[4].ToString() }));
                    }
                    lvlist.EndUpdate();
                    lvlist.Items.Clear();
                    
                    
                }

            }catch (Exception ex)
            {
                MessageBox.Show("코드 에러발생");
            }
          
        }
        private bool Txtcheck()
        {
            if (this.textBox1.Text == "")
            {
                this.textBox1.Focus();
                return false;
            }
            if (this.textBox2.Text == "")
            {
                this.textBox2.Focus();
                return false;
            }
            if (this.textBox3.Text == "")
            {
                this.textBox3.Focus();
                return false;
            }
            if (this.textBox4.Text == "")
            {
                this.textBox4.Focus();
                return false;
            }
            return true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {   try
            {   if (Txtcheck() == true)
                {
                    using (MySqlConnection Mysql = new MySqlConnection(Conn))
                    {
                        Mysql.Open();
                        string UpdateQuery = "INSERT INTO t_info(name, age, phone, job) ";

                        UpdateQuery += "VALUES('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "')";
                        MySqlCommand command = new MySqlCommand(UpdateQuery, Mysql);
                        command.ExecuteNonQuery();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("정상적으로 데이터가 업데이트 되었습니다", "알림", MessageBoxButtons.OK);

                            txtClear();
                        }
                        else
                        {
                            MessageBox.Show("DB 에러발생", "알림", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("코드 에러발생", "알림", MessageBoxButtons.OK);
            }
        }
        private void txtClear()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
        }
        

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (this.lvlist.SelectedIndices.Count > 0) 
            {
                DialogResult _dlr = MessageBox.Show("선택한 데이터를 삭제할까요?","알림",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            switch (_dlr)
            {
                 case DialogResult.Yes:
                        try
                        {
                            int num = 0;
                            using(MySqlConnection Mysql = new MySqlConnection(Conn))
                            { 
                                Mysql.Open();
                                string delQuery = "DELETE FROM t_into where child = " + num + "";
                                
                                MySqlCommand command = new MySqlCommand(delQuery,Mysql);
                                
                                if (command.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("정상적으로 삭제가 완료 되었습니다.", "알림",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("정상적으로 삭제되지 않았습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }catch (Exception ex)
                        {
                            MessageBox.Show("코드 에러 발생");
                        }
                 
                        break;
                 case DialogResult.No:
                 {      
                        break;
                 }
                }
            }
            

        }
        

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (Txtcheck() == true)
            {
                try
                {
                    //this.lvlist_Click();
                    using (MySqlConnection Mysql = new MySqlConnection(Conn))
                    {
                        Mysql.Open();
                        string UpdateQuery = "UPDATE t_info SET name ='" + this.textBox1.Text + ",' age=" + this.textBox2.Text; // 여기서 에러확률 높음
                        UpdateQuery += "', phone='" + this.textBox3.Text + "', job= '" + this.textBox4.Text + "'WHERE id = " + num + ""; 
                        MySqlCommand command = new MySqlCommand(UpdateQuery,Mysql);
                        if(command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("수정완료","알림",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("수정실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("코드에러");
                }
                
            }
        }
      
        private void lvlist_Click(object sender, EventArgs e)
        {
            if (this.lvlist.SelectedItems.Count > 0)
            {
                string num = this.lvlist.SelectedItems[0].SubItems[0].Text;
                this.textBox1.Text = this.lvlist.SelectedItems[0].SubItems[1].Text;
                this.textBox2.Text = this.lvlist.SelectedItems[0].SubItems[2].Text;
                this.textBox3.Text = this.lvlist.SelectedItems[0].SubItems[3].Text;
                this.textBox4.Text = this.lvlist.SelectedItems[0].SubItems[4].Text;

            }
        }
    }
}
