namespace database_crashcourse
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnrent = new Button();
            label2 = new Label();
            txtrid = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 26);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 0;
            label1.Text = "Bogsy Video Store";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(169, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(467, 118);
            dataGridView1.TabIndex = 1;
            // 
            // btnrent
            // 
            btnrent.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnrent.Location = new Point(32, 118);
            btnrent.Name = "btnrent";
            btnrent.Size = new Size(79, 41);
            btnrent.TabIndex = 2;
            btnrent.Text = "Rent";
            btnrent.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 242);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Rent ID:";
            // 
            // txtrid
            // 
            txtrid.Location = new Point(220, 239);
            txtrid.Name = "txtrid";
            txtrid.Size = new Size(46, 23);
            txtrid.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(346, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(37, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 242);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Movie ID:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(487, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 242);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 7;
            label4.Text = "Renter Name:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(299, 326);
            button1.Name = "button1";
            button1.Size = new Size(79, 41);
            button1.TabIndex = 9;
            button1.Text = "Borrow";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(417, 326);
            button2.Name = "button2";
            button2.Size = new Size(79, 41);
            button2.TabIndex = 10;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(338, 282);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 286);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 12;
            label5.Text = "Rented Date:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 428);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(txtrid);
            Controls.Add(label2);
            Controls.Add(btnrent);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnrent;
        private Label label2;
        private TextBox txtrid;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Label label5;
    }
}
