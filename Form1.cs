using System.Text;

namespace Alphabetic_Telephone_Number_Translator_chap8_prob9_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //This method makes sure that the number entered is valid
        private bool isValid(string str)
        {
            const int VALID_LENGTH = 12;
            bool valid;
            if (str.Length == VALID_LENGTH && str[3] == '-' && str[7] == '-')
            {
                valid = true;
            }
            else
            {
                valid = false;
            }
            return valid;
            
        }
        //This method format the number entered by the user
        private string decrypt(ref string str)
        {
            str = str.Replace('A', '2').Replace('B', '2').Replace('C', '2');
            str = str.Replace('D', '3').Replace('E', '3').Replace('F', '3');
            str = str.Replace('G', '4').Replace('H', '4').Replace('I', '4');
            str = str.Replace('J', '5').Replace('K', '5').Replace('L', '5');
            str = str.Replace('M', '6').Replace('N', '6').Replace('O', '6');
            str = str.Replace('P', '7').Replace('Q', '7').Replace('R', '7').Replace('S', '7');
            str = str.Replace('T', '8').Replace('U', '8').Replace('V', '8');
            str = str.Replace('W', '9').Replace('X', '9').Replace('Y', '9').Replace('Z', '9');

            return str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = phoneNumtb.Text.Trim();
            
            
            if (isValid(input))
            {
                decrypt(ref input);
                formatedNumlbl.Text = input;

                //MessageBox.Show(input);
            }
            else
            {
                MessageBox.Show("Invalid input");
            }



            
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
