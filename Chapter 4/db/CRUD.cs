using MySql.Data.MySqlClient;
using System;
using System.Data;
namespace DatabaseTest
{
    class Program
    {
        MySqlConnection conn;
        MySqlCommand command;
        void CreateConnection()
        {
            string constr = "SERVER=localhost; DATABASE=bca;UID = root; PASSWORD =; ";
            conn = new MySqlConnection(constr);
            conn.Open();
        }
        void InsertUpdateDelete(string sql)
        {
            command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            Console.WriteLine("Operation Performed Successfully !");
        }
        void SelectRecords(string sql)
        {
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                Console.WriteLine("Sid\t Name\t Address");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string sid = dt.Rows[i]["sid"].ToString();
                    string name = dt.Rows[i]["name"].ToString();
                    string address = dt.Rows[i]["address"].ToString();
                    Console.WriteLine(sid + "\t" + name + "\t" + address);
                }
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            try
            {
                obj.CreateConnection();
            x: Console.WriteLine("1.Insert\t 2.Update\t 3.Delete\t4.Select");


                Console.WriteLine("Enter your choice: ");
                int n = Convert.ToInt32(Console.ReadLine());
                string sql = "", nm = "", add = "";
                int id = 0;
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Ënter Name of Student: ");
                        nm = Console.ReadLine();
                        Console.WriteLine("Ënter Address of Student: ");
                        add = Console.ReadLine();
                        sql = "INSERT INTO tblStudent (name,address)VALUES('" + nm + "', '" + add + "')";
                        obj.InsertUpdateDelete(sql);
                        break;
                    case 2:
                        Console.WriteLine("Enter id to be updated");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ënter Name of Student: ");
                        nm = Console.ReadLine();
                        Console.WriteLine("Ënter Address of Student: ");
                        add = Console.ReadLine();
                        sql = "UPDATE tblStudent SET name='" + nm + "',address = '" + add + "' WHERE sid = " + id;
                        obj.InsertUpdateDelete(sql);
                        break;
                    case 3:
                        Console.WriteLine("Enter id to be deleted");
                        id = Convert.ToInt32(Console.ReadLine());
                        sql = "DELETE FROM tblStudent WHERE sid=" + id;
                        obj.InsertUpdateDelete(sql);
                        break;
                    case 4:
                        sql = "SELECT * FROM tblStudent";
                        obj.SelectRecords(sql);
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                goto x;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Connection Failed !");
            }


            Console.ReadKey();
        }
    }
}