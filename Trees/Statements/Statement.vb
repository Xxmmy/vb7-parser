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
''' A parse tree for a statement.
''' </summary>
Public MustInherit Class Statement
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

    Protected Sub New(ByVal type As TreeType, ByVal span As Span, ByVal comments As CommentCollection)
        MyBase.New(type, span)

        Debug.Assert(type >= TreeType.EmptyStatement AndAlso type <= TreeType.EndBlockStatement)

        _Comments = comments
    End Sub
End Class