namespace RealTimeClock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lblClock = new Label();
            lblDate = new Label();
            btnToggleTheme = new Button();
            alarmTimePicker = new DateTimePicker();
            btnSetAlarm = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Dock = DockStyle.Fill;
            lblClock.Font = new Font("Segoe UI", 24F);
            lblClock.Location = new Point(0, 0);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(98, 45);
            lblClock.TabIndex = 0;
            lblClock.Text = "Clock";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Location = new Point(58, 63);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date";
            // 
            // btnToggleTheme
            // 
            btnToggleTheme.Location = new Point(193, 12);
            btnToggleTheme.Name = "btnToggleTheme";
            btnToggleTheme.Size = new Size(79, 23);
            btnToggleTheme.TabIndex = 2;
            btnToggleTheme.Text = "Switch Dark";
            btnToggleTheme.UseVisualStyleBackColor = true;
            btnToggleTheme.Click += btnToggleTheme_Click;
            // 
            // alarmTimePicker
            // 
            alarmTimePicker.Format = DateTimePickerFormat.Time;
            alarmTimePicker.Location = new Point(193, 94);
            alarmTimePicker.Name = "alarmTimePicker";
            alarmTimePicker.ShowUpDown = true;
            alarmTimePicker.Size = new Size(75, 23);
            alarmTimePicker.TabIndex = 3;
            // 
            // btnSetAlarm
            // 
            btnSetAlarm.Location = new Point(197, 123);
            btnSetAlarm.Name = "btnSetAlarm";
            btnSetAlarm.Size = new Size(75, 23);
            btnSetAlarm.TabIndex = 4;
            btnSetAlarm.Text = "Set Alarm";
            btnSetAlarm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(btnSetAlarm);
            Controls.Add(alarmTimePicker);
            Controls.Add(btnToggleTheme);
            Controls.Add(lblDate);
            Controls.Add(lblClock);
            MinimumSize = new Size(300, 200);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The Real Time Clock";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblClock;
        private Label lblDate;
        private Button btnToggleTheme;
        private DateTimePicker alarmTimePicker;
        private Button btnSetAlarm;
    }
}
