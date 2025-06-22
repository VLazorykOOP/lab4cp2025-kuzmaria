namespace FurnitureAppVS9
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(30, 25);
            this.lblUsername.Text = "Логін:";

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(100, 22);
            this.txtUsername.Width = 150;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 65);
            this.lblPassword.Text = "Пароль:";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(100, 62);
            this.txtPassword.Width = 150;
            this.txtPassword.PasswordChar = '*';

            // btnLogin
            this.btnLogin.Text = "Увійти";
            this.btnLogin.Location = new System.Drawing.Point(100, 100);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // LoginForm
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblUsername, this.txtUsername,
                this.lblPassword, this.txtPassword,
                this.btnLogin
            });
            this.Text = "Авторизація";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
