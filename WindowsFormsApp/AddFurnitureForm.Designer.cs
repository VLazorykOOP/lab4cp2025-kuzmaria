namespace FurnitureAppVS9
{
    partial class AddFurnitureForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            this.txtType.Location = new System.Drawing.Point(12, 12);
            this.txtBrand.Location = new System.Drawing.Point(12, 42);
            this.txtManufacturer.Location = new System.Drawing.Point(12, 72);
            this.txtSupplier.Location = new System.Drawing.Point(12, 102);
            this.txtPrice.Location = new System.Drawing.Point(12, 132);
            //
            this.btnSave.Text = "Зберегти";
            this.btnSave.Location = new System.Drawing.Point(12, 162);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            this.ClientSize = new System.Drawing.Size(230, 210);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnSave);
            this.Text = "Додати меблі";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}