namespace Bulan.KL.Winforms.UserManager
{
    partial class AddUserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbFullName = new TextBox();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(119, 44);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(269, 23);
            tbFullName.TabIndex = 0;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(119, 93);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(269, 23);
            tbUserName.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(119, 147);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(269, 23);
            tbPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 52);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "Full Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 101);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 155);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.MenuHighlight;
            btnSave.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.Info;
            btnSave.Location = new Point(31, 188);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(357, 50);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 20F, FontStyle.Bold);
            label5.Location = new Point(86, 9);
            label5.Name = "label5";
            label5.Size = new Size(234, 32);
            label5.TabIndex = 8;
            label5.Text = "ADD USER FORM";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 250);
            Controls.Add(label5);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(tbFullName);
            Name = "AddUserForm";
            Text = "Add User Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbFullName;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSave;
        private Label label5;
    }
}
