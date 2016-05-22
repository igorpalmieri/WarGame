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
            this.buttonJogar = new System.Windows.Forms.Button();
            this.buttonOpt = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonAvancar = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonJogar
            // 
            this.buttonJogar.BackColor = System.Drawing.Color.Transparent;
            this.buttonJogar.FlatAppearance.BorderSize = 0;
            this.buttonJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJogar.Font = new System.Drawing.Font("Century", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJogar.ForeColor = System.Drawing.Color.Black;
            this.buttonJogar.Location = new System.Drawing.Point(410, 336);
            this.buttonJogar.Name = "buttonJogar";
            this.buttonJogar.Size = new System.Drawing.Size(290, 63);
            this.buttonJogar.TabIndex = 0;
            this.buttonJogar.UseVisualStyleBackColor = false;
            this.buttonJogar.Visible = false;
            this.buttonJogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOpt
            // 
            this.buttonOpt.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpt.ForeColor = System.Drawing.Color.Transparent;
            this.buttonOpt.Location = new System.Drawing.Point(410, 408);
            this.buttonOpt.Name = "buttonOpt";
            this.buttonOpt.Size = new System.Drawing.Size(290, 66);
            this.buttonOpt.TabIndex = 1;
            this.buttonOpt.UseVisualStyleBackColor = false;
            this.buttonOpt.Visible = false;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.Transparent;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVoltar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonVoltar.Location = new System.Drawing.Point(401, 480);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 71);
            this.buttonVoltar.TabIndex = 2;
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Visible = false;
            // 
            // buttonAvancar
            // 
            this.buttonAvancar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAvancar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAvancar.Location = new System.Drawing.Point(662, 480);
            this.buttonAvancar.Name = "buttonAvancar";
            this.buttonAvancar.Size = new System.Drawing.Size(75, 71);
            this.buttonAvancar.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarGame.Properties.Resources.uffsoftcorp;
            this.ClientSize = new System.Drawing.Size(1142, 565);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonAvancar);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonOpt);
            this.Controls.Add(this.buttonJogar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "War Game - By UffSoft Corporate";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.Button buttonOpt;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonAvancar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonJogar;
    }
}

