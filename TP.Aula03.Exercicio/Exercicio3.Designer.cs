namespace TP.Aula03.Exercicio
{
    partial class Exercicio3
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblLinhas = new System.Windows.Forms.Label();
            this.mtbLinhas = new System.Windows.Forms.MaskedTextBox();
            this.mtbColunas = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblColunas = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpxMatriz = new System.Windows.Forms.GroupBox();
            this.pnlMatriz = new System.Windows.Forms.Panel();
            this.lblMatriz = new System.Windows.Forms.Label();
            this.gpxMatriz.SuspendLayout();
            this.pnlMatriz.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(47, 315);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "limpar";
            this.btnLimpar.UseMnemonic = false;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.BackColor = System.Drawing.Color.LightGray;
            this.lblEnunciado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnunciado.Location = new System.Drawing.Point(47, 34);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(262, 72);
            this.lblEnunciado.TabIndex = 27;
            this.lblEnunciado.Text = "Peça ao usuário uma quantidade\r\nde linhas e outra de colunas, depois \r\ndeclare ta" +
    "l matriz, inicialize todos os \r\nelementos de 1 até \'linha x coluna\'.\r\n";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(234, 183);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 26;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(212, 315);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblLinhas
            // 
            this.lblLinhas.AutoSize = true;
            this.lblLinhas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLinhas.Location = new System.Drawing.Point(47, 146);
            this.lblLinhas.Name = "lblLinhas";
            this.lblLinhas.Size = new System.Drawing.Size(179, 32);
            this.lblLinhas.TabIndex = 24;
            this.lblLinhas.Text = "Insira o número de linhas\r\n(somente números inteiros)";
            // 
            // mtbLinhas
            // 
            this.mtbLinhas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbLinhas.Location = new System.Drawing.Point(257, 147);
            this.mtbLinhas.Mask = "00";
            this.mtbLinhas.Name = "mtbLinhas";
            this.mtbLinhas.Size = new System.Drawing.Size(30, 26);
            this.mtbLinhas.TabIndex = 1;
            this.mtbLinhas.ValidatingType = typeof(int);
            // 
            // mtbColunas
            // 
            this.mtbColunas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbColunas.Location = new System.Drawing.Point(257, 239);
            this.mtbColunas.Mask = "00";
            this.mtbColunas.Name = "mtbColunas";
            this.mtbColunas.Size = new System.Drawing.Size(30, 26);
            this.mtbColunas.TabIndex = 2;
            this.mtbColunas.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(234, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 31;
            // 
            // lblColunas
            // 
            this.lblColunas.AutoSize = true;
            this.lblColunas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColunas.Location = new System.Drawing.Point(47, 238);
            this.lblColunas.Name = "lblColunas";
            this.lblColunas.Size = new System.Drawing.Size(180, 32);
            this.lblColunas.TabIndex = 30;
            this.lblColunas.Text = "Insira o número de colunas\r\n(somente números inteiros)";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.IndianRed;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(698, 304);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(88, 81);
            this.btnVoltar.TabIndex = 32;
            this.btnVoltar.Text = "Voltar para menu";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gpxMatriz
            // 
            this.gpxMatriz.BackColor = System.Drawing.Color.LightGray;
            this.gpxMatriz.Controls.Add(this.pnlMatriz);
            this.gpxMatriz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpxMatriz.Location = new System.Drawing.Point(352, 34);
            this.gpxMatriz.Name = "gpxMatriz";
            this.gpxMatriz.Size = new System.Drawing.Size(401, 260);
            this.gpxMatriz.TabIndex = 33;
            this.gpxMatriz.TabStop = false;
            this.gpxMatriz.Text = "Representação gráfica da matriz";
            this.gpxMatriz.Enter += new System.EventHandler(this.gpxMatriz_Enter);
            // 
            // pnlMatriz
            // 
            this.pnlMatriz.AutoScroll = true;
            this.pnlMatriz.BackColor = System.Drawing.Color.Transparent;
            this.pnlMatriz.Controls.Add(this.lblMatriz);
            this.pnlMatriz.Location = new System.Drawing.Point(0, 25);
            this.pnlMatriz.Name = "pnlMatriz";
            this.pnlMatriz.Size = new System.Drawing.Size(401, 235);
            this.pnlMatriz.TabIndex = 4;
            // 
            // lblMatriz
            // 
            this.lblMatriz.AutoSize = true;
            this.lblMatriz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMatriz.Location = new System.Drawing.Point(32, 23);
            this.lblMatriz.Name = "lblMatriz";
            this.lblMatriz.Size = new System.Drawing.Size(0, 19);
            this.lblMatriz.TabIndex = 3;
            // 
            // Exercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 397);
            this.Controls.Add(this.gpxMatriz);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.mtbColunas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblColunas);
            this.Controls.Add(this.mtbLinhas);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblLinhas);
            this.Name = "Exercicio3";
            this.Text = "Exercicio3";
            this.gpxMatriz.ResumeLayout(false);
            this.pnlMatriz.ResumeLayout(false);
            this.pnlMatriz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLimpar;
        private Label lblEnunciado;
        private Label lblError;
        private Button btnInsert;
        private Label lblLinhas;
        private MaskedTextBox mtbLinhas;
        private MaskedTextBox mtbColunas;
        private Label label1;
        private Label lblColunas;
        private Button btnVoltar;
        private GroupBox gpxMatriz;
        private Label lblMatriz;
        private Panel pnlMatriz;
    }
}