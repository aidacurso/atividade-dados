
namespace atividade1
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelJogador1 = new System.Windows.Forms.Label();
            this.labelComputador = new System.Windows.Forms.Label();
            this.textDado1 = new System.Windows.Forms.TextBox();
            this.textDado2 = new System.Windows.Forms.TextBox();
            this.textJogador1 = new System.Windows.Forms.TextBox();
            this.textComputador = new System.Windows.Forms.TextBox();
            this.buttonJogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(116, 23);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(99, 33);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "dados";
            // 
            // labelJogador1
            // 
            this.labelJogador1.AutoSize = true;
            this.labelJogador1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJogador1.Location = new System.Drawing.Point(25, 168);
            this.labelJogador1.Name = "labelJogador1";
            this.labelJogador1.Size = new System.Drawing.Size(108, 23);
            this.labelJogador1.TabIndex = 1;
            this.labelJogador1.Text = "jogador 1:";
            // 
            // labelComputador
            // 
            this.labelComputador.AutoSize = true;
            this.labelComputador.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComputador.Location = new System.Drawing.Point(25, 224);
            this.labelComputador.Name = "labelComputador";
            this.labelComputador.Size = new System.Drawing.Size(140, 23);
            this.labelComputador.TabIndex = 2;
            this.labelComputador.Text = "computador:";
            // 
            // textDado1
            // 
            this.textDado1.BackColor = System.Drawing.SystemColors.Menu;
            this.textDado1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDado1.Location = new System.Drawing.Point(62, 82);
            this.textDado1.Multiline = true;
            this.textDado1.Name = "textDado1";
            this.textDado1.Size = new System.Drawing.Size(71, 63);
            this.textDado1.TabIndex = 3;
            // 
            // textDado2
            // 
            this.textDado2.BackColor = System.Drawing.SystemColors.Menu;
            this.textDado2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDado2.Location = new System.Drawing.Point(176, 84);
            this.textDado2.Multiline = true;
            this.textDado2.Name = "textDado2";
            this.textDado2.Size = new System.Drawing.Size(71, 63);
            this.textDado2.TabIndex = 4;
            // 
            // textJogador1
            // 
            this.textJogador1.BackColor = System.Drawing.SystemColors.Info;
            this.textJogador1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textJogador1.Location = new System.Drawing.Point(176, 167);
            this.textJogador1.Name = "textJogador1";
            this.textJogador1.Size = new System.Drawing.Size(26, 24);
            this.textJogador1.TabIndex = 5;
            // 
            // textComputador
            // 
            this.textComputador.BackColor = System.Drawing.SystemColors.Menu;
            this.textComputador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textComputador.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textComputador.Location = new System.Drawing.Point(176, 224);
            this.textComputador.Name = "textComputador";
            this.textComputador.Size = new System.Drawing.Size(26, 17);
            this.textComputador.TabIndex = 6;
            // 
            // buttonJogar
            // 
            this.buttonJogar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonJogar.Location = new System.Drawing.Point(236, 183);
            this.buttonJogar.Name = "buttonJogar";
            this.buttonJogar.Size = new System.Drawing.Size(81, 42);
            this.buttonJogar.TabIndex = 7;
            this.buttonJogar.Text = "jogar";
            this.buttonJogar.UseVisualStyleBackColor = true;
            this.buttonJogar.Click += new System.EventHandler(this.buttonJogar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 276);
            this.Controls.Add(this.buttonJogar);
            this.Controls.Add(this.textComputador);
            this.Controls.Add(this.textJogador1);
            this.Controls.Add(this.textDado2);
            this.Controls.Add(this.textDado1);
            this.Controls.Add(this.labelComputador);
            this.Controls.Add(this.labelJogador1);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelJogador1;
        private System.Windows.Forms.Label labelComputador;
        private System.Windows.Forms.TextBox textDado1;
        private System.Windows.Forms.TextBox textDado2;
        private System.Windows.Forms.TextBox textJogador1;
        private System.Windows.Forms.TextBox textComputador;
        private System.Windows.Forms.Button buttonJogar;
    }
}

