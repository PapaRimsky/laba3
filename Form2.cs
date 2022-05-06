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
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }
        private void TextBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9)) e.SuppressKeyPress = false;
            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9)) e.SuppressKeyPress = false;
            if ((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right)) e.SuppressKeyPress = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            f1.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, comboBox2.Text, dateTimePicker1.Text, comboBox1.Text, textBox5.Text);
            Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void addPubHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 newForm = new Form11(this);
            newForm.Show();
        }

        private void addUDKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5(this);
            newForm.Show();
        }
    }
}
