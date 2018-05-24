namespace FoodTruck.Grafico
{
    partial class ListarPedidos
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
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.tbAdicionarBebida = new System.Windows.Forms.Button();
            this.tbLanche = new System.Windows.Forms.Button();
            this.btnRemoverBebida = new System.Windows.Forms.Button();
            this.btnRemoverLanche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPedidos
            // 
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Location = new System.Drawing.Point(12, 12);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.Size = new System.Drawing.Size(545, 202);
            this.dgPedidos.TabIndex = 0;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(388, 233);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 1;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(469, 233);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 2;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // tbAdicionarBebida
            // 
            this.tbAdicionarBebida.Location = new System.Drawing.Point(17, 233);
            this.tbAdicionarBebida.Name = "tbAdicionarBebida";
            this.tbAdicionarBebida.Size = new System.Drawing.Size(75, 23);
            this.tbAdicionarBebida.TabIndex = 4;
            this.tbAdicionarBebida.Text = "+ Bebida";
            this.tbAdicionarBebida.UseVisualStyleBackColor = true;
            this.tbAdicionarBebida.Click += new System.EventHandler(this.tbAdicionarBebida_Click);
            // 
            // tbLanche
            // 
            this.tbLanche.Location = new System.Drawing.Point(201, 233);
            this.tbLanche.Name = "tbLanche";
            this.tbLanche.Size = new System.Drawing.Size(75, 23);
            this.tbLanche.TabIndex = 5;
            this.tbLanche.Text = "+ Lanche";
            this.tbLanche.UseVisualStyleBackColor = true;
            this.tbLanche.Click += new System.EventHandler(this.tbLanche_Click);
            // 
            // btnRemoverBebida
            // 
            this.btnRemoverBebida.Location = new System.Drawing.Point(98, 233);
            this.btnRemoverBebida.Name = "btnRemoverBebida";
            this.btnRemoverBebida.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverBebida.TabIndex = 6;
            this.btnRemoverBebida.Text = "- Bebida";
            this.btnRemoverBebida.UseVisualStyleBackColor = true;
            this.btnRemoverBebida.Click += new System.EventHandler(this.btnRemoverBebida_Click);
            // 
            // btnRemoverLanche
            // 
            this.btnRemoverLanche.Location = new System.Drawing.Point(282, 233);
            this.btnRemoverLanche.Name = "btnRemoverLanche";
            this.btnRemoverLanche.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverLanche.TabIndex = 7;
            this.btnRemoverLanche.Text = "- Lanche";
            this.btnRemoverLanche.UseVisualStyleBackColor = true;
            this.btnRemoverLanche.Click += new System.EventHandler(this.btnRemoverLanche_Click);
            // 
            // ListarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 272);
            this.Controls.Add(this.btnRemoverLanche);
            this.Controls.Add(this.btnRemoverBebida);
            this.Controls.Add(this.tbLanche);
            this.Controls.Add(this.tbAdicionarBebida);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.dgPedidos);
            this.Name = "ListarPedidos";
            this.Text = "ListarPedidos";
            this.Load += new System.EventHandler(this.ListarPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button tbAdicionarBebida;
        private System.Windows.Forms.Button tbLanche;
        private System.Windows.Forms.Button btnRemoverBebida;
        private System.Windows.Forms.Button btnRemoverLanche;
    }
}