namespace Ordering_System___Gift_4_You
{
    partial class ProductUI
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
            this.button_viewmore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_initial = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_code = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_viewmore
            // 
            this.button_viewmore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_viewmore.AutoSize = true;
            this.button_viewmore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_viewmore.Font = new System.Drawing.Font("PT Sans Caption", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_viewmore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.button_viewmore.Location = new System.Drawing.Point(177, 90);
            this.button_viewmore.Name = "button_viewmore";
            this.button_viewmore.Size = new System.Drawing.Size(80, 17);
            this.button_viewmore.TabIndex = 0;
            this.button_viewmore.Text = "VIEW MORE";
            this.button_viewmore.Visible = false;
            this.button_viewmore.Click += new System.EventHandler(this.button_viewmore_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.label_initial);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 60);
            this.panel1.TabIndex = 5;
            // 
            // label_initial
            // 
            this.label_initial.AutoSize = true;
            this.label_initial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_initial.Font = new System.Drawing.Font("PT Sans Caption", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_initial.ForeColor = System.Drawing.Color.White;
            this.label_initial.Location = new System.Drawing.Point(8, 6);
            this.label_initial.Name = "label_initial";
            this.label_initial.Size = new System.Drawing.Size(44, 48);
            this.label_initial.TabIndex = 0;
            this.label_initial.Text = "B";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_name.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(148)))), ((int)(((byte)(163)))));
            this.label_name.Location = new System.Drawing.Point(79, 33);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(116, 23);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "Product Name:";
            // 
            // label_description
            // 
            this.label_description.AutoEllipsis = true;
            this.label_description.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_description.Font = new System.Drawing.Font("Lato", 8F);
            this.label_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(148)))), ((int)(((byte)(163)))));
            this.label_description.Location = new System.Drawing.Point(83, 56);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(169, 23);
            this.label_description.TabIndex = 7;
            this.label_description.Text = "Description:";
            // 
            // label_code
            // 
            this.label_code.AutoSize = true;
            this.label_code.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_code.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(76)))));
            this.label_code.Location = new System.Drawing.Point(79, 10);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(113, 23);
            this.label_code.TabIndex = 6;
            this.label_code.Text = "Product Code:";
            // 
            // ProductUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_code);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_viewmore);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.Name = "ProductUI";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(270, 117);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label button_viewmore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_initial;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_code;
    }
}
