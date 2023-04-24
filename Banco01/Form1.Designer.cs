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
            label9 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(160, 178);
            button1.Name = "button1";
            button1.Size = new Size(98, 23);
            button1.TabIndex = 0;
            button1.Text = "Saque";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Location = new Point(59, 178);
            button2.Name = "button2";
            button2.Size = new Size(95, 23);
            button2.TabIndex = 1;
            button2.Text = "Depósito";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(27, 178);
            button3.Name = "button3";
            button3.Size = new Size(114, 49);
            button3.TabIndex = 2;
            button3.Text = "Criar Conta Corrente";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 78);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 136);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "Saldo inicial:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(84, 248);
            label3.Name = "label3";
            label3.Size = new Size(105, 24);
            label3.TabIndex = 5;
            label3.Text = "Saldo Atual";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(93, 279);
            label4.Name = "label4";
            label4.Size = new Size(20, 24);
            label4.TabIndex = 5;
            label4.Text = "0";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(56, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 23);
            textBox3.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(35, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(253, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(147, 178);
            button4.Name = "button4";
            button4.Size = new Size(116, 49);
            button4.TabIndex = 2;
            button4.Text = "Criar Conta Poupança";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 37);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 3;
            label5.Text = "Selecione a Conta:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 107);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 3;
            label6.Text = "Número da conta:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(136, 104);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(127, 23);
            textBox5.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 83);
            label7.Name = "label7";
            label7.Size = new Size(211, 15);
            label7.TabIndex = 3;
            label7.Text = "Digite o valor a ser depósitado/sacado:";
            label7.Click += label5_Click;
            // 
            // btnTransferir
            // 
            btnTransferir.BackColor = SystemColors.ButtonHighlight;
            btnTransferir.Location = new Point(103, 313);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(130, 23);
            btnTransferir.TabIndex = 0;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = false;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 230);
            label8.Name = "label8";
            label8.Size = new Size(253, 15);
            label8.TabIndex = 3;
            label8.Text = "Selecione a conta que receberá a transferência:";
            label8.Click += label5_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(35, 248);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(253, 23);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2Transferir_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(89, 45);
            label9.Name = "label9";
            label9.Size = new Size(128, 21);
            label9.TabIndex = 7;
            label9.Text = "Dados do cliente:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(65, 279);
            label10.Name = "label10";
            label10.Size = new Size(202, 21);
            label10.TabIndex = 8;
            label10.Text = "Selecione a opção desejada:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(73, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 354);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ScrollBar;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnTransferir);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(384, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 353);
            panel2.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(56, 154);
            label11.Name = "label11";
            label11.Size = new Size(202, 21);
            label11.TabIndex = 8;
            label11.Text = "Selecione a opção desejada:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private Label label9;
        private Label label10;
        private Panel panel1;
        private Panel panel2;
        private Label label11;
    }
}