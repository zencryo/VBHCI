<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RTBDisplay = New System.Windows.Forms.RichTextBox()
        Me.btBrowse = New System.Windows.Forms.Button()
        Me.RTBUser = New System.Windows.Forms.RichTextBox()
        Me.btSubmit = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWPM = New System.Windows.Forms.TextBox()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.btStart = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblWPM = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RTBDisplay
        '
        Me.RTBDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBDisplay.Location = New System.Drawing.Point(12, 12)
        Me.RTBDisplay.Name = "RTBDisplay"
        Me.RTBDisplay.ShortcutsEnabled = False
        Me.RTBDisplay.Size = New System.Drawing.Size(791, 257)
        Me.RTBDisplay.TabIndex = 0
        Me.RTBDisplay.Text = ""
        '
        'btBrowse
        '
        Me.btBrowse.Location = New System.Drawing.Point(826, 169)
        Me.btBrowse.Name = "btBrowse"
        Me.btBrowse.Size = New System.Drawing.Size(71, 24)
        Me.btBrowse.TabIndex = 1
        Me.btBrowse.Text = "Browse"
        Me.btBrowse.UseVisualStyleBackColor = True
        '
        'RTBUser
        '
        Me.RTBUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBUser.Location = New System.Drawing.Point(12, 289)
        Me.RTBUser.Name = "RTBUser"
        Me.RTBUser.Size = New System.Drawing.Size(791, 297)
        Me.RTBUser.TabIndex = 2
        Me.RTBUser.Text = ""
        '
        'btSubmit
        '
        Me.btSubmit.Location = New System.Drawing.Point(882, 348)
        Me.btSubmit.Name = "btSubmit"
        Me.btSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btSubmit.TabIndex = 3
        Me.btSubmit.Text = "Submit"
        Me.btSubmit.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(904, 176)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(211, 20)
        Me.txtFileName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(883, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Minimum WPM"
        '
        'txtWPM
        '
        Me.txtWPM.Location = New System.Drawing.Point(963, 211)
        Me.txtWPM.Name = "txtWPM"
        Me.txtWPM.Size = New System.Drawing.Size(100, 20)
        Me.txtWPM.TabIndex = 6
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(944, 260)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(19, 13)
        Me.lblMin.TabIndex = 7
        Me.lblMin.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(960, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = ":"
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Location = New System.Drawing.Point(969, 260)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(19, 13)
        Me.lblSec.TabIndex = 9
        Me.lblSec.Text = "00"
        '
        'btStart
        '
        Me.btStart.Location = New System.Drawing.Point(882, 298)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(75, 23)
        Me.btStart.TabIndex = 10
        Me.btStart.Text = "Start"
        Me.btStart.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblWPM)
        Me.GroupBox1.Location = New System.Drawing.Point(886, 386)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "WPM"
        '
        'lblWPM
        '
        Me.lblWPM.AutoSize = True
        Me.lblWPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWPM.Location = New System.Drawing.Point(68, 28)
        Me.lblWPM.Name = "lblWPM"
        Me.lblWPM.Size = New System.Drawing.Size(70, 51)
        Me.lblWPM.TabIndex = 0
        Me.lblWPM.Text = "00"
        Me.lblWPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblScore)
        Me.GroupBox2.Location = New System.Drawing.Point(886, 492)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 102)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Score"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(68, 28)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(70, 51)
        Me.lblScore.TabIndex = 0
        Me.lblScore.Text = "00"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 681)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btStart)
        Me.Controls.Add(Me.lblSec)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.txtWPM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.btSubmit)
        Me.Controls.Add(Me.RTBUser)
        Me.Controls.Add(Me.btBrowse)
        Me.Controls.Add(Me.RTBDisplay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RTBDisplay As RichTextBox
    Friend WithEvents btBrowse As Button
    Friend WithEvents RTBUser As RichTextBox
    Friend WithEvents btSubmit As Button
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtWPM As TextBox
    Friend WithEvents lblMin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSec As Label
    Friend WithEvents btStart As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblWPM As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblScore As Label
End Class
