using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

string connectionString = @"Data Source=LJUPCHO; Initial Catalog =ExampleDatabase; User ID=Ljupcho/Shemov;Password=;Trusted_Connection=Yes;";

SqlConnection connection = new SqlConnection(connectionString);
connection.Open();
Console.WriteLine("Conected to the Server!");
SqlCommand command = new SqlCommand();
command.Connection = connection;
command.CommandType = CommandType.Text;
command.CommandText = "SELECT * FROM dbo.People";
SqlDataReader reader = command.ExecuteReader();
if (reader.HasRows)
{

    while (reader.Read())
    {
        Console.WriteLine(reader.GetString(1)+ "-" + reader.GetString(2));

    }
}

connection.Close();