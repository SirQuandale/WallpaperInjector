namespace Wallpaper_Injector
{
    partial class Form1
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
            this.SetWallpaperBtn = new FlatUI.FlatButton();
            this.SuspendLayout();
            // 
            // SetWallpaperBtn
            // 
            this.SetWallpaperBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetWallpaperBtn.BackColor = System.Drawing.Color.Transparent;
            this.SetWallpaperBtn.BaseColor = System.Drawing.Color.MediumPurple;
            this.SetWallpaperBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetWallpaperBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SetWallpaperBtn.Location = new System.Drawing.Point(222, 150);
            this.SetWallpaperBtn.Name = "SetWallpaperBtn";
            this.SetWallpaperBtn.Rounded = true;
            this.SetWallpaperBtn.Size = new System.Drawing.Size(333, 106);
            this.SetWallpaperBtn.TabIndex = 0;
            this.SetWallpaperBtn.Text = "Set Wallpaper";
            this.SetWallpaperBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.SetWallpaperBtn.Click += new System.EventHandler(this.WallpaperSetting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetWallpaperBtn);
            this.Name = "Form1";
            this.Text = "Wallpaper Injector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FlatButton SetWallpaperBtn;
    }
}

