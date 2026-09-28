namespace CadastroCliente
{
    partial class Excluir
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.codigoTexto = new System.Windows.Forms.Label();
            this.excluirCliente = new System.Windows.Forms.Label();
            this.Voltar = new System.Windows.Forms.Button();
            this.exc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(122, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 30);
            this.textBox1.TabIndex = 24;
            // 
            // codigoTexto
            // 
            this.codigoTexto.AutoSize = true;
            this.codigoTexto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoTexto.Location = new System.Drawing.Point(38, 87);
            this.codigoTexto.Name = "codigoTexto";
            this.codigoTexto.Size = new System.Drawing.Size(78, 23);
            this.codigoTexto.TabIndex = 23;
            this.codigoTexto.Text = "Código:";
            // 
            // excluirCliente
            // 
            this.excluirCliente.AutoSize = true;
            this.excluirCliente.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirCliente.Location = new System.Drawing.Point(114, 9);
            this.excluirCliente.Name = "excluirCliente";
            this.excluirCliente.Size = new System.Drawing.Size(267, 45);
            this.excluirCliente.TabIndex = 22;
            this.excluirCliente.Text = "Excluir Cliente";
            // 
            // Voltar
            // 
            this.Voltar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.Location = new System.Drawing.Point(249, 154);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(185, 39);
            this.Voltar.TabIndex = 29;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // exc
            // 
            this.exc.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exc.Location = new System.Drawing.Point(100, 154);
            this.exc.Name = "exc";
            this.exc.Size = new System.Drawing.Size(143, 40);
            this.exc.TabIndex = 28;
            this.exc.Text = "Excluir";
            this.exc.UseVisualStyleBackColor = true;
            this.exc.Click += new System.EventHandler(this.exc_Click);
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 246);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.exc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.codigoTexto);
            this.Controls.Add(this.excluirCliente);
            this.Name = "Excluir";
            this.Text = "Excluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label codigoTexto;
        private System.Windows.Forms.Label excluirCliente;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button exc;
    }
}