using System.Media;
using System.Numerics;

namespace WinFormsApp3
{
    public partial class Form1 : Form



    {
        Button[,] btnpiece;

        bool player = false;
        

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            

            if (player)
            {
              button.Text = ("X");
                

            }
            else
            {
                button.Text = ("O");
            }
           


            player = !player;
            button.Click -= new EventHandler(button1_Click);
            validate();


           
        }

        public void validate()
        {
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.WriteLine(btnpiece[i, j].Text.ToString());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnpiece = new Button[3, 3] { { button1, button2, button3 }, { button4, button5, button6 }, { button7, button8, button9 } };
        }








        /* private void button5_Click(object sender, EventArgs e)
         {

         }

         private void button3_Click(object sender, EventArgs e)
         {

         }
        */
    }
    }

    