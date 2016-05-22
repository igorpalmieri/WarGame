namespace WarGame
{
    partial class Form_ataque
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
            this.labelAtaque = new System.Windows.Forms.Label();
            this.label_defesa = new System.Windows.Forms.Label();
            this.tx_ataque = new System.Windows.Forms.TextBox();
            this.tx_defesa = new System.Windows.Forms.TextBox();
            this.tx_num_defesa = new System.Windows.Forms.TextBox();
            this.tx_num_ataque = new System.Windows.Forms.TextBox();
            this.label_num_ataque = new System.Windows.Forms.Label();
            this.label_num_defesa = new System.Windows.Forms.Label();
            this.label_resultado_dados = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.button_atacar = new System.Windows.Forms.Button();
            this.button_recuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAtaque
            // 
            this.labelAtaque.AutoSize = true;
            this.labelAtaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtaque.Location = new System.Drawing.Point(118, 20);
            this.labelAtaque.Name = "labelAtaque";
            this.labelAtaque.Size = new System.Drawing.Size(108, 26);
            this.labelAtaque.TabIndex = 0;
            this.labelAtaque.Text = "ATAQUE";
            // 
            // label_defesa
            // 
            this.label_defesa.AutoSize = true;
            this.label_defesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_defesa.Location = new System.Drawing.Point(524, 20);
            this.label_defesa.Name = "label_defesa";
            this.label_defesa.Size = new System.Drawing.Size(107, 26);
            this.label_defesa.TabIndex = 1;
            this.label_defesa.Text = "DEFESA";
            // 
            // tx_ataque
            // 
            this.tx_ataque.Location = new System.Drawing.Point(58, 60);
            this.tx_ataque.Name = "tx_ataque";
            this.tx_ataque.ReadOnly = true;
            this.tx_ataque.Size = new System.Drawing.Size(235, 20);
            this.tx_ataque.TabIndex = 2;
            this.tx_ataque.Text = "PAÍS_TEMPO_EXECUCAO";
            // 
            // tx_defesa
            // 
            this.tx_defesa.Location = new System.Drawing.Point(460, 60);
            this.tx_defesa.Name = "tx_defesa";
            this.tx_defesa.ReadOnly = true;
            this.tx_defesa.Size = new System.Drawing.Size(235, 20);
            this.tx_defesa.TabIndex = 3;
            this.tx_defesa.Text = "PAÍS_TEMPO_EXECUCAO";
            // 
            // tx_num_defesa
            // 
            this.tx_num_defesa.Location = new System.Drawing.Point(610, 103);
            this.tx_num_defesa.Name = "tx_num_defesa";
            this.tx_num_defesa.ReadOnly = true;
            this.tx_num_defesa.Size = new System.Drawing.Size(85, 20);
            this.tx_num_defesa.TabIndex = 4;
            this.tx_num_defesa.Text = "Nº TROPAS";
            // 
            // tx_num_ataque
            // 
            this.tx_num_ataque.Location = new System.Drawing.Point(208, 103);
            this.tx_num_ataque.Name = "tx_num_ataque";
            this.tx_num_ataque.ReadOnly = true;
            this.tx_num_ataque.Size = new System.Drawing.Size(85, 20);
            this.tx_num_ataque.TabIndex = 5;
            this.tx_num_ataque.Text = "Nº TROPAS";
            // 
            // label_num_ataque
            // 
            this.label_num_ataque.AutoSize = true;
            this.label_num_ataque.Location = new System.Drawing.Point(58, 103);
            this.label_num_ataque.Name = "label_num_ataque";
            this.label_num_ataque.Size = new System.Drawing.Size(78, 13);
            this.label_num_ataque.TabIndex = 6;
            this.label_num_ataque.Text = "Total de tropas";
            // 
            // label_num_defesa
            // 
            this.label_num_defesa.AutoSize = true;
            this.label_num_defesa.Location = new System.Drawing.Point(457, 103);
            this.label_num_defesa.Name = "label_num_defesa";
            this.label_num_defesa.Size = new System.Drawing.Size(78, 13);
            this.label_num_defesa.TabIndex = 7;
            this.label_num_defesa.Text = "Total de tropas";
            // 
            // label_resultado_dados
            // 
            this.label_resultado_dados.AutoSize = true;
            this.label_resultado_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado_dados.Location = new System.Drawing.Point(12, 239);
            this.label_resultado_dados.Name = "label_resultado_dados";
            this.label_resultado_dados.Size = new System.Drawing.Size(201, 26);
            this.label_resultado_dados.TabIndex = 8;
            this.label_resultado_dados.Text = "Resultado Dados:";
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x.Location = new System.Drawing.Point(364, 20);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(24, 26);
            this.label_x.TabIndex = 9;
            this.label_x.Text = "x";
            // 
            // button_atacar
            // 
            this.button_atacar.Location = new System.Drawing.Point(508, 294);
            this.button_atacar.Name = "button_atacar";
            this.button_atacar.Size = new System.Drawing.Size(260, 56);
            this.button_atacar.TabIndex = 10;
            this.button_atacar.Text = "Atacar";
            this.button_atacar.UseVisualStyleBackColor = true;
            // 
            // button_recuar
            // 
            this.button_recuar.Location = new System.Drawing.Point(508, 381);
            this.button_recuar.Name = "button_recuar";
            this.button_recuar.Size = new System.Drawing.Size(260, 56);
            this.button_recuar.TabIndex = 11;
            this.button_recuar.Text = "Recuar";
            this.button_recuar.UseVisualStyleBackColor = true;
            // 
            // Form_ataque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 485);
            this.Controls.Add(this.button_recuar);
            this.Controls.Add(this.button_atacar);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.label_resultado_dados);
            this.Controls.Add(this.label_num_defesa);
            this.Controls.Add(this.label_num_ataque);
            this.Controls.Add(this.tx_num_ataque);
            this.Controls.Add(this.tx_num_defesa);
            this.Controls.Add(this.tx_defesa);
            this.Controls.Add(this.tx_ataque);
            this.Controls.Add(this.label_defesa);
            this.Controls.Add(this.labelAtaque);
            this.Name = "Form_ataque";
            this.Text = "Começou um ataque...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAtaque;
        private System.Windows.Forms.Label label_defesa;
        private System.Windows.Forms.TextBox tx_ataque;
        private System.Windows.Forms.TextBox tx_defesa;
        private System.Windows.Forms.TextBox tx_num_defesa;
        private System.Windows.Forms.TextBox tx_num_ataque;
        private System.Windows.Forms.Label label_num_ataque;
        private System.Windows.Forms.Label label_num_defesa;
        private System.Windows.Forms.Label label_resultado_dados;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Button button_atacar;
        private System.Windows.Forms.Button button_recuar;
    }
}