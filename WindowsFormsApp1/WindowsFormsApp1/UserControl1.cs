using System;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using Microsoft.Data.Sqlite;

/*
    mostly all of the methods used here are
    described in the "UserControl.cs" file.
    other functions are kinda easy to understand,
    so let's assume that it is not neccessary to 
    comment out how they work
*/

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        private SqliteConnection sqlConnection = null;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void clearBoxes()
        {
            eventDescriptionBox.Clear();
            eventFilesBox.Clear();
        }

        private int fillBoxes(SqliteDataReader dataReader)
        {
            int Id = 0;
            while (dataReader.Read())
            {
                eventDescriptionBox.Text = Convert.ToString(dataReader["eventDescription"]);
                eventFilesBox.Text = Convert.ToString(dataReader["files"]);
                if(Convert.ToInt32(dataReader["statusOfEvent"]) == 1)
                {
                    eventStatus.Text = "Событие ожидает выполнения";
                }
                else
                {
                    eventStatus.Text = "Событие выполнено";
                }
                Id = Convert.ToInt32(dataReader["Id"]);
            }
            return Id;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            string desktopPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dbPath = Path.Combine(desktopPath2, "helper\\data.sqlite");
            sqlConnection = new SqliteConnection($"Data Source={dbPath}");

            sqlConnection.Open();

            SqliteDataReader dataReader = null;
            try
            {
                SqliteCommand cmd = new SqliteCommand($"SELECT * from events WHERE CAST(strftime('%s', (CAST(SUBSTR(dateOfEvent, 7, 4) AS text) || '-' || CAST(SUBSTR(dateOfEvent, 4, 2) AS text) || '-' || CAST(SUBSTR(dateOfEvent, 1, 2) AS text))) AS integer) >= CAST(strftime('%s', date())  AS  integer) ORDER BY date(CAST(SUBSTR(dateOfEvent, 7, 4) AS text) || '-' || CAST(SUBSTR(dateOfEvent, 4, 2) AS text) || '-' || CAST(SUBSTR(dateOfEvent, 1, 2) AS text)) ASC", sqlConnection);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    string[] dateEnd = dataReader["dateOfEvent"].ToString().Split('.');
                    string yearEnd = Convert.ToString(dateEnd[2]);
                    listBox1.Items.Add(dataReader["eventName"] + $" | {dateEnd[0]}.{dateEnd[1]}.{yearEnd}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] arr;
            clearBoxes();
            int flag = 0;
            if (listBox1.Items.Count == 0 || listBox1.SelectedItem == null)
            {
                flag = 1;
            }
            if (flag == 0)
            {
                int Id = 0;
                arr = listBox1.SelectedItem.ToString().Split('|');
                SqliteDataReader dataReader = null;
                try
                {
                    SqliteCommand cmd = new SqliteCommand($"SELECT * FROM [events] WHERE eventName='{arr[0].Remove(arr[0].Length - 1)}' AND dateOfEvent='{arr[1].Substring(1)}'", sqlConnection);
                    dataReader = cmd.ExecuteReader();
                    Id = fillBoxes(dataReader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (dataReader != null && !dataReader.IsClosed)
                    {
                        dataReader.Close();
                    }
                }
            }
        }

        private void eventFiles_Click(object sender, EventArgs e)
        {

        }
    }
}
