namespace TP.Aula03.Exercicio
{
    partial class Exercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercicio2));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpxOrdenada = new System.Windows.Forms.GroupBox();
            this.lblPontuacoes = new System.Windows.Forms.Label();
            this.lblPontuacoesResult = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblNumerosInsert = new System.Windows.Forms.Label();
            this.txbNumerosInsert = new System.Windows.Forms.TextBox();
            this.gpbRanking = new System.Windows.Forms.GroupBox();
            this.lblRanking = new System.Windows.Forms.Label();
            this.lblRankingResult = new System.Windows.Forms.Label();
            this.gpxOrdenada.SuspendLayout();
            this.gpbRanking.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.IndianRed;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(700, 357);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(88, 81);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar para menu";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gpxOrdenada
            // 
            this.gpxOrdenada.BackColor = System.Drawing.Color.LightGray;
            this.gpxOrdenada.Controls.Add(this.lblPontuacoes);
            this.gpxOrdenada.Controls.Add(this.lblPontuacoesResult);
            this.gpxOrdenada.Location = new System.Drawing.Point(127, 255);
            this.gpxOrdenada.Name = "gpxOrdenada";
            this.gpxOrdenada.Size = new System.Drawing.Size(469, 47);
            this.gpxOrdenada.TabIndex = 23;
            this.gpxOrdenada.TabStop = false;
            // 
            // lblPontuacoes
            // 
            this.lblPontuacoes.AutoSize = true;
            this.lblPontuacoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPontuacoes.Location = new System.Drawing.Point(6, 19);
            this.lblPontuacoes.Name = "lblPontuacoes";
            this.lblPontuacoes.Size = new System.Drawing.Size(101, 19);
            this.lblPontuacoes.TabIndex = 9;
            this.lblPontuacoes.Text = "Pontuações";
            // 
            // lblPontuacoesResult
            // 
            this.lblPontuacoesResult.AutoSize = true;
            this.lblPontuacoesResult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPontuacoesResult.Location = new System.Drawing.Point(180, 19);
            this.lblPontuacoesResult.Name = "lblPontuacoesResult";
            this.lblPontuacoesResult.Size = new System.Drawing.Size(0, 19);
            this.lblPontuacoesResult.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(613, 214);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "limpar";
            this.btnLimpar.UseMnemonic = false;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 108);
            this.label1.TabIndex = 21;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(309, 204);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 20;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(613, 175);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblNumerosInsert
            // 
            this.lblNumerosInsert.AutoSize = true;
            this.lblNumerosInsert.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumerosInsert.Location = new System.Drawing.Point(103, 167);
            this.lblNumerosInsert.Name = "lblNumerosInsert";
            this.lblNumerosInsert.Size = new System.Drawing.Size(153, 32);
            this.lblNumerosInsert.TabIndex = 18;
            this.lblNumerosInsert.Text = "Insira as pontuações\r\n(separadas por vírgula)";
            // 
            // txbNumerosInsert
            // 
            this.txbNumerosInsert.Location = new System.Drawing.Point(307, 176);
            this.txbNumerosInsert.Name = "txbNumerosInsert";
            this.txbNumerosInsert.Size = new System.Drawing.Size(290, 23);
            this.txbNumerosInsert.TabIndex = 1;
            this.txbNumerosInsert.TextChanged += new System.EventHandler(this.txbNumerosInsert_TextChanged);
            // 
            // gpbRanking
            // 
            this.gpbRanking.BackColor = System.Drawing.Color.LightGray;
            this.gpbRanking.Controls.Add(this.lblRanking);
            this.gpbRanking.Controls.Add(this.lblRankingResult);
            this.gpbRanking.Location = new System.Drawing.Point(127, 308);
            this.gpbRanking.Name = "gpbRanking";
            this.gpbRanking.Size = new System.Drawing.Size(469, 47);
            this.gpbRanking.TabIndex = 24;
            this.gpbRanking.TabStop = false;
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRanking.Location = new System.Drawing.Point(6, 19);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(73, 19);
            this.lblRanking.TabIndex = 9;
            this.lblRanking.Text = "Ranking";
            // 
            // lblRankingResult
            // 
            this.lblRankingResult.AutoSize = true;
            this.lblRankingResult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRankingResult.Location = new System.Drawing.Point(180, 19);
            this.lblRankingResult.Name = "lblRankingResult";
            this.lblRankingResult.Size = new System.Drawing.Size(0, 19);
            this.lblRankingResult.TabIndex = 3;
            // 
            // Exercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbRanking);
            this.Controls.Add(this.gpxOrdenada);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblNumerosInsert);
            this.Controls.Add(this.txbNumerosInsert);
            this.Controls.Add(this.btnVoltar);
            this.Name = "Exercicio2";
            this.Text = "Exercicio2";
            this.gpxOrdenada.ResumeLayout(false);
            this.gpxOrdenada.PerformLayout();
            this.gpbRanking.ResumeLayout(false);
            this.gpbRanking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVoltar;
        private GroupBox gpxOrdenada;
        private Label lblPontuacoes;
        private Label lblPontuacoesResult;
        private Button btnLimpar;
        private Label label1;
        private Label lblError;
        private Button btnInsert;
        private Label lblNumerosInsert;
        private TextBox txbNumerosInsert;
        private GroupBox gpbRanking;
        private Label lblRanking;
        private Label lblRankingResult;
    }
}