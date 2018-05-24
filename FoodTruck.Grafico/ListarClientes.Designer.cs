namespace FoodTruck.Grafico
{
    partial class ListarClientes
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
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.tbCadastrarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCliente
            // 
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Location = new System.Drawing.Point(12, 12);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.Size = new System.Drawing.Size(582, 232);
            this.dgCliente.TabIndex = 0;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(509, 263);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 1;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // tbCadastrarCliente
            // 
            this.tbCadastrarCliente.Location = new System.Drawing.Point(428, 263);
            this.tbCadastrarCliente.Name = "tbCadastrarCliente";
            this.tbCadastrarCliente.Size = new System.Drawing.Size(75, 23);
            this.tbCadastrarCliente.TabIndex = 2;
            this.tbCadastrarCliente.Text = "Adicionar";
            this.tbCadastrarCliente.UseVisualStyleBackColor = true;
            this.tbCadastrarCliente.Click += new System.EventHandler(this.tbCadastrarCliente_Click);
            // 
            // ListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 297);
            this.Controls.Add(this.tbCadastrarCliente);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.dgCliente);
            this.Name = "ListarClientes";
            this.Text = "ListarClientes";
            this.Load += new System.EventHandler(this.ListarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button tbCadastrarCliente;
    }
}