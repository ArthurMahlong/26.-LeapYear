namespace _26._LeapYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            int year = int.Parse(txbYear.Text);
            if (year % 4 == 0 ) 
            {
                MessageBox.Show(year + " is a leap year");
            }
            else 
            {
                MessageBox.Show(year + " is not a leap year");
            }
        }
    }
}
