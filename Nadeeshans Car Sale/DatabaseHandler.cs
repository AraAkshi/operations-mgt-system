using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Configuration;

namespace Nadeeshans_Car_Sale
{
    class DatabaseHandler
    {
        //static string MySQLConnectionString = "datasource-127.0.0.1;port-3306;username-root;password-;database-nadeeshans";
        static string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=nadeeshans";

        //Get 1 value as result from query
        public static string returnOneValue(string query, List<MySqlParameter> paramsCollection, string column)
        {
            string data = null;

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Parameters.Clear();
            commandDatabase.Parameters.AddRange(paramsCollection.ToArray<MySqlParameter>());
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                Console.WriteLine("Query Executed Successfully");
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                Console.WriteLine("Reader got data");

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        data = myReader.GetString(column);
                    }
                }
                else
                {
                    data = "Null Data!";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(MessageBox.Show("Query Error : " + e.Message));
            }
            finally
            {
                databaseConnection.Close();
            }

            return data;
        }

        public static string returnOneValueWithoutParams(string query, string column)
        {
            string data = null;
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();
                Console.WriteLine("Connection Successful");
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                Console.WriteLine("Reader got data");

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        data = myReader.GetString(column);
                    }
                }
                else
                {
                    data = "Null Data!";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return data;
        }

        //Get result row count
        public static int returnRowCount(string query, List<MySqlParameter> paramsCollection)
        {
            int count = 0;
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Parameters.Clear();
            commandDatabase.Parameters.AddRange(paramsCollection.ToArray<MySqlParameter>());
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                Console.WriteLine("Connection Successful");
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        count++;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return count;
        }

        //Get Row Count without parameters
        public static int returnRowCountWithoutParams(string query)
        {
            int count = 0;
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);


            try
            {
                databaseConnection.Open();
                Console.WriteLine("Connection Made");
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        count++;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return count;
        }

        //Insert data 
        public static int insertOrDeleteRow(string query, List<MySqlParameter> paramsCollection)
        {
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Parameters.Clear();
            commandDatabase.Parameters.AddRange(paramsCollection.ToArray<MySqlParameter>());
            commandDatabase.CommandTimeout = 60;
            int rowsAffected = 0;
            try
            {
                //MessageBox.Show(query);
                databaseConnection.Open();
                Console.WriteLine("Connection Successful");
                rowsAffected = commandDatabase.ExecuteNonQuery();
                Console.WriteLine("Rows Affected: " + rowsAffected);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();

            }
            return rowsAffected;
        }

        //Populate DataViews
        public static void populateViewwithNoParameters(string query, DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView.Font, FontStyle.Regular);
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var dataAdapter = new MySqlDataAdapter(query, MySQLConnectionString);
            var commandBuilder = new MySqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView.ReadOnly = true;
            dataGridView.DataSource = ds.Tables[0];

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public static void populateViewwithParameters(string query, List<MySqlParameter> paramsCollection, DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView.Font, FontStyle.Regular);
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var dataAdapter = new MySqlDataAdapter(query, MySQLConnectionString);
            var commandBuilder = new MySqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView.ReadOnly = true;
            dataGridView.DataSource = ds.Tables[0];

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        //Populate DataGridView with binding
        public static void populateGridViewWithBinding(string query, DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView.Font, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var dataAdapter = new MySqlDataAdapter(query, MySQLConnectionString);
            var commandBuilder = new MySqlCommandBuilder(dataAdapter);
            var dt = new DataTable();
            try { dataAdapter.Fill(dt); }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                MessageBox.Show(query);
            }

            dataGridView.DataSource = dt;

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
