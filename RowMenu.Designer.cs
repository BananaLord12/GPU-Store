namespace GPU_Store
{
    partial class RowMenu
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
            this.productName = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.productID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(77, 26);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(38, 15);
            this.productName.TabIndex = 0;
            this.productName.Text = "label1";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Update.Location = new System.Drawing.Point(50, 71);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(192, 72);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Delete.Location = new System.Drawing.Point(50, 172);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(192, 72);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // productID
            // 
            this.productID.AutoSize = true;
            this.productID.Location = new System.Drawing.Point(119, 278);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(38, 15);
            this.productID.TabIndex = 3;
            this.productID.Text = "label1";
            this.productID.Visible = false;
            // 
            // RowMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(298, 322);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.productName);
            this.Name = "RowMenu";
            this.Text = "RowMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label productName;
        private Button btn_Update;
        private Button btn_Delete;
        private Label productID;
    }
}