using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoJackpot
{
    public partial class Form1 : Form
    {
        Random sortearfotos = new Random();
        public int tentativas = 7 ;
        public double premio = 0;

        public void mostravalor()
        {
            lbtentativas.Text = Convert.ToString(tentativas);
        }
        public void sortear (){


            
            {
                int SorteioFruta1 = sortearfotos.Next(1, 6);

                int SorteioFruta2 = sortearfotos.Next(1, 6);

                int SorteioFruta3 = sortearfotos.Next(1, 6);



                pbimg1.Load("imagens//" + SorteioFruta1 + ".png");
                pbimg2.Load("imagens//" + SorteioFruta2 + ".png");
                pbimg3.Load("imagens//" + SorteioFruta3 + ".png");

                tentativas = tentativas - 1;
                lbtentativas.Text = Convert.ToString(tentativas);





                if (tentativas == 0)
                {
                    System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som//somperdeu.wav");
                   Player.Play();

                    premio = 0;
                    lbpremio.Text = premio.ToString("C");
                    timerlimpaimagens.Enabled = true;




                    var resultado = MessageBox.Show("Suas chances acabaram, deseja jogar novamente?", "", MessageBoxButtons.YesNo);
                    
                    if (resultado == DialogResult.Yes) {

                        tentativas = 7;
                        lbtentativas.Text = Convert.ToString(tentativas);


                    }



                    else if(resultado == DialogResult.No)
                    {

                        Application.Exit();
                    }


                }





                if (SorteioFruta1 == SorteioFruta2 && SorteioFruta3 == SorteioFruta1)
                    {



                        if (SorteioFruta1 == 1 && SorteioFruta2 == 1 && SorteioFruta3 == 1)
                        {
                            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som//somdinheiro.wav");
                            Player.Play();
                            premio = premio + 0.25;
                            lbpremio.Text = premio.ToString("C");


                        var resultado = MessageBox.Show("Seu prêmio total é "+premio+". Deseja continuar o jogo?", "", MessageBoxButtons.YesNo);

                        if (resultado == DialogResult.Yes)
                        {

                            


                        }



                        else if (resultado == DialogResult.No)
                        {
                            MessageBox.Show("Você ganhou:"+premio);
                            Application.Exit();
                        }



                    }


                        if (SorteioFruta1 == 2 && SorteioFruta2 == 2 && SorteioFruta3 == 2)
                        {
                            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som//somdinheiro.wav");
                            Player.Play();
                            premio = premio + 0.25;
                            lbpremio.Text = premio.ToString("C");

                        var resultado = MessageBox.Show("Seu prêmio total é " + premio + ". Deseja continuar o jogo?", "", MessageBoxButtons.YesNo);

                        if (resultado == DialogResult.Yes)
                        {




                        }



                        else if (resultado == DialogResult.No)
                        {
                            MessageBox.Show("Você ganhou:" + premio);
                            Application.Exit();
                        }

                    }


                        if (SorteioFruta1 == 3 && SorteioFruta2 == 3 && SorteioFruta3 == 3)
                        {
                            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som//somdinheiro.wav");
                            Player.Play();
                            premio = premio + 0.25;
                            lbpremio.Text = premio.ToString("C");


                        var resultado = MessageBox.Show("Seu prêmio total é " + premio + ". Deseja continuar o jogo?", "", MessageBoxButtons.YesNo);

                        if (resultado == DialogResult.Yes)
                        {




                        }



                        else if (resultado == DialogResult.No)
                        {
                            MessageBox.Show("Você ganhou:" + premio);
                            Application.Exit();
                        }


                    }


                        if (SorteioFruta1 == 5 && SorteioFruta2 == 5 && SorteioFruta3 == 5)
                        {
                        System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som//som7.wav");
                        Player.Play();

                        tentativas = tentativas + 7;
                        lbtentativas.Text = Convert.ToString(tentativas);

                        premio = premio - 0.25;
                        lbpremio.Text = premio.ToString("C");


                        var resultado = MessageBox.Show("Você perdeu 25 centavos, mas ganhou +7 chances. Deseja continuar", "", MessageBoxButtons.YesNo);

                        if (resultado == DialogResult.Yes)
                        {




                        }



                        else if (resultado == DialogResult.No)
                        {
                            MessageBox.Show("Você ganhou:" + premio);
                            Application.Exit();
                        }



                    }


                        if (SorteioFruta1 == 4 && SorteioFruta2 == 4 && SorteioFruta3 == 4)
                        {
                        System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som//sompremio.wav");
                        Player.Play();

                        premio = premio +50;
                        tentativas = tentativas + 7;
                        lbpremio.Text = premio.ToString("C");
                        lbtentativas.Text = Convert.ToString(tentativas);



                        var resultado = MessageBox.Show("Você ganhou 50 conto e ganhou +7 chances. Deseja continuar", "", MessageBoxButtons.YesNo);

                        if (resultado == DialogResult.Yes)
                        {




                        }



                        else if (resultado == DialogResult.No)
                        {
                            MessageBox.Show("Você ganhou:" + premio);
                            Application.Exit();
                        }

                    }
                    }

                   



                    
            }

           
        }
        public Form1()
        {
            InitializeComponent();
        }

        Point arrastarcursor;
        Point moverform;
        bool arrasta;
        
        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbpremio.Text = premio.ToString("C");
            lbtentativas.Text = Convert.ToString(tentativas);
        }
        private void btnalavanca_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som//somalavanca.wav");
            Player.Play();


            btnalavanca.Visible = false;
            pbalavanca.Visible = true;
            timeralavanca.Enabled = true;

            sortear();

           


        }

        private void timeralavanca_Tick(object sender, EventArgs e)
        {
            timeralavanca.Enabled = false;
            
            btnalavanca.Visible = true;
            pbalavanca.Visible = false;
        }

      
       

     
     

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }






        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            arrasta = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            arrasta = true;
            arrastarcursor = Cursor.Position;
            moverform = this.Location;
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrasta == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(arrastarcursor));
                this.Location = Point.Add(moverform, new Size(diferenca));
            }
        }

        private void lbtentativas_Click(object sender, EventArgs e)
        {
          
        }

        private void lbpremio_Click(object sender, EventArgs e)
        {

        }

        private void timerlimpaimagens_Tick(object sender, EventArgs e)
        {
            timerlimpaimagens.Enabled = false;
            pbimg1.Image = null;
            pbimg2.Image = null;
            pbimg3.Image = null;


        }
    }
}
