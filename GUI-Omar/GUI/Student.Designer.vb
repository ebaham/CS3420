<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student
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
        Me.StudentGridLSTBOX = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Close = New System.Windows.Forms.Button()
        Me.StudentIDLBL = New System.Windows.Forms.Label()
        Me.NameLBL = New System.Windows.Forms.Label()
        Me.SemesterLBL = New System.Windows.Forms.Label()
        Me.GPALBL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StudentGridLSTBOX
        '
        Me.StudentGridLSTBOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentGridLSTBOX.FormattingEnabled = True
        Me.StudentGridLSTBOX.ItemHeight = 25
        Me.StudentGridLSTBOX.Location = New System.Drawing.Point(19, 64)
        Me.StudentGridLSTBOX.Margin = New System.Windows.Forms.Padding(2)
        Me.StudentGridLSTBOX.Name = "StudentGridLSTBOX"
        Me.StudentGridLSTBOX.Size = New System.Drawing.Size(438, 254)
        Me.StudentGridLSTBOX.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Grade Table"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Crimson
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(507, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 34)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Student ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Crimson
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(507, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 34)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Semester"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Crimson
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(507, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 34)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Crimson
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(507, 266)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 34)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "GPA"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Close
        '
        Me.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close.Location = New System.Drawing.Point(19, 356)
        Me.Close.Margin = New System.Windows.Forms.Padding(2)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(437, 29)
        Me.Close.TabIndex = 13
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'StudentIDLBL
        '
        Me.StudentIDLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudentIDLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentIDLBL.Location = New System.Drawing.Point(509, 64)
        Me.StudentIDLBL.Name = "StudentIDLBL"
        Me.StudentIDLBL.Size = New System.Drawing.Size(155, 33)
        Me.StudentIDLBL.TabIndex = 14
        '
        'NameLBL
        '
        Me.NameLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLBL.Location = New System.Drawing.Point(509, 142)
        Me.NameLBL.Name = "NameLBL"
        Me.NameLBL.Size = New System.Drawing.Size(155, 33)
        Me.NameLBL.TabIndex = 15
        '
        'SemesterLBL
        '
        Me.SemesterLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SemesterLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SemesterLBL.Location = New System.Drawing.Point(509, 222)
        Me.SemesterLBL.Name = "SemesterLBL"
        Me.SemesterLBL.Size = New System.Drawing.Size(155, 33)
        Me.SemesterLBL.TabIndex = 16
        '
        'GPALBL
        '
        Me.GPALBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GPALBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPALBL.Location = New System.Drawing.Point(509, 302)
        Me.GPALBL.Name = "GPALBL"
        Me.GPALBL.Size = New System.Drawing.Size(155, 33)
        Me.GPALBL.TabIndex = 17
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Close
        Me.ClientSize = New System.Drawing.Size(702, 402)
        Me.Controls.Add(Me.GPALBL)
        Me.Controls.Add(Me.SemesterLBL)
        Me.Controls.Add(Me.NameLBL)
        Me.Controls.Add(Me.StudentIDLBL)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StudentGridLSTBOX)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Student"
        Me.Text = "Student"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentGridLSTBOX As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Close As Button
    Friend WithEvents NameLBL As Label
    Friend WithEvents SemesterLBL As Label
    Friend WithEvents GPALBL As Label
    Public WithEvents StudentIDLBL As Label
End Class
