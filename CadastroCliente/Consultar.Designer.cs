namespace CadastroCliente
{
    partial class Consultar
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
            this.consultarCliente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // consultarCliente
            // 
            this.consultarCliente.AutoSize = true;
            this.consultarCliente.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarCliente.Location = new System.Drawing.Point(244, 24);
            this.consultarCliente.Name = "consultarCliente";
            this.consultarCliente.Size = new System.Drawing.Size(318, 45);
            this.consultarCliente.TabIndex = 0;
            this.consultarCliente.Text = "Consultar Cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(726, 282);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // voltar
            // 
            this.voltar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.Location = new System.Drawing.Point(313, 392);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(201, 36);
            this.voltar.TabIndex = 2;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.consultarCliente);
            this.Name = "Consultar";
            this.Text = "Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label consultarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button voltar;
    }
}