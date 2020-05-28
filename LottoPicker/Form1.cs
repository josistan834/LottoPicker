using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoPicker
{
    public partial class form1 : Form
    {
        

        public form1()
        {
            InitializeComponent();
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            //initializing number gen, variables, and list
            Random randGen = new Random();
            int num;
            int max;
            int tempValue;
            List<int> numbers = new List<int>();
            
            //try to set user input to values
            try
            {
                 max = Convert.ToInt16(maxInput.Text);
                 num = Convert.ToInt16(numInput.Text);
            }

            //if not possible use the default values
            catch
            {
                 max = 45;
                 num = 6;
            }

            //for the ammount of values inputted
            for (int i = 0; i < num; i++)
            {
                //generate a random value
                tempValue = randGen.Next(0, max);

                //if the random value is in the list continue to generate more values
                while (numbers.Contains(tempValue))
                {
                    tempValue = randGen.Next(0, max);
                }

                //insert the generated value into the list
                numbers.Insert(i, tempValue);
            }

            //output the list into the label
            outputBox.Text = String.Join(" ", numbers);
        }
    }
}
