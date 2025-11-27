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
            dataGridView1 = new DataGridView();
            btnNew = new Button();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(402, 281);
            dataGridView1.TabIndex = 17;
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
            // ListUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 416);
            Controls.Add(btnView);
            Controls.Add(btnNew);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Name = "ListUsersForm";
            Text = "List Users Forms";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView dataGridView1;
        private Button btnNew;
        private Button btnView;
    }
}