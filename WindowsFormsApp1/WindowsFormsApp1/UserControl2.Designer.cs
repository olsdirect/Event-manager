namespace WindowsFormsApp1
{
    partial class eventName
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.eventYearEnd = new Guna.UI2.WinForms.Guna2TextBox();
            this.eventMonthEnd = new Guna.UI2.WinForms.Guna2TextBox();
            this.eventDayEnd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eventNameBox = new System.Windows.Forms.TextBox();
            this.eventDescription = new System.Windows.Forms.Label();
            this.eventDescriptionBox = new System.Windows.Forms.TextBox();
            this.eventFiles = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.eventDayNotify = new Guna.UI2.WinForms.Guna2TextBox();
            this.eventMonthNotify = new Guna.UI2.WinForms.Guna2TextBox();
            this.eventYearNotify = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.showFilesBox = new System.Windows.Forms.TextBox();
            this.add = new Guna.UI2.WinForms.Guna2Button();
            this.delete = new Guna.UI2.WinForms.Guna2Button();
            this.acceptChanges = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormatString = "D";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 57;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(1076, 745);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // eventYearEnd
            // 
            this.eventYearEnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eventYearEnd.DefaultText = "";
            this.eventYearEnd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.eventYearEnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.eventYearEnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.eventYearEnd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.eventYearEnd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eventYearEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eventYearEnd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eventYearEnd.Location = new System.Drawing.Point(1104, 856);
            this.eventYearEnd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.eventYearEnd.Name = "eventYearEnd";
            this.eventYearEnd.PasswordChar = '\0';
            this.eventYearEnd.PlaceholderText = "";
            this.eventYearEnd.SelectedText = "";
            this.eventYearEnd.Size = new System.Drawing.Size(160, 46);
            this.eventYearEnd.TabIndex = 4;
            // 
            // eventMonthEnd
            // 
            this.eventMonthEnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eventMonthEnd.DefaultText = "";
            this.eventMonthEnd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.eventMonthEnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.eventMonthEnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.eventMonthEnd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.eventMonthEnd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eventMonthEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eventMonthEnd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eventMonthEnd.Location = new System.Drawing.Point(1276, 856);
            this.eventMonthEnd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.eventMonthEnd.Name = "eventMonthEnd";
            this.eventMonthEnd.PasswordChar = '\0';
            this.eventMonthEnd.PlaceholderText = "";
            this.eventMonthEnd.SelectedText = "";
            this.eventMonthEnd.Size = new System.Drawing.Size(100, 46);
            this.eventMonthEnd.TabIndex = 5;
            // 
            // eventDayEnd
            // 
            this.eventDayEnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eventDayEnd.DefaultText = "";
            this.eventDayEnd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.eventDayEnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.eventDayEnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.eventDayEnd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.eventDayEnd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eventDayEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eventDayEnd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eventDayEnd.Location = new System.Drawing.Point(1388, 856);
            this.eventDayEnd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.eventDayEnd.Name = "eventDayEnd";
            this.eventDayEnd.PasswordChar = '\0';
            this.eventDayEnd.PlaceholderText = "";
            this.eventDayEnd.SelectedText = "";
            this.eventDayEnd.Size = new System.Drawing.Size(100, 46);
            this.eventDayEnd.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1098, 825);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Год:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1270, 825);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Месяц:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1382, 825);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "День:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 769);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 45);
            this.label4.TabIndex = 10;
            this.label4.Text = "Название события:";
            // 
            // eventNameBox
            // 
            this.eventNameBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventNameBox.Location = new System.Drawing.Point(14, 815);
            this.eventNameBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.eventNameBox.Name = "eventNameBox";
            this.eventNameBox.Size = new System.Drawing.Size(854, 47);
            this.eventNameBox.TabIndex = 11;
            // 
            // eventDescription
            // 
            this.eventDescription.AutoSize = true;
            this.eventDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventDescription.Location = new System.Drawing.Point(1096, 6);
            this.eventDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.eventDescription.Name = "eventDescription";
            this.eventDescription.Size = new System.Drawing.Size(283, 41);
            this.eventDescription.TabIndex = 12;
            this.eventDescription.Text = "Описание события:";
            // 
            // eventDescriptionBox
            // 
            this.eventDescriptionBox.Location = new System.Drawing.Point(1104, 50);
            this.eventDescriptionBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.eventDescriptionBox.Multiline = true;
            this.eventDescriptionBox.Name = "eventDescriptionBox";
            this.eventDescriptionBox.Size = new System.Drawing.Size(886, 229);
            this.eventDescriptionBox.TabIndex = 13;
            this.eventDescriptionBox.TextChanged += new System.EventHandler(this.eventDescriptionBox_TextChanged);
            // 
            // eventFiles
            // 
            this.eventFiles.AutoSize = true;
            this.eventFiles.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventFiles.Location = new System.Drawing.Point(1096, 288);
            this.eventFiles.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.eventFiles.Name = "eventFiles";
            this.eventFiles.Size = new System.Drawing.Size(116, 41);
            this.eventFiles.TabIndex = 14;
            this.eventFiles.Text = "Файлы:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1600, 771);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(384, 41);
            this.label6.TabIndex = 17;
            this.label6.Text = "Дата начала уведомлений:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1886, 825);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "День:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1774, 825);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Месяц:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1602, 825);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Год:";
            // 
            // eventDayNotify
            // 
            this.eventDayNotify.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eventDayNotify.DefaultText = "";
            this.eventDayNotify.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.eventDayNotify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.eventDayNotify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.eventDayNotify.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.eventDayNotify.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eventDayNotify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eventDayNotify.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eventDayNotify.Location = new System.Drawing.Point(1892, 856);
            this.eventDayNotify.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.eventDayNotify.Name = "eventDayNotify";
            this.eventDayNotify.PasswordChar = '\0';
            this.eventDayNotify.PlaceholderText = "";
            this.eventDayNotify.SelectedText = "";
            this.eventDayNotify.Size = new System.Drawing.Size(100, 46);
            this.eventDayNotify.TabIndex = 20;
            this.eventDayNotify.TextChanged += new System.EventHandler(this.eventDayNotify_TextChanged);
            // 
            // eventMonthNotify
            // 
            this.eventMonthNotify.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eventMonthNotify.DefaultText = "";
            this.eventMonthNotify.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.eventMonthNotify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.eventMonthNotify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.eventMonthNotify.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.eventMonthNotify.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eventMonthNotify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eventMonthNotify.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eventMonthNotify.Location = new System.Drawing.Point(1780, 856);
            this.eventMonthNotify.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.eventMonthNotify.Name = "eventMonthNotify";
            this.eventMonthNotify.PasswordChar = '\0';
            this.eventMonthNotify.PlaceholderText = "";
            this.eventMonthNotify.SelectedText = "";
            this.eventMonthNotify.Size = new System.Drawing.Size(100, 46);
            this.eventMonthNotify.TabIndex = 19;
            // 
            // eventYearNotify
            // 
            this.eventYearNotify.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eventYearNotify.DefaultText = "";
            this.eventYearNotify.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.eventYearNotify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.eventYearNotify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.eventYearNotify.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.eventYearNotify.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eventYearNotify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eventYearNotify.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eventYearNotify.Location = new System.Drawing.Point(1608, 856);
            this.eventYearNotify.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.eventYearNotify.Name = "eventYearNotify";
            this.eventYearNotify.PasswordChar = '\0';
            this.eventYearNotify.PlaceholderText = "";
            this.eventYearNotify.SelectedText = "";
            this.eventYearNotify.Size = new System.Drawing.Size(160, 46);
            this.eventYearNotify.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1096, 771);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 41);
            this.label10.TabIndex = 25;
            this.label10.Text = "Дата события:";
            // 
            // showFilesBox
            // 
            this.showFilesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showFilesBox.Location = new System.Drawing.Point(1104, 353);
            this.showFilesBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.showFilesBox.Multiline = true;
            this.showFilesBox.Name = "showFilesBox";
            this.showFilesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showFilesBox.Size = new System.Drawing.Size(882, 398);
            this.showFilesBox.TabIndex = 27;
            // 
            // add
            // 
            this.add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(102)))), ((int)(((byte)(52)))));
            this.add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(14, 879);
            this.add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(548, 73);
            this.add.TabIndex = 29;
            this.add.Text = "Добавить событие";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(574, 879);
            this.delete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(298, 73);
            this.delete.TabIndex = 30;
            this.delete.Text = "Удалить событие";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // acceptChanges
            // 
            this.acceptChanges.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.acceptChanges.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.acceptChanges.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.acceptChanges.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.acceptChanges.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.acceptChanges.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.acceptChanges.ForeColor = System.Drawing.Color.White;
            this.acceptChanges.Location = new System.Drawing.Point(14, 963);
            this.acceptChanges.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.acceptChanges.Name = "acceptChanges";
            this.acceptChanges.Size = new System.Drawing.Size(858, 73);
            this.acceptChanges.TabIndex = 31;
            this.acceptChanges.Text = "Принять изменения";
            this.acceptChanges.Click += new System.EventHandler(this.acceptChanges_Click);
            // 
            // eventName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.acceptChanges);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.showFilesBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.eventDayNotify);
            this.Controls.Add(this.eventMonthNotify);
            this.Controls.Add(this.eventYearNotify);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.eventFiles);
            this.Controls.Add(this.eventDescriptionBox);
            this.Controls.Add(this.eventDescription);
            this.Controls.Add(this.eventNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventDayEnd);
            this.Controls.Add(this.eventMonthEnd);
            this.Controls.Add(this.eventYearEnd);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "eventName";
            this.Size = new System.Drawing.Size(2000, 1050);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2TextBox eventYearEnd;
        private Guna.UI2.WinForms.Guna2TextBox eventMonthEnd;
        private Guna.UI2.WinForms.Guna2TextBox eventDayEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eventNameBox;
        private System.Windows.Forms.Label eventDescription;
        private System.Windows.Forms.TextBox eventDescriptionBox;
        private System.Windows.Forms.Label eventFiles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox eventDayNotify;
        private Guna.UI2.WinForms.Guna2TextBox eventMonthNotify;
        private Guna.UI2.WinForms.Guna2TextBox eventYearNotify;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox showFilesBox;
        private Guna.UI2.WinForms.Guna2Button add;
        private Guna.UI2.WinForms.Guna2Button delete;
        private Guna.UI2.WinForms.Guna2Button acceptChanges;
    }
}
