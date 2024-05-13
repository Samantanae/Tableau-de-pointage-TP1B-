'
' Created by SharpDevelop.
' User: 2143336
' Date: 2024-05-13
' Time: 12:00
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.label1 = New System.Windows.Forms.Label()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.réglageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.changerLeLanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.m_splitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Team1SelectCB = New System.Windows.Forms.ComboBox()
		Me.Team1 = New System.Windows.Forms.Label()
		Me.Team2SelectCB = New System.Windows.Forms.ComboBox()
		Me.Team2 = New System.Windows.Forms.Label()
		Me.button1 = New System.Windows.Forms.Button()
		Me.ImgTeam1 = New System.Windows.Forms.PictureBox()
		Me.pictureBox2 = New System.Windows.Forms.PictureBox()
		Me.menuStrip1.SuspendLayout
		Me.panel1.SuspendLayout
		CType(Me.m_splitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.m_splitContainer1.Panel1.SuspendLayout
		Me.m_splitContainer1.Panel2.SuspendLayout
		Me.m_splitContainer1.SuspendLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ImgTeam1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.Dock = System.Windows.Forms.DockStyle.Top
		Me.label1.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(0, 24)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(384, 23)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Veuillez faire le choix des équipes"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'menuStrip1
		'
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.réglageToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(384, 24)
		Me.menuStrip1.TabIndex = 1
		Me.menuStrip1.Text = "menuStrip1"
		'
		'réglageToolStripMenuItem
		'
		Me.réglageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.changerLeLanguageToolStripMenuItem})
		Me.réglageToolStripMenuItem.Name = "réglageToolStripMenuItem"
		Me.réglageToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
		Me.réglageToolStripMenuItem.Text = "réglage"
		'
		'changerLeLanguageToolStripMenuItem
		'
		Me.changerLeLanguageToolStripMenuItem.Name = "changerLeLanguageToolStripMenuItem"
		Me.changerLeLanguageToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
		Me.changerLeLanguageToolStripMenuItem.Text = "changer le language"
		'
		'panel1
		'
		Me.panel1.Controls.Add(Me.m_splitContainer1)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.panel1.Location = New System.Drawing.Point(0, 47)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(384, 122)
		Me.panel1.TabIndex = 2
		'
		'm_splitContainer1
		'
		Me.m_splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.m_splitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.m_splitContainer1.Name = "m_splitContainer1"
		'
		'm_splitContainer1.Panel1
		'
		Me.m_splitContainer1.Panel1.Controls.Add(Me.ImgTeam1)
		Me.m_splitContainer1.Panel1.Controls.Add(Me.pictureBox1)
		Me.m_splitContainer1.Panel1.Controls.Add(Me.Team1SelectCB)
		Me.m_splitContainer1.Panel1.Controls.Add(Me.Team1)
		AddHandler Me.m_splitContainer1.Panel1.Paint, AddressOf Me.Panel1Paint
		'
		'm_splitContainer1.Panel2
		'
		Me.m_splitContainer1.Panel2.Controls.Add(Me.pictureBox2)
		Me.m_splitContainer1.Panel2.Controls.Add(Me.Team2SelectCB)
		Me.m_splitContainer1.Panel2.Controls.Add(Me.Team2)
		Me.m_splitContainer1.Size = New System.Drawing.Size(384, 122)
		Me.m_splitContainer1.SplitterDistance = 193
		Me.m_splitContainer1.TabIndex = 0
		'
		'pictureBox1
		'
		Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.pictureBox1.Location = New System.Drawing.Point(0, 114)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(193, 8)
		Me.pictureBox1.TabIndex = 2
		Me.pictureBox1.TabStop = false
		'
		'Team1SelectCB
		'
		Me.Team1SelectCB.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Team1SelectCB.FormattingEnabled = true
		Me.Team1SelectCB.Items.AddRange(New Object() {"Angeles de Los Angeles", "A's d'Oakland", "Astros de Houston", "Blue Jays de Toronto", "Braves d'Atlanta", "Brewers de Milwaukee", "Cardinals de Saint-Louis", "Cubs de Chicago", "Diamondbacks de l'Arizona", "Dodgers de Los Angeles", "Giants de San Francisco", "Indians de Cleveland", "Mariners de Seattle", "Marlins de Miami", "Mets de New York", "Natianals de Washington", "Orioles de Baltimore", "Padres de San Diego", "Phillies de Philadelphie", "Pirates de Pittburgs", "Rangers du Texas", "Rays de Tampa Bay", "Red Sox de Boston", "Reds de Cincinnati", "Rockies du Colorado", "Royals de Kansas City", "Tigre de Détroit", "Twins du Minnesota", "White Sox de Chicago", "Yankees de New York"})
		Me.Team1SelectCB.Location = New System.Drawing.Point(0, 23)
		Me.Team1SelectCB.Name = "Team1SelectCB"
		Me.Team1SelectCB.Size = New System.Drawing.Size(193, 21)
		Me.Team1SelectCB.TabIndex = 1
		AddHandler Me.Team1SelectCB.SelectedIndexChanged, AddressOf Me.ComboBox1SelectedIndexChanged
		'
		'Team1
		'
		Me.Team1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Team1.Location = New System.Drawing.Point(0, 0)
		Me.Team1.Name = "Team1"
		Me.Team1.Size = New System.Drawing.Size(193, 23)
		Me.Team1.TabIndex = 0
		'
		'Team2SelectCB
		'
		Me.Team2SelectCB.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Team2SelectCB.FormattingEnabled = true
		Me.Team2SelectCB.Location = New System.Drawing.Point(0, 23)
		Me.Team2SelectCB.Name = "Team2SelectCB"
		Me.Team2SelectCB.Size = New System.Drawing.Size(187, 21)
		Me.Team2SelectCB.TabIndex = 1
		'
		'Team2
		'
		Me.Team2.Dock = System.Windows.Forms.DockStyle.Top
		Me.Team2.Location = New System.Drawing.Point(0, 0)
		Me.Team2.Name = "Team2"
		Me.Team2.Size = New System.Drawing.Size(187, 23)
		Me.Team2.TabIndex = 0
		AddHandler Me.Team2.Click, AddressOf Me.Label3Click
		'
		'button1
		'
		Me.button1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.button1.Location = New System.Drawing.Point(0, 146)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(384, 23)
		Me.button1.TabIndex = 3
		Me.button1.Text = "Débuter la partie"
		Me.button1.UseVisualStyleBackColor = true
		'
		'ImgTeam1
		'
		Me.ImgTeam1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.ImgTeam1.Location = New System.Drawing.Point(0, 44)
		Me.ImgTeam1.Name = "ImgTeam1"
		Me.ImgTeam1.Size = New System.Drawing.Size(193, 70)
		Me.ImgTeam1.TabIndex = 3
		Me.ImgTeam1.TabStop = false
		'
		'pictureBox2
		'
		Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.pictureBox2.Location = New System.Drawing.Point(0, 44)
		Me.pictureBox2.Name = "pictureBox2"
		Me.pictureBox2.Size = New System.Drawing.Size(187, 78)
		Me.pictureBox2.TabIndex = 2
		Me.pictureBox2.TabStop = false
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(384, 169)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.menuStrip1)
		Me.MainMenuStrip = Me.menuStrip1
		Me.MinimumSize = New System.Drawing.Size(400, 39)
		Me.Name = "MainForm"
		Me.Text = "Entrez les équipes"
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.panel1.ResumeLayout(false)
		Me.m_splitContainer1.Panel1.ResumeLayout(false)
		Me.m_splitContainer1.Panel2.ResumeLayout(false)
		CType(Me.m_splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
		Me.m_splitContainer1.ResumeLayout(false)
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ImgTeam1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private pictureBox2 As System.Windows.Forms.PictureBox
	Private ImgTeam1 As System.Windows.Forms.PictureBox
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private Team2SelectCB As System.Windows.Forms.ComboBox
	Private button1 As System.Windows.Forms.Button
	Private Team1SelectCB As System.Windows.Forms.ComboBox
	Private Team2 As System.Windows.Forms.Label
	Private m_splitContainer1 As System.Windows.Forms.SplitContainer
	
	Public Property SplitContainer1() As SplitContainer
		Get
			Return m_splitContainer1
		End Get
		Set
			m_splitContainer1 = value
		End Set
	End Property
	Private panel1 As System.Windows.Forms.Panel
	Private Team1 As System.Windows.Forms.Label
	Private changerLeLanguageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private réglageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private label1 As System.Windows.Forms.Label
	
	Sub Label3Click(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub Panel1Paint(sender As Object, e As PaintEventArgs)
		
	End Sub
End Class
