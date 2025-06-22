namespace FurnitureAppVS9
{
    partial class EditFurnitureForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblPrice;
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
            this.lblType = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblType
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(20, 20);
            this.lblType.Text = "Тип:";
            // 
            // txtType
            this.txtType.Location = new System.Drawing.Point(120, 20);
            this.txtType.Size = new System.Drawing.Size(200, 20);
            // 
            // lblBrand
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(20, 60);
            this.lblBrand.Text = "Бренд:";
            // 
            // txtBrand
            this.txtBrand.Location = new System.Drawing.Point(120, 60);
            this.txtBrand.Size = new System.Drawing.Size(200, 20);
            // 
            // lblManufacturer
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(20, 100);
            this.lblManufacturer.Text = "Виробник:";
            // 
            // txtManufacturer
            this.txtManufacturer.Location = new System.Drawing.Point(120, 100);
            this.txtManufacturer.Size = new System.Drawing.Size(200, 20);
            // 
            // lblSupplier
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(20, 140);
            this.lblSupplier.Text = "Постачальник:";
            // 
            // txtSupplier
            this.txtSupplier.Location = new System.Drawing.Point(120, 140);
            this.txtSupplier.Size = new System.Drawing.Size(200, 20);
            // 
            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 180);
            this.lblPrice.Text = "Ціна:";
            // 
            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(120, 180);
            this.txtPrice.Size = new System.Drawing.Size(200, 20);
            // 
            // btnSave
            this.btnSave.Text = "Зберегти";
            this.btnSave.Location = new System.Drawing.Point(120, 220);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditFurnitureForm
            this.ClientSize = new System.Drawing.Size(350, 270);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnSave);
            this.Text = "Редагування меблів";
            this.Load += new System.EventHandler(this.EditFurnitureForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
