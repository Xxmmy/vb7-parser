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
''' A parse tree for a RemoveHandler statement.
''' </summary>
Public NotInheritable Class RemoveHandlerStatement
    Inherits HandlerStatement

    ''' <summary>
    ''' Constructs a new parse tree for a RemoveHandler statement.
    ''' </summary>
    ''' <param name="name">The name of the event.</param>
    ''' <param name="commaLocation">The location of the ','.</param>
    ''' <param name="delegateExpression">The delegate expression.</param>
    ''' <param name="span">The location of the parse tree.</param>
    ''' <param name="comments">The comments for the parse tree.</param>
    Public Sub New(ByVal name As Expression, ByVal commaLocation As Location, ByVal delegateExpression As Expression, ByVal span As Span, ByVal comments As CommentCollection)
        MyBase.New(TreeType.RemoveHandlerStatement, name, commaLocation, delegateExpression, span, comments)
    End Sub
End Class