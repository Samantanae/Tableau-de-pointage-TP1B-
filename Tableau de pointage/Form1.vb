Imports System.Linq

Public Class Form1
    Public Sub New()
        ' The Me.InitializeComponent call is required for Windows Forms designer support.
        Me.InitializeComponent()

        '
        ' TODO : Add constructor code after InitializeComponents
        '
    End Sub
    Public Sub change_name_team1()
        If L_T1vsT2.Text.StartsWith(L2T1.Text) Then
            L_T1vsT2.Text = L_T1vsT2.Text.Replace(L2T1.Text, T1name)
        Else
            L_T1vsT2.Text = L_T1vsT2.Text.Insert(0, T1name)
        End If

        L2T1.Text = T1name
        L3T1.Text = T1name
    End Sub
    Public Sub change_name_team2()
        If L_T1vsT2.Text.EndsWith(L2T1.Text) Then
            L_T1vsT2.Text = L_T1vsT2.Text.Replace(L2T1.Text, T2name)
        Else
            L_T1vsT2.Text = L_T1vsT2.Text + T2name
        End If

        L2T1.Text = T2name
        L3T1.Text = T2name
    End Sub
End Class