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
            checkWin();
        }
        void checkWin()
        {
            if(button1.Text == button2.Text && button2.Text == button3.Text)
            MessageBox.Show("Победа!");
        }
    }
}
