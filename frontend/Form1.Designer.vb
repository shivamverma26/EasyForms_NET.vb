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
        Me.btnCreateSubmission = New System.Windows.Forms.Button()
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.lblForm = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCreateSubmission
        '
        Me.btnCreateSubmission.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCreateSubmission.Location = New System.Drawing.Point(97, 226)
        Me.btnCreateSubmission.Name = "btnCreateSubmission"
        Me.btnCreateSubmission.Size = New System.Drawing.Size(275, 33)
        Me.btnCreateSubmission.TabIndex = 0
        Me.btnCreateSubmission.Text = "&CREATE NEW SUBMISSION"
        Me.btnCreateSubmission.UseVisualStyleBackColor = False
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.BackColor = System.Drawing.Color.Yellow
        Me.btnViewSubmissions.Location = New System.Drawing.Point(97, 147)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(275, 36)
        Me.btnViewSubmissions.TabIndex = 1
        Me.btnViewSubmissions.Text = "&VIEW SUBMISSIONS"
        Me.btnViewSubmissions.UseVisualStyleBackColor = False
        '
        'lblForm
        '
        Me.lblForm.BackColor = System.Drawing.SystemColors.Info
        Me.lblForm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForm.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblForm.Location = New System.Drawing.Point(66, 61)
        Me.lblForm.Multiline = True
        Me.lblForm.Name = "lblForm"
        Me.lblForm.ReadOnly = True
        Me.lblForm.Size = New System.Drawing.Size(336, 44)
        Me.lblForm.TabIndex = 15
        Me.lblForm.Text = "Slidely Form App"
        Me.lblForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(472, 343)
        Me.Controls.Add(Me.lblForm)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Controls.Add(Me.btnCreateSubmission)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents lblForm As TextBox
End Class
