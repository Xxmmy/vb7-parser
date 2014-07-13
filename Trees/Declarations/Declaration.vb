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
''' A parse tree for a declaration.
''' </summary>
Public Class Declaration
    Inherits Tree

    Private ReadOnly _Comments As CommentCollection

    ''' <summary>
    ''' The comments for the tree.
    ''' </summary>
    Public ReadOnly Property Comments() As CommentCollection
        Get
            Return _Comments
        End Get
    End Property

    ''' <summary>
    ''' Creates a bad declaration.
    ''' </summary>
    ''' <param name="span">The location of the parse tree.</param>
    ''' <param name="comments">The comments for the parse tree.</param>
    ''' <returns>A bad declaration.</returns>
    Public Shared Function GetBadDeclaration(ByVal span As Span, ByVal comments As CommentCollection) As Declaration
        Return New Declaration(span, comments)
    End Function

    Protected Sub New(ByVal type As TreeType, ByVal span As Span, ByVal comments As CommentCollection)
        MyBase.New(type, span)

        Debug.Assert(type >= TreeType.EmptyDeclaration AndAlso type <= TreeType.DelegateFunctionDeclaration)

        _Comments = comments
    End Sub

    Private Sub New(ByVal span As Span, ByVal comments As CommentCollection)
        MyBase.New(TreeType.SyntaxError, span)

        _Comments = comments
    End Sub

    Public Overrides ReadOnly Property IsBad() As Boolean
        Get
            Return Type = TreeType.SyntaxError
        End Get
    End Property
End Class