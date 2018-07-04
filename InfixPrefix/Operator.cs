//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:			Project 3 - PostFix/InFix
//	File Name:			Operator.cs
//	Description:		Operator Class to hold math operators
//	Course:				CSCI 2210-001 - Data Structures
//	Author:				Justin Adams, adamsjl3@etsu.edu, UndergradeCS, East Tennessee State University
//	Created:			Friday, October 27, 2017
//	Copyright:			Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{

	/// <summary>
	/// Hold Math operator and priority of operator to use in a Stack Class
	/// </summary>
	public class Operator
	{
		#region Properties
		/// <summary>
		/// Gets or sets the op.
		/// </summary>
		/// <value>
		/// The op.
		/// </value>
		public string Op { get; set; }//End Op
		/// <summary>
		/// Gets or sets the precedence.
		/// </summary>
		/// <value>
		/// The precedence.
		/// </value>
		public int Precedence { get; set; }//End Precedence
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="Operator"/> class.
		/// </summary>
		public Operator ( )
		{

		}//End Operator ( )
		 /// <summary>
		 /// Initializes a new instance of the <see cref="Operator"/> class.
		 /// </summary>
		 /// <param name="op">The op.</param>
		public Operator (string op)
		{
			Op = op;
		}//End Operator (string)
		#endregion

		#region Methods
		/// <summary>
		/// Implements the operator &lt;.
		/// </summary>
		/// <param name="lhs">The LHS.</param>
		/// <param name="rhs">The RHS.</param>
		/// <returns>
		/// The result of the operator.
		/// </returns>
		public static bool operator < (Operator lhs, Operator rhs)
		{
			bool status = false;

			if (lhs.Precedence < rhs.Precedence)
			{
				status = true;
			}//End if-statement
			return status;
		}//End operator < (Operator, Operator)

		/// <summary>
		/// Implements the operator &gt;.
		/// </summary>
		/// <param name="lhs">The LHS.</param>
		/// <param name="rhs">The RHS.</param>
		/// <returns>
		/// The result of the operator.
		/// </returns>
		public static bool operator > (Operator lhs, Operator rhs)
		{
			bool status = false;

			if (lhs.Precedence > rhs.Precedence)
			{
				status = true;
			}//End if-statement
			return status;
		}//End operator > (Operator, Operator)
		#endregion

	}//End Operator
}//End Project3
