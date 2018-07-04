//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:			Project 3 - PostFix/InFix
//	File Name:			InFixToPostFixDriver.cs
//	Description:		Driver for Project 3 Runs InFixToPostFixForm
//	Course:				CSCI 2210-001 - Data Structures
//	Author:				Justin Adams, adamsjl3@etsu.edu, UndergradeCS, East Tennessee State University
//	Created:			Friday, October 27, 2017
//	Copyright:			Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
	/// <summary>
	/// Driver Program for Project 3 Converting Infix to Postfix
	/// </summary>
	public static class InFixToPostFixDriver
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main ( )
		{
			Utility.WelcomeMessage ( );
			Application.EnableVisualStyles ( );
			Application.SetCompatibleTextRenderingDefault (false);
			Application.Run (new InFixToPostFixForm ( ));
		}//End Main ( )
	}//End InFixToPostFixDriver 
}//End Project3
