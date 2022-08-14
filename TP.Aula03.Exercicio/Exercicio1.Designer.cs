namespace TP.Aula03.Exercicio
{
    partial class Exercicio1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercicio1));
            this.txbNumerosInsert = new System.Windows.Forms.TextBox();
            this.lblNumerosInsert = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblArrayOrdenada = new System.Windows.Forms.Label();
            this.lblArrayPares = new System.Windows.Forms.Label();
            this.lblArrayImpares = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblOrdenadaTexto = new System.Windows.Forms.Label();
            this.lblParesTexto = new System.Windows.Forms.Label();
            this.lblImparesTexto = new System.Windows.Forms.Label();
            this.gpxOrdenada = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpxOrdenada.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbNumerosInsert
            // 
            this.txbNumerosInsert.Location = new System.Drawing.Point(251, 153);
            this.txbNumerosInsert.Name = "txbNumerosInsert";
            this.txbNumerosInsert.Size = new System.Drawing.Size(290, 23);
            this.txbNumerosInsert.TabIndex = 0;
            // 
            // lblNumerosInsert
            // 
            this.lblNumerosInsert.AutoSize = true;
            this.lblNumerosInsert.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumerosInsert.Location = new System.Drawing.Point(56, 144);
            this.lblNumerosInsert.Name = "lblNumerosInsert";
            this.lblNumerosInsert.Size = new System.Drawing.Size(189, 32);
            this.lblNumerosInsert.TabIndex = 1;
            this.lblNumerosInsert.Text = "Numeros a serem ordenados\r\n(separados por vírgula)";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(557, 152);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblArrayOrdenada
            // 
            this.lblArrayOrdenada.AutoSize = true;
            this.lblArrayOrdenada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArrayOrdenada.Location = new System.Drawing.Point(180, 19);
            this.lblArrayOrdenada.Name = "lblArrayOrdenada";
            this.lblArrayOrdenada.Size = new System.Drawing.Size(0, 19);
            this.lblArrayOrdenada.TabIndex = 3;
            // 
            // lblArrayPares
            // 
            this.lblArrayPares.AutoSize = true;
            this.lblArrayPares.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArrayPares.Location = new System.Drawing.Point(180, 19);
            this.lblArrayPares.Name = "lblArrayPares";
            this.lblArrayPares.Size = new System.Drawing.Size(0, 19);
            this.lblArrayPares.TabIndex = 4;
            // 
            // lblArrayImpares
            // 
            this.lblArrayImpares.AutoSize = true;
            this.lblArrayImpares.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArrayImpares.Location = new System.Drawing.Point(182, 19);
            this.lblArrayImpares.Name = "lblArrayImpares";
            this.lblArrayImpares.Size = new System.Drawing.Size(0, 19);
            this.lblArrayImpares.TabIndex = 5;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(253, 181);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 72);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(557, 108);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "limpar";
            this.btnLimpar.UseMnemonic = false;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblOrdenadaTexto
            // 
            this.lblOrdenadaTexto.AutoSize = true;
            this.lblOrdenadaTexto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrdenadaTexto.Location = new System.Drawing.Point(6, 19);
            this.lblOrdenadaTexto.Name = "lblOrdenadaTexto";
            this.lblOrdenadaTexto.Size = new System.Drawing.Size(139, 19);
            this.lblOrdenadaTexto.TabIndex = 9;
            this.lblOrdenadaTexto.Text = "Array Ordenada: ";
            // 
            // lblParesTexto
            // 
            this.lblParesTexto.AutoSize = true;
            this.lblParesTexto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblParesTexto.Location = new System.Drawing.Point(6, 19);
            this.lblParesTexto.Name = "lblParesTexto";
            this.lblParesTexto.Size = new System.Drawing.Size(130, 19);
            this.lblParesTexto.TabIndex = 10;
            this.lblParesTexto.Text = "Array de pares: ";
            // 
            // lblImparesTexto
            // 
            this.lblImparesTexto.AutoSize = true;
            this.lblImparesTexto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImparesTexto.Location = new System.Drawing.Point(6, 19);
            this.lblImparesTexto.Name = "lblImparesTexto";
            this.lblImparesTexto.Size = new System.Drawing.Size(148, 19);
            this.lblImparesTexto.TabIndex = 11;
            this.lblImparesTexto.Text = "Array de impares: ";
            // 
            // gpxOrdenada
            // 
            this.gpxOrdenada.BackColor = System.Drawing.Color.LightGray;
            this.gpxOrdenada.Controls.Add(this.lblOrdenadaTexto);
            this.gpxOrdenada.Controls.Add(this.lblArrayOrdenada);
            this.gpxOrdenada.Location = new System.Drawing.Point(71, 232);
            this.gpxOrdenada.Name = "gpxOrdenada";
            this.gpxOrdenada.Size = new System.Drawing.Size(469, 47);
            this.gpxOrdenada.TabIndex = 12;
            this.gpxOrdenada.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.lblParesTexto);
            this.groupBox1.Controls.Add(this.lblArrayPares);
            this.groupBox1.Location = new System.Drawing.Point(71, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 47);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.lblImparesTexto);
            this.groupBox2.Controls.Add(this.lblArrayImpares);
            this.groupBox2.Location = new System.Drawing.Point(71, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 47);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.IndianRed;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(589, 357);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(88, 81);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar para menu";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Exercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpxOrdenada);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblNumerosInsert);
            this.Controls.Add(this.txbNumerosInsert);
            this.Name = "Exercicio1";
            this.Text = "Exercicio1";
            this.gpxOrdenada.ResumeLayout(false);
            this.gpxOrdenada.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbNumerosInsert;
        private Label lblNumerosInsert;
        private Button btnInsert;
        private Label lblArrayOrdenada;
        private Label lblArrayPares;
        private Label lblArrayImpares;
        private Label lblError;
        private Label label1;
        private Button btnLimpar;
        private Label lblOrdenadaTexto;
        private Label lblParesTexto;
        private Label lblImparesTexto;
        private GroupBox gpxOrdenada;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnVoltar;
    }
}