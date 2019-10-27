using System;
using System.Windows.Forms;

namespace W_NameCoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hexTextBox.Text = Cryptor.HexNormal.Crypt(textTextBox.Text);
        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textTextBox.Text = Cryptor.HexNormal.Decrypt(hexTextBox.Text);
        }
    }
}
