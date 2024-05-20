'
' Created by SharpDevelop.
' User: 2143336
' Date: 2024-05-13
' Time: 12:00
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()

		'
		' TODO : Add constructor code after InitializeComponents
		'
		Randomize()
		random_name_team1()
		random_name_team2()

	End Sub

	Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
		Me.Hide()

		F1.change_name_team1()
		F1.change_name_team2()
		F1.Show()

	End Sub

	Private Sub Team1SelectCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Team1SelectCB.SelectedIndexChanged

		T1name = Team1SelectCB.Items(Team1SelectCB.SelectedIndex)
		Team1.Text = T1name
		If Not (IsNothing(T2name)) Then
			If (T2name = T1name) Then
				Me.random_name_team2()
			End If
		End If
	End Sub

	Private Sub Team2SelectCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Team2SelectCB.SelectedIndexChanged
		T2name = Team2SelectCB.SelectedText
		Team2.Text = T2name

		If Not (IsNothing(T1name)) Then
			If (T2name = T1name) Then
				Me.random_name_team2()
			End If
		End If

	End Sub
	Private Sub random_name_team1()
		Team1SelectCB.SelectedIndex = Int(Rnd() * Team1SelectCB.Items.Count)
		T1name = Team1SelectCB.SelectedItem.ToString()
		Team1.Text = T1name
		If (T2name = T1name) Then
			Me.random_name_team1()
		End If
	End Sub
	Private Sub random_name_team2()
		Team2SelectCB.SelectedIndex = Int(Rnd() * (Team2SelectCB.Items.Count - 1)) + 1
		T2name = Team2SelectCB.SelectedItem.ToString()
		Team2.Text = T2name
		If (T2name = T1name) Then
			Me.random_name_team2()
		End If
	End Sub
End Class
