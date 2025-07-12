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
                    isAlarmSet = false; // prevent repeating
                    lblAlarmStatus.Text = "Alarm triggered!";
                    lblAlarmStatus.ForeColor = Color.Red;

                    // Show a popup
                    MessageBox.Show("? Alarm Time Reached!", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Optional: Play a beep sound
                    System.Media.SystemSounds.Beep.Play();
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
        }
    }
}
