namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxAutoDisponibili = new System.Windows.Forms.ListBox();
            this.txtAuto = new System.Windows.Forms.TextBox();
            this.btnNoleggia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnInviaNome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAutoDisponibili
            // 
            this.listBoxAutoDisponibili.FormattingEnabled = true;
            this.listBoxAutoDisponibili.HorizontalExtent = 500;
            this.listBoxAutoDisponibili.HorizontalScrollbar = true;
            this.listBoxAutoDisponibili.Location = new System.Drawing.Point(9, 33);
            this.listBoxAutoDisponibili.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAutoDisponibili.Name = "listBoxAutoDisponibili";
            this.listBoxAutoDisponibili.Size = new System.Drawing.Size(260, 303);
            this.listBoxAutoDisponibili.TabIndex = 0;
            // 
            // txtAuto
            // 
            this.txtAuto.Location = new System.Drawing.Point(372, 240);
            this.txtAuto.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuto.Name = "txtAuto";
            this.txtAuto.Size = new System.Drawing.Size(152, 20);
            this.txtAuto.TabIndex = 1;
            // 
            // btnNoleggia
            // 
            this.btnNoleggia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoleggia.Location = new System.Drawing.Point(372, 284);
            this.btnNoleggia.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoleggia.Name = "btnNoleggia";
            this.btnNoleggia.Size = new System.Drawing.Size(151, 51);
            this.btnNoleggia.TabIndex = 2;
            this.btnNoleggia.Text = "NOLEGGIA";
            this.btnNoleggia.UseVisualStyleBackColor = true;
            this.btnNoleggia.Click += new System.EventHandler(this.btnNoleggia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(321, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inserire l\'auto che si vuole noleggiare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inserire il nome del cliente che vuole noleggiare:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(367, 87);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(152, 20);
            this.txtNome.TabIndex = 4;
            // 
            // btnInviaNome
            // 
            this.btnInviaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInviaNome.Location = new System.Drawing.Point(367, 127);
            this.btnInviaNome.Margin = new System.Windows.Forms.Padding(2);
            this.btnInviaNome.Name = "btnInviaNome";
            this.btnInviaNome.Size = new System.Drawing.Size(151, 51);
            this.btnInviaNome.TabIndex = 6;
            this.btnInviaNome.Text = "INSERISCI";
            this.btnInviaNome.UseVisualStyleBackColor = true;
            this.btnInviaNome.Click += new System.EventHandler(this.btnInviaNome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(659, 366);
            this.Controls.Add(this.btnInviaNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNoleggia);
            this.Controls.Add(this.txtAuto);
            this.Controls.Add(this.listBoxAutoDisponibili);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAutoDisponibili;
        private System.Windows.Forms.TextBox txtAuto;
        private System.Windows.Forms.Button btnNoleggia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnInviaNome;
    }
}

