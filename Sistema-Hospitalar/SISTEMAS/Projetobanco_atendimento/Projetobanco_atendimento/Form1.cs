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

namespace Projetobanco_atendimento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void popula() {


            string senhaatual;


            conexao comb = new conexao();
            comb.Open();
            comb.sql = "Select * from tb1_senhas ORDER BY tb1_preferencial = 'n' ";
            MySqlDataReader leitor = comb.Execsql();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    dtatendimento.Rows.Add(leitor["tb1_senha"].ToString(), leitor["tb1_preferencial"].ToString());


                    senhaatual = dtatendimento.CurrentRow.Cells[0].Value.ToString();

                    
                    label1.Text = senhaatual;
                }
            }
            comb.Close();
            
        }


        public void apagar()
        {
            conexao comb = new conexao();

            comb.sql = "DELETE FROM  tb1_senhas WHERE tb1_senha = " + dtatendimento.CurrentRow.Cells[0].Value.ToString();

            comb.Open();

            int lin = comb.Runsql();

            if (lin > 0)
            {
                MessageBox.Show("Atenção: Registro excluido", "Ação", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                MessageBox.Show("Atenção: Registro não encontrado", "Ação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            comb.Close();

            dtatendimento.Rows.Clear();


            popula();
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            
            popula();
            timeratualizagrid.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            apagar();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            dtatendimento.Rows.Clear();
            popula();
        }

        private void timerhorario_Tick(object sender, EventArgs e)
        {
            lbhoras.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
