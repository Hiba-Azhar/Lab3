namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String opPerformed = "";
        bool isOpPerformed = false;




        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (result.Text == "0" || isOpPerformed)
                result.Clear();

            isOpPerformed = false;
            Button button1  = (Button)sender;
            result.Text = result.Text + button1.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button1 = (Button)sender;
            opPerformed = button1.Text;
            resultValue = Double.Parse(result.Text);
            isOpPerformed = true;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            resultValue = 0;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (opPerformed)
            {

                case "+" :
                    result.Text = (resultValue + Double.Parse(result.Text)).ToString();
                    break;

                case "-" :
                    result.Text = (resultValue - Double.Parse(result.Text)).ToString();
                    break;

                case "*":
                    result.Text = (resultValue * Double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    result.Text = (resultValue / Double.Parse(result.Text)).ToString();
                    break;

                


            }       //switch
        }

        /*private void button1_click(object sender, EventArgs e)
        {

        }*/
    }
}