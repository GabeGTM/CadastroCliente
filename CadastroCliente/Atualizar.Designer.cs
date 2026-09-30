namespace CadastroCliente
{
    partial class Atualizar
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
            this.atualizarCliente = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cpf = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.enderecoTexto = new System.Windows.Forms.Label();
            this.telefoneTexto = new System.Windows.Forms.Label();
            this.Voltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // atualizarCliente
            // 
            this.atualizarCliente.AutoSize = true;
            this.atualizarCliente.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizarCliente.Location = new System.Drawing.Point(153, 9);
            this.atualizarCliente.Name = "atualizarCliente";
            this.atualizarCliente.Size = new System.Drawing.Size(304, 45);
            this.atualizarCliente.TabIndex = 0;
            this.atualizarCliente.Text = "Atualizar Cliente";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(130, 84);
            this.maskedTextBox1.Mask = "999.999.999-99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(404, 30);
            this.maskedTextBox1.TabIndex = 24;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(69, 91);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(55, 23);
            this.cpf.TabIndex = 23;
            this.cpf.Text = "CPF:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(130, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(404, 30);
            this.textBox4.TabIndex = 20;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // enderecoTexto
            // 
            this.enderecoTexto.AutoSize = true;
            this.enderecoTexto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTexto.Location = new System.Drawing.Point(11, 163);
            this.enderecoTexto.Name = "enderecoTexto";
            this.enderecoTexto.Size = new System.Drawing.Size(113, 23);
            this.enderecoTexto.TabIndex = 17;
            this.enderecoTexto.Text = "Novo Dado:";
            // 
            // telefoneTexto
            // 
            this.telefoneTexto.AutoSize = true;
            this.telefoneTexto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneTexto.Location = new System.Drawing.Point(45, 127);
            this.telefoneTexto.Name = "telefoneTexto";
            this.telefoneTexto.Size = new System.Drawing.Size(79, 23);
            this.telefoneTexto.TabIndex = 16;
            this.telefoneTexto.Text = "Campo:";
            // 
            // Voltar
            // 
            this.Voltar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.Location = new System.Drawing.Point(349, 217);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(185, 39);
            this.Voltar.TabIndex = 27;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(130, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(130, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 30);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 327);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.enderecoTexto);
            this.Controls.Add(this.telefoneTexto);
            this.Controls.Add(this.atualizarCliente);
            this.Name = "Atualizar";
            this.Text = "Atualizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label atualizarCliente;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label enderecoTexto;
        private System.Windows.Forms.Label telefoneTexto;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}