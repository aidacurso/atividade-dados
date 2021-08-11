
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
            this.labelJogadorGanhou = new System.Windows.Forms.Label();
            this.labelComputadorGanhou = new System.Windows.Forms.Label();
            this.textJogadorGanhu = new System.Windows.Forms.TextBox();
            this.textComputadorGanhou = new System.Windows.Forms.TextBox();
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
            this.labelJogador1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelJogador1.Location = new System.Drawing.Point(25, 168);
            this.labelJogador1.Name = "labelJogador1";
            this.labelJogador1.Size = new System.Drawing.Size(108, 23);
            this.labelJogador1.TabIndex = 1;
            this.labelJogador1.Text = "jogador 1:";
            this.labelJogador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelComputador
            // 
            this.labelComputador.AutoSize = true;
            this.labelComputador.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComputador.Location = new System.Drawing.Point(25, 193);
            this.labelComputador.Name = "labelComputador";
            this.labelComputador.Size = new System.Drawing.Size(140, 23);
            this.labelComputador.TabIndex = 2;
            this.labelComputador.Text = "computador:";
            this.labelComputador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textDado1
            // 
            this.textDado1.BackColor = System.Drawing.SystemColors.Menu;
            this.textDado1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textDado1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDado1.Location = new System.Drawing.Point(62, 82);
            this.textDado1.Multiline = true;
            this.textDado1.Name = "textDado1";
            this.textDado1.ReadOnly = true;
            this.textDado1.Size = new System.Drawing.Size(71, 63);
            this.textDado1.TabIndex = 3;
            this.textDado1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDado1.UseWaitCursor = true;
            // 
            // textDado2
            // 
            this.textDado2.BackColor = System.Drawing.SystemColors.Menu;
            this.textDado2.Cursor = System.Windows.Forms.Cursors.No;
            this.textDado2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDado2.Location = new System.Drawing.Point(176, 84);
            this.textDado2.Multiline = true;
            this.textDado2.Name = "textDado2";
            this.textDado2.ReadOnly = true;
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
            this.textComputador.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textComputador.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textComputador.Location = new System.Drawing.Point(176, 199);
            this.textComputador.Name = "textComputador";
            this.textComputador.ReadOnly = true;
            this.textComputador.Size = new System.Drawing.Size(26, 17);
            this.textComputador.TabIndex = 6;
            // 
            // buttonJogar
            // 
            this.buttonJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonJogar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonJogar.Location = new System.Drawing.Point(236, 183);
            this.buttonJogar.Name = "buttonJogar";
            this.buttonJogar.Size = new System.Drawing.Size(81, 42);
            this.buttonJogar.TabIndex = 7;
            this.buttonJogar.Text = "jogar";
            this.buttonJogar.UseVisualStyleBackColor = true;
            this.buttonJogar.Click += new System.EventHandler(this.buttonJogar_Click);
            // 
            // labelJogadorGanhou
            // 
            this.labelJogadorGanhou.AutoSize = true;
            this.labelJogadorGanhou.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJogadorGanhou.Location = new System.Drawing.Point(25, 228);
            this.labelJogadorGanhou.Name = "labelJogadorGanhou";
            this.labelJogadorGanhou.Size = new System.Drawing.Size(193, 17);
            this.labelJogadorGanhou.TabIndex = 8;
            this.labelJogadorGanhou.Text = "você já ganhou                   vezes";
            // 
            // labelComputadorGanhou
            // 
            this.labelComputadorGanhou.AutoSize = true;
            this.labelComputadorGanhou.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComputadorGanhou.Location = new System.Drawing.Point(23, 253);
            this.labelComputadorGanhou.Name = "labelComputadorGanhou";
            this.labelComputadorGanhou.Size = new System.Drawing.Size(229, 17);
            this.labelComputadorGanhou.TabIndex = 9;
            this.labelComputadorGanhou.Text = "o computador já ganhou             vezes";
            // 
            // textJogadorGanhu
            // 
            this.textJogadorGanhu.BackColor = System.Drawing.SystemColors.Menu;
            this.textJogadorGanhu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textJogadorGanhu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textJogadorGanhu.Location = new System.Drawing.Point(128, 226);
            this.textJogadorGanhu.Name = "textJogadorGanhu";
            this.textJogadorGanhu.Size = new System.Drawing.Size(50, 15);
            this.textJogadorGanhu.TabIndex = 10;
            this.textJogadorGanhu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textComputadorGanhou
            // 
            this.textComputadorGanhou.BackColor = System.Drawing.SystemColors.Menu;
            this.textComputadorGanhou.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textComputadorGanhou.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textComputadorGanhou.Location = new System.Drawing.Point(176, 251);
            this.textComputadorGanhou.Name = "textComputadorGanhou";
            this.textComputadorGanhou.Size = new System.Drawing.Size(39, 15);
            this.textComputadorGanhou.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 276);
            this.Controls.Add(this.textComputadorGanhou);
            this.Controls.Add(this.textJogadorGanhu);
            this.Controls.Add(this.labelComputadorGanhou);
            this.Controls.Add(this.labelJogadorGanhou);
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
        private System.Windows.Forms.Label labelJogadorGanhou;
        private System.Windows.Forms.Label labelComputadorGanhou;
        private System.Windows.Forms.TextBox textJogadorGanhu;
        private System.Windows.Forms.TextBox textComputadorGanhou;
    }
}

