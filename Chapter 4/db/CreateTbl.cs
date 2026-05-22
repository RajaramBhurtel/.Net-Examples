using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "server=127.0.0.1;username=root;database=BCA";
        try
        {
            MySqlConnection c1 = new MySqlConnection(s1);
            c1.Open();
            string sql = "Create table 5th(id int, name varchar(20),address varchar(50))";
            MySqlCommand cmd = new MySqlCommand(sql, c1);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Success");
            c1.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadKey();
    }
}