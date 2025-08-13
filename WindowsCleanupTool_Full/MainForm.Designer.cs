namespace WindowsCleanupTool
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.CheckBox chkTemp;
        private System.Windows.Forms.CheckBox chkPrefetch;
        private System.Windows.Forms.CheckBox chkRecycleBin;
        private System.Windows.Forms.CheckBox chkWindowsUpdate;
        private System.Windows.Forms.Button btnCleanup;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.chkTemp = new System.Windows.Forms.CheckBox();
            this.chkPrefetch = new System.Windows.Forms.CheckBox();
            this.chkRecycleBin = new System.Windows.Forms.CheckBox();
            this.chkWindowsUpdate = new System.Windows.Forms.CheckBox();
            this.btnCleanup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkTemp
            // 
            this.chkTemp.AutoSize = true;
            this.chkTemp.Location = new System.Drawing.Point(30, 30);
            this.chkTemp.Name = "chkTemp";
            this.chkTemp.Size = new System.Drawing.Size(96, 17);
            this.chkTemp.TabIndex = 0;
            this.chkTemp.Text = "Clear Temp files";
            this.chkTemp.UseVisualStyleBackColor = true;
            // 
            // chkPrefetch
            // 
            this.chkPrefetch.AutoSize = true;
            this.chkPrefetch.Location = new System.Drawing.Point(30, 60);
            this.chkPrefetch.Name = "chkPrefetch";
            this.chkPrefetch.Size = new System.Drawing.Size(96, 17);
            this.chkPrefetch.TabIndex = 1;
            this.chkPrefetch.Text = "Clear Prefetch";
            this.chkPrefetch.UseVisualStyleBackColor = true;
            // 
            // chkRecycleBin
            // 
            this.chkRecycleBin.AutoSize = true;
            this.chkRecycleBin.Location = new System.Drawing.Point(30, 90);
            this.chkRecycleBin.Name = "chkRecycleBin";
            this.chkRecycleBin.Size = new System.Drawing.Size(108, 17);
            this.chkRecycleBin.TabIndex = 2;
            this.chkRecycleBin.Text = "Empty Recycle Bin";
            this.chkRecycleBin.UseVisualStyleBackColor = true;
            // 
            // chkWindowsUpdate
            // 
            this.chkWindowsUpdate.AutoSize = true;
            this.chkWindowsUpdate.Location = new System.Drawing.Point(30, 120);
            this.chkWindowsUpdate.Name = "chkWindowsUpdate";
            this.chkWindowsUpdate.Size = new System.Drawing.Size(180, 17);
            this.chkWindowsUpdate.TabIndex = 3;
            this.chkWindowsUpdate.Text = "Clear Windows Update Downloads";
            this.chkWindowsUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCleanup
            // 
            this.btnCleanup.Location = new System.Drawing.Point(30, 160);
            this.btnCleanup.Name = "btnCleanup";
            this.btnCleanup.Size = new System.Drawing.Size(100, 30);
            this.btnCleanup.TabIndex = 4;
            this.btnCleanup.Text = "Run Cleanup";
            this.btnCleanup.UseVisualStyleBackColor = true;
            this.btnCleanup.Click += new System.EventHandler(this.btnCleanup_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnCleanup);
            this.Controls.Add(this.chkWindowsUpdate);
            this.Controls.Add(this.chkRecycleBin);
            this.Controls.Add(this.chkPrefetch);
            this.Controls.Add(this.chkTemp);
            this.Name = "MainForm";
            this.Text = "Windows Cleanup Tool";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
