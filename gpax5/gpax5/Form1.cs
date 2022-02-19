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
            oGPAcal.addGPA(dInput, name);

            double gpax
        }
    }
}