//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:			Project 3 - PostFix/InFix
//	File Name:			PostFix.cs
//	Description:		Holder of PostFix and Infix expressions
//	Course:				CSCI 2210-001 - Data Structures
//	Author:				Justin Adams, adamsjl3@etsu.edu, Undergrad CS, East Tennessee State University
//	Created:			Friday, October 27, 2017
//	Copyright:			Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{

	/// <summary>
	/// Creates an object to hold infix expression and convert to postfix  
	/// </summary>
	public class PostFix
	{
		#region Properties
		/// <summary>
		/// Gets or sets the infix expression.
		/// </summary>
		/// <value>
		/// The infix expression.
		/// </value>
		public string InfixExpression { get; set; }//End InfixExpression
		/// <summary>
		/// Gets or sets the post fix expession.
		/// </summary>
		/// <value>
		/// The post fix expession.
		/// </value>
		public string PostFixExpession { get; set; }//End PostFixExpession
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="PostFix"/> class.
		/// </summary>
		public PostFix ( )
		{
		}//End PostFix ( )
		 /// <summary>
		 /// Initializes a new instance of the <see cref="PostFix"/> class.
		 /// </summary>
		 /// <param name="input">The input.</param>
		public PostFix (string input)
		{
			InfixExpression = input;

			if (ValidExpression(input))
			{
				PostFixExpession = Convert ( ); 
			}//End if statement
			else
			{
				PostFixExpession = "*** ERROR ***\t Unmatched open and close parentheses";
			}//End else statement
		}//End PostFix (string)
		#endregion

		#region Methods
		/// <summary>
		/// Converts this instance.
		/// </summary>
		/// <returns></returns>
		private string Convert ( )
		{
			string operation = @"()=-+*/";					//Math Operators
			Stack<Operator> op = new Stack<Operator> ( );   //Stack of Math Operators
			List<string> tokenStrings = new List<string> ( );			//List of Tokens
			Operator opTemp = new Operator ( );				//Temporary	Holder of Operator
			string Output = "";								//Holder of PostFix Expression
			try
			{
				tokenStrings = Utility.Tokenizer (InfixExpression, operation);
			}//End try-statement
			catch (Exception e)
			{
				PostFixExpession = ("***Error***\tInvalid Data");
				MessageBox.Show (e.Message);
			}//End catch-statement
			tokenStrings.Insert (0, "(");
			tokenStrings.Insert (tokenStrings.Count, ")");
			for (int i = 0 ; i < tokenStrings.Count ; i++)
			{
				if (tokenStrings [i].Length == 1 && tokenStrings [i].IndexOfAny (operation.ToCharArray ( )) > -1)
				{
					opTemp = new Operator (tokenStrings [i]);
					switch (tokenStrings [i])
					{
						case ")"://Highest priority
						case "(":
							opTemp.Precedence = 1;
							break;
						case "*":
						case "/":
							opTemp.Precedence = 2;
							break;
						case "+":
						case "-":
							opTemp.Precedence = 3;
							break;
						case "=": //Lowest priority
							opTemp.Precedence = 4;
							break;
						default:
							break;
					}//End switch statement
					if (op.Count <= 0)
					{
						op.Push (opTemp);
						continue;
					}//End if statement
					if (opTemp.Precedence == 1)
					{
						if (opTemp.Op.Equals ("("))
						{
							op.Push (opTemp);
						}//End if statement
						else
						{
							while (op.Peek ( ).Precedence != 1)
							{
								Output += op.Pop ( ).Op + " ";
							}//End while loop
							if (op.Peek ( ).Precedence == 1)
							{
								op.Pop ( );
							}//End if statement
						}//End else statement
					}//End if statement
					else
					{
						if (opTemp < op.Peek ( ))
						{
							op.Push (opTemp);
						}//End if statement
						else if (opTemp > op.Peek ( ))
						{
							while (opTemp > op.Peek ( )
									&& op.Peek ( ).Precedence != 1)
							{
								Output += op.Pop ( ).Op + " ";
							}//End while loop
							op.Push (opTemp);
						}//End if statement
						else
						{
							Output += op.Pop ( ).Op + " ";
							op.Push (opTemp);
						}//End else statement
					}//End else statement
				}//End if statement
				else
				{
					Output += tokenStrings [i] + " ";
				}//End else statement	
			}//end for loop
			return Output;
		}//End Convert ( )

		/// <summary>
		/// Valid the expression.
		/// </summary>
		/// <param name="line">The line.</param>
		/// <returns>If the expression has same number open/close parentheses</returns>
		public bool ValidExpression (string line)
		{
			bool status = false;
			int begin = 0;      //Left parentheses
			int end = 0;        //Right parentheses

			for (int i = 0 ; i < line.Length ; i++)
			{
				if (line [i] == '(')
				{
					begin++;
				}//End if statement
				if (line [i] == ')')
				{
					end++;
				}//End if statement	
			}//end for loop
			if (end >= begin)
			{
				status = true;
			}//End if statement
			return status;
		}//ValidExpression (string)
		#endregion

	}//End PostFix
}//End Project3
