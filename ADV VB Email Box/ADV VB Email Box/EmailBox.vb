Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class EmailBox
    Inherits System.Windows.Forms.TextBox

    Enum ValidationType
        Email
        URL
    End Enum

    Private _type As ValidationType
    Private _forecolor As Color

    Public Sub New()
        InitializeComponent()
        _forecolor = Me.ForeColor
    End Sub

    <DefaultValue(ValidationType.Email),
    Description("Email or URL"),
    Browsable(True),
    Category("Behavior")>
    Public Property Type As ValidationType
        Get
            Return _type
        End Get
        Set(value As ValidationType)
            _type = value
        End Set
    End Property

    Private Sub EmailBox_TextChanged(sender As Object, e As System.EventArgs) Handles Me.TextChanged
        If valid() Then
            Me.ForeColor = Me._forecolor
        Else
            If Me.ForeColor <> Color.Red Then
                Me._forecolor = Me.ForeColor
            End If
            Me.ForeColor = Color.Red
        End If
    End Sub

    Private Function valid() As Boolean
        Dim result As Boolean = False
        Dim pattern As String = "[a-zA-Z0-9]+@[A-Z0-9a-z]+\.[a-zA-Z]{2,4}"
        Dim emailAddressMatch As Match = Regex.Match(Me.Text, pattern)
        If emailAddressMatch.Success Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function
End Class
