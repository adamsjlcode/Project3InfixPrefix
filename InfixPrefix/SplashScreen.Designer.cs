//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:			Project 3 - PostFix/InFix
//	File Name:			SplashScreen.Designer.cs
//	Description:		Designer class for SplashScreen Class
//	Course:				CSCI 2210-001 - Data Structures
//	Author:				Justin Adams, adamsjl3@etsu.edu, UndergradeCS, East Tennessee State University
//	Created:			Friday, October 27, 2017
//	Copyright:			Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project3
{
	/// <summary>
	/// Design of SplashScreen Form
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	partial class SplashScreen
	{
		#region Designer Requirements
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ( );
			}//End if-statement
			base.Dispose (disposing);
		}//End Dispose (bool)
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
			this.labelProject = new System.Windows.Forms.Label();
			this.labelProjectName = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelProject
			// 
			this.labelProject.BackColor = System.Drawing.Color.Transparent;
			this.labelProject.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelProject.ForeColor = System.Drawing.Color.Goldenrod;
			this.labelProject.Location = new System.Drawing.Point(0, 0);
			this.labelProject.Name = "labelProject";
			this.labelProject.Size = new System.Drawing.Size(616, 50);
			this.labelProject.TabIndex = 0;
			this.labelProject.Text = "Title";
			this.labelProject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelProjectName
			// 
			this.labelProjectName.BackColor = System.Drawing.Color.Transparent;
			this.labelProjectName.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelProjectName.ForeColor = System.Drawing.Color.Goldenrod;
			this.labelProjectName.Location = new System.Drawing.Point(0, 137);
			this.labelProjectName.Name = "labelProjectName";
			this.labelProjectName.Size = new System.Drawing.Size(616, 50);
			this.labelProjectName.TabIndex = 1;
			this.labelProjectName.Text = "Product";
			this.labelProjectName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// labelName
			// 
			this.labelName.BackColor = System.Drawing.Color.Transparent;
			this.labelName.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.ForeColor = System.Drawing.Color.Goldenrod;
			this.labelName.Location = new System.Drawing.Point(0, 63);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(616, 55);
			this.labelName.TabIndex = 2;
			this.labelName.Text = "Company";
			this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.labelProject);
			this.panel1.Controls.Add(this.labelName);
			this.panel1.Controls.Add(this.labelProjectName);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(616, 187);
			this.panel1.TabIndex = 3;
			// 
			// SplashScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(640, 840);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SplashScreen";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Project 3 - Justin Adams -SplashScreen";
			this.TransparencyKey = System.Drawing.Color.Black;
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}//End InitializeComponent ( )
		/// <summary>
		/// The label project
		/// </summary>
		private System.Windows.Forms.Label labelProject;
		/// <summary>
		/// The label project name
		/// </summary>
		private System.Windows.Forms.Label labelProjectName;
		/// <summary>
		/// The label name
		/// </summary>
		private System.Windows.Forms.Label labelName;
		/// <summary>
		/// The panel1
		/// </summary>
		private System.Windows.Forms.Panel panel1;
		#endregion

	}//End SplashScreen
}//End Project3