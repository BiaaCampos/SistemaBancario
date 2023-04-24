using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace Banco01
{

    //Classe principal do aplicativo
    public partial class Form1 : Form
    {
        public List<Conta> listContas { get; set; } // Lista usada para armezanar as contas
        public int IndiceContaEncontrado { get; set; } // Lista usada para armazenar os incides das contas

        public Conta? ContaAtual1 { get; set; }
        public Conta? ContaAtual2 { get; set; }

        public Form1()
        {
            InitializeComponent();
            listContas = new List<Conta>(); //Atribuindo a propriedade "ListContas" e adicionando na lista "Conta"
        }

        //Criação de um novo objeto "cliente"
        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = textBox1.Text;

            Conta conta = new Conta(cliente);

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Criando um novo objeto "cliente" com o tipo de conta corrente
        private void button3_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = textBox1.Text;

            Conta conta = new ContaCorrente(cliente);
            conta.Depositar(Convert.ToDouble(textBox2.Text));
            conta.Numero = Convert.ToInt32(textBox5.Text);

            listContas.Add(conta); //Está sendo adicionado a nova conta na "ListContas"
            AtualizarComboBox();

            MessageBox.Show("Conta Corrente criada com sucesso!");

            textBox1.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox2.Text = string.Empty;
        }


        //Criando um novo objeto "cliente" com o tipo de conta poupança
        private void button4_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = textBox1.Text;

            Conta conta = new ContaPoupanca(cliente);
            conta.Depositar(Convert.ToDouble(textBox2.Text));
            conta.Numero = Convert.ToInt32(textBox5.Text);
            listContas.Add(conta);
            AtualizarComboBox();

            MessageBox.Show("Conta Poupança criada com sucesso!");

            textBox1.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox2.Text = string.Empty;
        }


        //Manipulador de evento, utilizado quando o valor que é selecionado no combobox1 é alterado
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Conta? selectedConta = comboBox1.SelectedItem as Conta;
                IndiceContaEncontrado = listContas.FindIndex(x => x.Numero == selectedConta.Numero);
                label4.Text = listContas[IndiceContaEncontrado].getSaldo();
                ContaAtual1 = listContas[IndiceContaEncontrado];
            }
            else
            {
                label4.Text = "0";
                ContaAtual1 = null;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarComboBox();

        }

        //Usado para selecionar qual conta deseja
        private void AtualizarComboBox()
        {
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = listContas;

            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            comboBox1.DataSource = listContas;

            comboBox1.DisplayMember = "Numero";
            comboBox1.ValueMember = "Numero";
            comboBox1.DataSource = bindingSource1.DataSource;

            comboBox2.DataSource = null;
            comboBox2.Items.Clear();
            comboBox2.DataSource = listContas;

            comboBox2.DisplayMember = "Numero";
            comboBox2.ValueMember = "Numero";
            comboBox2.DataSource = bindingSource1.DataSource;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        //Método para poder sacar o valor desejado
        private void button1_Click(object sender, EventArgs e)
        {
            //sacar
            if (!String.IsNullOrEmpty(textBox3.Text))
            {
                double valorSaque = Convert.ToDouble(textBox3.Text);

                if (valorSaque > ContaAtual1.Saldo)
                {
                    MessageBox.Show("Saldo insuficiente para o saque solicitado.");
                }
                else
                {
                    if (ContaAtual1 is ContaCorrente)
                    {
                        ContaAtual1.Sacar(valorSaque);
                    }
                    else if (ContaAtual1 is ContaPoupanca)
                    {
                        ContaAtual1.Sacar(valorSaque);
                    }
                }
            }
            else
            {
                MessageBox.Show("Valor não informado.");
            }
            AtualizarComboBox();

            MessageBox.Show("Valor sacado com sucesso!");

            textBox3.Text = string.Empty;

        }

        //Método para fazer o depósito desejado
        private void button2_Click_1(object sender, EventArgs e) //Deposito
        {
            if (!String.IsNullOrEmpty(textBox3.Text))
            {
                //depositar
                ContaAtual1.Depositar(Convert.ToDouble(textBox3.Text));
                label4.Text = listContas[IndiceContaEncontrado].getSaldo();

            }
            else
            {
                MessageBox.Show("valor não informado");
            }

            MessageBox.Show("Valor depositado com sucesso!");

            textBox3.Text = string.Empty;

        }

        //Método para fazer a transferência
        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox3.Text))
            {
                //transferir
                ContaAtual1.Transferir(Convert.ToDouble(textBox3.Text));
                ContaAtual2.Depositar(Convert.ToDouble(textBox3.Text));
            }
            else
            {
                MessageBox.Show("valor n�o informado");
            }
            AtualizarComboBox();

            MessageBox.Show("Valor transferido com sucesso!");

            textBox3.Text = string.Empty;
        }


        //Selecionar a conta para qual deseja fazer a transferência
        private void comboBox2Transferir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem == comboBox2.SelectedItem)
            {
                MessageBox.Show("Você não pode selecionar a mesma conta");
                comboBox2.SelectedIndex = -1;
            }
            else if (comboBox2.SelectedItem != null)
            {
                Conta? selectedConta = comboBox2.SelectedItem as Conta;
                IndiceContaEncontrado = listContas.FindIndex(x => x.Numero == selectedConta.Numero);
                ContaAtual2 = listContas[IndiceContaEncontrado];
            }
            else
            {
                ContaAtual2 = null;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}