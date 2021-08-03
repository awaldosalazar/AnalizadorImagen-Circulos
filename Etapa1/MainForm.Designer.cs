/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 23/01/2019
 * Time: 01:44 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Etapa1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBoxImg;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.Button buttonFindCicleCenters;
		private System.Windows.Forms.ListBox listBoxCenter;
		
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
			this.pictureBoxImg = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.buttonFindCicleCenters = new System.Windows.Forms.Button();
			this.listBoxCenter = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxImg
			// 
			this.pictureBoxImg.Location = new System.Drawing.Point(12, 12);
			this.pictureBoxImg.Name = "pictureBoxImg";
			this.pictureBoxImg.Size = new System.Drawing.Size(482, 308);
			this.pictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxImg.TabIndex = 0;
			this.pictureBoxImg.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// buttonOpen
			// 
			this.buttonOpen.Location = new System.Drawing.Point(501, 13);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(158, 23);
			this.buttonOpen.TabIndex = 1;
			this.buttonOpen.Text = "Seleccionar Imagen";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.ButtonOpenClick);
			// 
			// buttonFindCicleCenters
			// 
			this.buttonFindCicleCenters.Location = new System.Drawing.Point(501, 42);
			this.buttonFindCicleCenters.Name = "buttonFindCicleCenters";
			this.buttonFindCicleCenters.Size = new System.Drawing.Size(158, 23);
			this.buttonFindCicleCenters.TabIndex = 2;
			this.buttonFindCicleCenters.Text = "Analizar Imagen";
			this.buttonFindCicleCenters.UseVisualStyleBackColor = true;
			this.buttonFindCicleCenters.Click += new System.EventHandler(this.ButtonFindCicleCentersClick);
			// 
			// listBoxCenter
			// 
			this.listBoxCenter.FormattingEnabled = true;
			this.listBoxCenter.Location = new System.Drawing.Point(501, 83);
			this.listBoxCenter.Name = "listBoxCenter";
			this.listBoxCenter.Size = new System.Drawing.Size(155, 238);
			this.listBoxCenter.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 332);
			this.Controls.Add(this.listBoxCenter);
			this.Controls.Add(this.buttonFindCicleCenters);
			this.Controls.Add(this.buttonOpen);
			this.Controls.Add(this.pictureBoxImg);
			this.Name = "MainForm";
			this.Text = "Etapa1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
