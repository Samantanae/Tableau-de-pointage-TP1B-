Option Explicit On
Imports System.Linq
Imports System.Net.Security
Public Class Form1
    Public Sub New()
        ' The Me.InitializeComponent call is required for Windows Forms designer support.
        Me.InitializeComponent()

        '
        ' TODO : Add constructor code after InitializeComponents
        '
        TextBoxT1.Text = "0"
        TextBoxT2.Text = "0"
        LastPointT2 = "0"
        LastPointT1 = "0"
        nMatch = 0
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

        L2T2.Text = T2name
        L3T2.Text = T2name
    End Sub
    Public Sub change_img_team1()
        PB1T1.Image = T1img
        PB2T1.Image = T1img
    End Sub
    Public Sub change_img_team2()
        PB1T2.Image = T2img
        PB2T2.Image = T2img

    End Sub
    Private Function verif_not_egaliter() As Boolean
        verif_not_egaliter = Int(LTT1.Text) <> Int(LTT2.Text)
    End Function
    Public Sub change_n_manche(n_manche As Integer)
        Label20.Text = "Score de la manche no " & CStr(n_manche)
        ButtonEnregistrez.Text = "Enregistrez le score de la manche no  " & CStr(n_manche)
        If n_manche > 17 Then
            Me.fin_partie()
        ElseIf n_manche > 8 Then
            If verif_not_egaliter() Then
                fin_partie()
            End If
        End If
    End Sub
    Private Function validation_pointT2() As Boolean
        Dim r As Boolean
        If IsNumeric(TextBoxT2.Text) Then
            If -1 < Int(TextBoxT2.Text) And Int(TextBoxT2.Text) < 16 Then
                If CStr(Int(TextBoxT2.Text)) <> TextBoxT2.Text Then
                    r = False
                Else
                    r = True
                End If
            Else
                r = False
            End If
        Else
            r = False
        End If
        validation_pointT2 = r
    End Function
    Private Function validation_pointT1() As Boolean
        Dim r As Boolean
        If IsNumeric(TextBoxT1.Text) Then
            If -1 < Int(TextBoxT1.Text) And Int(TextBoxT1.Text) < 15 Then
                If CStr(Int(TextBoxT1.Text)) <> TextBoxT1.Text Then
                    r = False
                Else
                    r = True
                End If
            Else
                r = False
            End If
        Else
            r = False
        End If
        validation_pointT1 = r

    End Function
    Private Sub ButtonEnregistrez_Click(sender As Object, e As EventArgs) Handles ButtonEnregistrez.Click
        If (nMatch = 0) Then
            TextBoxTT1.Text = TextBoxT1.Text
            TextBoxTT2.Text = TextBoxT2.Text
            TextBoxTTT.Text = CStr(Int(TextBoxT1.Text) + Int(TextBoxT2.Text))
        Else
            TextBoxTT1.Text = TextBoxTT1.Text & ChrW(9) & TextBoxT1.Text
            TextBoxTT2.Text = TextBoxTT2.Text & ChrW(9) & TextBoxT2.Text
            TextBoxTTT.Text = TextBoxTTT.Text & ChrW(9) & CStr(Int(TextBoxT1.Text) + Int(TextBoxT2.Text))
        End If
        relult_T1(nMatch) = Int(TextBoxT1.Text)
        relult_T2(nMatch) = Int(TextBoxT2.Text)

        nMatch = nMatch + 1
        TextBoxT1.Text = "0"
        TextBoxT2.Text = "0"
        Me.change_n_manche(nMatch)
        TotalValT1 = Me.Sommation(relult_T1)
        TotalValT2 = Me.Sommation(relult_T2)
        LTT1.Text = CStr(TotalValT1)
        LTT2.Text = CStr(TotalValT2)


    End Sub
    Private Sub fin_partie()
        If nMatch = 17 Then
            MsgBox("La partie est terminée et c'est égalité")

        ElseIf TotalValT1 < TotalValT2 Then
            MsgBox("La partie est terminée et le gagnant est " & T2name)
        ElseIf TotalValT2 < TotalValT1 Then
            MsgBox("La partie est terminée et le gagnant est " & T1name)
        Else
            MsgBox("La partie est terminée et c'est égalité")
        End If
        End
    End Sub
    Public Function Sommation(ByRef l As Object)
        Dim i, t As Integer
        t = 0
        For Each i In l
            t = t + i
        Next
        Sommation = t
    End Function

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed

    End Sub

    Private Sub TextBoxT1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxT1.TextChanged
        Me.tbt1_verif()
    End Sub

    Private Sub TextBoxT2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxT2.TextChanged
        Me.tbt2_verif()
    End Sub
    Private Sub tbt2_verif()
        If TextBoxT2.Text <> LastPointT2 Then
            If Me.validation_pointT2() Then
                LastPointT2 = TextBoxT2.Text
            Else
                TextBoxT2.Text = LastPointT2
            End If
        End If
    End Sub
    Private Sub tbt1_verif()
        If TextBoxT1.Text <> LastPointT1 Then
            If Me.validation_pointT1() Then
                LastPointT1 = TextBoxT1.Text
            Else
                TextBoxT1.Text = LastPointT1
            End If
        End If
    End Sub
    Private Sub TextBoxT2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxT2.Validating
        Me.tbt2_verif()
    End Sub
    Private Sub TextBoxT1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxT1.Validating
        Me.tbt1_verif()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fin_partie()
    End Sub
End Class