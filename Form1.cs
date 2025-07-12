namespace RealTimeClock
{
    public partial class Form1 : Form
    {
        private DateTime alarmTime;
        private bool isDarkTheme = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
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
    }
}
