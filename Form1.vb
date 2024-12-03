Imports System.CodeDom

Public Class Form1
    Dim x As Integer
    Dim res As String
    Dim v As Boolean

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LB1.Click

    End Sub

    Private Sub BTN_Click(sender As Object, e As EventArgs) Handles BTN.Click
        v = True
        If CMB.Text = "" Then
            v = False
        Else
            res = "la taille choisit est :  " + CMB.Text + " Le type de Croute est : "
        End If


        If RB1.Checked Then
            res += RB1.Text
        ElseIf RB2.Checked Then
            res += RB2.Text
        ElseIf RB3.Checked Then
            res += RB3.Text
        Else
            v = False
        End If
        res += vbNewLine + " et les ingredients sont: "
        If CB1.Checked Then
            res += CB1.Text + " ,"
        End If
        If CB2.Checked Then
            res += CB2.Text + " ,"
        End If
        If CB3.Checked Then
            res += CB3.Text + " ,"
        End If
        If CB4.Checked Then
            res += CB4.Text + " ,"
        End If
        If v Then
            res = res.Substring(0, res.Length - 1)
            LBL2.Text = res
        Else
            MessageBox.Show("completer le formulaire")
        End If



    End Sub

    Private Sub CMB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB.SelectedIndexChanged

    End Sub
End Class
