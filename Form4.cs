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
    public partial class Form4 : Form
    {
        Form3 f3;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(Form3 f3)
        {
            this.f3 = f3;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            f3.dataGridView1.Rows.Add(textBox1.Text, dateTimePicker1.Text, comboBox1.Text, comboBox2.Text);
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

        private void addWorkplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7(this);
            newForm.Show();
        }

        private void addScienceDegreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 newForm = new Form9(this);
            newForm.Show();
        }
    }
}
