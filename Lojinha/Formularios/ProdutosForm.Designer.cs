namespace Lojinha.Formularios
{
    partial class ProdutosForm
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
            this.NomeProdutoLabel = new System.Windows.Forms.Label();
            this.PreçoProdutoLabel = new System.Windows.Forms.Label();
            this.Estoque = new System.Windows.Forms.Label();
            this.CodigoLabel = new System.Windows.Forms.Label();
            this.NomeProdutoTextBox = new System.Windows.Forms.TextBox();
            this.PrecoProdutoTextBox = new System.Windows.Forms.TextBox();
            this.EstoqueProdutoTextBox = new System.Windows.Forms.TextBox();
            this.CodigoProdutoTextBox = new System.Windows.Forms.TextBox();
            this.InserirProdutoButton = new System.Windows.Forms.Button();
            this.ExcluirProdutoButton = new System.Windows.Forms.Button();
            this.AlterarProdutoButton = new System.Windows.Forms.Button();
            this.ListarProdutoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NomeProdutoLabel
            // 
            this.NomeProdutoLabel.AutoSize = true;
            this.NomeProdutoLabel.Location = new System.Drawing.Point(12, 87);
            this.NomeProdutoLabel.Name = "NomeProdutoLabel";
            this.NomeProdutoLabel.Size = new System.Drawing.Size(35, 13);
            this.NomeProdutoLabel.TabIndex = 0;
            this.NomeProdutoLabel.Text = "Nome";
            // 
            // PreçoProdutoLabel
            // 
            this.PreçoProdutoLabel.AutoSize = true;
            this.PreçoProdutoLabel.Location = new System.Drawing.Point(12, 130);
            this.PreçoProdutoLabel.Name = "PreçoProdutoLabel";
            this.PreçoProdutoLabel.Size = new System.Drawing.Size(35, 13);
            this.PreçoProdutoLabel.TabIndex = 1;
            this.PreçoProdutoLabel.Text = "Preço";
            // 
            // Estoque
            // 
            this.Estoque.AutoSize = true;
            this.Estoque.Location = new System.Drawing.Point(12, 164);
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(46, 13);
            this.Estoque.TabIndex = 2;
            this.Estoque.Text = "Estoque";
            // 
            // CodigoLabel
            // 
            this.CodigoLabel.AutoSize = true;
            this.CodigoLabel.Location = new System.Drawing.Point(12, 28);
            this.CodigoLabel.Name = "CodigoLabel";
            this.CodigoLabel.Size = new System.Drawing.Size(40, 13);
            this.CodigoLabel.TabIndex = 3;
            this.CodigoLabel.Text = "Codigo";
            // 
            // NomeProdutoTextBox
            // 
            this.NomeProdutoTextBox.Location = new System.Drawing.Point(132, 80);
            this.NomeProdutoTextBox.Name = "NomeProdutoTextBox";
            this.NomeProdutoTextBox.Size = new System.Drawing.Size(100, 20);
            this.NomeProdutoTextBox.TabIndex = 4;
            // 
            // PrecoProdutoTextBox
            // 
            this.PrecoProdutoTextBox.Location = new System.Drawing.Point(132, 123);
            this.PrecoProdutoTextBox.Name = "PrecoProdutoTextBox";
            this.PrecoProdutoTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrecoProdutoTextBox.TabIndex = 5;
            // 
            // EstoqueProdutoTextBox
            // 
            this.EstoqueProdutoTextBox.Location = new System.Drawing.Point(132, 157);
            this.EstoqueProdutoTextBox.Name = "EstoqueProdutoTextBox";
            this.EstoqueProdutoTextBox.Size = new System.Drawing.Size(100, 20);
            this.EstoqueProdutoTextBox.TabIndex = 6;
            // 
            // CodigoProdutoTextBox
            // 
            this.CodigoProdutoTextBox.Location = new System.Drawing.Point(132, 21);
            this.CodigoProdutoTextBox.Name = "CodigoProdutoTextBox";
            this.CodigoProdutoTextBox.Size = new System.Drawing.Size(100, 20);
            this.CodigoProdutoTextBox.TabIndex = 7;
            // 
            // InserirProdutoButton
            // 
            this.InserirProdutoButton.Location = new System.Drawing.Point(108, 268);
            this.InserirProdutoButton.Name = "InserirProdutoButton";
            this.InserirProdutoButton.Size = new System.Drawing.Size(75, 23);
            this.InserirProdutoButton.TabIndex = 8;
            this.InserirProdutoButton.Text = "Inserir";
            this.InserirProdutoButton.UseVisualStyleBackColor = true;
            this.InserirProdutoButton.Click += new System.EventHandler(this.InserirProdutoButton_Click);
            // 
            // ExcluirProdutoButton
            // 
            this.ExcluirProdutoButton.Location = new System.Drawing.Point(295, 267);
            this.ExcluirProdutoButton.Name = "ExcluirProdutoButton";
            this.ExcluirProdutoButton.Size = new System.Drawing.Size(75, 23);
            this.ExcluirProdutoButton.TabIndex = 9;
            this.ExcluirProdutoButton.Text = "Excluir";
            this.ExcluirProdutoButton.UseVisualStyleBackColor = true;
            this.ExcluirProdutoButton.Click += new System.EventHandler(this.ExcluirProdutoButton_Click);
            // 
            // AlterarProdutoButton
            // 
            this.AlterarProdutoButton.Location = new System.Drawing.Point(488, 267);
            this.AlterarProdutoButton.Name = "AlterarProdutoButton";
            this.AlterarProdutoButton.Size = new System.Drawing.Size(75, 23);
            this.AlterarProdutoButton.TabIndex = 10;
            this.AlterarProdutoButton.Text = "Alterar";
            this.AlterarProdutoButton.UseVisualStyleBackColor = true;
            this.AlterarProdutoButton.Click += new System.EventHandler(this.AlterarProdutoButton_Click);
            // 
            // ListarProdutoButton
            // 
            this.ListarProdutoButton.Location = new System.Drawing.Point(670, 268);
            this.ListarProdutoButton.Name = "ListarProdutoButton";
            this.ListarProdutoButton.Size = new System.Drawing.Size(75, 23);
            this.ListarProdutoButton.TabIndex = 11;
            this.ListarProdutoButton.Text = "Listar";
            this.ListarProdutoButton.UseVisualStyleBackColor = true;
            // 
            // ProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListarProdutoButton);
            this.Controls.Add(this.AlterarProdutoButton);
            this.Controls.Add(this.ExcluirProdutoButton);
            this.Controls.Add(this.InserirProdutoButton);
            this.Controls.Add(this.CodigoProdutoTextBox);
            this.Controls.Add(this.EstoqueProdutoTextBox);
            this.Controls.Add(this.PrecoProdutoTextBox);
            this.Controls.Add(this.NomeProdutoTextBox);
            this.Controls.Add(this.CodigoLabel);
            this.Controls.Add(this.Estoque);
            this.Controls.Add(this.PreçoProdutoLabel);
            this.Controls.Add(this.NomeProdutoLabel);
            this.Name = "ProdutosForm";
            this.Text = "ProdutosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomeProdutoLabel;
        private System.Windows.Forms.Label PreçoProdutoLabel;
        private System.Windows.Forms.Label Estoque;
        private System.Windows.Forms.Label CodigoLabel;
        private System.Windows.Forms.TextBox NomeProdutoTextBox;
        private System.Windows.Forms.TextBox PrecoProdutoTextBox;
        private System.Windows.Forms.TextBox EstoqueProdutoTextBox;
        private System.Windows.Forms.TextBox CodigoProdutoTextBox;
        private System.Windows.Forms.Button InserirProdutoButton;
        private System.Windows.Forms.Button ExcluirProdutoButton;
        private System.Windows.Forms.Button AlterarProdutoButton;
        private System.Windows.Forms.Button ListarProdutoButton;
    }
}