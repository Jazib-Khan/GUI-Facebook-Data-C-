using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISADdb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Initiates the connection to mysql and inputs the required details
        string connectionString = "SERVER=" + dbConnect.server + ";" +
            "DATABASE=" + dbConnect.databaseServer + ";" + "UID=" +
            dbConnect.userName + ";" + "PASSWORD=" +
            dbConnect.password + ";" + "SslMode=" +
            dbConnect.sslmode + ";";


        //Data is retrieved out of the friendship table by selecting everything from the friendship table to be displayed 
        private void btnFriend_Click(object sender, EventArgs e)
        {

            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {

                //selects all from the table 
                string DataSearch = "SELECT * FROM isad157_jkhan.friendships;";

                connection.Open();

                MySqlCommand cnd = new MySqlCommand(DataSearch, connection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cnd);

                DataTable userDataTable = new DataTable();
                sqlDA.Fill(userDataTable);

                //datagridview on the windows form from which the data will be displayed on for the front end
                dataGridView1.DataSource = userDataTable;


            }
           
        }

        //Data is retrieved out of the users table by selecting everything from the users table to be displayed 
        private void btnUser_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {

                //selects all from the table
                string DataSearch = "SELECT * FROM isad157_jkhan.users;";

                connection.Open();

                MySqlCommand cnd = new MySqlCommand(DataSearch, connection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cnd);

                DataTable userDataTable = new DataTable();
                sqlDA.Fill(userDataTable);

                //datagridview on the windows form from which the data will be displayed on for the front end
                dataGridView1.DataSource = userDataTable;


            }
        }

        //Data is retrieved out of the message table by selecting everything from the messsage table to be displayed 
        private void btnMessage_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {

                //selects all from the table
                string DataSearch = "SELECT * FROM isad157_jkhan.messages;";

                connection.Open();

                MySqlCommand cnd = new MySqlCommand(DataSearch, connection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cnd);

                DataTable userDataTable = new DataTable();
                sqlDA.Fill(userDataTable);

                //datagridview on the windows form from which the data will be displayed on for the front end
                dataGridView1.DataSource = userDataTable;


            }
        }

        //Data is retrieved out of the workplace table by selecting everything from the workplace table to be displayed 
        private void btnWorkplace_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {

                //selects all from the table
                string DataSearch = "SELECT * FROM isad157_jkhan.workplace;";

                connection.Open();

                MySqlCommand cnd = new MySqlCommand(DataSearch, connection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cnd);

                DataTable userDataTable = new DataTable();
                sqlDA.Fill(userDataTable);

                //datagridview on the windows form from which the data will be displayed on for the front end
                dataGridView1.DataSource = userDataTable;


            }
        }

        //Data is retrieved out of the universities table by selecting everything from the universities table to be displayed 
        private void btnUniversities_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {

                //selects all from the table
                string DataSearch = "SELECT * FROM isad157_jkhan.universities;";

                connection.Open();

                MySqlCommand cnd = new MySqlCommand(DataSearch, connection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cnd);

                DataTable userDataTable = new DataTable();
                sqlDA.Fill(userDataTable);

                //datagridview on the windows form from which the data will be displayed on for the front end
                dataGridView1.DataSource = userDataTable;


            }
        }
    }
    
}
