//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:			Project 3 - PostFix/InFix
//	File Name:			InFixToPostFixForm.cs
//	Description:		Main Screen for Project3 
//	Course:				CSCI 2210-001 - Data Structures
//	Author:				Justin Adams, adamsjl3@etsu.edu, Undergrad CS, East Tennessee State University
//	Created:			Friday, October 27, 2017
//	Copyright:			Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
	/// <summary>
	/// Main Screen for Project3 user creates postfix expression from infix expression
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class InFixToPostFixForm : Form
	{
		#region Properties
		/// <summary>
		/// The file data
		/// </summary>
		public List<string> FileData = new List<string> ( );
		/// <summary>
		/// The post fix's
		/// </summary>
		public List<PostFix> PostFixs = new List<Project3.PostFix> ( );
		/// <summary>
		/// The post fix
		/// </summary>
		public PostFix PostFix = new PostFix ( );
		/// <summary>
		/// Gets or sets the file path.
		/// </summary>
		/// <value>
		/// The file path.
		/// </value>
		public string FilePath { get; set; }//End FilePath
		/// <summary>
		/// The open file title
		/// </summary>
		string OpenFileTitle = "Select A Text File To Analyze";
		#endregion

		#region Initialize Components/Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="InFixToPostFixForm"/> class.
		/// </summary>
		public InFixToPostFixForm ( )
		{
			Thread thread = new Thread (new ThreadStart (SplashStartPage));
			thread.Start ( );
			Thread.Sleep (5000);
			thread.Abort ( );
			InitializeComponent ( );
			this.Text = AssemblyProduct + " " +AssemblyTitle + ", " + AssemblyCompany;

		}//End InFixToPostFixForm ( )
		 /// <summary>
		 /// Splashes the start page.
		 /// </summary>
		public void SplashStartPage ( )
		{
			Application.Run (new SplashScreen());
		}//End SplashStartPage ( )
		#endregion

		#region Assembly Attribute Accessors

		/// <summary>
		/// Gets the assembly title.
		/// </summary>
		/// <value>
		/// The assembly title.
		/// </value>
		public string AssemblyTitle
		{
			get
			{
				object [ ] attributes = Assembly.GetExecutingAssembly ( ).GetCustomAttributes (typeof (AssemblyTitleAttribute), false);
				if (attributes.Length > 0)
				{
					AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute) attributes [0];
					if (titleAttribute.Title != "")
					{
						return titleAttribute.Title;
					}//End if-statement
				}//End if-statement
				return System.IO.Path.GetFileNameWithoutExtension (Assembly.GetExecutingAssembly ( ).CodeBase);
			}//End get
		}//End AssemblyTitle

		/// <summary>
		/// Gets the assembly product.
		/// </summary>
		/// <value>
		/// The assembly product.
		/// </value>
		public string AssemblyProduct
		{
			get
			{
				object [ ] attributes = Assembly.GetExecutingAssembly ( ).GetCustomAttributes (typeof (AssemblyProductAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}//End if-statement
				return ((AssemblyProductAttribute) attributes [0]).Product;
			}//End get
		}//End AssemblyProduct

		/// <summary>
		/// Gets the assembly company.
		/// </summary>
		/// <value>
		/// The assembly company.
		/// </value>
		public string AssemblyCompany
		{
			get
			{
				object [ ] attributes = Assembly.GetExecutingAssembly ( ).GetCustomAttributes (typeof (AssemblyCompanyAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}//End if-statement
				return ((AssemblyCompanyAttribute) attributes [0]).Company;
			}//End get
		}//End AssemblyCompany
		#endregion

		#region ClickEvents
		/// <summary>
		/// Handles the Click event of the aboutInfixToPostfixToolStripMenuItem control Displaying AboutBox.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void aboutInfixToPostfixToolStripMenuItem_Click (object sender, EventArgs e)
		{
			AboutBox aboutBox = new AboutBox ( );
			aboutBox.Show ( );
		}//End aboutInfixToPostfixToolStripMenuItem_Click (object, EventArg)

		/// <summary>
		/// Handles the Click event of the inputInfixDataHereToolStripMenuItem control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void inputInfixDataHereToolStripMenuItem_Click (object sender, EventArgs e)
		{
			try
			{
				FilePath = Utility.GetPath (OpenFileTitle, 0);
				FileData = Utility.LoadDataFile (FilePath);
			}//End try-statement
			catch (Exception r)
			{
				MessageBox.Show (r.Message);
			}//End catch-statement
			for (int i = 0 ; i < FileData.Count ; i++)
			{
				PostFix = new PostFix (FileData [i]);
				PostFixs.Add (PostFix);
			}//end for loop

			foreach (PostFix data in PostFixs)
			{
				FileListBox.Items.Add(data.InfixExpression);
			}//end for-each loop
		}//End inputInfixDataHereToolStripMenuItem_Click (object, EventArgs)
		 /// <summary>
		 /// Handles the Click event of the exitToolStripMenuItem control.
		 /// </summary>
		 /// <param name="sender">The source of the event.</param>
		 /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void exitToolStripMenuItem_Click (object sender, EventArgs e)
		{
			Application.Exit ( );
		}//End exitToolStripMenuItem_Click (object, EventArgs)
		
		/// <summary>
		 /// Handles the Click event of the PostfixGenButton control.
		 /// </summary>
		 /// <param name="sender">The source of the event.</param>
		 /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void PostfixGenButton_Click (object sender, EventArgs e)
		{
			if (InfixTextBox.Text != String.Empty)
			{
				PostFix = new PostFix (InfixTextBox.Text);
				FileListBox.Items.Add (PostFix.InfixExpression);
				PostfixTextBox.Text = PostFix.PostFixExpession;
				PostFixs.Add (PostFix);
			}//End if statement
			else
			{
				MessageBox.Show ("Infix box empty");
			}//End else statement
		}//End PostfixGenButton_Click (object, EventArgs)

		/// <summary>
		/// Handles the Click event of the ClearButton control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ClearButton_Click (object sender, EventArgs e)
		{
			InfixTextBox.Text = ""; 
			PostfixTextBox.Text = "";
		}//End ClearButton_Click (object, EventArgs)

		/// <summary>
		/// Handles the Click event of the ExitButton control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ExitButton_Click (object sender, EventArgs e)
		{
			Application.Exit ( );
		}//End ExitButton_Click (object, EventArgs)
		
		/// <summary>
		/// Handles the FormClosing event of the InFixToPostFixForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
		private void InFixToPostFixForm_FormClosing (object sender, FormClosingEventArgs e)
		{
			Utility.ExitMessage ( );
		}//End InFixToPostFixForm_FormClosing (object, FormClosingEventArgs)
		
		/// <summary>
		/// Handles the SelectedIndexChanged event of the FileListBox control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void FileListBox_SelectedIndexChanged (object sender, EventArgs e)
		{
			int loc = FileListBox.SelectedIndex;
			InfixTextBox.Text = PostFixs [loc].InfixExpression;
			PostfixTextBox.Text = PostFixs [loc].PostFixExpession;
		}//End FileListBox_SelectedIndexChanged (object, EventArgs)
		#endregion

	}//End InFixToPostFixForm
}//End Project3
