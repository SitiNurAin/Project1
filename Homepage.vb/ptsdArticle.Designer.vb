<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ptsdArticle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HealthTopicsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StressToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuicideToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepressionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectLanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 79)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(907, 594)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("https://www.mayoclinic.org/diseases-conditions/post-traumatic-stress-disorder/sym" &
        "ptoms-causes/syc-20355967", System.UriKind.Absolute)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(12, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(173, 52)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Homepage.vb.My.Resources.Resources.Untitled__5_1
        Me.PictureBox1.Location = New System.Drawing.Point(386, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.AutoSize = False
        Me.MenuToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HealthTopicsToolStripMenuItem1, Me.AboutUsToolStripMenuItem, Me.ContactUsToolStripMenuItem, Me.SelectLanguageToolStripMenuItem, Me.HomeToolStripMenuItem})
        Me.MenuToolStripMenuItem.Image = Global.Homepage.vb.My.Resources.Resources.icons8_menu_48
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'HealthTopicsToolStripMenuItem1
        '
        Me.HealthTopicsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StressToolStripMenuItem1, Me.SuicideToolStripMenuItem1, Me.DepressionToolStripMenuItem1})
        Me.HealthTopicsToolStripMenuItem1.Name = "HealthTopicsToolStripMenuItem1"
        Me.HealthTopicsToolStripMenuItem1.Size = New System.Drawing.Size(193, 26)
        Me.HealthTopicsToolStripMenuItem1.Text = "Health Topics "
        '
        'StressToolStripMenuItem1
        '
        Me.StressToolStripMenuItem1.Name = "StressToolStripMenuItem1"
        Me.StressToolStripMenuItem1.Size = New System.Drawing.Size(158, 26)
        Me.StressToolStripMenuItem1.Text = "Stress "
        '
        'SuicideToolStripMenuItem1
        '
        Me.SuicideToolStripMenuItem1.Name = "SuicideToolStripMenuItem1"
        Me.SuicideToolStripMenuItem1.Size = New System.Drawing.Size(158, 26)
        Me.SuicideToolStripMenuItem1.Text = "Suicide"
        '
        'DepressionToolStripMenuItem1
        '
        Me.DepressionToolStripMenuItem1.Name = "DepressionToolStripMenuItem1"
        Me.DepressionToolStripMenuItem1.Size = New System.Drawing.Size(158, 26)
        Me.DepressionToolStripMenuItem1.Text = "Depression"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.ContactUsToolStripMenuItem.Text = "Contact Us"
        '
        'SelectLanguageToolStripMenuItem
        '
        Me.SelectLanguageToolStripMenuItem.Name = "SelectLanguageToolStripMenuItem"
        Me.SelectLanguageToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.SelectLanguageToolStripMenuItem.Text = "Select Language"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ptsdArticle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(947, 695)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "ptsdArticle"
        Me.Text = "ptsdArticle"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HealthTopicsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StressToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SuicideToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DepressionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectLanguageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
