/*
 * Creato da SharpDevelop.
 * Utente: utente1
 * Data: 07/04/2008
 * Ora: 9.15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace OSLfonts
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtFont = new System.Windows.Forms.TextBox();
			this.btnFont = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSaveTo = new System.Windows.Forms.Button();
			this.txtSaveTo = new System.Windows.Forms.TextBox();
			this.saveFile = new System.Windows.Forms.SaveFileDialog();
			this.fontDialog = new System.Windows.Forms.FontDialog();
			this.chkRemoveTempFiles = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// txtFont
			// 
			this.txtFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFont.Location = new System.Drawing.Point(93, 12);
			this.txtFont.Multiline = true;
			this.txtFont.Name = "txtFont";
			this.txtFont.ReadOnly = true;
			this.txtFont.Size = new System.Drawing.Size(277, 47);
			this.txtFont.TabIndex = 0;
			// 
			// btnFont
			// 
			this.btnFont.Location = new System.Drawing.Point(376, 12);
			this.btnFont.Name = "btnFont";
			this.btnFont.Size = new System.Drawing.Size(75, 20);
			this.btnFont.TabIndex = 1;
			this.btnFont.Text = "Font";
			this.btnFont.UseVisualStyleBackColor = true;
			this.btnFont.Click += new System.EventHandler(this.BtnFontClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Font";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(295, 119);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(93, 119);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Save to";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnSaveTo
			// 
			this.btnSaveTo.Location = new System.Drawing.Point(376, 65);
			this.btnSaveTo.Name = "btnSaveTo";
			this.btnSaveTo.Size = new System.Drawing.Size(75, 20);
			this.btnSaveTo.TabIndex = 6;
			this.btnSaveTo.Text = "...";
			this.btnSaveTo.UseVisualStyleBackColor = true;
			this.btnSaveTo.Click += new System.EventHandler(this.BtnSaveToClick);
			// 
			// txtSaveTo
			// 
			this.txtSaveTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSaveTo.Location = new System.Drawing.Point(93, 65);
			this.txtSaveTo.Name = "txtSaveTo";
			this.txtSaveTo.ReadOnly = true;
			this.txtSaveTo.Size = new System.Drawing.Size(277, 20);
			this.txtSaveTo.TabIndex = 5;
			// 
			// chkRemoveTempFiles
			// 
			this.chkRemoveTempFiles.Location = new System.Drawing.Point(93, 91);
			this.chkRemoveTempFiles.Name = "chkRemoveTempFiles";
			this.chkRemoveTempFiles.Size = new System.Drawing.Size(277, 24);
			this.chkRemoveTempFiles.TabIndex = 8;
			this.chkRemoveTempFiles.Text = "Remove temp files when finished";
			this.chkRemoveTempFiles.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 149);
			this.Controls.Add(this.chkRemoveTempFiles);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSaveTo);
			this.Controls.Add(this.txtSaveTo);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnFont);
			this.Controls.Add(this.txtFont);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(481, 176);
			this.MinimumSize = new System.Drawing.Size(481, 176);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OSLfonts";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox chkRemoveTempFiles;
		private System.Windows.Forms.FontDialog fontDialog;
		private System.Windows.Forms.SaveFileDialog saveFile;
		private System.Windows.Forms.TextBox txtSaveTo;
		private System.Windows.Forms.Button btnSaveTo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFont;
		private System.Windows.Forms.TextBox txtFont;
	}
}
