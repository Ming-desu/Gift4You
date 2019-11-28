namespace Ordering_System___Gift_4_You
{
    partial class Notification
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_caption = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_okay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button_close = new System.Windows.Forms.PictureBox();
            this.picture_icon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Controls.Add(this.label_caption);
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Controls.Add(this.picture_icon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 200);
            this.panel1.TabIndex = 0;
            // 
            // label_caption
            // 
            this.label_caption.AutoSize = true;
            this.label_caption.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_caption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(148)))), ((int)(((byte)(163)))));
            this.label_caption.Location = new System.Drawing.Point(111, 141);
            this.label_caption.Name = "label_caption";
            this.label_caption.Size = new System.Drawing.Size(228, 19);
            this.label_caption.TabIndex = 2;
            this.label_caption.Text = "You have successfully created account.";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(170, 112);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(111, 29);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Awesome!";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_okay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 80);
            this.panel2.TabIndex = 1;
            // 
            // button_okay
            // 
            this.button_okay.BackColor = System.Drawing.Color.White;
            this.button_okay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_okay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(76)))));
            this.button_okay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_okay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_okay.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_okay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(76)))));
            this.button_okay.Location = new System.Drawing.Point(171, 23);
            this.button_okay.Name = "button_okay";
            this.button_okay.Size = new System.Drawing.Size(109, 34);
            this.button_okay.TabIndex = 0;
            this.button_okay.Text = "OKAY";
            this.button_okay.UseVisualStyleBackColor = false;
            this.button_okay.Click += new System.EventHandler(this.Button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // button_close
            // 
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.Image = global::Ordering_System___Gift_4_You.Properties.Resources.icon_x_thick_white;
            this.button_close.Location = new System.Drawing.Point(418, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(20, 20);
            this.button_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_close.TabIndex = 13;
            this.button_close.TabStop = false;
            this.button_close.Click += new System.EventHandler(this.Button_Click);
            // 
            // picture_icon
            // 
            this.picture_icon.Image = global::Ordering_System___Gift_4_You.Properties.Resources.icon_ok_white;
            this.picture_icon.Location = new System.Drawing.Point(200, 40);
            this.picture_icon.Name = "picture_icon";
            this.picture_icon.Size = new System.Drawing.Size(50, 50);
            this.picture_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_icon.TabIndex = 0;
            this.picture_icon.TabStop = false;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_caption;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox picture_icon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_okay;
        private System.Windows.Forms.PictureBox button_close;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}