using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Da_Forca
{
    public partial class Form2 : Form
    {
        int erros = 0;
        int acertos = 0;
        int numeroDeLetras = 0;
        int tema = 0;
        bool acertou = false;
        string palavra = "";
        string criptografada = " ";
        ClassePalavra pegarPalavra = new ClassePalavra();

        public Form2()
        {
            InitializeComponent();
            comboTemas.SelectedIndex = 0;
            labelResultado.Visible = false;
            HabilitarOuDesabititarBotoes(false);
            ImagemErros(0);
        }

        public void NovoJogo(int tema)
        {
            ImagemErros(0);
            palavra = pegarPalavra.PalavraAleatoria(tema, palavra);
            numeroDeLetras = palavra.Length;
            labelResultado.Visible = false;
            acertos = 0;
            erros = 0;
            labelAcertos.Text = "Acertos: ";
            labelErros.Text = "Erros: ";
            PreencherOTextBox(numeroDeLetras);
            HabilitarOuDesabititarBotoes(true);

            if (palavra.Contains("-"))
            {
                acertou = true;
                SubstituirLetras("-");
                VerificarSeAcertou();
                VerificarSeGanhou();
            }

            if (palavra.Contains(" "))
            {
                acertou = true;
                SubstituirLetras(" ");
                VerificarSeAcertou();
                VerificarSeGanhou();
            }
        }

        private void VerificarLetra(string letra)
        {
            switch (letra)
            {
                case "A":
                    if ((palavra.Contains("A")) || (palavra.Contains("Á")) || (palavra.Contains("À")) || (palavra.Contains("Ã")) || (palavra.Contains("Â")))
                    {
                        acertou = true;
                        SubstituirLetras("A");
                        SubstituirLetras("Á");
                        SubstituirLetras("À");
                        SubstituirLetras("Ã");
                        SubstituirLetras("Â");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "B":
                    if (palavra.Contains("B"))
                    {
                        acertou = true;
                        SubstituirLetras("B");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "C":
                    if ((palavra.Contains("C")) || (palavra.Contains("Ç")))
                    {
                        acertou = true;
                        SubstituirLetras("C");
                        SubstituirLetras("Ç");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "D":
                    if (palavra.Contains("D"))
                    {
                        acertou = true;
                        SubstituirLetras("D");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "E":
                    if ((palavra.Contains("E")) || (palavra.Contains("É")) || (palavra.Contains("È")) || (palavra.Contains("Ê")))
                    {
                        acertou = true;
                        SubstituirLetras("E");
                        SubstituirLetras("É");
                        SubstituirLetras("È");
                        SubstituirLetras("Ê");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "F":
                    if (palavra.Contains("F"))
                    {
                        acertou = true;
                        SubstituirLetras("F");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "G":
                    if (palavra.Contains("G"))
                    {
                        acertou = true;
                        SubstituirLetras("G");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "H":
                    if (palavra.Contains("H"))
                    {
                        acertou = true;
                        SubstituirLetras("H");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "I":
                    if ((palavra.Contains("I")) || (palavra.Contains("Í")) || (palavra.Contains("Ì")))
                    {
                        acertou = true;
                        SubstituirLetras("I");
                        SubstituirLetras("Í");
                        SubstituirLetras("Ì");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "J":
                    if (palavra.Contains("J"))
                    {
                        acertou = true;
                        SubstituirLetras("J");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "K":
                    if (palavra.Contains("K"))
                    {
                        acertou = true;
                        SubstituirLetras("K");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "L":
                    if (palavra.Contains("L"))
                    {
                        acertou = true;
                        SubstituirLetras("L");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "M":
                    if (palavra.Contains("M"))
                    {
                        acertou = true;
                        SubstituirLetras("M");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "N":
                    if (palavra.Contains("N"))
                    {
                        acertou = true;
                        SubstituirLetras("N");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "O":
                    if ((palavra.Contains("O")) || (palavra.Contains("Ó")) || (palavra.Contains("Ò")) || (palavra.Contains("Õ")) || (palavra.Contains("Ô")))
                    {
                        acertou = true;
                        SubstituirLetras("O");
                        SubstituirLetras("Ó");
                        SubstituirLetras("Ò");
                        SubstituirLetras("Õ");
                        SubstituirLetras("Ô");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "P":
                    if (palavra.Contains("P"))
                    {
                        acertou = true;
                        SubstituirLetras("P");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "Q":
                    if (palavra.Contains("Q"))
                    {
                        acertou = true;
                        SubstituirLetras("Q");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "R":
                    if (palavra.Contains("R"))
                    {
                        acertou = true;
                        SubstituirLetras("R");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "S":
                    if (palavra.Contains("S"))
                    {
                        acertou = true;
                        SubstituirLetras("S");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "T":
                    if (palavra.Contains("T"))
                    {
                        acertou = true;
                        SubstituirLetras("T");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "U":
                    if ((palavra.Contains("U")) || (palavra.Contains("Ú")) || (palavra.Contains("Ù")) || (palavra.Contains("Ü")))
                    {
                        acertou = true;
                        SubstituirLetras("U");
                        SubstituirLetras("Ú");
                        SubstituirLetras("Ù");
                        SubstituirLetras("Ü");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "V":
                    if (palavra.Contains("V"))
                    {
                        acertou = true;
                        SubstituirLetras("V");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "W":
                    if (palavra.Contains("W"))
                    {
                        acertou = true;
                        SubstituirLetras("W");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "X":
                    if (palavra.Contains("X"))
                    {
                        acertou = true;
                        SubstituirLetras("X");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "Y":
                    if (palavra.Contains("Y"))
                    {
                        acertou = true;
                        SubstituirLetras("Y");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;

                case "Z":
                    if (palavra.Contains("Z"))
                    {
                        acertou = true;
                        SubstituirLetras("Z");
                    }
                    else
                    {
                        acertou = false;
                    }
                    VerificarSeAcertou();
                    VerificarSeGanhou();
                    break;
            }
        }

        public void PreencherOTextBox(int numeroLetras)
        {
            criptografada = " ";

            for (int i = numeroLetras; i > 0; i--)
            {
                criptografada += "_ ";
            }

            txtPalavra.Text = criptografada;            
        }

        public void SubstituirLetras(string letra)
        {
            int auxiliar = 1;
            StringBuilder sub = new StringBuilder(criptografada);

            if (palavra.Contains(letra))
            {
                for (int i = 0; i < numeroDeLetras; i++)
                {
                    if (palavra[i] == letra[0])
                    {
                        sub.Remove(auxiliar, 1);
                        sub.Insert(auxiliar, letra[0]);
                        acertos++;
                    }
                    auxiliar = (auxiliar + 2);
                }

                criptografada = sub.ToString();
                txtPalavra.Text = criptografada; 
            }
        }

        public void VerificarSeAcertou()
        {
            if (acertou == true)
            {
                labelAcertos.Text = "Acertos: " + acertos.ToString();
            }
            else
            {
                erros++;
                ImagemErros(erros);
                labelErros.Text = "Erros: " + erros.ToString();
            }
        }

        public void ImagemErros(int erros)
        {
            switch (erros)
            {
                case 0:
                    panel1.BackgroundImage = global::Jogo_Da_Forca.Properties.Resources.arvore2;
                    break;
                case 1:
                    panel1.BackgroundImage = global::Jogo_Da_Forca.Properties.Resources._1ERRO;
                    break;
                case 2:
                    panel1.BackgroundImage = global::Jogo_Da_Forca.Properties.Resources._2ERRO;
                    break;
                case 3:
                    panel1.BackgroundImage = global::Jogo_Da_Forca.Properties.Resources._3ERRO;
                    break;
                case 4:
                    panel1.BackgroundImage = global::Jogo_Da_Forca.Properties.Resources._4ERRO;
                    break;
                case 5:
                    panel1.BackgroundImage = global::Jogo_Da_Forca.Properties.Resources._5ERRO;
                    break;
                case 6:
                    panel1.BackgroundImage = global::Jogo_Da_Forca.Properties.Resources._6ERRO;
                    break;
            }
        }

        public void VerificarSeGanhou()
        {
            if (acertos == numeroDeLetras)
            {
                Ganhou();
            }

            if (erros == 6)
            {
                Perdeu();
            }
        }

        public void Perdeu()
        {
            HabilitarOuDesabititarBotoes(false);
            labelResultado.Text = "Você perdeu! A palavra era: " + palavra;
            labelResultado.ForeColor = System.Drawing.Color.Red;
            labelResultado.Visible = true;
        }

        public void Ganhou()
        {
            HabilitarOuDesabititarBotoes(false);
            labelResultado.Text = "Você acertou! A palavra era: " + palavra;
            labelResultado.ForeColor = System.Drawing.Color.Green;
            labelResultado.Visible = true;
        }

        public void HabilitarOuDesabititarBotoes(bool comando)
        {
            btnQ.Enabled = comando;
            btnW.Enabled = comando;
            btnE.Enabled = comando;
            btnR.Enabled = comando;
            btnT.Enabled = comando;
            btnY.Enabled = comando;
            btnU.Enabled = comando;
            btnI.Enabled = comando;
            btnO.Enabled = comando;
            btnP.Enabled = comando;
            btnA.Enabled = comando;
            btnS.Enabled = comando;
            btnD.Enabled = comando;
            btnF.Enabled = comando;
            btnG.Enabled = comando;
            btnH.Enabled = comando;
            btnJ.Enabled = comando;
            btnK.Enabled = comando;
            btnL.Enabled = comando;
            btnZ.Enabled = comando;
            btnZ.Enabled = comando;
            btnX.Enabled = comando;
            btnC.Enabled = comando;
            btnV.Enabled = comando;
            btnB.Enabled = comando;
            btnN.Enabled = comando;
            btnM.Enabled = comando;
        }

        private void BtnQ_Click(object sender, EventArgs e)
        {
            VerificarLetra("Q");
            btnQ.Enabled = false;
        }

        private void BtnW_Click(object sender, EventArgs e)
        {
            VerificarLetra("W");
            btnW.Enabled = false;
        }

        private void BtnE_Click(object sender, EventArgs e)
        {
            VerificarLetra("E");
            btnE.Enabled = false;
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            VerificarLetra("R");
            btnR.Enabled = false;
        }

        private void BtnT_Click(object sender, EventArgs e)
        {
            VerificarLetra("T");
            btnT.Enabled = false;
        }

        private void BtnY_Click(object sender, EventArgs e)
        {
            VerificarLetra("Y");
            btnY.Enabled = false;
        }

        private void BtnU_Click(object sender, EventArgs e)
        {
            VerificarLetra("U");
            btnU.Enabled = false;
        }

        private void BtnI_Click(object sender, EventArgs e)
        {
            VerificarLetra("I");
            btnI.Enabled = false;
        }

        private void BtnO_Click(object sender, EventArgs e)
        {
            VerificarLetra("O");
            btnO.Enabled = false;
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            VerificarLetra("P");
            btnP.Enabled = false;
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            VerificarLetra("A");
            btnA.Enabled = false;
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            VerificarLetra("S");
            btnS.Enabled = false;
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            VerificarLetra("D");
            btnD.Enabled = false;
        }

        private void BtnF_Click(object sender, EventArgs e)
        {
            VerificarLetra("F");
            btnF.Enabled = false;
        }

        private void BtnG_Click(object sender, EventArgs e)
        {
            VerificarLetra("G");
            btnG.Enabled = false;
        }

        private void BtnH_Click(object sender, EventArgs e)
        {
            VerificarLetra("H");
            btnH.Enabled = false;
        }

        private void BtnJ_Click(object sender, EventArgs e)
        {
            VerificarLetra("J");
            btnJ.Enabled = false;
        }

        private void BtnK_Click(object sender, EventArgs e)
        {
            VerificarLetra("K");
            btnK.Enabled = false;
        }

        private void BtnL_Click(object sender, EventArgs e)
        {
            VerificarLetra("L");
            btnL.Enabled = false;
        }

        private void BtnZ_Click(object sender, EventArgs e)
        {
            VerificarLetra("Z");
            btnZ.Enabled = false;
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            VerificarLetra("X");
            btnX.Enabled = false;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            VerificarLetra("C");
            btnC.Enabled = false;
        }

        private void BtnV_Click(object sender, EventArgs e)
        {
            VerificarLetra("V");
            btnV.Enabled = false;
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            VerificarLetra("B");
            btnB.Enabled = false;
        }

        private void BtnN_Click(object sender, EventArgs e)
        {
            VerificarLetra("N");
            btnN.Enabled = false;
        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            VerificarLetra("M");
            btnM.Enabled = false;
        }

        private void BtnNovoJogo_Click(object sender, EventArgs e)
        {
            if ((erros == 6) || (acertos == numeroDeLetras))
            {
                txtPalavra.Text = null;
                NovoJogo(tema);
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja começar um novo jogo? ", " Encerrar o jogo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtPalavra.Text = null;
                    NovoJogo(tema);
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar o jogo?", "Encerrar o Jogo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar o jogo?", "Encerrar o Jogo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ComboTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            tema = Convert.ToInt32(comboTemas.SelectedIndex);
        }
    }
}
