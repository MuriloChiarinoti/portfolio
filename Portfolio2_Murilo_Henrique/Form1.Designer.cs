using Vlc.DotNet.Forms;

namespace Portfolio2_Murilo_Henrique
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            textBox3 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            splitContainer2 = new SplitContainer();
            button5 = new Button();
            button3 = new Button();
            textBox6 = new TextBox();
            button2 = new Button();
            textBox4 = new TextBox();
            videoView1 = new LibVLCSharp.WinForms.VideoView();
            tabPage3 = new TabPage();
            splitContainer3 = new SplitContainer();
            button8 = new Button();
            button7 = new Button();
            textBox8 = new TextBox();
            button4 = new Button();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            pictureBox2 = new PictureBox();
            comboBox1 = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, -3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(446, 453);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(438, 425);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Carros";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Silver;
            splitContainer1.Panel1.Controls.Add(textBox3);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Transparent;
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(432, 419);
            splitContainer1.SplitterDistance = 144;
            splitContainer1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Silver;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(10, 44);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 154);
            textBox3.TabIndex = 2;
            textBox3.Text = "Olá, sejam bem vindos!\r\nAbordaremos o tema JDM (Japanese Domestic Cars), mostrando veículos icônicos e pessoas famosas nesse mundo";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(4, 383);
            button1.Name = "button1";
            button1.Size = new Size(137, 31);
            button1.TabIndex = 0;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Crimson;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(10, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 22);
            textBox1.TabIndex = 0;
            textBox1.Text = " JDM CARS";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(10, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(131, 155);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Escolha uma opcao";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 122);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(89, 19);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "Toyota AE86";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 97);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(100, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Nissan Skyline";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(83, 19);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "Mazda RX7";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 19);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "Toyota Supra";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(108, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Smokey Nagata";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(-1, 222);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 197);
            textBox2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 213);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(438, 425);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Videos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.Silver;
            splitContainer2.Panel1.Controls.Add(button5);
            splitContainer2.Panel1.Controls.Add(button3);
            splitContainer2.Panel1.Controls.Add(textBox6);
            splitContainer2.Panel1.Controls.Add(button2);
            splitContainer2.Panel1.Controls.Add(textBox4);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(videoView1);
            splitContainer2.Size = new Size(432, 419);
            splitContainer2.SplitterDistance = 144;
            splitContainer2.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Location = new Point(13, 169);
            button5.Name = "button5";
            button5.Size = new Size(120, 39);
            button5.TabIndex = 3;
            button5.Text = "Selecione arquivo";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(13, 214);
            button3.Name = "button3";
            button3.Size = new Size(120, 39);
            button3.TabIndex = 0;
            button3.Text = "Pause";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Silver;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(13, 57);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(118, 98);
            textBox6.TabIndex = 2;
            textBox6.Text = "Insira de seu computador um arquivo de vídeo (MP4, AVI...) para que possa ser reproduzido\r\n";
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(4, 378);
            button2.Name = "button2";
            button2.Size = new Size(137, 31);
            button2.TabIndex = 1;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Crimson;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(13, 18);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(118, 22);
            textBox4.TabIndex = 0;
            textBox4.Text = "JDM CARS";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // videoView1
            // 
            videoView1.BackColor = Color.Black;
            videoView1.Location = new Point(18, 17);
            videoView1.MediaPlayer = null;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(255, 375);
            videoView1.TabIndex = 0;
            videoView1.Text = "videoView1";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(splitContainer3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(438, 425);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cultura";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(3, 3);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.BackColor = Color.Silver;
            splitContainer3.Panel1.Controls.Add(button8);
            splitContainer3.Panel1.Controls.Add(button7);
            splitContainer3.Panel1.Controls.Add(textBox8);
            splitContainer3.Panel1.Controls.Add(button4);
            splitContainer3.Panel1.Controls.Add(textBox5);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(textBox7);
            splitContainer3.Panel2.Controls.Add(pictureBox2);
            splitContainer3.Panel2.Controls.Add(comboBox1);
            splitContainer3.Size = new Size(432, 419);
            splitContainer3.SplitterDistance = 144;
            splitContainer3.TabIndex = 0;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.Location = new Point(3, 378);
            button8.Name = "button8";
            button8.Size = new Size(137, 31);
            button8.TabIndex = 5;
            button8.Text = "Sair";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(13, 178);
            button7.Name = "button7";
            button7.Size = new Size(108, 23);
            button7.TabIndex = 4;
            button7.Text = "Random";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.Silver;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Location = new Point(13, 58);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(108, 102);
            textBox8.TabIndex = 3;
            textBox8.Text = "Nessa seção irei abordar alguns tópicos da cultura JDM presente em jogos, animes e filmes\r\n";
            // 
            // button4
            // 
            button4.Location = new Point(13, 217);
            button4.Name = "button4";
            button4.Size = new Size(108, 23);
            button4.TabIndex = 0;
            button4.Text = "Limpar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Crimson;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(13, 16);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(118, 22);
            textBox5.TabIndex = 0;
            textBox5.Text = "JDM CARS";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Silver;
            textBox7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(3, 259);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(278, 157);
            textBox7.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(3, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(278, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Velozes e Furiosos: Desafio em Tóquio", "Need for Speed Underground", "Need for Speed Underground 2", "Initial D" });
            comboBox1.Location = new Point(9, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 458);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Random";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)videoView1).EndInit();
            tabPage3.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private SplitContainer splitContainer1;
        private Button button1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TabPage tabPage2;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private RadioButton radioButton5;
        private SplitContainer splitContainer2;
        private TextBox textBox4;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox6;
        private TabPage tabPage3;
        private SplitContainer splitContainer3;
        private Button button4;
        private TextBox textBox5;
        private Button button3;
        private Button button6;
        private Button button5;
        private TextBox textBox8;
        private TextBox textBox7;
        private PictureBox pictureBox2;
        private ComboBox comboBox1;
        private Button button7;
        private Button button8;
        private LibVLCSharp.WinForms.VideoView videoView1;
    }
}