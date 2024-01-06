namespace TypeingTest
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.signInBtn = new System.Windows.Forms.Button();
            this.errorMsgLabl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign in";
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameTxtBox.Location = new System.Drawing.Point(79, 216);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.PlaceholderText = "User name or Roll no";
            this.userNameTxtBox.Size = new System.Drawing.Size(283, 27);
            this.userNameTxtBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(79, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTxtBox.Location = new System.Drawing.Point(79, 264);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PlaceholderText = "Password";
            this.passwordTxtBox.Size = new System.Drawing.Size(283, 27);
            this.passwordTxtBox.TabIndex = 3;
            this.passwordTxtBox.UseSystemPasswordChar = true;
            // 
            // signInBtn
            // 
            this.signInBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signInBtn.Location = new System.Drawing.Point(79, 297);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(120, 35);
            this.signInBtn.TabIndex = 4;
            this.signInBtn.Text = "Sign in";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // errorMsgLabl
            // 
            this.errorMsgLabl.AutoSize = true;
            this.errorMsgLabl.ForeColor = System.Drawing.Color.Crimson;
            this.errorMsgLabl.Location = new System.Drawing.Point(157, 182);
            this.errorMsgLabl.Name = "errorMsgLabl";
            this.errorMsgLabl.Size = new System.Drawing.Size(179, 15);
            this.errorMsgLabl.TabIndex = 5;
            this.errorMsgLabl.Text = "Incorrect user name or password";
            this.errorMsgLabl.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.errorMsgLabl);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox userNameTxtBox;
        private PictureBox pictureBox1;
        private TextBox passwordTxtBox;
        private Button signInBtn;
        private Label errorMsgLabl;
    }
}