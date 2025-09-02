using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Collections;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        StringBuilder SB = new StringBuilder();
        private string CS = "CROSSINI";
        ArrayList wrongGuesses = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guess = textBox1.Text.ToUpper();

            if (guess == CS.ToUpper())
            {
                MessageBox.Show("Correct Guess", "Guess The Word", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label1.Text = CS;
            }
            else
            {
                wrongGuesses.Add(guess);

                SB.Clear();
                foreach (string g in wrongGuesses)
                {
                    SB.AppendLine(g);
                }
                textBox2.Text = SB.ToString();

                MessageBox.Show("Wrong Guess", "Guess The Word", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
