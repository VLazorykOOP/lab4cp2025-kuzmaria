namespace FurnitureAppVS9
{
    partial class SearchForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 20);
            this.lblSearch.Text = "Пошук:";

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(90, 17);
            this.txtSearch.Width = 180;

            // btnSearch
            this.btnSearch.Text = "Знайти";
            this.btnSearch.Location = new System.Drawing.Point(90, 50);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // SearchForm
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblSearch, this.txtSearch, this.btnSearch
            });
            this.Text = "Пошук";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
