//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:			Project 3 - PostFix/InFix
//	File Name:			SplashScreen.cs
//	Description:		Project 3 Splash Screen
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
	/// <summary>
	/// Splash Screen Initializer
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class SplashScreen : Form
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="SplashScreen"/> class.
		/// </summary>
		public SplashScreen ( )
		{
			InitializeComponent ( );
			labelName.Text = AssemblyCompany;
			labelProject.Text = AssemblyProduct;
			labelProjectName.Text = AssemblyTitle;
		}//End SplashScreen ( )
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

	}//End SplashScreen
}//End Project3
