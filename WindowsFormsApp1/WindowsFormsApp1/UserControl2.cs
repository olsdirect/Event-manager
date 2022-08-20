using System;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using Microsoft.Data.Sqlite;

namespace WindowsFormsApp1
{
    public partial class eventName : UserControl
    {
        private SqliteConnection sqlConnection = null;
        public eventName()
        {
            InitializeComponent();
        }
        private void clearBoxes()//this makes the textBoxes empty
        {
            eventYearEnd.Clear();
            eventMonthEnd.Clear();
            eventDayEnd.Clear();
            eventNameBox.Clear();
            eventYearNotify.Clear();
            eventMonthNotify.Clear();
            eventDayNotify.Clear();
            eventDescriptionBox.Clear();
            showFilesBox.Clear();
        }

        private int fillBoxes(SqliteDataReader dataReader1) //this fills the text boxes with info from dataReader. dataReader gets info from sql database
        {                                                //then returns ID of the event filled
            int Id = 0;
            while (dataReader1.Read())
            {
                string[] dateEnd = dataReader1["dateOfEvent"].ToString().Split('.');
                string[] dateNotify = dataReader1["dateOfNotification"].ToString().Split('.');
                eventNameBox.Text = Convert.ToString(dataReader1["eventName"]);
                eventDescriptionBox.Text = Convert.ToString(dataReader1["eventDescription"]);
                showFilesBox.Text = Convert.ToString(dataReader1["files"]);
                eventMonthEnd.Text = Convert.ToString(dateEnd[1]);
                eventDayEnd.Text = Convert.ToString(dateEnd[0]);
                eventYearEnd.Text = Convert.ToString(dateEnd[2]);
                eventYearNotify.Text = Convert.ToString(dateNotify[2]);
                eventMonthNotify.Text = Convert.ToString(dateNotify[1]);
                eventDayNotify.Text = Convert.ToString(dateNotify[0]);
                Id = Convert.ToInt32(dataReader1["Id"]);
            }
            return Id;
        }

        private void delete_Click(object sender, EventArgs e)           //deletes the event from database and listBox by executing the sqlCommand
        {                                                               //splits the event name given in the listBox by '|'. Then the string removes
            string[] arr = listBox1.SelectedItem.ToString().Split('|'); //spaces in front and in the back of array elements
            SqliteCommand cmd = new SqliteCommand($"DELETE FROM [events] WHERE eventName='{arr[0].Remove(arr[0].Length - 1)}' AND" +
                $" dateOfEvent='{arr[1].Substring(1)}'", sqlConnection);
            cmd.ExecuteNonQuery();
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void add_Click(object sender, EventArgs e) //adds the event to database and to the listBox
        {
            try //a neat moment - we must use the try method so that if user wrote incorrect data, it will make an exception
            {
                DateTime eventDateEOE = new DateTime(Int32.Parse(eventYearEnd.Text), Int32.Parse(eventMonthEnd.Text), Int32.Parse(eventDayEnd.Text));
                DateTime eventDateSON = new DateTime(Int32.Parse(eventYearNotify.Text), Int32.Parse(eventMonthNotify.Text), Int32.Parse(eventDayNotify.Text));
                SqliteCommand command = new SqliteCommand($"INSERT INTO [events] (eventName, statusOfEvent, dateOfNotification, dateOfEvent, eventDescription, files) " +
                    $"VALUES ('{eventNameBox.Text}', 1, '{eventDateSON:d}', '{eventDateEOE:d}', '{eventDescriptionBox.Text}', '{showFilesBox}')",
                    sqlConnection);             //just a sql query which inserts a new element. then we insert formated info to the list box. 
                command.ExecuteNonQuery();      //It is nessesary to formate it the right way, so we know how to find elements then.
                listBox1.Items.Add(eventNameBox.Text + $" | {eventDayEnd.Text}.{eventMonthEnd.Text}.{eventYearEnd.Text}");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Неверно введены данные {ex.Message}");
            }
            clearBoxes();
        }

        private void connectFiles()
        {

        }

        private void UserControl2_Load(object sender, EventArgs e) //event of loading the form, just before the image of the form shows. 
        {                                                          //it gives us the opportunity to fill the listbox in descending chronological order
            string desktopPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //get location of the documents folder
            string dbPath = Path.Combine(desktopPath2, "helper\\data.sqlite"); //make path do database
            sqlConnection = new SqliteConnection($"Data Source={dbPath}");

            sqlConnection.Open();                                  //by the way right here we are oppening the connection to the database
            SqliteDataReader dataReader = null;
            try                                                    //it is neccessary to use try for the exception when dataReader catches an error
            {
                SqliteCommand cmd = new SqliteCommand($"SELECT * FROM [events] ORDER BY date(CAST(SUBSTR(dateOfEvent, 7, 4) AS text) || '-' " +
                    $"|| CAST(SUBSTR(dateOfEvent, 4, 2) AS text) || '-' || CAST(SUBSTR(dateOfEvent, 1, 2) AS text)) ASC", sqlConnection); //command to take all the elements of database and to sort it
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    string[] dateEnd = dataReader["dateOfEvent"].ToString().Split('.');     //then we take info from db and fill the listBox with them
                    string yearEnd = Convert.ToString(dateEnd[2]);
                    eventNameBox.Text = Convert.ToString(dataReader["eventName"]);
                    eventMonthEnd.Text = Convert.ToString(dateEnd[1]);
                    eventDayEnd.Text = Convert.ToString(dateEnd[0]);
                    listBox1.Items.Add(eventNameBox.Text + $" | {eventDayEnd.Text}.{eventMonthEnd.Text}.{yearEnd}");
                }
                clearBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close(); //also we must close the dataReader to continue work with our database
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //happens when user selects a new element in listBox
        {
            string[] arr;
            clearBoxes();
            int flag = 0;
            int Id = 0;
            if (listBox1.Items.Count == 0 || listBox1.SelectedItem == null) {
                flag = 1;
                clearBoxes();
            }
            if(flag == 0)
            {
                arr = listBox1.SelectedItem.ToString().Split('|');
                SqliteDataReader dataReader1 = null;
                try
                {
                    SqliteCommand cmd = new SqliteCommand($"SELECT * FROM [events] WHERE eventName='{arr[0].Remove(arr[0].Length - 1)}'" +
                        $" AND dateOfEvent='{arr[1].Substring(1)}'", sqlConnection);
                    dataReader1 = cmd.ExecuteReader();
                    Id = fillBoxes(dataReader1);            //getting the id of selected event to fill the files box
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (dataReader1 != null && !dataReader1.IsClosed)
                    {
                        dataReader1.Close();
                    }
                }
            }
        }

        private void acceptChanges_Click(object sender, EventArgs e) //when the button "принять изменения" is clicked
        {
            int flag = 0;
            if (listBox1.Items.Count == 0 || listBox1.SelectedItem == null)
            {
                flag = 1; //if user didn't choose any of elements, this will help us to ignore the input
            }
            if( flag == 0)
            {
                try
                {
                    String[] arr = listBox1.SelectedItem.ToString().Split('|');
                    DateTime eventDateEOE = new DateTime(Int32.Parse(eventYearEnd.Text), Int32.Parse(eventMonthEnd.Text), Int32.Parse(eventDayEnd.Text));
                    DateTime eventDateSON = new DateTime(Int32.Parse(eventYearNotify.Text), Int32.Parse(eventMonthNotify.Text), Int32.Parse(eventDayNotify.Text));
                    SqliteCommand command = new SqliteCommand($"UPDATE [events] SET eventName='{eventNameBox.Text}', " +  //query to update the info that we got from textBoxes
                        $"dateOfNotification='{eventDateSON:d}', dateOfEvent='{eventDateEOE:d}'," +                  //it is neccessary to format every element
                        $" eventDescription='{eventDescriptionBox.Text}', files='{showFilesBox.Text}'" +
                        $"WHERE dateOfEvent='{arr[1].Substring(1)}' AND eventName='{arr[0].Remove(arr[0].Length - 1)}'", sqlConnection);
                    command.ExecuteNonQuery();
                    listBox1.Items.Add(eventNameBox.Text + $" | {eventDayEnd.Text}.{eventMonthEnd.Text}.{eventYearEnd.Text}");
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неверно введены данные {ex.Message}");
                }
            }
        }

        private void addFile_Click(object sender, EventArgs e)
        {

        }

        private void eventDescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void eventDayNotify_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
