<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Me.lblForm = New System.Windows.Forms.TextBox()
        Me.lblGithub = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnStopwatch = New System.Windows.Forms.Button()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblElapsedTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblForm
        '
        Me.lblForm.BackColor = System.Drawing.SystemColors.Menu
        Me.lblForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForm.Location = New System.Drawing.Point(32, 22)
        Me.lblForm.Multiline = True
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(286, 44)
        Me.lblForm.TabIndex = 27
        Me.lblForm.Text = "Create Submission"
        Me.lblForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGithub
        '
        Me.lblGithub.AutoSize = True
        Me.lblGithub.Location = New System.Drawing.Point(174, 272)
        Me.lblGithub.Name = "lblGithub"
        Me.lblGithub.Size = New System.Drawing.Size(93, 40)
        Me.lblGithub.TabIndex = 26
        Me.lblGithub.Text = "GitHub Link" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For Task 2"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSubmit.Location = New System.Drawing.Point(329, 427)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(193, 44)
        Me.btnSubmit.TabIndex = 25
        Me.btnSubmit.Text = "&SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnStopwatch
        '
        Me.btnStopwatch.BackColor = System.Drawing.Color.Yellow
        Me.btnStopwatch.Location = New System.Drawing.Point(158, 349)
        Me.btnStopwatch.Name = "btnStopwatch"
        Me.btnStopwatch.Size = New System.Drawing.Size(237, 31)
        Me.btnStopwatch.TabIndex = 24
        Me.btnStopwatch.Text = "&TOGGLE STOPWATCH"
        Me.btnStopwatch.UseVisualStyleBackColor = False
        '
        'txtGithub
        '
        Me.txtGithub.Location = New System.Drawing.Point(304, 272)
        Me.txtGithub.Multiline = True
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.Size = New System.Drawing.Size(246, 40)
        Me.txtGithub.TabIndex = 21
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(304, 215)
        Me.txtPhone.Multiline = True
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(246, 34)
        Me.txtPhone.TabIndex = 20
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(176, 222)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(92, 20)
        Me.lblPhone.TabIndex = 19
        Me.lblPhone.Text = "Phone Num"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(304, 157)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(246, 34)
        Me.txtEmail.TabIndex = 18
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(304, 95)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(246, 34)
        Me.txtName.TabIndex = 17
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(194, 165)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 20)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "Email"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(193, 105)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 20)
        Me.lblName.TabIndex = 15
        Me.lblName.Text = "Name"
        '
        'lblElapsedTime
        '
        Me.lblElapsedTime.AutoSize = True
        Me.lblElapsedTime.Location = New System.Drawing.Point(432, 355)
        Me.lblElapsedTime.Name = "lblElapsedTime"
        Me.lblElapsedTime.Size = New System.Drawing.Size(57, 20)
        Me.lblElapsedTime.TabIndex = 28
        Me.lblElapsedTime.Text = "00 : 00"
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 525)
        Me.Controls.Add(Me.lblElapsedTime)
        Me.Controls.Add(Me.lblForm)
        Me.Controls.Add(Me.lblGithub)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnStopwatch)
        Me.Controls.Add(Me.txtGithub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblForm As TextBox
    Friend WithEvents lblGithub As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnStopwatch As Button
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblElapsedTime As Label
End Class
