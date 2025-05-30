
namespace ServerApp
{
    partial class ServerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxClienti;
        private System.Windows.Forms.ListBox listBoxAuto;
        private System.Windows.Forms.ListBox listBoxLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxClienti = new System.Windows.Forms.ListBox();
            this.listBoxAuto = new System.Windows.Forms.ListBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxClienti
            // 
            this.listBoxClienti.FormattingEnabled = true;
            this.listBoxClienti.Location = new System.Drawing.Point(12, 12);
            this.listBoxClienti.Size = new System.Drawing.Size(200, 160);
            // 
            // listBoxAuto
            // 
            this.listBoxAuto.FormattingEnabled = true;
            this.listBoxAuto.Location = new System.Drawing.Point(230, 12);
            this.listBoxAuto.Size = new System.Drawing.Size(200, 160);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(12, 190);
            this.listBoxLog.Size = new System.Drawing.Size(418, 134);
            // 
            // ServerForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 340);
            this.Controls.Add(this.listBoxClienti);
            this.Controls.Add(this.listBoxAuto);
            this.Controls.Add(this.listBoxLog);
            this.Name = "ServerForm";
            this.Text = "Server - Noleggio Auto";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
        }
    }
}
