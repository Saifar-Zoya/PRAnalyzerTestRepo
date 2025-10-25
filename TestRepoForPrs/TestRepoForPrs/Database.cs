using System.Data.SqlClient;

public class Database
{
    public void GetUser(string username)
    {
        string query = "SELECT * FROM Users WHERE Username = '" + username + "'";
        // unsafe → potential SQL injection

        //using (var conn = new SqlConnection("Server=.;Database=TestDb;Trusted_Connection=True;"))
        //{
        //    // just for demo, do nothing
        //}
    }
}
