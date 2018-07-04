//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:			Project 3 - PostFix/InFix
//	File Name:			AboutBox.Designer.cs
//	Description:		Designer class for InFixToPostFixForm Class
//	Course:				CSCI 2210-001 - Data Structures
//	Author:				Justin Adams, adamsjl3@etsu.edu, UndergradeCS, East Tennessee State University
//	Created:			Friday, October 27, 2017
//	Copyright:			Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project3
{
	/// <summary>
	/// Designer for InFixToPostFix Form
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	partial class InFixToPostFixForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InFixToPostFixForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inputInfixDataHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutInfixToPostfixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.InfixTextBox = new System.Windows.Forms.TextBox();
			this.InfixLabel = new System.Windows.Forms.Label();
			this.PostfixLabel = new System.Windows.Forms.Label();
			this.PostfixTextBox = new System.Windows.Forms.TextBox();
			this.PostfixGenButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.FileListBox = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(534, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputInfixDataHereToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// inputInfixDataHereToolStripMenuItem
			// 
			this.inputInfixDataHereToolStripMenuItem.Name = "inputInfixDataHereToolStripMenuItem";
			this.inputInfixDataHereToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.inputInfixDataHereToolStripMenuItem.Text = "Input Infix Data Here";
			this.inputInfixDataHereToolStripMenuItem.Click += new System.EventHandler(this.inputInfixDataHereToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutInfixToPostfixToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutInfixToPostfixToolStripMenuItem
			// 
			this.aboutInfixToPostfixToolStripMenuItem.Name = "aboutInfixToPostfixToolStripMenuItem";
			this.aboutInfixToPostfixToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.aboutInfixToPostfixToolStripMenuItem.Text = "About Infix to Postfix";
			this.aboutInfixToPostfixToolStripMenuItem.Click += new System.EventHandler(this.aboutInfixToPostfixToolStripMenuItem_Click);
			// 
			// InfixTextBox
			// 
			this.InfixTextBox.Location = new System.Drawing.Point(128, 177);
			this.InfixTextBox.Name = "InfixTextBox";
			this.InfixTextBox.Size = new System.Drawing.Size(367, 20);
			this.InfixTextBox.TabIndex = 1;
			// 
			// InfixLabel
			// 
			this.InfixLabel.AutoSize = true;
			this.InfixLabel.Location = new System.Drawing.Point(30, 177);
			this.InfixLabel.Name = "InfixLabel";
			this.InfixLabel.Size = new System.Drawing.Size(80, 13);
			this.InfixLabel.TabIndex = 2;
			this.InfixLabel.Text = "Infix Expression";
			// 
			// PostfixLabel
			// 
			this.PostfixLabel.AllowDrop = true;
			this.PostfixLabel.AutoSize = true;
			this.PostfixLabel.Location = new System.Drawing.Point(30, 203);
			this.PostfixLabel.Name = "PostfixLabel";
			this.PostfixLabel.Size = new System.Drawing.Size(92, 13);
			this.PostfixLabel.TabIndex = 3;
			this.PostfixLabel.Text = "Postfix Expression";
			// 
			// PostfixTextBox
			// 
			this.PostfixTextBox.Location = new System.Drawing.Point(128, 203);
			this.PostfixTextBox.Name = "PostfixTextBox";
			this.PostfixTextBox.Size = new System.Drawing.Size(367, 20);
			this.PostfixTextBox.TabIndex = 4;
			// 
			// PostfixGenButton
			// 
			this.PostfixGenButton.Location = new System.Drawing.Point(4, 14);
			this.PostfixGenButton.Name = "PostfixGenButton";
			this.PostfixGenButton.Size = new System.Drawing.Size(102, 23);
			this.PostfixGenButton.TabIndex = 5;
			this.PostfixGenButton.Text = "Generate Postfix";
			this.PostfixGenButton.UseVisualStyleBackColor = true;
			this.PostfixGenButton.Click += new System.EventHandler(this.PostfixGenButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(214, 14);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(102, 23);
			this.ClearButton.TabIndex = 6;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(409, 14);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(102, 23);
			this.ExitButton.TabIndex = 7;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// FileListBox
			// 
			this.FileListBox.FormattingEnabled = true;
			this.FileListBox.Location = new System.Drawing.Point(8, 29);
			this.FileListBox.Name = "FileListBox";
			this.FileListBox.Size = new System.Drawing.Size(514, 134);
			this.FileListBox.TabIndex = 8;
			this.FileListBox.SelectedIndexChanged += new System.EventHandler(this.FileListBox_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ClearButton);
			this.panel1.Controls.Add(this.PostfixGenButton);
			this.panel1.Controls.Add(this.ExitButton);
			this.panel1.Location = new System.Drawing.Point(8, 229);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(514, 40);
			this.panel1.TabIndex = 9;
			// 
			// InFixToPostFixForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 281);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.FileListBox);
			this.Controls.Add(this.PostfixTextBox);
			this.Controls.Add(this.PostfixLabel);
			this.Controls.Add(this.InfixLabel);
			this.Controls.Add(this.InfixTextBox);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "InFixToPostFixForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InFixToPostFixForm_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}//End InitializeComponent ( )

		#endregion

		#region Properties
		/// <summary>
		/// The menu strip
		/// </summary>
		private System.Windows.Forms.MenuStrip menuStrip1;
		/// <summary>
		/// The file tool strip menu item
		/// </summary>
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		/// <summary>
		/// The input infix data here tool strip menu item
		/// </summary>
		private System.Windows.Forms.ToolStripMenuItem inputInfixDataHereToolStripMenuItem;
		/// <summary>
		/// The exit tool strip menu item
		/// </summary>
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		/// <summary>
		/// The help tool strip menu item
		/// </summary>
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		/// <summary>
		/// The about infix to postfix tool strip menu item
		/// </summary>
		private System.Windows.Forms.ToolStripMenuItem aboutInfixToPostfixToolStripMenuItem;
		/// <summary>
		/// The infix text box
		/// </summary>
		private System.Windows.Forms.TextBox InfixTextBox;
		/// <summary>
		/// The infix label
		/// </summary>
		private System.Windows.Forms.Label InfixLabel;
		/// <summary>
		/// The postfix label
		/// </summary>
		private System.Windows.Forms.Label PostfixLabel;
		/// <summary>
		/// The postfix text box
		/// </summary>
		private System.Windows.Forms.TextBox PostfixTextBox;
		/// <summary>
		/// The postfix gen button
		/// </summary>
		private System.Windows.Forms.Button PostfixGenButton;
		/// <summary>
		/// The clear button
		/// </summary>
		private System.Windows.Forms.Button ClearButton;
		/// <summary>
		/// The exit button
		/// </summary>
		private System.Windows.Forms.Button ExitButton;
		/// <summary>
		/// The file ListBox
		/// </summary>
		private System.Windows.Forms.ListBox FileListBox;
		/// <summary>
		/// The panel1
		/// </summary>
		private System.Windows.Forms.Panel panel1;
		#endregion

	}//End InFixToPostFixForm
}//End Project3

