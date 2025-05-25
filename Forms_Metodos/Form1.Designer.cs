namespace Forms_Metodos
{
    partial class EsquecerSenha
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MtB_Codigo_Verificacao = new System.Windows.Forms.TextBox();
            this.MtB_Busca_Matricula_Senha = new System.Windows.Forms.MaskedTextBox();
            this.tB_Confir_New_Senha = new System.Windows.Forms.TextBox();
            this.tB_New_Senha = new System.Windows.Forms.TextBox();
            this.tB_Senha_Temp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Senha_Confirm = new System.Windows.Forms.Label();
            this.label_Senha = new System.Windows.Forms.Label();
            this.label_Senha_Temp = new System.Windows.Forms.Label();
            this.Esqueceu_Senha = new System.Windows.Forms.Label();
            this.Ocultar_Senha = new System.Windows.Forms.PictureBox();
            this.Ocultar_Senha_ = new System.Windows.Forms.PictureBox();
            this.Ocultar_Senha_Confir = new System.Windows.Forms.PictureBox();
            this.Mostrar_Senha = new System.Windows.Forms.PictureBox();
            this.Mostrar_Senha_ = new System.Windows.Forms.PictureBox();
            this.Mostrar_Senha_Confir = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new System.Windows.Forms.Button();
            this.MBNT_Verificar_Codigo = new System.Windows.Forms.Button();
            this.BnT_Verificar_Senha_Temp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar_Senha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar_Senha_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar_Senha_Confir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Senha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Senha_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Senha_Confir)).BeginInit();
            this.SuspendLayout();
            // 
            // MtB_Codigo_Verificacao
            // 
            this.MtB_Codigo_Verificacao.BackColor = System.Drawing.Color.White;
            this.MtB_Codigo_Verificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.MtB_Codigo_Verificacao.Location = new System.Drawing.Point(233, 68);
            this.MtB_Codigo_Verificacao.Margin = new System.Windows.Forms.Padding(4);
            this.MtB_Codigo_Verificacao.Name = "MtB_Codigo_Verificacao";
            this.MtB_Codigo_Verificacao.Size = new System.Drawing.Size(129, 31);
            this.MtB_Codigo_Verificacao.TabIndex = 62;
            this.MtB_Codigo_Verificacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MBNT_Verificar_Codigo_KeyPress);
            // 
            // MtB_Busca_Matricula_Senha
            // 
            this.MtB_Busca_Matricula_Senha.BackColor = System.Drawing.Color.White;
            this.MtB_Busca_Matricula_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.MtB_Busca_Matricula_Senha.Location = new System.Drawing.Point(233, 3);
            this.MtB_Busca_Matricula_Senha.Margin = new System.Windows.Forms.Padding(4);
            this.MtB_Busca_Matricula_Senha.Mask = "000000";
            this.MtB_Busca_Matricula_Senha.Name = "MtB_Busca_Matricula_Senha";
            this.MtB_Busca_Matricula_Senha.Size = new System.Drawing.Size(128, 31);
            this.MtB_Busca_Matricula_Senha.TabIndex = 61;
            // 
            // tB_Confir_New_Senha
            // 
            this.tB_Confir_New_Senha.BackColor = System.Drawing.Color.White;
            this.tB_Confir_New_Senha.Enabled = false;
            this.tB_Confir_New_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_Confir_New_Senha.Location = new System.Drawing.Point(207, 283);
            this.tB_Confir_New_Senha.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Confir_New_Senha.Name = "tB_Confir_New_Senha";
            this.tB_Confir_New_Senha.PasswordChar = '*';
            this.tB_Confir_New_Senha.Size = new System.Drawing.Size(294, 31);
            this.tB_Confir_New_Senha.TabIndex = 60;
            // 
            // tB_New_Senha
            // 
            this.tB_New_Senha.BackColor = System.Drawing.Color.White;
            this.tB_New_Senha.Enabled = false;
            this.tB_New_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_New_Senha.Location = new System.Drawing.Point(207, 231);
            this.tB_New_Senha.Margin = new System.Windows.Forms.Padding(4);
            this.tB_New_Senha.Name = "tB_New_Senha";
            this.tB_New_Senha.PasswordChar = '*';
            this.tB_New_Senha.Size = new System.Drawing.Size(294, 31);
            this.tB_New_Senha.TabIndex = 59;
            // 
            // tB_Senha_Temp
            // 
            this.tB_Senha_Temp.BackColor = System.Drawing.Color.White;
            this.tB_Senha_Temp.Enabled = false;
            this.tB_Senha_Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_Senha_Temp.Location = new System.Drawing.Point(207, 178);
            this.tB_Senha_Temp.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Senha_Temp.Name = "tB_Senha_Temp";
            this.tB_Senha_Temp.PasswordChar = '*';
            this.tB_Senha_Temp.Size = new System.Drawing.Size(294, 31);
            this.tB_Senha_Temp.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(120, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 57;
            this.label4.Text = "Matrícula:";
            // 
            // label_Senha_Confirm
            // 
            this.label_Senha_Confirm.AutoSize = true;
            this.label_Senha_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label_Senha_Confirm.ForeColor = System.Drawing.Color.Black;
            this.label_Senha_Confirm.Location = new System.Drawing.Point(5, 289);
            this.label_Senha_Confirm.Name = "label_Senha_Confirm";
            this.label_Senha_Confirm.Size = new System.Drawing.Size(197, 25);
            this.label_Senha_Confirm.TabIndex = 56;
            this.label_Senha_Confirm.Text = "Conforme a Senha:";
            // 
            // label_Senha
            // 
            this.label_Senha.AutoSize = true;
            this.label_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label_Senha.ForeColor = System.Drawing.Color.Black;
            this.label_Senha.Location = new System.Drawing.Point(120, 237);
            this.label_Senha.Name = "label_Senha";
            this.label_Senha.Size = new System.Drawing.Size(80, 25);
            this.label_Senha.TabIndex = 55;
            this.label_Senha.Text = "Senha:";
            // 
            // label_Senha_Temp
            // 
            this.label_Senha_Temp.AutoSize = true;
            this.label_Senha_Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label_Senha_Temp.ForeColor = System.Drawing.Color.Black;
            this.label_Senha_Temp.Location = new System.Drawing.Point(5, 184);
            this.label_Senha_Temp.Name = "label_Senha_Temp";
            this.label_Senha_Temp.Size = new System.Drawing.Size(195, 25);
            this.label_Senha_Temp.TabIndex = 54;
            this.label_Senha_Temp.Text = "Senha Temporária:";
            // 
            // Esqueceu_Senha
            // 
            this.Esqueceu_Senha.AutoSize = true;
            this.Esqueceu_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Esqueceu_Senha.ForeColor = System.Drawing.Color.Black;
            this.Esqueceu_Senha.Location = new System.Drawing.Point(5, 74);
            this.Esqueceu_Senha.Name = "Esqueceu_Senha";
            this.Esqueceu_Senha.Size = new System.Drawing.Size(232, 25);
            this.Esqueceu_Senha.TabIndex = 53;
            this.Esqueceu_Senha.Text = "Código de verificação: ";
            // 
            // Ocultar_Senha
            // 
            this.Ocultar_Senha.Image = global::Forms_Metodos.Properties.Resources.icons8_fechadura_aberta_48;
            this.Ocultar_Senha.Location = new System.Drawing.Point(508, 169);
            this.Ocultar_Senha.Name = "Ocultar_Senha";
            this.Ocultar_Senha.Size = new System.Drawing.Size(49, 47);
            this.Ocultar_Senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Ocultar_Senha.TabIndex = 64;
            this.Ocultar_Senha.TabStop = false;
            this.Ocultar_Senha.Click += new System.EventHandler(this.Ocultar_Senha_Click);
            // 
            // Ocultar_Senha_
            // 
            this.Ocultar_Senha_.Image = global::Forms_Metodos.Properties.Resources.icons8_fechadura_aberta_48;
            this.Ocultar_Senha_.Location = new System.Drawing.Point(508, 225);
            this.Ocultar_Senha_.Name = "Ocultar_Senha_";
            this.Ocultar_Senha_.Size = new System.Drawing.Size(49, 45);
            this.Ocultar_Senha_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Ocultar_Senha_.TabIndex = 66;
            this.Ocultar_Senha_.TabStop = false;
            this.Ocultar_Senha_.Click += new System.EventHandler(this.Ocultar_Senha__Click);
            // 
            // Ocultar_Senha_Confir
            // 
            this.Ocultar_Senha_Confir.Image = global::Forms_Metodos.Properties.Resources.icons8_fechadura_aberta_48;
            this.Ocultar_Senha_Confir.Location = new System.Drawing.Point(508, 280);
            this.Ocultar_Senha_Confir.Name = "Ocultar_Senha_Confir";
            this.Ocultar_Senha_Confir.Size = new System.Drawing.Size(49, 48);
            this.Ocultar_Senha_Confir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Ocultar_Senha_Confir.TabIndex = 68;
            this.Ocultar_Senha_Confir.TabStop = false;
            this.Ocultar_Senha_Confir.Click += new System.EventHandler(this.Ocultar_Senha_Confir_Click);
            // 
            // Mostrar_Senha
            // 
            this.Mostrar_Senha.Image = global::Forms_Metodos.Properties.Resources.icons8_senha_48;
            this.Mostrar_Senha.Location = new System.Drawing.Point(508, 169);
            this.Mostrar_Senha.Name = "Mostrar_Senha";
            this.Mostrar_Senha.Size = new System.Drawing.Size(49, 47);
            this.Mostrar_Senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Mostrar_Senha.TabIndex = 63;
            this.Mostrar_Senha.TabStop = false;
            this.Mostrar_Senha.Click += new System.EventHandler(this.Mostrar_Senha_Click);
            // 
            // Mostrar_Senha_
            // 
            this.Mostrar_Senha_.Image = global::Forms_Metodos.Properties.Resources.icons8_senha_48;
            this.Mostrar_Senha_.Location = new System.Drawing.Point(508, 225);
            this.Mostrar_Senha_.Name = "Mostrar_Senha_";
            this.Mostrar_Senha_.Size = new System.Drawing.Size(49, 48);
            this.Mostrar_Senha_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Mostrar_Senha_.TabIndex = 65;
            this.Mostrar_Senha_.TabStop = false;
            this.Mostrar_Senha_.Click += new System.EventHandler(this.Mostrar_Senha__Click);
            // 
            // Mostrar_Senha_Confir
            // 
            this.Mostrar_Senha_Confir.Image = global::Forms_Metodos.Properties.Resources.icons8_senha_48;
            this.Mostrar_Senha_Confir.Location = new System.Drawing.Point(508, 279);
            this.Mostrar_Senha_Confir.Name = "Mostrar_Senha_Confir";
            this.Mostrar_Senha_Confir.Size = new System.Drawing.Size(49, 48);
            this.Mostrar_Senha_Confir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Mostrar_Senha_Confir.TabIndex = 67;
            this.Mostrar_Senha_Confir.TabStop = false;
            this.Mostrar_Senha_Confir.Click += new System.EventHandler(this.Mostrar_Senha_Confir_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(368, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 33);
            this.metroButton1.TabIndex = 69;
            this.metroButton1.Text = "button1";
            this.metroButton1.UseVisualStyleBackColor = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // MBNT_Verificar_Codigo
            // 
            this.MBNT_Verificar_Codigo.Location = new System.Drawing.Point(369, 66);
            this.MBNT_Verificar_Codigo.Name = "MBNT_Verificar_Codigo";
            this.MBNT_Verificar_Codigo.Size = new System.Drawing.Size(96, 33);
            this.MBNT_Verificar_Codigo.TabIndex = 70;
            this.MBNT_Verificar_Codigo.Text = "button2";
            this.MBNT_Verificar_Codigo.UseVisualStyleBackColor = true;
            this.MBNT_Verificar_Codigo.Click += new System.EventHandler(this.MBNT_Verificar_Codigo_Click);
            this.MBNT_Verificar_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MBNT_Verificar_Codigo_KeyPress);
            // 
            // BnT_Verificar_Senha_Temp
            // 
            this.BnT_Verificar_Senha_Temp.Location = new System.Drawing.Point(577, 344);
            this.BnT_Verificar_Senha_Temp.Name = "BnT_Verificar_Senha_Temp";
            this.BnT_Verificar_Senha_Temp.Size = new System.Drawing.Size(96, 33);
            this.BnT_Verificar_Senha_Temp.TabIndex = 71;
            this.BnT_Verificar_Senha_Temp.Text = "button3";
            this.BnT_Verificar_Senha_Temp.UseVisualStyleBackColor = true;
            this.BnT_Verificar_Senha_Temp.Click += new System.EventHandler(this.BnT_Verificar_Senha_Temp_Click);
            // 
            // EsquecerSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 389);
            this.Controls.Add(this.BnT_Verificar_Senha_Temp);
            this.Controls.Add(this.MBNT_Verificar_Codigo);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Ocultar_Senha);
            this.Controls.Add(this.Ocultar_Senha_);
            this.Controls.Add(this.Ocultar_Senha_Confir);
            this.Controls.Add(this.Mostrar_Senha);
            this.Controls.Add(this.Mostrar_Senha_);
            this.Controls.Add(this.Mostrar_Senha_Confir);
            this.Controls.Add(this.MtB_Codigo_Verificacao);
            this.Controls.Add(this.MtB_Busca_Matricula_Senha);
            this.Controls.Add(this.tB_Confir_New_Senha);
            this.Controls.Add(this.tB_New_Senha);
            this.Controls.Add(this.tB_Senha_Temp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Senha_Confirm);
            this.Controls.Add(this.label_Senha);
            this.Controls.Add(this.label_Senha_Temp);
            this.Controls.Add(this.Esqueceu_Senha);
            this.Name = "EsquecerSenha";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar_Senha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar_Senha_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar_Senha_Confir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Senha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Senha_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Senha_Confir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox MtB_Codigo_Verificacao;
        public System.Windows.Forms.MaskedTextBox MtB_Busca_Matricula_Senha;
        public System.Windows.Forms.TextBox tB_Confir_New_Senha;
        public System.Windows.Forms.TextBox tB_New_Senha;
        public System.Windows.Forms.TextBox tB_Senha_Temp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Senha_Confirm;
        private System.Windows.Forms.Label label_Senha;
        private System.Windows.Forms.Label label_Senha_Temp;
        private System.Windows.Forms.Label Esqueceu_Senha;
        private System.Windows.Forms.PictureBox Ocultar_Senha;
        private System.Windows.Forms.PictureBox Ocultar_Senha_;
        private System.Windows.Forms.PictureBox Ocultar_Senha_Confir;
        private System.Windows.Forms.PictureBox Mostrar_Senha;
        private System.Windows.Forms.PictureBox Mostrar_Senha_;
        private System.Windows.Forms.PictureBox Mostrar_Senha_Confir;
        private System.Windows.Forms.Button metroButton1;
        private System.Windows.Forms.Button MBNT_Verificar_Codigo;
        private System.Windows.Forms.Button BnT_Verificar_Senha_Temp;
    }
}

