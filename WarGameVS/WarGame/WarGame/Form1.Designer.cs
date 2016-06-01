using System;

namespace WarGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonAvancar = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnOpcoes = new System.Windows.Forms.Button();
            this.btnBolso = new System.Windows.Forms.Button();
            this.btnGloria = new System.Windows.Forms.Button();
            this.btnCerebro = new System.Windows.Forms.Button();
            this.btnInes = new System.Windows.Forms.Button();
            this.fundoVerde = new System.Windows.Forms.PictureBox();
            this.fundoVermelho = new System.Windows.Forms.PictureBox();
            this.fundoAzul = new System.Windows.Forms.PictureBox();
            this.fundoAmarelo = new System.Windows.Forms.PictureBox();
            this.imgHeli = new System.Windows.Forms.PictureBox();
            this.imgTanque = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundoVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundoVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundoAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundoAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTanque)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.Transparent;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVoltar.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.ForeColor = System.Drawing.Color.Black;
            this.buttonVoltar.Location = new System.Drawing.Point(401, 480);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 71);
            this.buttonVoltar.TabIndex = 2;
            this.buttonVoltar.Text = "<";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Visible = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonAvancar
            // 
            this.buttonAvancar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAvancar.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvancar.ForeColor = System.Drawing.Color.Black;
            this.buttonAvancar.Location = new System.Drawing.Point(662, 480);
            this.buttonAvancar.Name = "buttonAvancar";
            this.buttonAvancar.Size = new System.Drawing.Size(75, 71);
            this.buttonAvancar.TabIndex = 3;
            this.buttonAvancar.Text = ">";
            this.buttonAvancar.UseVisualStyleBackColor = false;
            this.buttonAvancar.Visible = false;
            this.buttonAvancar.Click += new System.EventHandler(this.buttonAvancar_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(470, 415);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(194, 50);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Transparent;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJogar.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnJogar.Location = new System.Drawing.Point(454, 338);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(223, 71);
            this.btnJogar.TabIndex = 6;
            this.btnJogar.Text = "-JOGAR-";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Visible = false;
            this.btnJogar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnOpcoes
            // 
            this.btnOpcoes.BackColor = System.Drawing.Color.Transparent;
            this.btnOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpcoes.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnOpcoes.Location = new System.Drawing.Point(454, 420);
            this.btnOpcoes.Name = "btnOpcoes";
            this.btnOpcoes.Size = new System.Drawing.Size(223, 71);
            this.btnOpcoes.TabIndex = 7;
            this.btnOpcoes.Text = "-OPCOES-";
            this.btnOpcoes.UseVisualStyleBackColor = false;
            this.btnOpcoes.Visible = false;
            // 
            // btnBolso
            // 
            this.btnBolso.BackColor = System.Drawing.Color.Red;
            this.btnBolso.BackgroundImage = global::WarGame.Properties.Resources.bolso_sad;
            this.btnBolso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBolso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBolso.FlatAppearance.BorderSize = 5;
            this.btnBolso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnBolso.Location = new System.Drawing.Point(484, 294);
            this.btnBolso.Name = "btnBolso";
            this.btnBolso.Size = new System.Drawing.Size(87, 66);
            this.btnBolso.TabIndex = 8;
            this.btnBolso.UseVisualStyleBackColor = true;
            this.btnBolso.Visible = false;
            this.btnBolso.Click += new System.EventHandler(this.btnBolso_Click);
            // 
            // btnGloria
            // 
            this.btnGloria.BackColor = System.Drawing.Color.Green;
            this.btnGloria.BackgroundImage = global::WarGame.Properties.Resources.gloria_feliz;
            this.btnGloria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGloria.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGloria.FlatAppearance.BorderSize = 5;
            this.btnGloria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGloria.Location = new System.Drawing.Point(387, 294);
            this.btnGloria.Name = "btnGloria";
            this.btnGloria.Size = new System.Drawing.Size(81, 66);
            this.btnGloria.TabIndex = 9;
            this.btnGloria.UseVisualStyleBackColor = false;
            this.btnGloria.Visible = false;
            this.btnGloria.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // btnCerebro
            // 
            this.btnCerebro.BackColor = System.Drawing.Color.Blue;
            this.btnCerebro.BackgroundImage = global::WarGame.Properties.Resources.cerebro_sad;
            this.btnCerebro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerebro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCerebro.FlatAppearance.BorderSize = 5;
            this.btnCerebro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCerebro.Location = new System.Drawing.Point(584, 294);
            this.btnCerebro.Name = "btnCerebro";
            this.btnCerebro.Size = new System.Drawing.Size(75, 66);
            this.btnCerebro.TabIndex = 10;
            this.btnCerebro.UseVisualStyleBackColor = false;
            this.btnCerebro.Visible = false;
            this.btnCerebro.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnInes
            // 
            this.btnInes.BackColor = System.Drawing.Color.Yellow;
            this.btnInes.BackgroundImage = global::WarGame.Properties.Resources.ines_sad;
            this.btnInes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInes.FlatAppearance.BorderSize = 5;
            this.btnInes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnInes.Location = new System.Drawing.Point(674, 294);
            this.btnInes.Name = "btnInes";
            this.btnInes.Size = new System.Drawing.Size(75, 66);
            this.btnInes.TabIndex = 11;
            this.btnInes.UseVisualStyleBackColor = false;
            this.btnInes.Visible = false;
            this.btnInes.Click += new System.EventHandler(this.btnInes_Click);
            // 
            // fundoVerde
            // 
            this.fundoVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.fundoVerde.Location = new System.Drawing.Point(378, 294);
            this.fundoVerde.Name = "fundoVerde";
            this.fundoVerde.Size = new System.Drawing.Size(99, 66);
            this.fundoVerde.TabIndex = 12;
            this.fundoVerde.TabStop = false;
            this.fundoVerde.Visible = false;
            // 
            // fundoVermelho
            // 
            this.fundoVermelho.BackColor = System.Drawing.Color.Maroon;
            this.fundoVermelho.Location = new System.Drawing.Point(477, 294);
            this.fundoVermelho.Name = "fundoVermelho";
            this.fundoVermelho.Size = new System.Drawing.Size(99, 66);
            this.fundoVermelho.TabIndex = 13;
            this.fundoVermelho.TabStop = false;
            this.fundoVermelho.Visible = false;
            // 
            // fundoAzul
            // 
            this.fundoAzul.BackColor = System.Drawing.Color.Navy;
            this.fundoAzul.Location = new System.Drawing.Point(576, 294);
            this.fundoAzul.Name = "fundoAzul";
            this.fundoAzul.Size = new System.Drawing.Size(92, 66);
            this.fundoAzul.TabIndex = 14;
            this.fundoAzul.TabStop = false;
            this.fundoAzul.Visible = false;
            // 
            // fundoAmarelo
            // 
            this.fundoAmarelo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.fundoAmarelo.Location = new System.Drawing.Point(668, 294);
            this.fundoAmarelo.Name = "fundoAmarelo";
            this.fundoAmarelo.Size = new System.Drawing.Size(88, 66);
            this.fundoAmarelo.TabIndex = 15;
            this.fundoAmarelo.TabStop = false;
            this.fundoAmarelo.Visible = false;
            // 
            // imgHeli
            // 
            this.imgHeli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgHeli.Image = global::WarGame.Properties.Resources.heligif;
            this.imgHeli.Location = new System.Drawing.Point(462, 57);
            this.imgHeli.Name = "imgHeli";
            this.imgHeli.Size = new System.Drawing.Size(107, 88);
            this.imgHeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHeli.TabIndex = 16;
            this.imgHeli.TabStop = false;
            this.imgHeli.Visible = false;
            // 
            // imgTanque
            // 
            this.imgTanque.Image = global::WarGame.Properties.Resources.tirogif2;
            this.imgTanque.Location = new System.Drawing.Point(91, 282);
            this.imgTanque.Name = "imgTanque";
            this.imgTanque.Size = new System.Drawing.Size(265, 219);
            this.imgTanque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTanque.TabIndex = 17;
            this.imgTanque.TabStop = false;
            this.imgTanque.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WarGame.Properties.Resources.uffsoftcorp;
            this.ClientSize = new System.Drawing.Size(1142, 565);
            this.Controls.Add(this.imgTanque);
            this.Controls.Add(this.imgHeli);
            this.Controls.Add(this.btnInes);
            this.Controls.Add(this.btnCerebro);
            this.Controls.Add(this.btnGloria);
            this.Controls.Add(this.btnBolso);
            this.Controls.Add(this.btnOpcoes);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonAvancar);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.fundoVerde);
            this.Controls.Add(this.fundoVermelho);
            this.Controls.Add(this.fundoAzul);
            this.Controls.Add(this.fundoAmarelo);
            this.Controls.Add(this.btnJogar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "War Game - By UffSoft Corporate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundoVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundoVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundoAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundoAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTanque)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonAvancar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnOpcoes;
        private System.Windows.Forms.Button btnBolso;
        private System.Windows.Forms.Button btnGloria;
        private System.Windows.Forms.Button btnCerebro;
        private System.Windows.Forms.Button btnInes;
        private System.Windows.Forms.PictureBox fundoVerde;
        private System.Windows.Forms.PictureBox fundoVermelho;
        private System.Windows.Forms.PictureBox fundoAzul;
        private System.Windows.Forms.PictureBox fundoAmarelo;
        private System.Windows.Forms.PictureBox imgHeli;
        private System.Windows.Forms.PictureBox imgTanque;
        //private System.Windows.Forms.Button buttonJogar;
    }
}

