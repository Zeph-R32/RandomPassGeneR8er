using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_PDKP_PASS_GENER8
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

            //karakter yang digunakan untuk password
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
            textBox1.Text = randomchars; //menampilkan password baru
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text); //mengkopi password ke clipboard
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body style=\"background-color:black;\">" +
            "<iframe width=\"480\" height=\"190\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            var url = "https://www.youtube.com/embed/w0HTnLs3ZSs";
            this.webBrowser1.DocumentText = string.Format(embed, url);
        }
    }
}