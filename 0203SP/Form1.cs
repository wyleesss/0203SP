namespace _0203SP
{
    public partial class Form1 : Form
    {

        static readonly string[] alphaElements =
        {
          "Àà", "Áá", "Ââ", "Ãã", "¥´", "Ää", "Åå",
          "ªº", "Ææ", "Çç", "Èè", "²³", "¯¿", "Éé",
          "Êê", "Ëë", "Ìì", "Íí", "Îî", "Ïï", "Ðð",
          "Ññ", "Òò", "Óó", "Ôô", "Õõ", "Öö", "×÷",
          "Øø", "Ùù", "Üü", "Þþ", "ßÿ"
        };

        Thread? displayThread;

        public Form1()
        {
            InitializeComponent();
            startButton.Select();
        }

        public void displayRangeLetters()
        {
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new MethodInvoker(displayRangeLetters));
            }
            else
            {
                textBox1.Clear();

                int iterator = Convert.ToInt16(startPosUpDown.Value) - 1;

                while (iterator != Convert.ToInt16(endPosUpDown.Value) - 1)
                {
                    textBox1.Text += alphaElements[iterator] + " ";

                    if (iterator + 1 == 33 && endPosUpDown.Value - 1 != 33)
                    {
                        iterator = 0;
                        textBox1.Text += " |||  ";
                    }
                    else
                    {
                        iterator++;
                    }
                }

                textBox1.Text += alphaElements[iterator];
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            displayThread = new Thread(displayRangeLetters);
            displayThread.Start();
        }

        private void startPosUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            if (startPosUpDown.Value == startPosUpDown.Maximum)
            {
                startPosUpDown.Value = startPosUpDown.Maximum;
            }
        }

        private void endPosUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            if (endPosUpDown.Value == endPosUpDown.Maximum)
            {
                endPosUpDown.Value = endPosUpDown.Maximum;
            }
        }

        private void startPosUpDown_ValueChanged(object sender, EventArgs e)
        {
            startPosChar.Text = Convert.ToString(alphaElements[Convert.ToInt16(startPosUpDown.Value - 1)][0]);
        }

        private void endPosUpDown_ValueChanged(object sender, EventArgs e)
        {
            endPosChar.Text = Convert.ToString(alphaElements[Convert.ToInt16(endPosUpDown.Value - 1)][0]);
        }

        private void startPosUpDown_Validated(object sender, EventArgs e)
        {
            if (startPosUpDown.Text == "")
            {
                startPosUpDown.Text = "1";
                startPosUpDown.Value = 1;
            }
        }

        private void endPosUpDown_Validated(object sender, EventArgs e)
        {
            if (endPosUpDown.Text == "")
            {
                endPosUpDown.Text = "33";
                endPosUpDown.Value = 33;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            startButton.Select();
        }

        private void startPosUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                startButton.Select();
            }
        }

        private void endPosUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                startButton.Select();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            startButton.Select();
        }
    }
}