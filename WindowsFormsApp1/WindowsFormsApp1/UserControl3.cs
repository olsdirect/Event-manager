using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            string desktopPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(desktopPath2, "helper\\logs.txt");
            textBox1.Text = File.ReadAllText(filePath); //here we use the only method, which gives us the possibility to 
        }                                               //fill the textBox with text from "logs.txt "

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string desktopPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(desktopPath2, "helper\\logs.txt");
            System.IO.File.WriteAllText(filePath, string.Empty); //Empty the file when button clicked
        }
    }
}
