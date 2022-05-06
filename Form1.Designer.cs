
namespace laba3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UDKid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublicationHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Pages,
            this.UDKid,
            this.Date,
            this.PublicationHouse,
            this.DOI});
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(819, 379);
            this.dataGridView1.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.Frozen = true;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // Pages
            // 
            this.Pages.Frozen = true;
            this.Pages.HeaderText = "Pages";
            this.Pages.MinimumWidth = 6;
            this.Pages.Name = "Pages";
            this.Pages.Width = 125;
            // 
            // UDKid
            // 
            this.UDKid.Frozen = true;
            this.UDKid.HeaderText = "UDK";
            this.UDKid.MinimumWidth = 6;
            this.UDKid.Name = "UDKid";
            this.UDKid.Width = 125;
            // 
            // Date
            // 
            this.Date.Frozen = true;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // PublicationHouse
            // 
            this.PublicationHouse.Frozen = true;
            this.PublicationHouse.HeaderText = "PublicationHouse";
            this.PublicationHouse.MinimumWidth = 6;
            this.PublicationHouse.Name = "PublicationHouse";
            this.PublicationHouse.Width = 140;
            // 
            // DOI
            // 
            this.DOI.Frozen = true;
            this.DOI.HeaderText = "DOI";
            this.DOI.MinimumWidth = 6;
            this.DOI.Name = "DOI";
            this.DOI.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить работу\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Удалить работу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(469, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "Добавить авторов\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(701, 496);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 49);
            this.button4.TabIndex = 6;
            this.button4.Text = "Работы/Авторы";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 585);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Works";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn UDKid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicationHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOI;
        private System.Windows.Forms.Button button4;
        public  System.Windows.Forms.DataGridView dataGridView1;
    }
}

