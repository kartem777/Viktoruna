namespace Viktoruna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += b_c;
        }
        private void b_c(object sender, EventArgs e)
        {
            int a = 0;
            if (radioButton1.Checked) a++;
            if (radioButton7.Checked) a++;
            if (radioButton9.Checked) a++;
            if (radioButton11.Checked) a++;
            if (radioButton15.Checked) a++;
            if (radioButton18.Checked) a++;
            label1.Text = "score:" + a.ToString() + "/6";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
