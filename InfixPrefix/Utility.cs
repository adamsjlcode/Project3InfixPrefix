//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:			Project 3 - PostFix/InFix
//	File Name:			Utility.cs
//	Description:		Utility class for Project Three
//	Course:				CSCI 2210-001 - Data Structures
//	Author:				Justin Adams, adamsjl3@etsu.edu, Undergrad CS, East Tennessee State University
//	Created:			Friday, October 27, 2017
//	Copyright:			Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
	/// <summary>
	/// Utilities for program
	/// </summary>
	public static class Utility
	{
		#region Methods
		/// <summary>
		/// Tokenizers the specified line.
		/// </summary>
		/// <param name="line">The line.</param>
		/// <param name="delims">The delims.</param>
		/// <returns>List of token string</returns>
		/// <exception cref="Exception">Invalid Input</exception>
		public static List<string> Tokenizer (string line, string delims)
		{
			List<string> Tokens = new List<string> ( );     //List of tokens
			string badInput = "<>?;:\"\'|{}_&^%$#@!~`";     //List of invalid tokens
			string token = "";								//Temporary Token Holder
			int Position = 0;
			if (line.IndexOfAny (badInput.ToCharArray ( )) > -1)
			{
				throw new Exception ("Invalid Input");
			}//End if statement
			while (line.Length != 0)
			{
				//Remove leading whitespace
				if (line.StartsWith (" "))
				{
					line = line.TrimStart (' ');
				}//End if statement
				Position = line.IndexOfAny (delims.ToCharArray ( ));
				//Check if line is empty
				if (Position == -1)
				{
					Tokens.Add (line);
					break;
				}
				//Check string position is whitespace
				if (line [Position].Equals (' '))
				{

					token = line.Substring (0, Position);
					//Remove section of string  
					line = line.Remove (0, Tokens.Count);
					//Remove leading whitespaces
					line = line.TrimStart (' ');
					//Add token to list
					Tokens.Add (token);
				}//End if statement
				 //Check if delimiter is in the starting position
				else if (Position == 0)
				{
					//Add delimiter to list
					Tokens.Add (line [0].ToString ( ));
					line = line.Remove (0, 1);
				}//End else if statement
				 //Delimiter in the middle of words
				else
				{
					token = line.Substring (0, Position);
					//Add both tokens to list
					Tokens.Add (token);
					Tokens.Add (line [Position].ToString ( ));
					//Remove section of string plus next delimiter
					line = line.Remove (0, Position + 1);
				}//End else statement
			}//End while loop												
			return Tokens;
		}//End Tokenizer (string)
		/// <summary>
		/// Loads the data file.
		/// </summary>
		/// <param name="path">The path.</param>
		public static List<string> LoadDataFile (string path)
		{
			List<string> fileData = new List<string> ( );
			StreamReader fileReader = null;
			try
			{
				fileReader = new StreamReader (path);
				while (fileReader.Peek ( ) != -1)
				{
					try
					{
						fileData.Add(fileReader.ReadLine ( ));
					}//End try-statement
					catch (IndexOutOfRangeException e)
					{
						throw new Exception ("Invalid Data\nPlease Check File");
					}//End else-statement
				}//End while loop
			}//End try-statement
			catch (Exception e)
			{
				throw new Exception ("Invalid Selection");
			}
			finally
			{
				if (fileReader != null)
				{
					fileReader.Close ( );
				}//End if statement
			}//End finally-statement
			return fileData;
		}//End LoadDataFile (string)
		/// <summary>
		/// Gets the file path.
		/// </summary>
		/// <param name="choice">The choice.</param>
		/// <returns>Path to file</returns>
		public static string GetPath (string title, int choice)
		{
			Stream stream = null;	//Holder of stream object
			string path = "";       //Holder of path location
			//Switch on ether user needs to save or read file
			switch (choice)
			{
				case 0://Check Open path
					OpenFileDialog OpenFile = new OpenFileDialog ( );
					OpenFile.Title = title;
					OpenFile.InitialDirectory = Environment.CurrentDirectory ;
					OpenFile.InitialDirectory = @"..";
					//I used this from the slide but it won't work
					//Directory:\Project3\Project3\bin\Debug\..(parent)\..(parent)\
					//I'm in Project3 \TextFiles ??
					//OpenFile.InitialDirectory = Application.StartupPath + @"..\..\TextFiles";
					//OpenFile.InitialDirectory = Environment.CurrentDirectory;
					//OpenFile.InitialDirectory = @"..\..\TextFiles";
					OpenFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
					if (OpenFile.ShowDialog ( ) == DialogResult.OK)
					{
						try
						{
							if ((stream = OpenFile.OpenFile ( )) != null)
							{
								path = OpenFile.FileName;
							}//End if statement
						}//End try statement
						catch (Exception ex)
						{
							MessageBox.Show ("Error: Could not read file from disk. Original error: " + ex.Message);
						}//End catch statement
						finally
						{
							stream.Close ( );
						}//End finally-statement
					}//End try statement
					break;
				case 1://Check Save path
					SaveFileDialog SaveFile = new SaveFileDialog ( );
					SaveFile.Title = title;
					SaveFile.InitialDirectory = Application.StartupPath + @"..\..\TextFiles";
					SaveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
					if (SaveFile.ShowDialog ( ) == DialogResult.OK)
					{
						try
						{
							if ((stream = SaveFile.OpenFile ( )) != null)
							{
								path = SaveFile.FileName;
							}//End if statement
						}//End try statement
						catch (Exception ex)
						{
							MessageBox.Show ("Error: Could not read file from disk. Original error: " + ex.Message);
						}//End catch statement
						finally
						{
							stream.Close ( );
						}//End finally-statement
					}//End try statement
					break;
				default:
					break;
			}//End switch statement
			return path;
		}//End GetPath (int)
		 /// <summary>
		 /// Welcome message.
		 /// </summary>
		 /// <param name="info">The information.</param>
		 /// <param name="title">The title.</param>
		public static void WelcomeMessage ( )
		{
			MessageBox.Show ("This Program converts infix expression into postfix expression by" +
				" a file or by a text box \nEnjoy" , "Welcome Message");
		}//End WelcomeMessage ( )
		 /// <summary>
		 /// Exit message.
		 /// </summary>
		 /// <param name="info">The information.</param>
		 /// <param name="title">The title.</param>
		public static void ExitMessage ( )
		{
			MessageBox.Show ("Thank you, for using this program if you have any questions.\n" +
									"\nPlease contact me at:\n\n" +
									"Justin Adams\n" +
									"Adamsjl3@etsu.edu\n" +
									"CSCI 2210\n", "Thank you");
		}//End WelcomeMessage ( )
		#endregion

	}//End Utility
}//Project 3
