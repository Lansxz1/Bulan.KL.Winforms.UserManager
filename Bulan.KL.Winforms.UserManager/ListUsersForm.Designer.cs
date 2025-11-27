namespace Bulan.KL.Winforms.UserManager
{
    partial class ListUsersForm
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
            btnNew = new Button();
            btnView = new Button();
            dgvViewUsers = new DataGridView();
            btnRefreshQ1QAZ = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvViewUsers).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 20F, FontStyle.Bold);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(212, 32);
            label5.TabIndex = 16;
            label5.Text = "LIST OF USERS";
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.GradientActiveCaption;
            btnNew.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnNew.Location = new Point(12, 331);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(181, 78);
            btnNew.TabIndex = 18;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.ActiveCaption;
            btnView.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnView.Location = new Point(233, 331);
            btnView.Name = "btnView";
            btnView.Size = new Size(181, 78);
            btnView.TabIndex = 19;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            // 
            // dgvViewUsers
            // 
            dgvViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewUsers.Location = new Point(12, 44);
            dgvViewUsers.Name = "dgvViewUsers";
            dgvViewUsers.Size = new Size(402, 281);
            dgvViewUsers.TabIndex = 20;
            // 
            // btnRefreshQ1QAZ
            // 
            btnRefreshQ1QAZ.BackColor = SystemColors.Control;
            btnRefreshQ1QAZ.BackgroundImage = Properties.Resources.images1;
            btnRefreshQ1QAZ.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefreshQ1QAZ.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRefreshQ1QAZ.Location = new Point(233, 3);
            btnRefreshQ1QAZ.Name = "btnRefreshQ1QAZ";
            btnRefreshQ1QAZ.Size = new Size(40, 38);
            btnRefreshQ1QAZ.TabIndex = 21;
            btnRefreshQ1QAZ.UseVisualStyleBackColor = false;
            // 
            // ListUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 416);
            Controls.Add(btnRefreshQ1QAZ);
            Controls.Add(dgvViewUsers);
            Controls.Add(btnView);
            Controls.Add(btnNew);
            Controls.Add(label5);
            Name = "ListUsersForm";
            Text = "List Users Forms";
            Load += ListUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button btnNew;
        private Button btnView;
        private DataGridView dgvViewUsers;
        private Button btnRefreshQ1QAZ;
    }
}