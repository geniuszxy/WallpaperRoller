namespace WallpaperRoller
{
	partial class HelperForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelperForm));
			this.tbSaveFolder = new System.Windows.Forms.TextBox();
			this.btnSelectFolder = new System.Windows.Forms.Button();
			this.btnExplore = new System.Windows.Forms.Button();
			this.btnInstall = new System.Windows.Forms.Button();
			this.gbSaveFolder = new System.Windows.Forms.GroupBox();
			this.gbSaveFolder.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbSaveFolder
			// 
			this.tbSaveFolder.Location = new System.Drawing.Point(6, 20);
			this.tbSaveFolder.Name = "tbSaveFolder";
			this.tbSaveFolder.Size = new System.Drawing.Size(264, 21);
			this.tbSaveFolder.TabIndex = 1;
			// 
			// btnSelectFolder
			// 
			this.btnSelectFolder.Location = new System.Drawing.Point(276, 18);
			this.btnSelectFolder.Name = "btnSelectFolder";
			this.btnSelectFolder.Size = new System.Drawing.Size(23, 23);
			this.btnSelectFolder.TabIndex = 2;
			this.btnSelectFolder.Text = "…";
			this.btnSelectFolder.UseVisualStyleBackColor = true;
			// 
			// btnExplore
			// 
			this.btnExplore.Location = new System.Drawing.Point(305, 18);
			this.btnExplore.Name = "btnExplore";
			this.btnExplore.Size = new System.Drawing.Size(61, 23);
			this.btnExplore.TabIndex = 3;
			this.btnExplore.Text = "Explore";
			this.btnExplore.UseVisualStyleBackColor = true;
			// 
			// btnInstall
			// 
			this.btnInstall.Location = new System.Drawing.Point(12, 12);
			this.btnInstall.Name = "btnInstall";
			this.btnInstall.Size = new System.Drawing.Size(75, 23);
			this.btnInstall.TabIndex = 4;
			this.btnInstall.Text = "Install";
			this.btnInstall.UseVisualStyleBackColor = true;
			// 
			// gbSaveFolder
			// 
			this.gbSaveFolder.Controls.Add(this.tbSaveFolder);
			this.gbSaveFolder.Controls.Add(this.btnSelectFolder);
			this.gbSaveFolder.Controls.Add(this.btnExplore);
			this.gbSaveFolder.Location = new System.Drawing.Point(12, 41);
			this.gbSaveFolder.Name = "gbSaveFolder";
			this.gbSaveFolder.Size = new System.Drawing.Size(374, 51);
			this.gbSaveFolder.TabIndex = 5;
			this.gbSaveFolder.TabStop = false;
			this.gbSaveFolder.Text = "Save Folder";
			// 
			// HelperForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 104);
			this.Controls.Add(this.gbSaveFolder);
			this.Controls.Add(this.btnInstall);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "HelperForm";
			this.Text = "Wallpaper Roller";
			this.Load += new System.EventHandler(this.HelperForm_Load);
			this.gbSaveFolder.ResumeLayout(false);
			this.gbSaveFolder.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox tbSaveFolder;
		private System.Windows.Forms.Button btnSelectFolder;
		private System.Windows.Forms.Button btnExplore;
		private System.Windows.Forms.Button btnInstall;
		private System.Windows.Forms.GroupBox gbSaveFolder;
	}
}