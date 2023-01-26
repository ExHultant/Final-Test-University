using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabajo_de_Comida_Rapida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        }
        double incremento(double mt, int fp)
        {
            double incre = 0;
            switch (fp)
            {
                case 0:
                    incre = 0;
                    break;
                case 1:
                    incre = 0;
                    break;

                case 2:
                    incre = mt * 15 / 100;
                    break;
            }
            return incre;
        }
        double montoFinal(double mt, double incre1)
        {
            double mfin = 0;

            mfin = (mt + incre1);
            return mfin;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int ch = 0;
            double tph = 0, incre1 = 0, mf1 = 0;
            string fullname = textBox1.Text;
            int ci = int.Parse(textBox2.Text);
            int tipoh = comboBox1.SelectedIndex;
            ch = int.Parse(textBox3.Text);
            int fp = comboBox2.SelectedIndex;
            switch (tipoh)
            {
                case 0:
                    tph = ch * 1.50;
                    break; 
                case 1:
                    tph = ch * 2;
                    break; 
                case 2:
                    tph = ch * 2.50;
                    break; 
                case 3:
                    tph = ch * 3;
                    break; 
                case 4:
                    tph = ch * 5;
                    break; 
                case 5:
                    tph = ch * 5;
                    break; 
                case 6:
                    tph = ch * 10;
                    break;
            }
            double mt = tph;
            DialogResult resp1 = MessageBox.Show("¿Esta Seguro de Procesar su pedido previo?", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (resp1 == DialogResult.OK)
            {
                textBox4.Text = mt.ToString();
                incre1 = incremento(mt, fp);
                textBox6.Text = incre1.ToString();
                mf1 = montoFinal(mt, incre1);
                textBox5.Text = mf1.ToString();
            }
            else
            {
                MessageBox.Show("Retornando aplicacion", "Espere...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Desea Salir?", "¿Salir?", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (resp == DialogResult.OK)
            {
                MessageBox.Show("Gracias Por comprar en Ice Cream Bears", "Hasta la Proxima", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show("Retornando aplicacion", "Espere...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        { 
               
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras son permitidas en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números son permitidos en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese Solamentes Numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
