using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Akrip
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string encodedText = string.Empty;
            List<char> chrText = text.ToCharArray().ToList();

            for (int i = 0; i < chrText.Count; i++)
            {
                encodedText = encodedText + (char)(chrText[i] + 3);
            }
            textBox2.Text = encodedText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string decodedText = string.Empty;
            List<char> chrText = text.ToCharArray().ToList();

            for (int i = 0; i < chrText.Count; i++)
            {
                decodedText = decodedText + (char)(chrText[i] - 3);
            }
            textBox2.Text = decodedText;
        }

    }
}
