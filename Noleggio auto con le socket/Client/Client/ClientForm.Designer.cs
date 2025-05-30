
namespace ClientApp
{
    partial class ClientForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxAuto;
        private System.Windows.Forms.TextBox textBoxAuto;
        private System.Windows.Forms.Button btnNoleggia;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxAuto = new System.Windows.Forms.ListBox();
            this.textBoxAuto = new System.Windows.Forms.TextBox();
            this.btnNoleggia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAuto
            // 
            this.listBoxAuto.FormattingEnabled = true;
            this.listBoxAuto.Location = new System.Drawing.Point(12, 12);
            this.listBoxAuto.Size = new System.Drawing.Size(200, 95);
            // 
            // textBoxAuto
            // 
            this.textBoxAuto.Location = new System.Drawing.Point(12, 120);
            this.textBoxAuto.Size = new System.Drawing.Size(200, 20);
            // 
            // btnNoleggia
            // 
            this.btnNoleggia.Location = new System.Drawing.Point(12, 150);
            this.btnNoleggia.Size = new System.Drawing.Size(200, 30);
            this.btnNoleggia.Text = "Noleggia";
            this.btnNoleggia.Click += new System.EventHandler(this.btnNoleggia_Click);
            // 
            // ClientForm
            // 
            this.ClientSize = new System.Drawing.Size(230, 200);
            this.Controls.Add(this.listBoxAuto);
            this.Controls.Add(this.textBoxAuto);
            this.Controls.Add(this.btnNoleggia);
            this.Name = "ClientForm";
            this.Text = "Client - Noleggio Auto";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
