namespace Examen_2
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
            cmbOperaciones = new ComboBox();
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNum1 = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMXN = new TextBox();
            txtCAD = new TextBox();
            txtEUR = new TextBox();
            txtJPY = new TextBox();
            label8 = new Label();
            txtUSD = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbOperaciones
            // 
            cmbOperaciones.FormattingEnabled = true;
            cmbOperaciones.Location = new Point(12, 51);
            cmbOperaciones.Name = "cmbOperaciones";
            cmbOperaciones.Size = new Size(321, 33);
            cmbOperaciones.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(339, 104);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 34);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 2;
            label1.Text = "Moneda";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 9);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 2;
            label2.Text = "Monto";
            label2.Click += label2_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(339, 53);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(150, 31);
            txtNum1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(321, 273);
            dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 5;
            label3.Text = "Conversiones:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 199);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 5;
            label4.Text = "MXN - Peso";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 242);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 5;
            label5.Text = "CAD - Dolar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 292);
            label6.Name = "label6";
            label6.Size = new Size(92, 25);
            label6.TabIndex = 5;
            label6.Text = "EUR -Euro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 345);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 5;
            label7.Text = "JPY -Yen";
            // 
            // txtMXN
            // 
            txtMXN.Location = new Point(159, 193);
            txtMXN.Name = "txtMXN";
            txtMXN.Size = new Size(150, 31);
            txtMXN.TabIndex = 6;
            // 
            // txtCAD
            // 
            txtCAD.Location = new Point(159, 242);
            txtCAD.Name = "txtCAD";
            txtCAD.Size = new Size(150, 31);
            txtCAD.TabIndex = 6;
            // 
            // txtEUR
            // 
            txtEUR.Location = new Point(159, 289);
            txtEUR.Name = "txtEUR";
            txtEUR.Size = new Size(150, 31);
            txtEUR.TabIndex = 6;
            // 
            // txtJPY
            // 
            txtJPY.Location = new Point(159, 342);
            txtJPY.Name = "txtJPY";
            txtJPY.Size = new Size(150, 31);
            txtJPY.TabIndex = 6;
            txtJPY.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 388);
            label8.Name = "label8";
            label8.Size = new Size(107, 25);
            label8.TabIndex = 5;
            label8.Text = "USD - Dolar";
            // 
            // txtUSD
            // 
            txtUSD.Location = new Point(159, 388);
            txtUSD.Name = "txtUSD";
            txtUSD.Size = new Size(150, 31);
            txtUSD.TabIndex = 6;
            txtUSD.TextChanged += textBox4_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 450);
            Controls.Add(txtUSD);
            Controls.Add(txtJPY);
            Controls.Add(txtEUR);
            Controls.Add(txtCAD);
            Controls.Add(txtMXN);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(txtNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(cmbOperaciones);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOperaciones;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private TextBox txtNum1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMXN;
        private TextBox txtCAD;
        private TextBox txtEUR;
        private TextBox txtJPY;
        private Label label8;
        private TextBox txtUSD;
    }
}
