'
' Visual Basic .NET Parser
'
' Copyright (C) 2004, Microsoft Corporation. All rights reserved.
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER 
' EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF 
' MERCHANTIBILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
'

''' <summary>
''' A parse tree for a CType expression.
''' </summary>
Public NotInheritable Class CTypeExpression
    Inherits CastTypeExpression

    ''' <summary>
    ''' Constructs a new parse tree for a CType expression.
    ''' </summary>
    ''' <param name="leftParenthesisLocation">The location of the '('.</param>
    ''' <param name="operand">The expression to be converted.</param>
    ''' <param name="commaLocation">The location of the ','.</param>
    ''' <param name="target">The target type of the conversion.</param>
    ''' <param name="rightParenthesisLocation">The location of the ')'.</param>
    ''' <param name="span">The location of the parse tree.</param>
    Public Sub New(ByVal leftParenthesisLocation As Location, ByVal operand As Expression, ByVal commaLocation As Location, ByVal target As TypeName, ByVal rightParenthesisLocation As Location, ByVal span As Span)
        MyBase.New(TreeType.CTypeExpression, leftParenthesisLocation, operand, commaLocation, target, rightParenthesisLocation, span)
    End Sub
End Class