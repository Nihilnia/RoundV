using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _1_finishinUp
{

    //MsSQL Interface
    interface IMsSQL
    {
        SqlConnection GetMsSQLConnection();
        List<MsSQL_Customers> GetAllCustomers();

        void GetCustomerByID(string ID);
        void AddCustomer(string ID, string Name, string Company);
        void UpdateCustomer(string ID, string Name, string Company);
        void DeleteCustomer(string ID);

    }
    
    //MySQL Interface
    interface IMySQL
    {
        MySqlConnection GetMySQLConnection();
        List<MySQL_Customers> GetAllCustomers();

        void GetCustomerByID(int ID);
        void AddCustomer(int ID, string Name, string surName, string Company);
        void UpdateCustomer(int ID, string Name, string surName, string Company);
        void DeleteCustomer(int ID);

    }

    class MsSQLThingz : IMsSQL
    {

        public SqlConnection GetMsSQLConnection()
        {
            string connectionString = @"Data Source= .\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = SSPI;";

            var connection = new SqlConnection(connectionString);

            return connection;
            
        }

        public List<MsSQL_Customers> GetAllCustomers()
        {
            List<MsSQL_Customers> allCustomers = new List<MsSQL_Customers>();

            using (var connection = GetMsSQLConnection())
            {
                try
                {
                    connection.Open();

                    string sqlQuery = @"SELECT CustomerID, ContactName, CompanyName FROM Customers";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    SqlDataReader theReader = command.ExecuteReader();

                    while (theReader.Read())
                    {
                        allCustomers.Add(new MsSQL_Customers
                        {
                            ID = theReader["CustomerID"].ToString(),
                            Name = theReader["ContactName"].ToString(),
                            Company = theReader["CompanyName"].ToString()
                        });
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine("Somethings went wrong with MSsql..");
                    Console.WriteLine(err.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return allCustomers;
        }

        public void GetCustomerByID(string ID)
        {
            using (var connection = GetMsSQLConnection())
            {
                try
                {
                    connection.Open();

                    string sqlQuery = @"SELECT CustomerID, ContactName, CompanyName FROM Customers WHERE CustomerID = @cID";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    ////////fuck
                    command.Parameters.Add("@cID", System.Data.SqlDbType.NChar).Value = ID;

                    SqlDataReader theReader = command.ExecuteReader();

                    //do not forget the read first, lol
                    theReader.Read();

                    Console.WriteLine($@"Here is the customer:
                                       
                                    ID: {theReader["CustomerID"]},
                                    Name: {theReader["ContactName"]},
                                    Company: {theReader["CompanyName"]},
                                
                            ");



                }
                catch (Exception err)
                {
                    Console.WriteLine("Somethings went wrong with MSsql..");
                    Console.WriteLine(err.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void AddCustomer(string ID, string Name, string Company)
        {
            using (var connection = GetMsSQLConnection())
            {
                try
                {
                    connection.Open();

                    string sqlQuery = @"INSERT INTO Customers (CustomerID, ContactName, CompanyName)

                                    VALUES(@cID, @cName, @cCompany)";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    command.Parameters.Add("@cID", System.Data.SqlDbType.NChar).Value = ID;
                    command.Parameters.Add("@cName", System.Data.SqlDbType.NVarChar).Value = Name;
                    command.Parameters.Add("@cCompany", System.Data.SqlDbType.NVarChar).Value = Company;

                    object resultZ = command.ExecuteNonQuery();

                    if(resultZ != null)
                    {
                        Console.WriteLine($@"New Customer Added...
                                            ID: {ID},
                                            Name: {Name},
                                            Company: {Company},
                                                ");
                    }


                }
                catch (Exception err)
                {
                    Console.WriteLine("Somethings went wrong with MSsql..");
                    Console.WriteLine(err.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void UpdateCustomer(string ID, string Name, string Company)
        {
            using (var connection = GetMsSQLConnection())
            {
                try
                {
                    connection.Open();

                    string sqlQuery = @"UPDATE Customers SET ContactName = @cName, CompanyName = @cCompany
                                        WHERE CustomerID = @cID";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    command.Parameters.Add("@cID", System.Data.SqlDbType.NChar).Value = ID;
                    command.Parameters.Add("@cName", System.Data.SqlDbType.NVarChar).Value = Name;
                    command.Parameters.Add("@cCompany", System.Data.SqlDbType.NChar).Value = Company;

                    object resultZ = command.ExecuteNonQuery();

                    if (resultZ != null)
                    {
                        Console.WriteLine($@"Customer Updated...
                                            ID: {ID},
                                            Name: {Name},
                                            Company: {Company},
                                                ");
                    }


                }
                catch (Exception err)
                {
                    Console.WriteLine("Somethings went wrong with MSsql..");
                    Console.WriteLine(err.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void DeleteCustomer(string ID)
        {
            using (var connection = GetMsSQLConnection())
            {
                try
                {
                    connection.Open();

                    string sqlQuery = @"DELETE FROM Customers WHERE CustomerID = @cID";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    command.Parameters.Add("@cID", System.Data.SqlDbType.NChar).Value = ID;

                    object resultZ = command.ExecuteNonQuery();

                    if (resultZ != null)
                    {
                        Console.WriteLine($@"Customer deleted, ID was: {ID}...
                                                ");
                    }


                }
                catch (Exception err)
                {
                    Console.WriteLine("Somethings went wrong with MSsql..");
                    Console.WriteLine(err.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }



    // M Y S Q L S I D E


    class MySQLThingz : IMySQL
    {

        public MySqlConnection GetMySQLConnection()
        {
            string connectionString = @"Server = localhost; port = 3306; database = northwind; user = root; password = 1234;";

            var connection = new MySqlConnection(connectionString);

            return connection;
        }

        public void AddCustomer(int ID, string Name, string surName, string Company)
        {
            using (var connection = GetMySQLConnection())
            {
                try
                {
                    connection.Open();

                    string mySqlQuery = @"INSERT INTO northwind.customers (id, first_name, last_name, company)
                                            SET id = @cID, first_name = @cName, last_name = @cSurName, company = @cCompany
                                                    ";

                    MySqlCommand command = new MySqlCommand(mySqlQuery, connection);

                    command.Parameters.Add("@cID", MySqlDbType.Int32).Value = ID;
                    command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = Name;
                    command.Parameters.Add("@cSurName", MySqlDbType.VarChar).Value = surName;
                    command.Parameters.Add("@cCompany", MySqlDbType.VarChar).Value = Company;

                    Console.WriteLine($@"Customer added..
                                            ID: {ID},                               
                                            Name: {Name},                               
                                            Suyrname: {surName},                               
                                            Company: {Company},                               
                            ");
                }
                catch (Exception err)
                {
                    Console.WriteLine("Somethings went wrong with MSsql..");
                    Console.WriteLine(err.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void DeleteCustomer(int ID)
        {
            using (var connection = GetMySQLConnection())
            {
                try
                {
                    connection.Open();

                    string mySqlQuery = @"DELETE FROM northwind.customers WHERE id = @cID";

                    MySqlCommand command = new MySqlCommand(mySqlQuery, connection);

                    command.Parameters.Add("@cID", MySqlDbType.Int32).Value = ID;

                    Console.WriteLine($@"Customer with {ID} deleted..:                               
                            ");
                }
                catch (Exception err)
                {
                    Console.WriteLine("Somethings went wrong with MSsql..");
                    Console.WriteLine(err.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<MySQL_Customers> GetAllCustomers()
        {
            List<MySQL_Customers> allCustomers = new List<MySQL_Customers>();

            using (var connection = GetMySQLConnection())
            {
                try
                {
                    connection.Open();

                    string mySqlQuery = @"SELECT id, CONCAT(first_name, ' ', last_name) AS 'Name', company";

                    MySqlCommand command = new MySqlCommand(mySqlQuery, connection);

                    MySqlDataReader theReader = command.ExecuteReader();

                    while (theReader.Read())
                    {
                        allCustomers.Add(new MySQL_Customers
                        {
                            ID = Convert.ToInt32(theReader["id"].ToString()),
                            Name = theReader["Name"].ToString(),
                            Company = theReader["company"].ToString()
                        });
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine("Somethings went wrong with MSsql..");
                    Console.WriteLine(err.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return allCustomers;
        }

        public void GetCustomerByID(int ID)
        {
            using (var connection = GetMySQLConnection())
            {
                try
                {
                    connection.Open();

                    string mySqlQuery = @"SELECT id, CONCAT(first_name, ' ', last_name) AS 'Name', company FROM northwind.customers WHERE id = @cID";

                    MySqlCommand command = new MySqlCommand(mySqlQuery, connection);

                    command.Parameters.Add("@cID", MySqlDbType.Int32).Value = ID;

                    MySqlDataReader theReader = command.ExecuteReader();

                    Console.WriteLine($@"Here is the customer:
                                       
                                    ID: {theReader["id"]},
                                    Name: {theReader["Name"]},
                                    Company: {theReader["company"]},
                                
                            ");
                }
                catch (Exception err)
                {
                    Console.WriteLine("Somethings went wrong with MSsql..");
                    Console.WriteLine(err.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        

        public void UpdateCustomer(int ID, string Name, string surName, string Company)
        {
            using (var connection = GetMySQLConnection())
            {
                try
                {
                    connection.Open();

                    string mySqlQuery = @"UPDATE northwind.customers SET first_name = @cName, last_name = @cSurName, company = @cCompany WHERE id = @cID";

                    MySqlCommand command = new MySqlCommand(mySqlQuery, connection);

                    command.Parameters.Add("@cID", MySqlDbType.Int32).Value = ID;
                    command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = Name;
                    command.Parameters.Add("@cSurName", MySqlDbType.VarChar).Value = surName;
                    command.Parameters.Add("@cCompany", MySqlDbType.VarChar).Value = Company;

                    Console.WriteLine($@"Customer with {ID} updated..:                               
                            ");
                }
                catch (Exception err)
                {
                    Console.WriteLine("Somethings went wrong with MSsql..");
                    Console.WriteLine(err.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //MsSQL Processes
            MsSQLThingz msSqlProcesses = new MsSQLThingz();

            while (true)
            {
                Console.WriteLine(@"What do you wanna do (MsSQL):
                1) Get All Customers
                2) Get a Customer by ID
                3) Add a new customer
                4) Update a customer
                5) Delete a customer    
            ");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        var allCustomers = msSqlProcesses.GetAllCustomers();

                        Console.WriteLine("All Customers FROM MsSQL:");

                        foreach (var f in allCustomers)
                        {
                            Console.WriteLine(@$"
                            ID: {f.ID},
                            ID: {f.Name},
                            ID: {f.Company},
");
                        }

                        Console.WriteLine("Total Customer Count:" + allCustomers.Count);
                        break;

                    case "2":
                        Console.WriteLine("Give me the ID..: ");
                        string consoleID = Console.ReadLine();
                        msSqlProcesses.GetCustomerByID(consoleID);
                        break;

                    case "3":
                        Console.WriteLine("Give me the ID..: ");
                        string newID = Console.ReadLine();
                        Console.WriteLine("Give me the Name..: ");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Give me the Company Name..: ");
                        string newCompany = Console.ReadLine();

                        msSqlProcesses.AddCustomer(newID, newName, newCompany);
                        break;

                    case "4":

                        Console.WriteLine("Give me the ID..: ");
                        string updateID = Console.ReadLine();
                        Console.WriteLine("Give me the Name..: ");
                        string updateName = Console.ReadLine();
                        Console.WriteLine("Give me the Company Name..: ");
                        string updateCompany = Console.ReadLine();
                        msSqlProcesses.UpdateCustomer(updateID, updateName, updateCompany);
                        break;

                    case "5":
                        Console.WriteLine("Give me the ID fro the delete..: ");
                        string deleteID = Console.ReadLine();
                        msSqlProcesses.DeleteCustomer(deleteID);
                        break;

                    default:
                        break;
                }
            }

            

        }
    }
}
