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

namespace Projetobanco_Ficha
{
    public partial class Form1 : Form

    {
        public int varsenha = 0;

        Conexao comb = new Conexao();
        public Form1()
        {

            InitializeComponent();
            
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Conexao comb = new Conexao();
            comb.open();


            comb.sql = "INSERT INTO tb1_senhas (tb1_preferencial) VALUES('n')";

            int lin = comb.Runsql();

            if (lin > 0)
            {





            }
            else
            {

            }



            //sql que ordena para mostrar a ultima senha 


            comb.sql = "Select tb1_senha from tb1_senhas ORDER BY tb1_senha DESC LIMIT 1 ";


            MySqlDataReader leitor = comb.Execsql();





            if (leitor.HasRows)
            {

                while (leitor.Read())
                {

                    lbsuasenha.Text = leitor["tb1_senha"].ToString();















                }

            }
            comb.close();
            timersenhaaparece.Enabled = true;
        }




        private void btpreferencia_Click(object sender, EventArgs e)
        {

            Conexao comb = new Conexao();
            comb.open();


            comb.sql = "INSERT INTO tb1_senhas (tb1_preferencial) VALUES('s')";

            int lin = comb.Runsql();

            if (lin > 0)
            {





            }
            else
            {

            }



            //sql que ordena para mostrar a ultima senha 


            comb.sql = "Select tb1_senha from tb1_senhas ORDER BY tb1_senha DESC LIMIT 1 ";


            MySqlDataReader leitor = comb.Execsql();





            if (leitor.HasRows)
            {

                while (leitor.Read())
                {

                    lbsuasenha.Text = leitor["tb1_senha"].ToString();





                    









                }

            }
            comb.close();
            lbprefer.Visible = true;
            timerprefer.Enabled = true;
            timersenhaaparece.Enabled = true;
        }


















        //códigos para o panel aparecer e depois sumir

        private void timersenha_Tick(object sender, EventArgs e)
        {
            panel1.Visible = true;

            timersenhaaparece.Enabled = false;
            timersenhasome.Enabled = true;
          
        }

        private void timersenhasome_Tick(object sender, EventArgs e)
        {
            timersenhasome.Enabled = false;
            panel1.Visible = false;
        }

        private void timerprefer_Tick(object sender, EventArgs e)
        {
            timerprefer.Enabled = false;
            lbprefer.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
