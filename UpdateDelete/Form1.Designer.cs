namespace UpdateDelete
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.SalPrice = new System.Windows.Forms.TextBox();
            this.PurDate = new System.Windows.Forms.DateTimePicker();
            this.ExpDate = new System.Windows.Forms.DateTimePicker();
            this.MfgDate = new System.Windows.Forms.DateTimePicker();
            this.Type = new System.Windows.Forms.ComboBox();
            this.PurPrice = new System.Windows.Forms.TextBox();
            this.Sup = new System.Windows.Forms.TextBox();
            this.Manf = new System.Windows.Forms.TextBox();
            this.Qut = new System.Windows.Forms.TextBox();
            this.Des = new System.Windows.Forms.TextBox();
            this.BatchNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1244, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Id  : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Location = new System.Drawing.Point(381, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "VEIW";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.Add);
            this.groupBox2.Controls.Add(this.SalPrice);
            this.groupBox2.Controls.Add(this.PurDate);
            this.groupBox2.Controls.Add(this.ExpDate);
            this.groupBox2.Controls.Add(this.MfgDate);
            this.groupBox2.Controls.Add(this.Type);
            this.groupBox2.Controls.Add(this.PurPrice);
            this.groupBox2.Controls.Add(this.Sup);
            this.groupBox2.Controls.Add(this.Manf);
            this.groupBox2.Controls.Add(this.Qut);
            this.groupBox2.Controls.Add(this.Des);
            this.groupBox2.Controls.Add(this.BatchNo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1246, 224);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Details";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DarkOrange;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add.Location = new System.Drawing.Point(1011, 33);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(178, 63);
            this.Add.TabIndex = 2;
            this.Add.Text = "UPDATE";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // SalPrice
            // 
            this.SalPrice.Location = new System.Drawing.Point(622, 125);
            this.SalPrice.Name = "SalPrice";
            this.SalPrice.Size = new System.Drawing.Size(327, 20);
            this.SalPrice.TabIndex = 23;
            // 
            // PurDate
            // 
            this.PurDate.Location = new System.Drawing.Point(622, 156);
            this.PurDate.Name = "PurDate";
            this.PurDate.Size = new System.Drawing.Size(327, 20);
            this.PurDate.TabIndex = 22;
            // 
            // ExpDate
            // 
            this.ExpDate.Location = new System.Drawing.Point(622, 63);
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Size = new System.Drawing.Size(327, 20);
            this.ExpDate.TabIndex = 21;
            // 
            // MfgDate
            // 
            this.MfgDate.Location = new System.Drawing.Point(622, 32);
            this.MfgDate.Name = "MfgDate";
            this.MfgDate.Size = new System.Drawing.Size(327, 20);
            this.MfgDate.TabIndex = 20;
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Tablate",
            "Bottle"});
            this.Type.Location = new System.Drawing.Point(121, 94);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(327, 21);
            this.Type.TabIndex = 19;
            // 
            // PurPrice
            // 
            this.PurPrice.Location = new System.Drawing.Point(622, 94);
            this.PurPrice.Name = "PurPrice";
            this.PurPrice.Size = new System.Drawing.Size(327, 20);
            this.PurPrice.TabIndex = 16;
            // 
            // Sup
            // 
            this.Sup.Location = new System.Drawing.Point(121, 186);
            this.Sup.Name = "Sup";
            this.Sup.Size = new System.Drawing.Size(327, 20);
            this.Sup.TabIndex = 15;
            // 
            // Manf
            // 
            this.Manf.Location = new System.Drawing.Point(121, 156);
            this.Manf.Name = "Manf";
            this.Manf.Size = new System.Drawing.Size(327, 20);
            this.Manf.TabIndex = 14;
            // 
            // Qut
            // 
            this.Qut.Location = new System.Drawing.Point(121, 125);
            this.Qut.Name = "Qut";
            this.Qut.Size = new System.Drawing.Size(327, 20);
            this.Qut.TabIndex = 13;
            // 
            // Des
            // 
            this.Des.Location = new System.Drawing.Point(121, 63);
            this.Des.Name = "Des";
            this.Des.Size = new System.Drawing.Size(327, 20);
            this.Des.TabIndex = 12;
            // 
            // BatchNo
            // 
            this.BatchNo.Location = new System.Drawing.Point(121, 32);
            this.BatchNo.Name = "BatchNo";
            this.BatchNo.Size = new System.Drawing.Size(327, 20);
            this.BatchNo.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(512, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Purchase Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Sale Price (Rs.)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(512, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Purchase Price (Rs.)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Exp Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mfg Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Manufacture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Batch No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Brown;
            this.dataGridView1.Location = new System.Drawing.Point(12, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1246, 196);
            this.dataGridView1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(1011, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 63);
            this.button2.TabIndex = 24;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox SalPrice;
        private System.Windows.Forms.DateTimePicker PurDate;
        private System.Windows.Forms.DateTimePicker ExpDate;
        private System.Windows.Forms.DateTimePicker MfgDate;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.TextBox PurPrice;
        private System.Windows.Forms.TextBox Sup;
        private System.Windows.Forms.TextBox Manf;
        private System.Windows.Forms.TextBox Qut;
        private System.Windows.Forms.TextBox Des;
        private System.Windows.Forms.TextBox BatchNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

