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

            // Update query
            string sql = "update student set name='Rajaram' where id=1";

            MySqlCommand cmd = new MySqlCommand(sql, c1);

            // Execute update query
            int rows = cmd.ExecuteNonQuery();

            Console.WriteLine(rows + " record updated successfully");

            c1.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadKey();
    }
}