namespace Lottó_szám_generátor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void generalas_Click(object sender, EventArgs e)
        {
           Random vs = new Random();
            int szam1 = vs.Next(1, 91);
            int szam2 = vs.Next(1, 91);
            int szam3 = vs.Next(1, 91);
            int szam4 = vs.Next(1, 91);
            int szam5 = vs.Next(1, 91);
           
            num_1.Text = szam1.ToString();
            num_2.Text = szam2.ToString();
            num_3.Text = szam3.ToString();
            num_4.Text = szam4.ToString();
            num_5.Text = szam5.ToString();


        }
    }
}