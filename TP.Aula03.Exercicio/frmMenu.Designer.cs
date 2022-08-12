namespace TP.Aula03.Exercicio
{
    partial class frmMenu
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
            this.btnExercicio1 = new System.Windows.Forms.Button();
            this.btnExercicio2 = new System.Windows.Forms.Button();
            this.btnExercicio3 = new System.Windows.Forms.Button();
            this.btnExercicio4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExercicio1
            // 
            this.btnExercicio1.BackColor = System.Drawing.Color.Silver;
            this.btnExercicio1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExercicio1.Location = new System.Drawing.Point(81, 125);
            this.btnExercicio1.Name = "btnExercicio1";
            this.btnExercicio1.Size = new System.Drawing.Size(300, 148);
            this.btnExercicio1.TabIndex = 0;
            this.btnExercicio1.Text = "Exercício 1\r\n\r\nOrdenação de \r\nnúmeros";
            this.btnExercicio1.UseVisualStyleBackColor = false;
            this.btnExercicio1.Click += new System.EventHandler(this.btnExercicio1_Click);
            // 
            // btnExercicio2
            // 
            this.btnExercicio2.BackColor = System.Drawing.Color.Silver;
            this.btnExercicio2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExercicio2.Location = new System.Drawing.Point(381, 125);
            this.btnExercicio2.Name = "btnExercicio2";
            this.btnExercicio2.Size = new System.Drawing.Size(300, 148);
            this.btnExercicio2.TabIndex = 1;
            this.btnExercicio2.Text = "Exercício 2\r\n\r\nRanking de \r\npontuação";
            this.btnExercicio2.UseVisualStyleBackColor = false;
            this.btnExercicio2.Click += new System.EventHandler(this.btnExercicio2_Click);
            // 
            // btnExercicio3
            // 
            this.btnExercicio3.BackColor = System.Drawing.Color.Silver;
            this.btnExercicio3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExercicio3.Location = new System.Drawing.Point(81, 272);
            this.btnExercicio3.Name = "btnExercicio3";
            this.btnExercicio3.Size = new System.Drawing.Size(300, 148);
            this.btnExercicio3.TabIndex = 2;
            this.btnExercicio3.Text = "Exercício 3\r\n\r\nCrie uma \r\nmatriz";
            this.btnExercicio3.UseVisualStyleBackColor = false;
            this.btnExercicio3.Click += new System.EventHandler(this.btnExercicio3_Click);
            // 
            // btnExercicio4
            // 
            this.btnExercicio4.BackColor = System.Drawing.Color.Silver;
            this.btnExercicio4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExercicio4.Location = new System.Drawing.Point(381, 272);
            this.btnExercicio4.Name = "btnExercicio4";
            this.btnExercicio4.Size = new System.Drawing.Size(300, 148);
            this.btnExercicio4.TabIndex = 3;
            this.btnExercicio4.Text = "Exercício 4\r\n\r\nJogo da \r\nvelha";
            this.btnExercicio4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(191, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 82);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione o exercício \r\nque deseja testar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExercicio4);
            this.Controls.Add(this.btnExercicio3);
            this.Controls.Add(this.btnExercicio2);
            this.Controls.Add(this.btnExercicio1);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExercicio1;
        private Button btnExercicio2;
        private Button btnExercicio3;
        private Button btnExercicio4;
        private Label label1;
    }
}