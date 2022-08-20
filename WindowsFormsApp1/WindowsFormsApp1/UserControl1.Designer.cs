namespace WindowsFormsApp1
{
    partial class UserControl1
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
            this.eventFilesBox = new System.Windows.Forms.TextBox();
            this.eventFiles = new System.Windows.Forms.Label();
            this.eventDescriptionBox = new System.Windows.Forms.TextBox();
            this.eventDescription = new System.Windows.Forms.Label();
            this.eventStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormatString = "d";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(537, 514);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // eventFilesBox
            // 
            this.eventFilesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventFilesBox.Location = new System.Drawing.Point(553, 234);
            this.eventFilesBox.Multiline = true;
            this.eventFilesBox.Name = "eventFilesBox";
            this.eventFilesBox.ReadOnly = true;
            this.eventFilesBox.Size = new System.Drawing.Size(444, 164);
            this.eventFilesBox.TabIndex = 19;
            // 
            // eventFiles
            // 
            this.eventFiles.AutoSize = true;
            this.eventFiles.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventFiles.Location = new System.Drawing.Point(549, 211);
            this.eventFiles.Name = "eventFiles";
            this.eventFiles.Size = new System.Drawing.Size(59, 20);
            this.eventFiles.TabIndex = 18;
            this.eventFiles.Text = "Файлы:";
            this.eventFiles.Click += new System.EventHandler(this.eventFiles_Click);
            // 
            // eventDescriptionBox
            // 
            this.eventDescriptionBox.Location = new System.Drawing.Point(553, 27);
            this.eventDescriptionBox.Multiline = true;
            this.eventDescriptionBox.Name = "eventDescriptionBox";
            this.eventDescriptionBox.ReadOnly = true;
            this.eventDescriptionBox.Size = new System.Drawing.Size(444, 181);
            this.eventDescriptionBox.TabIndex = 17;
            // 
            // eventDescription
            // 
            this.eventDescription.AutoSize = true;
            this.eventDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventDescription.Location = new System.Drawing.Point(549, 4);
            this.eventDescription.Name = "eventDescription";
            this.eventDescription.Size = new System.Drawing.Size(145, 20);
            this.eventDescription.TabIndex = 16;
            this.eventDescription.Text = "Описание события:";
            // 
            // eventStatus
            // 
            this.eventStatus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventStatus.Location = new System.Drawing.Point(546, 401);
            this.eventStatus.Name = "eventStatus";
            this.eventStatus.Size = new System.Drawing.Size(451, 84);
            this.eventStatus.TabIndex = 20;
            this.eventStatus.Text = "Выберите событие, чтобы узнать его статус";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eventStatus);
            this.Controls.Add(this.eventFilesBox);
            this.Controls.Add(this.eventFiles);
            this.Controls.Add(this.eventDescriptionBox);
            this.Controls.Add(this.eventDescription);
            this.Controls.Add(this.listBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1000, 546);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox eventFilesBox;
        private System.Windows.Forms.Label eventFiles;
        private System.Windows.Forms.TextBox eventDescriptionBox;
        private System.Windows.Forms.Label eventDescription;
        private System.Windows.Forms.Label eventStatus;
    }
}
