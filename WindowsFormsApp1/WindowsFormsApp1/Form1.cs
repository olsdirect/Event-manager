using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.Sqlite;
using System.IO;
using Microsoft.Win32;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const string name = "WindowsFormsApp1";
        public bool SetAutorunValue(bool autorun)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                    reg.SetValue(name, ExePath);
                else
                    reg.DeleteValue(name);

                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        private SqliteConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
            UserControl1 uc = new UserControl1();
            addUserControl(uc);
        }

        private DateTime makeDate(string date) //function that makes a date from string
        {
            DateTime myDate = DateTime.ParseExact(date, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            return myDate;
        }

        private void addUserControl(UserControl userControl) //function that shows us one of the UserControl forms. See in context down below
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)//<-----| *from here*
        {
            UserControl1 uc = new UserControl1();                  //      | just some functions for our form to
            addUserControl(uc);                                    //      | and for user to be able to switch
        }                                                          //      | be able to be closed, minimized to tray
                                                                   //      | the tabs in the form
        private void guna2Button2_Click(object sender, EventArgs e)//<-----| \|/
        {
            eventName uc = new eventName();
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)//<------| *to here*
        {
            UserControl3 uc = new UserControl3();
            addUserControl(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetAutorunValue(true);
            string desktopPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dbPath = Path.Combine(desktopPath2, "helper\\data.sqlite");
            string filePath = Path.Combine(desktopPath2, "helper\\logs.txt");
            sqlConnection = new SqliteConnection($"Data Source={dbPath}");
            sqlConnection.Open();
            SqliteDataReader dataReader1 = null;
            List<string> names = new List<string>();
            List<string> namesToAssignStatus = new List<string>();
            List<string> datesToAssignStatus = new List<string>();
            List<string> dates = new List<string>();
            int flag = 1;
            try
            {
                SqliteCommand cmd = new SqliteCommand($"SELECT * FROM [events] WHERE statusOfEvent='1'", sqlConnection);
                dataReader1 = cmd.ExecuteReader();
                while (dataReader1.Read())
                {
                    if(makeDate(Convert.ToString(dataReader1["dateOfNotification"])) <= DateTime.Today && makeDate(Convert.ToString(dataReader1["dateOfEvent"])) > DateTime.Today)
                    {
                        String Name = Convert.ToString(dataReader1["eventName"]);
                        String Date = Convert.ToString(dataReader1["dateOfEvent"]);
                        if (MessageBox.Show($"Вы выполнили событие '{Convert.ToString(dataReader1["eventName"])}'?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            names.Add(Name);
                            dates.Add(Date);
                        }
                        else
                        {
                            using (StreamWriter sw = File.AppendText(filePath))
                            {
                                sw.WriteLine($"Пользователь отреагировал 'Не выполнено' на событие с именем {Name} и датой {Date}");
                            }
                        }
                    }
                    else if (makeDate(Convert.ToString(dataReader1["dateOfEvent"])) < DateTime.Today)
                    {
                        String nameTo = Convert.ToString(dataReader1["eventName"]);
                        String dateTo = Convert.ToString(dataReader1["dateOfEvent"]);
                        namesToAssignStatus.Add(nameTo);
                        datesToAssignStatus.Add(dateTo);
                        flag = 0;
                    }
                }
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
            if(flag == 0)
            {
                for (int i = 0; i < namesToAssignStatus.Count; i++)
                {
                    SqliteCommand command = new SqliteCommand($"UPDATE [events] SET statusOfEvent='0' WHERE dateOfEvent='{datesToAssignStatus[i]}' AND eventName='{namesToAssignStatus[i]}'", sqlConnection);
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine($"Событие с именем {namesToAssignStatus[i]} и датой {datesToAssignStatus[i]} не было выполнено в срок");
                    }
                    command.ExecuteNonQuery();
                }
            }
            for (int i = 0; i < names.Count; i++)
            {
                SqliteCommand command = new SqliteCommand($"UPDATE [events] SET statusOfEvent='0' WHERE dateOfEvent='{dates[i]}' AND eventName='{names[i]}'", sqlConnection);
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine($"Пользователь отреагировал 'Выполнено' на событие с именем {names[i]} и датой {dates[i]}");
                }
                command.ExecuteNonQuery();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

