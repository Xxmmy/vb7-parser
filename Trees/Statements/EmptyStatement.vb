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
''' A parse tree for an empty statement.
''' </summary>
Public NotInheritable Class EmptyStatement
    Inherits Statement

    ''' <summary>
    ''' Constructs a new parse tree for an empty statement.
    ''' </summary>
    ''' <param name="span">The location of the parse tree.</param>
    ''' <param name="comments">The comments for the parse tree.</param>
    Public Sub New(ByVal span As Span, ByVal comments As CommentCollection)
        MyBase.New(TreeType.EmptyStatement, span, comments)
    End Sub
End Class