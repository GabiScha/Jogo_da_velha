﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class JogoDaVelha : Form
    {
        public JogoDaVelha()
        {
            InitializeComponent();
        }

        private void btnjogada_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string[,] m = new string[3, 3];
            string jogador = "";
            int row;
            int col;

            int row = int.Parse(txtrow.Text);
            int row = int.Parse(txtrow.Text);




            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++, cont += 5)
                {

                    m[i, j] = "-";
                }
            }


            lbljogodavelha.Text = "";
            for (int i = 0; i < m.GetLength(0); i++)
            {
                
                for (int j = 0; j < m.GetLength(1); j++)
                {

                    lbljogodavelha.Text +="|" + m[i, j] + "|";

                }
                lbljogodavelha.Text += "\n";
            }











        }
    }
}