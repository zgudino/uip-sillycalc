Imports System.Math
Imports PC4___P13.UIP.Arithmetics

Public Class MainForm
    Dim a, b As Integer

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.a = 0
        Me.b = 0

        AddHandler TextBoxA.TextChanged, AddressOf CommonHandler
        AddHandler TextBoxB.TextChanged, AddressOf CommonHandler
    End Sub

    Private Sub CommonHandler(ByVal sender As Object, ByVal e As EventArgs)
        Select Case sender.Name
            Case "TextBoxA"
                Me.a = Val(CType(sender, TextBox).Text)
            Case "TextBoxB"
                Me.b = Val(CType(sender, TextBox).Text)
            Case Else
                Return
        End Select

        TextBoxAdd.Text = GetAddition(Me.a, Me.b).ToString
        TextBoxSub.Text = GetSubtraction(Me.a, Me.b).ToString
        TextBoxMul.Text = GetMultiplication(Me.a, Me.b).ToString
        TextBoxRDiv.Text = GetDivision(Me.a, Me.b).ToString
        TextBoxDiv.Text = Floor(GetDivision(Me.a, Me.b)).ToString
        TextBoxMod.Text = GetModulus(Me.a, Me.b).ToString
    End Sub
End Class
