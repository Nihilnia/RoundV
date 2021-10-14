using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _3_deletingIntel
{
    class Program
    {

        static void Main(string[] args)
        {

            //Reaching to SQL
            SqlProcess sqlThingz = new SqlProcess();

            foreach (var f in sqlThingz.GetAllCustomers())
            {
                Console.WriteLine(@$"
                    CUSTOMER
                ID: {f.ID},
                Name: {f.Name},
                Company: {f.Company}            
            ");
            }
            var theCountSQL = sqlThingz.CountThem();

            Console.WriteLine("Total results: " + theCountSQL);

            Console.WriteLine("Give me the ID (Sql): ");
            string userInputSQL = Console.ReadLine();
            SQL_Customers foundCustomerSQL = sqlThingz.GetCustomerByID(userInputSQL);
            Console.WriteLine(@$"Customer found: " +
                $"ID: {foundCustomerSQL.ID}" +
                $"Name: {foundCustomerSQL.Name}" +
                $"Company: {foundCustomerSQL.Company}");

            Console.WriteLine("Wanna add new customer? ");
            var userChoice = Console.ReadLine();

            if (userChoice.ToUpper() == "Y")
            {
                Console.WriteLine("ID: ");
                string consoleID = Console.ReadLine();
                Console.WriteLine("Name: ");
                string consoleName = Console.ReadLine();
                Console.WriteLine("Company: ");
                string consoleCompany = Console.ReadLine();

                sqlThingz.AddCustomer(consoleID, consoleName, consoleCompany);
            }

            Console.WriteLine("Wanna delete a customer by ID?: ");
            string userDeleteChoice = Console.ReadLine();
            if (userDeleteChoice.ToUpper() == "Y")
            {
                Console.WriteLine("Give me the ID for the delete..:");
                string consoleDelete = Console.ReadLine();
                sqlThingz.DeleteCustomer(consoleDelete);
            }


        }


        // I N T E R F A C E S

        interface ISQLThingz
        {

            public SqlConnection GetSQLConnection();
            public List<SQL_Customers> GetAllCustomers();

            public SQL_Customers GetCustomerByID(string ID);
            public void AddCustomer(string ID, string Name, string Company);
            public void DeleteCustomer(string ID);
            public void UpdateCustomer();
            int CountThem();
        }

        interface IMySQLThingz
        {

            public MySqlConnection GetMySQLConnection();
            public List<MySQL_Customers> GetAllCustomers();

            public MySQL_Customers GetCustomerByID(int ID);
            public void AddCustomer();
            public void DeleteCustomer();
            public void UpdateCustomer();

            int Count();
        }





        // SQL BASE

        public class SqlProcess : ISQLThingz
        {
            public void AddCustomer(string ID, string Name, string Company)
            {
                using (var connection = GetSQLConnection())
                {
                    try
                    {
                        connection.Open();


                        string sqlQuery = @"INSERT INTO Customers (CustomerID, ContactName, CompanyName)
                                                VALUES (@cID, @cName, @cCompany)";

                        SqlCommand command = new SqlCommand(sqlQuery, connection);

                        command.Parameters.Add("@cID", System.Data.SqlDbType.NChar).Value = ID;
                        command.Parameters.Add("@cName", System.Data.SqlDbType.NChar).Value = Name;
                        command.Parameters.Add("@cCompany", System.Data.SqlDbType.NChar).Value = Company;

                        int resultZ = command.ExecuteNonQuery();

                        Console.WriteLine($"{resultZ} customer added to DB.");
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine("Somethings went wrong with SQL");
                        Console.WriteLine(err.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            public int CountThem()
            {
                using (var connection = GetSQLConnection())
                {
                    int countOfEm = 0;

                    try
                    {
                        connection.Open();
                        Console.WriteLine("Sql Connection- Success..");

                        string DBQuery = "SELECT COUNT(*) FROM Customers";

                        SqlCommand command = new SqlCommand(DBQuery, connection);


                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            countOfEm = Convert.ToInt32(result);
                        }





                    }
                    catch (Exception err)
                    {
                        Console.WriteLine("Somethings went wrong with SQL Connection..");
                        Console.WriteLine(err.Message);

                    }
                    finally
                    {
                        connection.Close();
                    }

                    return countOfEm;
                }
            }


            public void DeleteCustomer(string ID)
            {
                using (var connection = GetSQLConnection())
                {


                    try
                    {
                        connection.Open();

                        string SQLQuery = "DELETE FROM Customers WHERE CustomerID = @cID";

                        SqlCommand command = new SqlCommand(SQLQuery, connection);

                        command.Parameters.Add("@cID", System.Data.SqlDbType.NChar).Value = ID;

                        int resultZ = command.ExecuteNonQuery();

                        Console.WriteLine($"{resultZ} customer deleted from DB.");
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                        Console.WriteLine("Somethings went wrong with SQL..");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            public List<SQL_Customers> GetAllCustomers()
            {
                List<SQL_Customers> allCustomers = new List<SQL_Customers>();

                using (var connection = GetSQLConnection())
                {
                    try
                    {
                        connection.Open();
                        Console.WriteLine("Sql Connection- Success..");

                        string DBQuery = "SELECT * FROM Customers";

                        SqlCommand command = new SqlCommand(DBQuery, connection);

                        SqlDataReader theReader = command.ExecuteReader();



                        while (theReader.Read())
                        {
                            allCustomers.Add(
                                new SQL_Customers
                                {
                                    ID = theReader["CustomerID"].ToString(),
                                    Name = theReader["ContactName"].ToString(),
                                    Company = theReader["CompanyName"].ToString()
                                }
                                );
                        }
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine("Somethings went wrong with SQL Connection..");
                        Console.WriteLine(err.Message);

                    }
                    finally
                    {
                        connection.Close();
                    }

                    return allCustomers;
                }
            }



            public SQL_Customers GetCustomerByID(string ID)
            {
                SQL_Customers foundCustomer = new SQL_Customers();

                using (var connection = GetSQLConnection())
                {
                    try
                    {
                        connection.Open();
                        Console.WriteLine("Sql Connection- Success..");

                        string DBQuery = "SELECT * FROM Customers Where CustomerID = @IDofCustomer";


                        SqlCommand command = new SqlCommand(DBQuery, connection);
                        command.Parameters.Add("@IDofCustomer", System.Data.SqlDbType.NChar).Value = ID;

                        SqlDataReader theReader = command.ExecuteReader();

                        theReader.Read();

                        if (theReader.HasRows)
                        {
                            foundCustomer.ID = theReader["CustomerID"].ToString();
                            foundCustomer.Name = theReader["ContactName"].ToString();
                            foundCustomer.Company = theReader["CompanyName"].ToString();
                        }


                    }
                    catch (Exception err)
                    {
                        Console.WriteLine("Somethings went wrong with SQL Connection..");
                        Console.WriteLine(err.Message);

                    }
                    finally
                    {
                        connection.Close();
                    }

                    return foundCustomer;
                }
            }

            public SqlConnection GetSQLConnection()
            {
                string connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = SSPI;";

                List<SQL_Customers> allCustomers = new List<SQL_Customers>();

                var connection = new SqlConnection(connectionString);

                return connection;
            }

            public void UpdateCustomer()
            {
                throw new NotImplementedException();
            }
        }



        // MYSQL BASE

        public class MySqlProcess : IMySQLThingz
        {
            public void AddCustomer()
            {
                throw new NotImplementedException();
            }

            public int Count()
            {
                //
                using (var connection = GetMySQLConnection())
                {

                    int countX = 0;

                    try
                    {
                        connection.Open();
                        Console.WriteLine("MySql Connection- Success..");

                        string DBQuery = "SELECT COUNT(*) FROM Northwind.Customers";

                        MySqlCommand command = new MySqlCommand(DBQuery, connection);


                        object countY = command.ExecuteScalar();

                        if (countY != null)
                        {
                            countX = Convert.ToInt32(countY);

                        }



                    }
                    catch (Exception err)
                    {
                        Console.WriteLine("Somethings went wrong with MySQL Connection..");
                        Console.WriteLine(err.Message);

                    }
                    finally
                    {
                        connection.Close();
                    }

                    return countX;

                }
            }

            public void DeleteCustomer()
            {
                throw new NotImplementedException();
            }

            public List<MySQL_Customers> GetAllCustomers()
            {

                List<MySQL_Customers> allCustomers = new List<MySQL_Customers>();

                var connection = GetMySQLConnection();

                using (connection)
                {

                    try
                    {
                        connection.Open();
                        Console.WriteLine("MySql Connection- Success..");

                        string DBQuery = "SELECT * FROM Northwind.Customers";

                        MySqlCommand command = new MySqlCommand(DBQuery, connection);

                        MySqlDataReader theReader = command.ExecuteReader();



                        while (theReader.Read())
                        {
                            allCustomers.Add(
                                new MySQL_Customers
                                {
                                    ID = int.Parse(theReader["id"].ToString()),
                                    Name = theReader["first_name"].ToString(),
                                    Company = theReader["company"].ToString()
                                }
                                );
                        }
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine("Somethings went wrong with MySQL Connection..");
                        Console.WriteLine(err.Message);

                    }
                    finally
                    {
                        connection.Close();
                    }

                    return allCustomers;

                }
            }

            public MySQL_Customers GetCustomerByID(int ID)
            {

                MySQL_Customers foundCustomer = null;

                var connection = GetMySQLConnection();

                using (connection)
                {

                    try
                    {
                        connection.Open();
                        Console.WriteLine("MySql Connection- Success..");

                        string DBQuery = "SELECT * FROM Northwind.Customers WHERE id = @customerID";

                        MySqlCommand command = new MySqlCommand(DBQuery, connection);
                        command.Parameters.Add("@customerID", MySqlDbType.Int32).Value = ID;

                        MySqlDataReader theReader = command.ExecuteReader();

                        theReader.Read();

                        if (theReader.HasRows)
                        {
                            foundCustomer = new MySQL_Customers()
                            {
                                ID = Convert.ToInt32(theReader["id"]),
                                Name = theReader["first_name"].ToString(),
                                Company = theReader["company"].ToString()
                            };


                        }


                    }
                    catch (Exception err)
                    {
                        Console.WriteLine("Somethings went wrong with MySQL Connection..");
                        Console.WriteLine(err.Message);

                    }
                    finally
                    {
                        connection.Close();
                    }



                }

                return foundCustomer;

            }

            public MySqlConnection GetMySQLConnection()
            {
                //MYSQL Connection
                string connectionString = @"server = localhost; port = 3306; database = northwind; user = root; password = 1234;";

                List<MySQL_Customers> allCustomers = new List<MySQL_Customers>();

                var connection = new MySqlConnection(connectionString);

                return connection;
            }

            public void UpdateCustomer()
            {
                throw new NotImplementedException();
            }
        }
    }
}
