using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class Form10 : Form
    {
        Form9 f9;
        public Form10()
        {
            InitializeComponent();
        }
        public Form10(Form9 f9)
        {
            this.f9 = f9;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            f9.dataGridView1.Rows.Add(textBox2.Text);
            Close();
        }
        private void TextBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9)) e.SuppressKeyPress = false;
            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9)) e.SuppressKeyPress = false;
            if ((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right)) e.SuppressKeyPress = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
