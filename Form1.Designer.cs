namespace AtividadeEAD03
{
    partial class Form1
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
            this.lblNomeCidade = new System.Windows.Forms.Label();
            this.txtbNomeCidade = new System.Windows.Forms.TextBox();
            this.btnAdcCidade = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnIdCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeCidade
            // 
            this.lblNomeCidade.AutoSize = true;
            this.lblNomeCidade.Location = new System.Drawing.Point(31, 26);
            this.lblNomeCidade.Name = "lblNomeCidade";
            this.lblNomeCidade.Size = new System.Drawing.Size(89, 13);
            this.lblNomeCidade.TabIndex = 0;
            this.lblNomeCidade.Text = "Nome da Cidade:";
            // 
            // txtbNomeCidade
            // 
            this.txtbNomeCidade.Location = new System.Drawing.Point(34, 42);
            this.txtbNomeCidade.Name = "txtbNomeCidade";
            this.txtbNomeCidade.Size = new System.Drawing.Size(230, 20);
            this.txtbNomeCidade.TabIndex = 1;
            // 
            // btnAdcCidade
            // 
            this.btnAdcCidade.Location = new System.Drawing.Point(270, 40);
            this.btnAdcCidade.Name = "btnAdcCidade";
            this.btnAdcCidade.Size = new System.Drawing.Size(108, 23);
            this.btnAdcCidade.TabIndex = 2;
            this.btnAdcCidade.Text = "Adicionar Cidade";
            this.btnAdcCidade.UseVisualStyleBackColor = true;
            this.btnAdcCidade.Click += new System.EventHandler(this.btnAdcCidade_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdCidade,
            this.ColumnNomeCidade});
            this.dataGridView1.Location = new System.Drawing.Point(87, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 289);
            this.dataGridView1.TabIndex = 3;
            // 
            // ColumnIdCidade
            // 
            this.ColumnIdCidade.HeaderText = "ID";
            this.ColumnIdCidade.Name = "ColumnIdCidade";
            // 
            // ColumnNomeCidade
            // 
            this.ColumnNomeCidade.HeaderText = "Nome da Cidade";
            this.ColumnNomeCidade.Name = "ColumnNomeCidade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 379);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdcCidade);
            this.Controls.Add(this.txtbNomeCidade);
            this.Controls.Add(this.lblNomeCidade);
            this.Name = "Form1";
            this.Text = "Estados Brasileiros";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCidade;
        private System.Windows.Forms.TextBox txtbNomeCidade;
        private System.Windows.Forms.Button btnAdcCidade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeCidade;
    }
}

