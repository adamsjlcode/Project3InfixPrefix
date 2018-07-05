# Project 3 Infix to Prefix
![Infix Prefix Logo](http://justinadamsportfolio.com/wp-content/uploads/2018/05/AboutBoxImage.jpg)
## Propose
The purpose of this assignment is to get some experience with stacks and the .NET Stack<T> class.  This is done in the context of parsing arithmetic expressions.
## Infix
Infix notation is the standard notation used for arithmetic expressions in C#.  For example, to add operands X and Y, the binary operator (+) is placed between the operands as in X + Y.  Rules of precedence are applied to determine in what order an expression with a series of operations such as A + B – C * D / E is evaluated.
Parentheses are used to override these rules when the rules of precedence result in the operations being done in an order that is not intended.  For example, (A + B – C) * (D / E) would have a different calculated result than A + B – C * D / E which would be evaluated as A + (B – (C * D) / E).
## Postfix
Postfix notation is an alternative notation that is unambiguous and never requires parentheses.  In postfix notation, a binary operator (such as multiplication or subtraction) follows the two operands on which it operates.
For example, the infix expression X + Y is rewritten in postfix notation as X Y +.  Some calculators are designed to use this form.
When evaluating a postfix expression, read it from left to right.  The first operator is applied to the two immediately preceding operands, and the result replaces the two operands and the operator.  The process is repeated until there are no more operators.
For example, the postfix expression 5  6  7  8  +  -  *  9  -  evaluates as follows

| Expression  |  Operation |
| --  |  -- |
| 5 6 7 8 + - * 9 -  |  First apply + to 7 8 yielding 15 which replaces those 3 items.  The resulting expression is 5 6 1 5 - * 9 -. |
|  5 6 1 5 - * 9 - |  Next apply - to 6 1 5 yielding - 9.  The new expression is 5 - 9 * 9 - |
|  5  - 9  *  9  -  |  Third, apply the * to 5 and -9 yielding -4 5.  The new expression is - 4 5 9 - |
|  -4 5 9 -  |  Last, apply the final - to - 4 5 and 9 to get - 5 4  This is the result. |

Note that the character “-” appears as both a negative sign (unary operator) and as a subtraction (binary) operator.  Only the binary operators are processed for our purposes here.
