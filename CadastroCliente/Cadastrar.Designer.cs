namespace CadastroCliente
{
    partial class Cadastrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.codigoTexto = new System.Windows.Forms.Label();
            this.nomeTexto = new System.Windows.Forms.Label();
            this.telefoneTexto = new System.Windows.Forms.Label();
            this.enderecoTexto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cadastrarCliente = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.cpf = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Cliente";
            // 
            // codigoTexto
            // 
            this.codigoTexto.AutoSize = true;
            this.codigoTexto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoTexto.Location = new System.Drawing.Point(57, 94);
            this.codigoTexto.Name = "codigoTexto";
            this.codigoTexto.Size = new System.Drawing.Size(78, 23);
            this.codigoTexto.TabIndex = 1;
            this.codigoTexto.Text = "Código:";
            // 
            // nomeTexto
            // 
            this.nomeTexto.AutoSize = true;
            this.nomeTexto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTexto.Location = new System.Drawing.Point(68, 166);
            this.nomeTexto.Name = "nomeTexto";
            this.nomeTexto.Size = new System.Drawing.Size(67, 23);
            this.nomeTexto.TabIndex = 2;
            this.nomeTexto.Text = "Nome:";
            // 
            // telefoneTexto
            // 
            this.telefoneTexto.AutoSize = true;
            this.telefoneTexto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneTexto.Location = new System.Drawing.Point(45, 202);
            this.telefoneTexto.Name = "telefoneTexto";
            this.telefoneTexto.Size = new System.Drawing.Size(90, 23);
            this.telefoneTexto.TabIndex = 3;
            this.telefoneTexto.Text = "Telefone:";
            // 
            // enderecoTexto
            // 
            this.enderecoTexto.AutoSize = true;
            this.enderecoTexto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTexto.Location = new System.Drawing.Point(35, 238);
            this.enderecoTexto.Name = "enderecoTexto";
            this.enderecoTexto.Size = new System.Drawing.Size(100, 23);
            this.enderecoTexto.TabIndex = 4;
            this.enderecoTexto.Text = "Endereço:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(141, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 30);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(141, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(404, 30);
            this.textBox2.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(141, 231);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(404, 30);
            this.textBox4.TabIndex = 8;
            // 
            // cadastrarCliente
            // 
            this.cadastrarCliente.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarCliente.Location = new System.Drawing.Point(141, 290);
            this.cadastrarCliente.Name = "cadastrarCliente";
            this.cadastrarCliente.Size = new System.Drawing.Size(143, 40);
            this.cadastrarCliente.TabIndex = 9;
            this.cadastrarCliente.Text = "Cadastrar";
            this.cadastrarCliente.UseVisualStyleBackColor = true;
            this.cadastrarCliente.Click += new System.EventHandler(this.cadastrarCliente_Click);
            // 
            // Voltar
            // 
            this.Voltar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.Location = new System.Drawing.Point(360, 290);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(185, 39);
            this.Voltar.TabIndex = 10;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(80, 130);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(55, 23);
            this.cpf.TabIndex = 11;
            this.cpf.Text = "CPF:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(141, 123);
            this.maskedTextBox1.Mask = "999.999.999-99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(404, 30);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(141, 195);
            this.maskedTextBox2.Mask = "(999) 99999-9999";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(404, 30);
            this.maskedTextBox2.TabIndex = 13;
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 380);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.cadastrarCliente);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.enderecoTexto);
            this.Controls.Add(this.telefoneTexto);
            this.Controls.Add(this.nomeTexto);
            this.Controls.Add(this.codigoTexto);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label codigoTexto;
        private System.Windows.Forms.Label nomeTexto;
        private System.Windows.Forms.Label telefoneTexto;
        private System.Windows.Forms.Label enderecoTexto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button cadastrarCliente;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}