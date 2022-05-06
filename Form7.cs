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
    public partial class Form7 : Form
    {
        Form4 f4;
        public Form7()
        {
            InitializeComponent();
        }
        public Form7(Form4 f4)
        {
            this.f4 = f4;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form8 newForm = new Form8(this);
            newForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int delet = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(delet);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            f4.comboBox1.Items.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                 f4.comboBox1.Items.Add(row.Cells[0].Value.ToString());
            }
            Close();
        }
    }
}
