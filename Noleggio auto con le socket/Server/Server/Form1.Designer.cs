namespace Server
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
            this.listBoxAutoNoleggiate = new System.Windows.Forms.ListBox();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.listBoxMonitorNoleggi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxAutoDisponibili
            // 
            this.listBoxAutoDisponibili.FormattingEnabled = true;
            this.listBoxAutoDisponibili.HorizontalScrollbar = true;
            this.listBoxAutoDisponibili.ItemHeight = 16;
            this.listBoxAutoDisponibili.Location = new System.Drawing.Point(24, 163);
            this.listBoxAutoDisponibili.Name = "listBoxAutoDisponibili";
            this.listBoxAutoDisponibili.Size = new System.Drawing.Size(171, 260);
            this.listBoxAutoDisponibili.TabIndex = 0;
            // 
            // listBoxAutoNoleggiate
            // 
            this.listBoxAutoNoleggiate.FormattingEnabled = true;
            this.listBoxAutoNoleggiate.HorizontalScrollbar = true;
            this.listBoxAutoNoleggiate.ItemHeight = 16;
            this.listBoxAutoNoleggiate.Location = new System.Drawing.Point(217, 163);
            this.listBoxAutoNoleggiate.Name = "listBoxAutoNoleggiate";
            this.listBoxAutoNoleggiate.Size = new System.Drawing.Size(165, 260);
            this.listBoxAutoNoleggiate.TabIndex = 1;
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.HorizontalExtent = 300;
            this.listBoxClient.HorizontalScrollbar = true;
            this.listBoxClient.ItemHeight = 16;
            this.listBoxClient.Location = new System.Drawing.Point(404, 163);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(207, 260);
            this.listBoxClient.TabIndex = 2;
            // 
            // listBoxMonitorNoleggi
            // 
            this.listBoxMonitorNoleggi.FormattingEnabled = true;
            this.listBoxMonitorNoleggi.HorizontalExtent = 300;
            this.listBoxMonitorNoleggi.HorizontalScrollbar = true;
            this.listBoxMonitorNoleggi.ItemHeight = 16;
            this.listBoxMonitorNoleggi.Location = new System.Drawing.Point(632, 163);
            this.listBoxMonitorNoleggi.Name = "listBoxMonitorNoleggi";
            this.listBoxMonitorNoleggi.Size = new System.Drawing.Size(207, 260);
            this.listBoxMonitorNoleggi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Auto disponibili:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Auto non disponibili:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Client connessi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(640, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Monitoraggio noleggio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(440, 44);
            this.label5.TabIndex = 9;
            this.label5.Text = "Noleggio auto D\'Onofrio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMonitorNoleggi);
            this.Controls.Add(this.listBoxClient);
            this.Controls.Add(this.listBoxAutoNoleggiate);
            this.Controls.Add(this.listBoxAutoDisponibili);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAutoDisponibili;
        private System.Windows.Forms.ListBox listBoxAutoNoleggiate;
        private System.Windows.Forms.ListBox listBoxClient;
        private System.Windows.Forms.ListBox listBoxMonitorNoleggi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

