using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]

        static void Main()
        {   //데이터베이스 변수선언 단점은 connection 정보가 다 들어있어서 하드 코딩은 추천되지 않을것같다 
            using (MySqlConnection connection = new MySqlConnection("server=localhost;,port=3036;Database=test;Uid=root;Pwd=1234;"))
            {
                string insertQurey = "INSERT INTO test(id, pwd) VALUES(test,1234)";
                try { 
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQurey, connection);
                    
                        if(command.ExecuteNonQuery() ==1 )
                        {
                        Console.WriteLine("INSERT SCUSEX");
                        }
                        else
                        {
                        Console.WriteLine("INSERT FAIL");
                    }
                    }
                    catch (Exception ex)
                    {
                    Console.WriteLine("실패");
                    connection.Close();
                    }
                }
            }
            //    Console.WriteLine("Hello World");

        }
    }
