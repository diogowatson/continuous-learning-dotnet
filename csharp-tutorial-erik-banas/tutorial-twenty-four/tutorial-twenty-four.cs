using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//database packages
using System.Data.Common;
using System.Configuration;
using System.Data;

//databaases
//I'm conncted to my slq server in local
//app.config was configured
namespace csharp_tutorial_24
{
    class FinalTutorialDatabase
    {
        static void Main()
        {
            //acessing the configuration data in the Appp.config
            string provider = ConfigurationManager.AppSettings["provider"];

            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            //the DbproviderFactories in gonna create an instance of DbProviderFactory
            //wich I'm calling factory(is the instance that be used to pass querys to database)

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            //creating the conection with the database
            using (DbConnection connection = factory.CreateConnection())
            {
                //if is not conected
                if (connection == null)
                {
                    Console.WriteLine("Conection Error");
                    Console.ReadLine();
                    return;
                }

                //data to open the correct database
                connection.ConnectionString = connectionString;

                connection.Open();

                DbCommand command = factory.CreateCommand();

                if (command == null)
                {
                    Console.WriteLine("Command Error");
                    Console.ReadLine();
                    return;
                }

                command.Connection = connection;
                //very simple query, just to test it
                command.CommandText = "Select * From Products";

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Console.WriteLine($"{dataReader["PodId"]}"
                            + $"{dataReader["Product"]}");
                    }
                }

                //prevent console to close
                Console.ReadLine();

            }

        }

    }//end of class

}//end of namespace
