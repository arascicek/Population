namespace Population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double population, rate;
            int days;

            if (double.TryParse(txtStart.Text, out population) &&
                double.TryParse(txtRate.Text, out rate) &&
                int.TryParse(txtDays.Text, out days) &&
                population > 0 && rate >= 0 && days > 0)
            {
                rate = rate / 100;
                lstPopulation.Items.Clear();
                lstPopulation.Items.Add("Day\tApproximate Population");

                for (int day = 1; day <= days; day++)
                {
                    lstPopulation.Items.Add(day + "\t" + population.ToString("0.####"));
                    population = population + (population * rate);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid positive numbers in all three boxes.");
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtStart.Clear();
            txtRate.Clear();
            txtDays.Clear();
            lstPopulation.Items.Clear();
            txtStart.Focus();
        }
    }
}
