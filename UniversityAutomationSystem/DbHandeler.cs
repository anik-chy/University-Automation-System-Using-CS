using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for DbHandeler
/// </summary>
public class DbHandeler
{
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    public DbHandeler()
	{
        server = "localhost";
        database = "university";
        uid = "root";
        password = "";

        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        connection = new MySqlConnection(connectionString);
	}

    public MySqlConnection getConnection()
    {
        return connection;
    }
}