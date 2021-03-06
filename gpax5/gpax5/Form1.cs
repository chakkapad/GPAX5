namespace gpax5
{
    public partial class Form1 : Form
    {
        GPA_CAL oGPAcal = new GPA_CAL();
        private object dInput;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.textBoxGPA_input.Text;
            string name = this.textBoxName_input.Text;

            double dIput = Convert.ToDouble(input);
            oGPAcal.addGPA(dIput, name);

            double gpax = oGPAcal.getGPAx();
            textBoxGPAx.Text = gpax.ToString();

            double max = oGPAcal.getMax();
            textBoxMaxGPA.Text = max.ToString();
            textBoxMaxName.Text = oGPAcal.getMaxName();ToString();

            double min = oGPAcal.getMin();
            textBoxMinGPA.Text= min.ToString();
            textBoxMinName.Text= oGPAcal.getminMname();

            textBoxGPA_input.Text = " ";
            textBoxName_input.Text = String.Empty;
            textBoxAllData.Text = oGPAcal.getAlldata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPAx.Text = "";
            textBoxGPA_input.Text = "";
            textBoxMaxGPA.Text = "";
            textBoxMinGPA.Text = "";
            textBoxName_input.Text = "";
            textBoxMaxName.Text = "";
            textBoxMinName.Text = "";
            textBoxAllData.Text = "";
        }
    }
}