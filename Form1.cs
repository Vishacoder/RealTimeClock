namespace RealTimeClock
{
    public partial class Form1 : Form
    {
        private DateTime alarmTime;
        private bool isAlarmSet = false;
        private bool isDarkTheme = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            if (isAlarmSet)
            {
                if (DateTime.Now.Hour == alarmTime.Hour &&
                    DateTime.Now.Minute == alarmTime.Minute &&
                    DateTime.Now.Second == alarmTime.Second)
                {
                    isAlarmSet = false; // Stop checking
                    timer1.Stop();      // Pause timer while alarm is ringing
                    ShowAlarmWindow();  // Show custom alarm popup
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnToggleTheme_Click(object sender, EventArgs e)
        {
            if (isDarkTheme)
            {
                // Switch to Light Theme
                this.BackColor = Color.White;
                lblClock.ForeColor = Color.Black;
                lblDate.ForeColor = Color.Black;
                btnToggleTheme.Text = "Switch Dark";
            }
            else
            {
                // Switch to Dark Theme
                this.BackColor = Color.Black;
                lblClock.ForeColor = Color.LimeGreen;
                lblDate.ForeColor = Color.White;
                btnToggleTheme.Text = "Switch Light";
            }

            isDarkTheme = !isDarkTheme;
        }

        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            alarmTime = alarmTimePicker.Value;
            isAlarmSet = true;
            lblAlarmStatus.Text = "Alarm set for: " + alarmTime.ToString("hh.mm tt");
            lblAlarmStatus.ForeColor = Color.Green;
            btnSetAlarm.Enabled = false;
        }

        private void ShowAlarmWindow()
        {
            using (AlarmPopup alarmPopup = new AlarmPopup())
            {
                var result = alarmPopup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    lblAlarmStatus.Text = "Alarm off";
                    lblAlarmStatus.ForeColor = Color.Gray;

                    // Re-enable alarm setting
                    btnSetAlarm.Enabled = true;
                    timer1.Start(); // Resume clock
                }
            }
        }

    }
}
