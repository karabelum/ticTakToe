using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTakToe
{
    public partial class Form1 : Form
    {
        bool xTurn = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button senderB = (Button)sender;
            if (xTurn) 
            { 
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }
            xTurn = !xTurn;
            senderB.Enabled = false;
            checkWin(senderB);
        }
        void checkWin(Button pressedButton)
        {
            if(button1.Text == button2.Text && button2.Text == button3.Text && button2.Enabled == false) 
            { 
                MessageBox.Show("Победа " + pressedButton.Text);
                Application.Restart();
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победа " + pressedButton.Text);
                Application.Restart();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button8.Enabled == false )
            {
                MessageBox.Show("Победа " + pressedButton.Text);
                Application.Restart();
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победа " + pressedButton.Text);
                Application.Restart();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победа " + pressedButton.Text);
                Application.Restart();
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button4.Enabled == false)
            {
                MessageBox.Show("Победа " + pressedButton.Text);
                Application.Restart();
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победа " + pressedButton.Text);
                Application.Restart();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button6.Enabled == false)
            {
                MessageBox.Show("Победа " + pressedButton.Text);
                Application.Restart();
            }
        }
    }
}
