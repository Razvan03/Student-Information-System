using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.Design;
using System.Windows.Forms;
using System.Collections;

namespace student_information_system
{
    public class DatabaseManager
    {
        public DatabaseManager() { }

        public void CreateTables()
        {
            string databaseName = "db";
            if (!DatabaseExists(databaseName))
            {
                // Create the database
                string createDatabaseCommand = $"CREATE DATABASE {databaseName}";
                ExecuteNonQuery(createDatabaseCommand, GetConnection(useMaster: true).ConnectionString);

                if (!TableExists("Groups"))
                {
                    string createGroupsTable = @"
                CREATE TABLE Groups
                (
                    GroupID INT IDENTITY(1,1) PRIMARY KEY,
                    No INT NOT NULL
                );";
                    ExecuteNonQuery(createGroupsTable);
                }

                // Create the tables
                if (!TableExists("Students"))
                {
                    string createStudentsTable = @"
                CREATE TABLE Students
                (
                    StudentID INT IDENTITY(1,1) PRIMARY KEY,
                    Email VARCHAR(50) NOT NULL UNIQUE,
                    GroupID INT FOREIGN KEY REFERENCES Groups(GroupID),
                    FirstName VARCHAR(50) NOT NULL,
                    LastName VARCHAR(50) NOT NULL,
                    Date_of_Birth DATE NOT NULL,
                    Sex VARCHAR(2) NOT NULL,
                    Year INT NOT NULL,
                    Address VARCHAR(MAX) NOT NULL,
                    Photo VARBINARY(MAX)
                    
                );";
                    ExecuteNonQuery(createStudentsTable);
                }

                if (!TableExists("Credentials"))
                {
                    //TO DO!!!!!!!!!!!!!!!!
                    string createCredentialsTable = @"
                CREATE TABLE Credentials
                (
                    CredID INT IDENTITY(1,1) PRIMARY KEY,
                    Email VARCHAR(50) UNIQUE FOREIGN KEY REFERENCES Students(Email),
                    Username VARCHAR(50) NOT NULL,
                    Password VARCHAR(50) NOT NULL
                    
                );";
                    ExecuteNonQuery(createCredentialsTable);
                }

                if (!TableExists("Schedules"))
                {
                    string createSchedulesTable = @"
                CREATE TABLE Schedules
                (
                    ScheduleID INT IDENTITY(1,1) PRIMARY KEY,
                    GroupID INT FOREIGN KEY REFERENCES Groups(GroupID),
                    Day VARCHAR(9) NOT NULL,
                    Interval DATETIME NOT NULL,
                    Class VARCHAR(50) NOT NULL,
                    Professor VARCHAR(50) NOT NULL,
                    RoomNo VARCHAR(5) NOT NULL
                );";
                    ExecuteNonQuery(createSchedulesTable);
                }

                if (!TableExists("Professors"))
                {
                    string createProfessorsTable = @"
                CREATE TABLE Professors
                (
                    ProfessorID INT IDENTITY(1,1) PRIMARY KEY,
                    ProfName VARCHAR(50) NOT NULL UNIQUE,
                    Class VARCHAR(50) FOREIGN KEY REFERENCES Schedules(Class)
                );";
                    ExecuteNonQuery(createProfessorsTable);
                }
            }
        }

        public void ExecuteNonQuery(string commandText, string connectionString = null)
        {
            if (connectionString == null)
            {
                connectionString = GetConnection().ConnectionString;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public SqlConnection GetConnection(bool useMaster = false)
        {
            string databaseName = useMaster ? "master" : "db";
            string connectionString = $"Server=localhost\\SQLEXPRESS02;Database={databaseName};Integrated Security=True";
            return new SqlConnection(connectionString);
        }

        private bool DatabaseExists(string databaseName)
        {
            using (SqlConnection connection = GetConnection(useMaster: true))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM sys.databases WHERE name = @DatabaseName", connection))
                {
                    command.Parameters.AddWithValue("@DatabaseName", databaseName);
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        public void InsertStudent(int groupId, string firstName, string lastName, DateTime dateOfBirth, string sex, int year, string address, byte[] photo, string email)
        {
            string insertStudentQuery = @"
        INSERT INTO Students (GroupID, FirstName, LastName, Date_of_Birth, Sex, Year, Address, Photo, Email)
        VALUES (@GroupID, @FirstName, @LastName, @Date_of_Birth, @Sex, @Year, @Address, @Photo, @Email);";

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertStudentQuery, connection))
                {
                    command.Parameters.AddWithValue("@GroupID", groupId);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Date_of_Birth", dateOfBirth);
                    command.Parameters.AddWithValue("@Sex", sex);
                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Email", email);
                    if (photo != null)
                    {
                        command.Parameters.AddWithValue("@Photo", photo);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Photo", DBNull.Value);
                    }

                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertCredential(string Username, string Password, string Email)
        {
            string insertCredentialQuery = @"
        INSERT INTO Credentials (Username, Password, Email)
        VALUES (@Username, @Password, @Email);";

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertCredentialQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool CheckCredentials(string username, string password)
        {
            string checkCredentialsQuery = @"
        SELECT COUNT(*)
        FROM Credentials
        WHERE Username = @Username AND Password = @Password;";

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(checkCredentialsQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }
        public bool CheckEmail(string Email)
        {
            string checkCredentialsQuery = @"
        SELECT COUNT(*)
        FROM Students
        WHERE Email = @Email";

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(checkCredentialsQuery, connection))
                {
                    command.Parameters.AddWithValue("@Email", Email);


                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        public bool checkStudents(int DataReceived)
        {
            Console.WriteLine($"Checking students with year: {DataReceived}");
            string query = @"SELECT COUNT(*) 
                             FROM Students
                             WHERE Year=@DataReceived;";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@DataReceived", DataReceived);
                    int count = (int)command.ExecuteScalar();
                    Console.WriteLine($"Number of students with year {DataReceived}: {count}");
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        public DataSet returnStudents(int DataReceived)
        {
            string query = @"SELECT * 
                     FROM Students
                     WHERE Year = @DataReceived;";

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DataReceived", DataReceived);

                    // Create a new DataSet
                    DataSet dataSet = new DataSet();

                    // Create a new SqlDataAdapter using the SqlCommand
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        // Fill the DataSet using the SqlDataAdapter
                        dataAdapter.Fill(dataSet);
                    }

                    // Return the DataSet
                    return dataSet;
                }
            }
        }

        private bool TableExists(string tableName)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @TableName", connection))
                {
                    command.Parameters.AddWithValue("@TableName", tableName);
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }



    }
}
