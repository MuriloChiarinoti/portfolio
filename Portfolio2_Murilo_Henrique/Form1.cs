using LibVLCSharp.Shared;
using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Portfolio2_Murilo_Henrique

{
    public partial class Form1 : Form
    {
        protected LibVLC vlc;
        protected LibVLCSharp.Shared.MediaPlayer mp;

        public Form1()
        {
            InitializeComponent();
            vlc = new LibVLC();
            mp = new LibVLCSharp.Shared.MediaPlayer(vlc);
        }

        //Bot�o respons�vel por apresentar curiosidades � respeito de Smokey Nagata
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.Image = Properties.Resources.smokey_nagata;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                textBox2.Text = "Smokey Nagata � um lend�rio piloto de carros japoneses conhecido por sua habilidade em pilotar carros de alta performance e sua participa��o" +
                    " em corridas de rua ilegais. Ele � especialmente famoso por seu trabalho com o Toyota Supra, um carro esportivo japon�s que se tornou um �cone da cultura " +
                    "automotiva no Jap�o e em todo o mundo. ";
            }

            else
            {
                pictureBox1.Image = null;
            }
        }

        //Bot�o respons�vel por exibir a imagem do Toyota Supra e uma breve descri��o
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBox1.Image = Properties.Resources.toyota_supra;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                textBox2.Text = "O Supra de quarta gera��o � um coup� de dois lugares com motor dianteiro e tra��o traseira." +
                    " Ele vem equipado com um motor 2JZ de seis cilindros em linha, que � conhecido por sua confiabilidade e capacidade de lidar com modifica��es significativas." +
                    " A pot�ncia varia de 220 a 320 cavalos de pot�ncia, dependendo do modelo.  ";
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
        //Bot�o respons�vel por exibir a imagem do Mazda RX7 e uma breve descri��o
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                pictureBox1.Image = Properties.Resources.mazda_rx7;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                textBox2.Text = "O Mazda RX-7 � um carro esportivo de duas portas fabricado pela Mazda de 1978 a 2002. Com um motor rotativo de 1,3 litros, que produz cerca de 255 cavalos de pot�ncia, ele � conhecido pelo design esportivo e aerodin�mico." +
                    " O RX-7 tem far�is retr�teis e uma traseira em forma de cunha, al�m de ganhar pr�mios de design e desempenho." +
                    " � um dos carros esportivos japoneses mais reconhecidos. ";
            }
            else
            {
                pictureBox1.Image = null;
            }

        }
        //Bot�o respons�vel por exibir a imagem do Nissan Skyline R34 e uma breve descri��o
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                pictureBox1.Image = Properties.Resources.nissan_skyline;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                textBox2.Text = "O Nissan Skyline R34 � um carro esportivo fabricado pela Nissan de 1999 a 2002, com um motor twin-turbo de 2,6 litros," +
                    " produzindo cerca de 280 cavalos de pot�ncia. Ele � conhecido por seu design agressivo, tecnologia avan�ada, tra��o nas quatro rodas e" +
                    " sistema de controle de estabilidade. O R34 se tornou famoso em filmes e jogos de videogame e � considerado um �cone entre os carros japoneses de alto desempenho," +
                    " sendo um dos mais desejados e admirados de todos os tempos. ";
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        //Bot�o respons�vel por exibir a imagem do Toyota AE86 e uma breve descri��o
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                pictureBox1.Image = Properties.Resources.toyota_ae86;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                textBox2.Text = "O Toyota AE86 � um carro esportivo compacto fabricado pela Toyota de 1983 a 1987," +
                    " famoso por sua capacidade de manuseio em curvas, devido ao seu peso leve e equil�brio quase perfeito." +
                    " Com um motor de 1,6 litros e 128 cavalos, o AE86 � valorizado mais pelo seu desempenho em curvas do que por sua pot�ncia." +
                    " Ele � um carro cultuado entre os entusiastas de carros esportivos e � considerado um �cone da cultura automotiva japonesa dos anos 80 e 90," +
                    " tendo sido apresentado em jogos de v�deo game e no mang�/anime Initial D.";
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Bot�o respons�vel por abrir o menu escolha de arquivo de v�deo
        private void button5_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Arquivos de v�deo (*.mp4;*.mkv;*.avi)|*.mp4;*.mkv;*.avi|Todos os arquivos (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var media = new Media(vlc, ofd.FileName);
                    mp.Media = media;

                }
                videoView1.MediaPlayer = mp;
                mp.Play();
            }
        }


        public class Palavra
        {
            public string Nome { get; set; }
            public Image Imagem { get; set; }
            public string Texto { get; set; }
        }
        List<Palavra> palavras = new List<Palavra>
{
        new Palavra { Nome = "Velozes e Furiosos: Desafio em T�quio", Imagem = Properties.Resources.TokyoDrift, Texto = "Velozes e Furiosos: Desafio em T�quio\" � um filme de a��o de 2006, dirigido por Justin Lin, que conta a hist�ria de Sean Boswell, um jovem americano que se envolve com corridas de rua ilegais em T�quio e acaba se tornando parte de uma gangue local. O filme � o terceiro da franquia \"Velozes e Furiosos\" e apresenta muitas cenas de a��o com carros tunados e manobras arriscadas nas ruas da cidade japonesa. " },
        new Palavra { Nome = "Need for Speed Underground", Imagem = Properties.Resources.nfsu, Texto = "Need for Speed: Underground\" � um jogo eletr�nico de corrida lan�ado em 2003, desenvolvido pela EA Black Box e publicado pela Electronic Arts. � o s�timo t�tulo da s�rie \"Need for Speed\" e o primeiro a focar em corridas ilegais noturnas. O jogo apresenta uma variedade de carros personaliz�veis, modos de jogo como corridas de circuito, arrancada e drift, e uma trilha sonora com m�sicas de artistas famosos. " },
        new Palavra { Nome = "Need for Speed Underground 2", Imagem = Properties.Resources.nfsu2, Texto = "Need for Speed Underground 2 � um jogo de corrida lan�ado em 2004, desenvolvido pela EA Black Box e publicado pela Electronic Arts. O jogo se passa em uma cidade fict�cia e apresenta corridas ilegais, personaliza��o extensa de ve�culos e uma trilha sonora com m�sicas licenciadas." },
        new Palavra { Nome = "Initial D", Imagem = Properties.Resources.initiald, Texto = "Initial D � um anime de corrida de rua lan�ado em 1998. A hist�ria segue Takumi Fujiwara, um entregador de tofu que se torna um corredor de drift lend�rio na montanha local. Takumi pilota um Toyota AE86, um carro relativamente antigo, mas com habilidades de condu��o surpreendentes, herdadas de seu pai, um corredor de drift aposentado. O anime � conhecido por suas cenas de corrida empolgantes e pela trilha sonora eletr�nica animada. Initial D teve grande influ�ncia na cultura do drift e � um cl�ssico dos animes de corrida." },
};


        private void button7_Click(object sender, EventArgs e)
        {
            Palavra palavra = palavras[new Random().Next(palavras.Count)];
            // exibe a imagem e o texto da palavra nos controles correspondentes
            pictureBox2.Image = palavra.Imagem;
            textBox7.Text = palavra.Texto;
            comboBox1.SelectedItem = palavra.Nome;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            mp.Pause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            pictureBox2.Image = null;
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox2.Image = Properties.Resources.TokyoDrift;
                    textBox7.Text = "\"Velozes e Furiosos: Desafio em T�quio\\\" � um filme de a��o de 2006, dirigido por Justin Lin, que conta a hist�ria de Sean Boswell, um jovem americano que se envolve com corridas de rua ilegais em T�quio e acaba se tornando parte de uma gangue local. O filme � o terceiro da franquia \\\"Velozes e Furiosos\\\" e apresenta muitas cenas de a��o com carros tunados e manobras arriscadas nas ruas da cidade japonesa. \""; // atualiza o texto
                    break;
                case 1:
                    pictureBox2.Image = Properties.Resources.nfsu;
                    textBox7.Text = "Need for Speed: Underground\" � um jogo eletr�nico de corrida lan�ado em 2003, desenvolvido pela EA Black Box e publicado pela Electronic Arts. � o s�timo t�tulo da s�rie \"Need for Speed\" e o primeiro a focar em corridas ilegais noturnas. O jogo apresenta uma variedade de carros personaliz�veis, modos de jogo como corridas de circuito, arrancada e drift, e uma trilha sonora com m�sicas de artistas famosos."; // atualiza o texto
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.nfsu2;
                    textBox7.Text = "Need for Speed Underground 2 � um jogo de corrida lan�ado em 2004, desenvolvido pela EA Black Box e publicado pela Electronic Arts. O jogo se passa em uma cidade fict�cia e apresenta corridas ilegais, personaliza��o extensa de ve�culos e uma trilha sonora com m�sicas licenciadas."; // atualiza o texto
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.initiald;
                    textBox7.Text = "Initial D � um anime de corrida de rua lan�ado em 1998. A hist�ria segue Takumi Fujiwara, um entregador de tofu que se torna um corredor de drift lend�rio na montanha local. Takumi pilota um Toyota AE86, um carro relativamente antigo, mas com habilidades de condu��o surpreendentes, herdadas de seu pai, um corredor de drift aposentado. " +
                        "� conhecido por suas cenas de corrida empolgantes e pela trilha sonora eletr�nica animada. Initial D teve grande influ�ncia na cultura do drift e � um cl�ssico dos animes de corrida.\",\r\n";
                    break;
                default:
                    break;
            }
        }
    }
}
