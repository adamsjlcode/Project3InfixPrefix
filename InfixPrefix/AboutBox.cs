//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:			Project 3 - PostFix/InFix
//	File Name:			AboutBox.cs
//	Description:		AboutBox for Project Three
//	Course:				CSCI 2210-001 - Data Structures
//	Author:				Justin Adams, adamsjl3@etsu.edu, UndergradeCS, East Tennessee State University
//	Created:			Thursday, October 27, 2017
//	Copyright:			Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
	/// <summary>
	/// About Product Page
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	partial class AboutBox : Form
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="AboutBox"/> class.
		/// </summary>
		public AboutBox ( )
		{
			InitializeComponent ( );
			this.Text = String.Format ("About {0}", AssemblyTitle);
			this.labelProductName.Text = AssemblyProduct;
			this.labelVersion.Text = String.Format ("Version {0}", AssemblyVersion);
			this.labelCopyright.Text = AssemblyCopyright;
			this.labelCompanyName.Text = AssemblyCompany;
			this.textBoxDescription.Text = AssemblyDescription;
		}//End AboutBox ( ) 
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
		/// Gets the assembly version.
		/// </summary>
		/// <value>
		/// The assembly version.
		/// </value>
		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly ( ).GetName ( ).Version.ToString ( );
			}//End get
		}//End AssemblyVersion

		/// <summary>
		/// Gets the assembly description.
		/// </summary>
		/// <value>
		/// The assembly description.
		/// </value>
		public string AssemblyDescription
		{
			get
			{
				object [ ] attributes = Assembly.GetExecutingAssembly ( ).GetCustomAttributes (typeof (AssemblyDescriptionAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}//End if-statement
				return ((AssemblyDescriptionAttribute) attributes [0]).Description;
			}//End get
		}//End AssemblyDescription

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
		/// Gets the assembly copyright.
		/// </summary>
		/// <value>
		/// The assembly copyright.
		/// </value>
		public string AssemblyCopyright
		{
			get
			{
				object [ ] attributes = Assembly.GetExecutingAssembly ( ).GetCustomAttributes (typeof (AssemblyCopyrightAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}//End if-statement
				return ((AssemblyCopyrightAttribute) attributes [0]).Copyright;
			}//End get
		}//End AssemblyCopyright

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

		#region EventAction
		/// <summary>
		/// Handles the Click event of the okButton control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void okButton_Click (object sender, EventArgs e)
		{
			this.Dispose ( );
			return;
		}//End okButton_Click (object, EventArgs)

		/// <summary>
		/// Handles the FormClosed event of the AboutBox control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
		private void AboutBox_FormClosed (object sender, FormClosedEventArgs e)
		{
			this.Dispose ( );
			return;
		}//End AboutBox_FormClosed (object, FormClosedEventArgs)
		#endregion

	}//End AboutBox

}//End Project3
