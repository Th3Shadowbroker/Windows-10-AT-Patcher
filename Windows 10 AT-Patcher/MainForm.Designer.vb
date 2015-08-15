<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Status = New System.Windows.Forms.Label()
        Me.RunPatcher = New System.Windows.Forms.Button()
        Me.About = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconCreditLink = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Location = New System.Drawing.Point(13, 9)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(236, 13)
        Me.Status.TabIndex = 0
        Me.Status.Text = "Status: Der AT-Patch ist derzeit nicht nicht aktiv."
        '
        'RunPatcher
        '
        Me.RunPatcher.Location = New System.Drawing.Point(16, 96)
        Me.RunPatcher.Name = "RunPatcher"
        Me.RunPatcher.Size = New System.Drawing.Size(233, 23)
        Me.RunPatcher.TabIndex = 1
        Me.RunPatcher.Text = "Allow/Deny - Telemetry..."
        Me.RunPatcher.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.About.Location = New System.Drawing.Point(16, 125)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(233, 23)
        Me.About.TabIndex = 2
        Me.About.Text = "Über den AT-Patcher..."
        Me.About.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 52)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Wichtig: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Der AT-Patcher ist nicht alles was" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sie zum deaktiveren der Datenweite" & _
    "rgabe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "etc. benötigen !"
        '
        'IconCreditLink
        '
        Me.IconCreditLink.AutoSize = True
        Me.IconCreditLink.Location = New System.Drawing.Point(13, 159)
        Me.IconCreditLink.Name = "IconCreditLink"
        Me.IconCreditLink.Size = New System.Drawing.Size(94, 13)
        Me.IconCreditLink.TabIndex = 4
        Me.IconCreditLink.TabStop = True
        Me.IconCreditLink.Text = "Icon by IconsMind"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 181)
        Me.Controls.Add(Me.IconCreditLink)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.About)
        Me.Controls.Add(Me.RunPatcher)
        Me.Controls.Add(Me.Status)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows 10: AT-Patcher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents RunPatcher As System.Windows.Forms.Button
    Friend WithEvents About As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IconCreditLink As System.Windows.Forms.LinkLabel

End Class
