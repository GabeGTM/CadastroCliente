namespace CadastroCliente
{
    partial class TelaCliente
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
            this.tituloPagina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloPagina
            // 
            this.tituloPagina.AutoSize = true;
            this.tituloPagina.BackColor = System.Drawing.Color.White;
            this.tituloPagina.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloPagina.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tituloPagina.Location = new System.Drawing.Point(13, 9);
            this.tituloPagina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloPagina.Name = "tituloPagina";
            this.tituloPagina.Padding = new System.Windows.Forms.Padding(140, 0, 140, 0);
            this.tituloPagina.Size = new System.Drawing.Size(627, 45);
            this.tituloPagina.TabIndex = 0;
            this.tituloPagina.Text = "Bem-Vindo Cliente";
            this.tituloPagina.Click += new System.EventHandler(this.tituloPagina_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha uma das opções abaixo:";
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cadastrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cadastrar.Location = new System.Drawing.Point(31, 106);
            this.Cadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(268, 62);
            this.Cadastrar.TabIndex = 2;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Consultar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consultar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Consultar.Location = new System.Drawing.Point(336, 106);
            this.Consultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(268, 62);
            this.Consultar.TabIndex = 3;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = false;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Atualizar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atualizar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Atualizar.Location = new System.Drawing.Point(31, 196);
            this.Atualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(268, 62);
            this.Atualizar.TabIndex = 4;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = false;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Excluir.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Excluir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Excluir.Location = new System.Drawing.Point(336, 196);
            this.Excluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(268, 62);
            this.Excluir.TabIndex = 5;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 380);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tituloPagina);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TelaCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.TelaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloPagina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Excluir;
    }
}

