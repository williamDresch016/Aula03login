using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string usuario;
            string senha;

            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            if (usuario == "dresch" && senha == "123") 
            {
                MessageBox.Show("Você se conectou !");

            }
            else
            {
                MessageBox.Show("Está incorreto . . .");
            }
            
            

            
        }  
        
    }
}
