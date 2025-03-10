/*
 * Creato da SharpDevelop.
 * Utente: utente1
 * Data: 07/04/2008
 * Ora: 9.15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace OSLfonts
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.txtFont.Text =  this.txtFont.Font.Name + ", " + this.txtFont.Font.SizeInPoints.ToString();
			this.txtSaveTo.Text = Application.StartupPath + "\\" + this.txtFont.Font.Name + ".oft";
			this.chkRemoveTempFiles.Checked = true;
		}
		
		void BtnSaveToClick(object sender, EventArgs e)
		{
			this.saveFile.Filter = "File OFT (*.oft)|*.oft|All files (*.*)|*.*";
			this.saveFile.FileName = this.txtSaveTo.Text;
			if (this.saveFile.ShowDialog() == DialogResult.OK){
				this.txtSaveTo.Text = this.saveFile.FileName;
			}
		}
		
		void BtnFontClick(object sender, EventArgs e)
		{
			this.fontDialog.FontMustExist = true;
			this.fontDialog.ShowEffects = false;
			this.fontDialog.AllowScriptChange = false;
			this.fontDialog.AllowSimulations = false;
			if (this.fontDialog.ShowDialog() == DialogResult.OK)
			{
				this.txtFont.Text =  this.fontDialog.Font.Name + ", " + this.fontDialog.Font.SizeInPoints.ToString();
				this.txtFont.Font = this.fontDialog.Font;
				this.txtSaveTo.Text = System.IO.Path.GetDirectoryName(this.txtSaveTo.Text) + "\\" + this.txtFont.Font.Name + ".oft";
			}
		}
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnOKClick(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			System.IO.Directory.SetCurrentDirectory(System.IO.Path.GetDirectoryName(this.txtSaveTo.Text));
			
			try
			{
				Process proc;
				proc = new Process();
			    proc.StartInfo.UseShellExecute = false;
			    proc.StartInfo.FileName = Application.StartupPath + "\\font2osl.exe";
			    proc.StartInfo.Arguments = "-convert \"" + this.txtFont.Font.Name + "\" " + this.txtFont.Font.SizeInPoints.ToString() + " \"font.bmp\" \"font.txt\"";
			    proc.StartInfo.CreateNoWindow = true;
			    proc.StartInfo.UseShellExecute = false;
			    proc.StartInfo.RedirectStandardOutput = true;
			    proc.StartInfo.RedirectStandardError = true;			    
			    proc.StartInfo.RedirectStandardInput = true;
			    proc.EnableRaisingEvents = true;
			    proc.Start();			
			    proc.WaitForExit();
			    proc.StartInfo.Arguments = "-create \"font.bmp\" \"font.txt\" \"" + this.txtSaveTo.Text;
			    proc.Start();			
			    proc.WaitForExit();
			    proc.Close();
			    
			    if (this.chkRemoveTempFiles.Checked){
			    	System.IO.File.Delete(System.IO.Path.GetDirectoryName(this.txtSaveTo.Text) + "\\font.bmp");
			    	System.IO.File.Delete(System.IO.Path.GetDirectoryName(this.txtSaveTo.Text) + "\\font.txt");
			    }
    			Cursor.Current = Cursors.Default;
			}
			catch (System.Exception exc) 
			{
    			Cursor.Current = Cursors.Default;
				MessageBox.Show("Error creating font:\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				MessageBox.Show("Font generated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
