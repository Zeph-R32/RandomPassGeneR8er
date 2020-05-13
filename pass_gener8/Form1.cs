using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pass_gener8_kel51
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string randomchars = string.Empty;
            char[] array = "0123456789qwertyuiopasdfghjklmnbvcxzQWERTYUIOPLKJHGFDSAMNBVCXZ".ToCharArray();
            Random r1 = new Random();
            int getangka = Convert.ToInt32(numericUpDown1.Text);
            for (int i = 0; i < getangka; i++)
            {
                int point = r1.Next(1, array.Length);
                if (!randomchars.Contains(array.GetValue(point).ToString()))
                    randomchars += array.GetValue(point);
                else
                    i--;
            }
            textBox1.Text = randomchars;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}