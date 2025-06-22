namespace FurnitureAppVS9
{
    partial class OrderForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblFurniture;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.ComboBox comboFurniture;
        private System.Windows.Forms.Button btnSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblFurniture = new System.Windows.Forms.Label();
            this.comboFurniture = new System.Windows.Forms.ComboBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();

            // lblFurniture
            this.lblFurniture.AutoSize = true;
            this.lblFurniture.Location = new System.Drawing.Point(20, 20);
            this.lblFurniture.Text = "Товар:";

            // comboFurniture
            this.comboFurniture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFurniture.Location = new System.Drawing.Point(120, 17);
            this.comboFurniture.Width = 200;

            // lblCustomerName
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(20, 60);
            this.lblCustomerName.Text = "Ім'я клієнта:";

            // txtCustomerName
            this.txtCustomerName.Location = new System.Drawing.Point(120, 57);
            this.txtCustomerName.Width = 200;

            // lblQuantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(20, 100);
            this.lblQuantity.Text = "Кількість:";

            // numericQuantity
            this.numericQuantity.Location = new System.Drawing.Point(120, 97);
            this.numericQuantity.Minimum = 1;
            this.numericQuantity.Maximum = 100;
            this.numericQuantity.Value = 1;

            // btnSubmit
            this.btnSubmit.Text = "Замовити";
            this.btnSubmit.Location = new System.Drawing.Point(120, 140);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // OrderForm
            this.ClientSize = new System.Drawing.Size(350, 190);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblFurniture, this.comboFurniture,
                this.lblCustomerName, this.txtCustomerName,
                this.lblQuantity, this.numericQuantity,
                this.btnSubmit
            });
            this.Text = "Оформлення замовлення";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
