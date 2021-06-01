using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double peso, altura, verif_imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            verif_imc = peso/(altura * altura);

            //MessageBox.Show("O seu IMC é:", Convert.ToString(txt_imc.Text));

            //txt_imc.Text = verif_imc.ToString("0.00");
            txt_imc.Text = Convert.ToString(Math.Round (verif_imc, 2));

            if (verif_imc < 18.49)
            {
                //MessageBox.Show($"Seu IMC é {Math.Round(verif_imc, 2)}. Você está abaixo do peso.");
                MessageBox.Show("SITUATION: You are underweight", "BMI calculation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif_imc < 24.99)
            {
                //MessageBox.Show($"Parabéns! Seu IMC é {Math.Round(verif_imc, 2)}, e é o ideal.");
                MessageBox.Show("You are with normal weight", "BMI calculation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (verif_imc < 29.99) 
            {
                MessageBox.Show("SITUATION: You are overweight", "BMI calculation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif_imc < 34.99)
            {
                MessageBox.Show("SITUATION: You are overweight", "BMI calculation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif_imc < 39.99)
            {
                MessageBox.Show("Attention! You have class II Obesity (severe).", "BMI calculation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                MessageBox.Show("Attention! You have class III obesity (morbid)", "BMI calculation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            txt_imc.Clear();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        
        

        
    }
}
