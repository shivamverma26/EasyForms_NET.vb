<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.txtStopwatch = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblGithub = New System.Windows.Forms.Label()
        Me.lblForm = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(199, 115)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(200, 175)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 20)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Email"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(310, 105)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(246, 34)
        Me.txtName.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(310, 167)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(246, 34)
        Me.txtEmail.TabIndex = 3
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(182, 232)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(92, 20)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone Num"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(310, 225)
        Me.txtPhone.Multiline = True
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(246, 34)
        Me.txtPhone.TabIndex = 6
        '
        'txtGithub
        '
        Me.txtGithub.Location = New System.Drawing.Point(310, 282)
        Me.txtGithub.Multiline = True
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.ReadOnly = True
        Me.txtGithub.Size = New System.Drawing.Size(246, 40)
        Me.txtGithub.TabIndex = 7
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Location = New System.Drawing.Point(191, 339)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(85, 40)
        Me.lblStopwatch.TabIndex = 8
        Me.lblStopwatch.Text = "Stopwatch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Time"
        '
        'txtStopwatch
        '
        Me.txtStopwatch.Location = New System.Drawing.Point(310, 337)
        Me.txtStopwatch.Multiline = True
        Me.txtStopwatch.Name = "txtStopwatch"
        Me.txtStopwatch.ReadOnly = True
        Me.txtStopwatch.Size = New System.Drawing.Size(246, 34)
        Me.txtStopwatch.TabIndex = 9
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Yellow
        Me.btnPrevious.Location = New System.Drawing.Point(166, 418)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(189, 44)
        Me.btnPrevious.TabIndex = 10
        Me.btnPrevious.Text = "&PREVIOUS"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnNext.Location = New System.Drawing.Point(372, 418)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(193, 44)
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = "&NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblGithub
        '
        Me.lblGithub.AutoSize = True
        Me.lblGithub.Location = New System.Drawing.Point(180, 282)
        Me.lblGithub.Name = "lblGithub"
        Me.lblGithub.Size = New System.Drawing.Size(93, 40)
        Me.lblGithub.TabIndex = 12
        Me.lblGithub.Text = "GitHub Link" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For Task 2"
        '
        'lblForm
        '
        Me.lblForm.BackColor = System.Drawing.SystemColors.Menu
        Me.lblForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForm.Location = New System.Drawing.Point(34, 32)
        Me.lblForm.Multiline = True
        Me.lblForm.Name = "lblForm"
        Me.lblForm.ReadOnly = True
        Me.lblForm.Size = New System.Drawing.Size(286, 44)
        Me.lblForm.TabIndex = 14
        Me.lblForm.Text = "View Submissions"
        Me.lblForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 518)
        Me.Controls.Add(Me.lblForm)
        Me.Controls.Add(Me.lblGithub)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtStopwatch)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.txtGithub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblGithub As Label
    Friend WithEvents lblForm As TextBox
End Class
