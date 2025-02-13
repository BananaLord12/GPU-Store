namespace GPU_Store
{
    partial class Insert
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
            this.Brand = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.memorySize = new System.Windows.Forms.TextBox();
            this.memoryType = new System.Windows.Forms.TextBox();
            this.TDP = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert new Video Card";
            // 
            // Brand
            // 
            this.Brand.Location = new System.Drawing.Point(28, 81);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(100, 23);
            this.Brand.TabIndex = 1;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(204, 81);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(100, 23);
            this.Model.TabIndex = 2;
            // 
            // memorySize
            // 
            this.memorySize.Location = new System.Drawing.Point(68, 142);
            this.memorySize.Name = "memorySize";
            this.memorySize.Size = new System.Drawing.Size(100, 23);
            this.memorySize.TabIndex = 3;
            // 
            // memoryType
            // 
            this.memoryType.Location = new System.Drawing.Point(181, 187);
            this.memoryType.Name = "memoryType";
            this.memoryType.Size = new System.Drawing.Size(100, 23);
            this.memoryType.TabIndex = 4;
            // 
            // TDP
            // 
            this.TDP.Location = new System.Drawing.Point(28, 250);
            this.TDP.Name = "TDP";
            this.TDP.Size = new System.Drawing.Size(100, 23);
            this.TDP.TabIndex = 5;
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Price.Location = new System.Drawing.Point(204, 250);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 23);
            this.Price.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Memory Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Memory Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "TDP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Price";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(113, 327);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(125, 33);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(374, 397);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.TDP);
            this.Controls.Add(this.memoryType);
            this.Controls.Add(this.memorySize);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.label1);
            this.Name = "Insert";
            this.Text = "Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Brand;
        private TextBox Model;
        private TextBox memorySize;
        private TextBox memoryType;
        private TextBox TDP;
        private TextBox Price;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btn_Add;
    }
}