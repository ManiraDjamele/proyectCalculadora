using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyectCalculadora
{
    public partial class Form1 : Form
    {
        bool operacionRealizada = false;
        double resultado = 0;
        string operacion = "";
        public Form1()
        {
            InitializeComponent();

            button29.Click += new EventHandler(BotonNumero_Click); // Botón 0
            button25.Click += new EventHandler(BotonNumero_Click); // Botón 1
            button24.Click += new EventHandler(BotonNumero_Click); // Botón 2
            button23.Click += new EventHandler(BotonNumero_Click); // Botón 3
            button20.Click += new EventHandler(BotonNumero_Click); // Botón 4
            button19.Click += new EventHandler(BotonNumero_Click); // Botón 5
            button18.Click += new EventHandler(BotonNumero_Click); // Botón 6
            button15.Click += new EventHandler(BotonNumero_Click); // Botón 7
            button14.Click += new EventHandler(BotonNumero_Click); // Botón 8
            button13.Click += new EventHandler(BotonNumero_Click); // Botón 9
            button28.Click += new EventHandler(BotonDecimal_Click); // Botón ,

            button8.Click += new EventHandler(BotonBorrar_Click); // Botón C
            button9.Click += new EventHandler(BotonBorrarEntrada_Click); // Botón CE

            button27.Click += new EventHandler(BotonOperacion_Click); // Botón +
            button22.Click += new EventHandler(BotonOperacion_Click); // Botón -
            button17.Click += new EventHandler(BotonOperacion_Click); // Botón *
            button12.Click += new EventHandler(BotonOperacion_Click); // Botón /
            button21.Click += new EventHandler(BotonIgual_Click); // Botón =
        }

        private void cientificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel4.Visible = false;
            panel2.Visible = true;
            panel7.Visible = false;
            Size = new Size(490, 355);
            // panel4.Location = new Point(23,39);
        }
        private void BotonIgual_Click(object sender, EventArgs e)
        {
            double segundoOperando = double.Parse(richTextBox1.Text.Replace(",", "."));
            switch (operacion)
            {
                case "+":
                    richTextBox1.Text = (resultado + segundoOperando).ToString();
                    break;
                case "-":
                    richTextBox1.Text = (resultado - segundoOperando).ToString();
                    break;
                case "*":
                    richTextBox1.Text = (resultado * segundoOperando).ToString();
                    break;
                case "/":
                    richTextBox1.Text = (resultado / segundoOperando).ToString();
                    break;
                default:
                    break;
            }
            resultado = double.Parse(richTextBox1.Text.Replace(",", "."));
            operacion = "";
        }

        private void BotonOperacion_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            resultado = double.Parse(richTextBox1.Text.Replace(",", "."));
            operacionRealizada = true;
        }

        private void BotonDecimal_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains(","))
            {
                richTextBox1.Text += ",";
            }
        }

        private void BotonNumero_Click(object sender, EventArgs e)
        {
            // Verifica si el contenido actual es "0" o si una operación fue realizada recientemente
            if (richTextBox1.Text == "0" || operacionRealizada)
            {
                richTextBox1.Clear();
            }
            operacionRealizada = false; // Reinicia el estado de la operación
            Button boton = (Button)sender;
            richTextBox1.Text += boton.Text;
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1, 1);
                if (richTextBox1.Text == "")
                {
                    richTextBox1.Text = "0";
                }
            }
        }

        private void BotonBorrarEntrada_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            resultado = 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button89_Click(object sender, EventArgs e)
        {

        }

        private void button88_Click(object sender, EventArgs e)
        {

        }

        private void button87_Click(object sender, EventArgs e)
        {

        }

        private void button86_Click(object sender, EventArgs e)
        {

        }

        private void button85_Click(object sender, EventArgs e)
        {

        }

        private void button84_Click(object sender, EventArgs e)
        {

        }

        private void button63_Click(object sender, EventArgs e)
        {

        }

        private void button59_Click(object sender, EventArgs e)
        {

        }

        private void button105_Click(object sender, EventArgs e)
        {

        }

        private void button104_Click(object sender, EventArgs e)
        {

        }

        private void button103_Click(object sender, EventArgs e)
        {

        }

        private void button102_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //radio button hex
            button87.Enabled = true; //A
            button95.Enabled = true; //B
            button103.Enabled = true; //C
            button127.Enabled = true; //D
            button119.Enabled = true; //E
            button111.Enabled = true; //F
            button108.Enabled = false; //la coma ,
            button101.Enabled = true; //8
            button100.Enabled = true; //9
            button102.Enabled = true; // 7
            button126.Enabled = true; //4
            button125.Enabled = true; //5
            button124.Enabled = true; //6
            button117.Enabled = true; //2
            button116.Enabled = true; //3
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            //radio button bin
            button87.Enabled = false; //A
            button95.Enabled = false; //B
            button103.Enabled = false; //C
            button127.Enabled = false; //D
            button119.Enabled = false; //E
            button111.Enabled = false; //F
            button108.Enabled = false; //la coma ,
            button101.Enabled = false; //8
            button100.Enabled = false; //9
            button102.Enabled = false; // 7
            button126.Enabled = false; //4
            button125.Enabled = false; //5
            button124.Enabled = false; //6
            button117.Enabled = false; //2
            button116.Enabled = false; //3
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //radio button dec
            button87.Enabled = false; //A
            button95.Enabled = false; //B
            button103.Enabled = false; //C
            button127.Enabled = false; //D
            button119.Enabled = false; //E
            button111.Enabled = false; //F
            button108.Enabled = false; //la coma ,
            button101.Enabled = true; //8
            button100.Enabled = true; //9
            button102.Enabled = true; // 7
            button126.Enabled = true; //4
            button125.Enabled = true; //5
            button124.Enabled = true; //6
            button117.Enabled = true; //2
            button116.Enabled = true; //3
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button110_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //radio button oct
            button101.Enabled = false; //8
            button100.Enabled = false; //9
            button87.Enabled = false; //A
            button95.Enabled = false; //B
            button103.Enabled = false; //C
            button127.Enabled = false; //D
            button119.Enabled = false; //E
            button111.Enabled = false; //F
            button108.Enabled = false; //la coma ,
            button102.Enabled = true; // 7
            button126.Enabled = true; //4
            button125.Enabled = true; //5
            button124.Enabled = true; //6
            button117.Enabled = true; //2
            button116.Enabled = true; //3
        }



        private void conversiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            panel7.Visible = true;
            Size = new Size(610, 350);
        }

        private void básicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel4.Visible = false;
            panel2.Visible = false;
            panel7.Visible = false;
            Size = new Size(260, 350);
            //panel1.Location = new Point(23,39);//
        }

        private void programadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel4.Visible = true;
            panel2.Visible = false;
            panel7.Visible = false;
            Size = new Size(465, 345);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // richTextBox1.Text = richTextBox1.Text + '1'; // este queda mejor lo repito con el resto de button
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
           // textBox2.Text = textBox2.Text + '1'; //este medio chimbito
        }
    }
}
