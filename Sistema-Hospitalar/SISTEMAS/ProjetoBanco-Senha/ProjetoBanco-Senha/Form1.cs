using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjetoBanco_Senha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void aparecersenha()
        {

            
            conexao comb = new conexao();
            comb.Open();
            comb.sql =" Select * from tb1_senhas ORDER BY tb1_preferencial = 'n' LIMIT 1 ";
            MySqlDataReader leitor = comb.Execsql();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                 


                    lbsenha.Text =  leitor["tb1_senha"].ToString();
                }
            }
            comb.Close();





        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aparecersenha();
        }

        private void timersenha_Tick(object sender, EventArgs e)
        {
           
            
            
            
            
            
            aparecersenha();
       
        }
    }
}
