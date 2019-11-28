namespace Ordering_System___Gift_4_You
{
    partial class OrderUI
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
            this.label_sender = new System.Windows.Forms.Label();
            this.label_timestamp = new System.Windows.Forms.Label();
            this.label_order = new System.Windows.Forms.Label();
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
            // label_sender
            // 
            this.label_sender.AutoSize = true;
            this.label_sender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_sender.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(148)))), ((int)(((byte)(163)))));
            this.label_sender.Location = new System.Drawing.Point(13, 33);
            this.label_sender.Name = "label_sender";
            this.label_sender.Size = new System.Drawing.Size(63, 23);
            this.label_sender.TabIndex = 8;
            this.label_sender.Text = "Sender:";
            // 
            // label_timestamp
            // 
            this.label_timestamp.AutoEllipsis = true;
            this.label_timestamp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_timestamp.Font = new System.Drawing.Font("Lato", 8F);
            this.label_timestamp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(148)))), ((int)(((byte)(163)))));
            this.label_timestamp.Location = new System.Drawing.Point(17, 56);
            this.label_timestamp.Name = "label_timestamp";
            this.label_timestamp.Size = new System.Drawing.Size(169, 23);
            this.label_timestamp.TabIndex = 7;
            this.label_timestamp.Text = "Timestamp:";
            // 
            // label_order
            // 
            this.label_order.AutoSize = true;
            this.label_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_order.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(76)))));
            this.label_order.Location = new System.Drawing.Point(13, 10);
            this.label_order.Name = "label_order";
            this.label_order.Size = new System.Drawing.Size(75, 23);
            this.label_order.TabIndex = 6;
            this.label_order.Text = "Order Id:";
            // 
            // OrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.label_sender);
            this.Controls.Add(this.label_timestamp);
            this.Controls.Add(this.label_order);
            this.Controls.Add(this.button_viewmore);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.Name = "OrderUI";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(270, 117);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label button_viewmore;
        private System.Windows.Forms.Label label_sender;
        private System.Windows.Forms.Label label_timestamp;
        private System.Windows.Forms.Label label_order;
    }
}
