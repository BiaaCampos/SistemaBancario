namespace Banco01
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            btnTransferir = new Button();
            label8 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(614, 119);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 0;
            button1.Text = "Saque";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(614, 93);
            button2.Name = "button2";
            button2.Size = new Size(130, 23);
            button2.TabIndex = 1;
            button2.Text = "Depósito";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(236, 29);
            button3.Name = "button3";
            button3.Size = new Size(78, 49);
            button3.TabIndex = 2;
            button3.Text = "Criar Conta Corrente";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 48);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 110);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Saldo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(95, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 347);
            label3.Name = "label3";
            label3.Size = new Size(105, 24);
            label3.TabIndex = 5;
            label3.Text = "Saldo Atual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 379);
            label4.Name = "label4";
            label4.Size = new Size(20, 24);
            label4.TabIndex = 5;
            label4.Text = "0";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(508, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(348, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Location = new Point(236, 98);
            button4.Name = "button4";
            button4.Size = new Size(78, 44);
            button4.TabIndex = 2;
            button4.Text = "Criar Conta Poupança";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 29);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 3;
            label5.Text = "Selecione a Conta";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 77);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 3;
            label6.Text = "Número";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(95, 77);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(508, 98);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 3;
            label7.Text = "Digite o valor";
            label7.Click += label5_Click;
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(614, 148);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(130, 23);
            btnTransferir.TabIndex = 0;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(348, 196);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 3;
            label8.Text = "Selecione a Conta";
            label8.Click += label5_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(348, 214);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(153, 23);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2Transferir_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnTransferir);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Button button4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private Button btnTransferir;
        private Label label8;
        private ComboBox comboBox2;
    }
}