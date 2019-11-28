namespace Ordering_System___Gift_4_You
{
    partial class ProductItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_product_code = new System.Windows.Forms.Label();
            this.label_product_name = new System.Windows.Forms.Label();
            this.hoverable = new Ordering_System___Gift_4_You.TransparentPanel();
            this.SuspendLayout();
            // 
            // label_product_code
            // 
            this.label_product_code.AutoSize = true;
            this.label_product_code.Font = new System.Drawing.Font("PT Sans Caption", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_product_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(76)))));
            this.label_product_code.Location = new System.Drawing.Point(13, 9);
            this.label_product_code.Name = "label_product_code";
            this.label_product_code.Size = new System.Drawing.Size(92, 17);
            this.label_product_code.TabIndex = 0;
            this.label_product_code.Text = "Product Code";
            // 
            // label_product_name
            // 
            this.label_product_name.AutoSize = true;
            this.label_product_name.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_product_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(148)))), ((int)(((byte)(163)))));
            this.label_product_name.Location = new System.Drawing.Point(13, 26);
            this.label_product_name.Name = "label_product_name";
            this.label_product_name.Size = new System.Drawing.Size(74, 15);
            this.label_product_name.TabIndex = 1;
            this.label_product_name.Text = "Product name";
            // 
            // hoverable
            // 
            this.hoverable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hoverable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoverable.Location = new System.Drawing.Point(0, 0);
            this.hoverable.Name = "hoverable";
            this.hoverable.Opacity = 0;
            this.hoverable.Size = new System.Drawing.Size(156, 50);
            this.hoverable.TabIndex = 2;
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.hoverable);
            this.Controls.Add(this.label_product_name);
            this.Controls.Add(this.label_product_code);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(156, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_product_code;
        private System.Windows.Forms.Label label_product_name;
        private TransparentPanel hoverable;
    }
}
