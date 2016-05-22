namespace WarGame
{
    partial class Form_combo_ataque
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
            this.label_atacante = new System.Windows.Forms.Label();
            this.label_alvos = new System.Windows.Forms.Label();
            this.combo_alvos = new System.Windows.Forms.ComboBox();
            this.button_ir_ataque = new System.Windows.Forms.Button();
            this.button_desistir = new System.Windows.Forms.Button();
            this.tx_atacante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_atacante
            // 
            this.label_atacante.AutoSize = true;
            this.label_atacante.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_atacante.Location = new System.Drawing.Point(7, 34);
            this.label_atacante.Name = "label_atacante";
            this.label_atacante.Size = new System.Drawing.Size(123, 26);
            this.label_atacante.TabIndex = 0;
            this.label_atacante.Text = "Atacar com";
            this.label_atacante.Click += new System.EventHandler(this.label__Click);
            // 
            // label_alvos
            // 
            this.label_alvos.AutoSize = true;
            this.label_alvos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alvos.Location = new System.Drawing.Point(322, 34);
            this.label_alvos.Name = "label_alvos";
            this.label_alvos.Size = new System.Drawing.Size(283, 26);
            this.label_alvos.TabIndex = 1;
            this.label_alvos.Text = "Qual país você quer atacar?";
            this.label_alvos.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // combo_alvos
            // 
            this.combo_alvos.FormattingEnabled = true;
            this.combo_alvos.Location = new System.Drawing.Point(327, 76);
            this.combo_alvos.Name = "combo_alvos";
            this.combo_alvos.Size = new System.Drawing.Size(278, 21);
            this.combo_alvos.TabIndex = 2;
            this.combo_alvos.Text = "SOMENTE_INIMIGOS_FRONTEIRAS";
            // 
            // button_ir_ataque
            // 
            this.button_ir_ataque.Location = new System.Drawing.Point(90, 139);
            this.button_ir_ataque.Name = "button_ir_ataque";
            this.button_ir_ataque.Size = new System.Drawing.Size(195, 35);
            this.button_ir_ataque.TabIndex = 3;
            this.button_ir_ataque.Text = "Preparar Ataque";
            this.button_ir_ataque.UseVisualStyleBackColor = true;
            this.button_ir_ataque.Click += new System.EventHandler(this.button_ir_ataque_Click);
            // 
            // button_desistir
            // 
            this.button_desistir.Location = new System.Drawing.Point(327, 139);
            this.button_desistir.Name = "button_desistir";
            this.button_desistir.Size = new System.Drawing.Size(195, 35);
            this.button_desistir.TabIndex = 4;
            this.button_desistir.Text = "Desistir do Ataque";
            this.button_desistir.UseVisualStyleBackColor = true;
            // 
            // tx_atacante
            // 
            this.tx_atacante.Location = new System.Drawing.Point(12, 76);
            this.tx_atacante.Name = "tx_atacante";
            this.tx_atacante.Size = new System.Drawing.Size(168, 20);
            this.tx_atacante.TabIndex = 5;
            this.tx_atacante.Text = "TEMPO_EXECUCAO";
            // 
            // Form_combo_ataque
            // 
            this.ClientSize = new System.Drawing.Size(622, 196);
            this.Controls.Add(this.tx_atacante);
            this.Controls.Add(this.button_desistir);
            this.Controls.Add(this.button_ir_ataque);
            this.Controls.Add(this.combo_alvos);
            this.Controls.Add(this.label_alvos);
            this.Controls.Add(this.label_atacante);
            this.Name = "Form_combo_ataque";
            this.Text = "Envie suas tropas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_atacante;
        private System.Windows.Forms.Label label_alvos;
        private System.Windows.Forms.ComboBox combo_alvos;
        private System.Windows.Forms.Button button_ir_ataque;
        private System.Windows.Forms.Button button_desistir;
        private System.Windows.Forms.TextBox tx_atacante;
    }
}