'
' Created by SharpDevelop.
' User: 2143336
' Date: 2024-05-13
' Time: 12:00
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Option Explicit On
Partial Public Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()

		'
		' TODO : Add constructor code after InitializeComponents
		'
		Randomize()

		Me.change_name_team1(My.Settings.Default.EquipeDefauxIndexTeam1)
		Me.change_name_team2(My.Settings.Default.EquipeDefauxIndexTeam2)


	End Sub

	Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
		Me.Hide()

		F1.change_name_team1()
		F1.change_name_team2()
		F1.change_img_team1()
		F1.change_img_team2()
		F1.Show()

	End Sub

	Private Sub Team1SelectCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Team1SelectCB.SelectedIndexChanged

		T1name = Team1SelectCB.Items(Team1SelectCB.SelectedIndex)
		My.Settings.Default.EquipeDefauxIndexTeam1 = Team1SelectCB.SelectedIndex
		Team1.Text = T1name
		If Not (IsNothing(T2name)) Then
			If (T2name = T1name) Then
				Me.random_name_team2()
			End If
		End If
		If My.Computer.FileSystem.GetFiles(My.Application.Info.DirectoryPath & "\imageÉquipe\").Contains(My.Application.Info.DirectoryPath & "\imageÉquipe\" & T1name & ".png") Then
			T1img = Image.FromFile(My.Application.Info.DirectoryPath & "\imageÉquipe\" & T1name & ".png")
		Else

		End If
	End Sub

	Private Sub Team2SelectCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Team2SelectCB.SelectedIndexChanged
		T2name = Team2SelectCB.Items(Team2SelectCB.SelectedIndex)
		Team2.Text = T2name
		Me.change_name_team2(Team2SelectCB.SelectedIndex)
		If Not (IsNothing(T1name)) Then
			If (T2name = T1name) Then
				Me.random_name_team2()
			End If
		End If

		If T2name <> "" Then
			T2img = Image.FromFile(My.Application.Info.DirectoryPath & "\imageÉquipe\" & T2name & ".png")
		End If


	End Sub
	Private Sub change_name_team1(id_name As Integer)
		If (id_name > Team1SelectCB.Items.Count) Then
			Throw New ApplicationException("l'id désiré est trops élevé pour pouvoir être dans la liste des équipes possibles")
			Exit Sub
		End If
		Team1SelectCB.SelectedIndex = id_name
		T1name = Team1SelectCB.SelectedItem.ToString()
		Team1.Text = T1name
		If (T2name = T1name) Then
			Me.random_name_team1()
		End If


	End Sub
	Private Sub change_name_team2(id_name As Integer)
		If (id_name > Team2SelectCB.Items.Count) Then
			Throw New ApplicationException("l'id désiré est trops élevé pour pouvoir être dans la liste des équipes possibles")
			Exit Sub
		End If
		Team2SelectCB.SelectedIndex = id_name
		T2name = Team2SelectCB.SelectedItem.ToString()
		Team2.Text = T2name
		If (T2name = T1name) Then
			Me.random_name_team1()
		End If

	End Sub
	Private Sub random_name_team1()
		Me.change_name_team1(Int(Rnd() * Team1SelectCB.Items.Count))
	End Sub
	Private Sub random_name_team2()
		Me.change_name_team2(Int(Rnd() * Team2SelectCB.Items.Count))
	End Sub


End Class
