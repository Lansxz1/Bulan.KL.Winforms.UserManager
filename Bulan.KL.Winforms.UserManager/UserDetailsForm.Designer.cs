namespace Bulan.KL.Winforms.UserManager
{
    partial class UserDetailsForm
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
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 20F, FontStyle.Bold);
            label5.Location = new Point(63, 20);
            label5.Name = "label5";
            label5.Size = new Size(128, 32);
            label5.TabIndex = 17;
            label5.Text = "Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(7, 175);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 20;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(7, 121);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 19;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 18;
            label1.Text = "Full Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 175);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 23;
            label4.Text = "********";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(80, 121);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 22;
            label6.Text = "Lansxz";
           
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(76, 72);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 21;
            label7.Text = "Kristoffer Lance Bulan";
            
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Highlight;
            btnClose.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnClose.ForeColor = SystemColors.Info;
            btnClose.Location = new Point(12, 205);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(247, 63);
            btnClose.TabIndex = 24;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // UserDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 280);
            Controls.Add(btnClose);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "UserDetailsForm";
            Text = "UserDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button btnClose;
    }
}