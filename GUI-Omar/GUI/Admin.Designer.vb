<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.studentID = New System.Windows.Forms.TextBox()
        Me.semester = New System.Windows.Forms.TextBox()
        Me.courseID = New System.Windows.Forms.TextBox()
        Me.gradeUpdate = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(18, 58)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(438, 264)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Grade Table"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Crimson
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(519, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Student ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Crimson
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(519, 146)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 34)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Semester"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Crimson
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(519, 232)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 34)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Course ID"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'studentID
        '
        Me.studentID.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentID.Location = New System.Drawing.Point(518, 98)
        Me.studentID.Margin = New System.Windows.Forms.Padding(2)
        Me.studentID.Name = "studentID"
        Me.studentID.Size = New System.Drawing.Size(161, 29)
        Me.studentID.TabIndex = 5
        '
        'semester
        '
        Me.semester.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semester.Location = New System.Drawing.Point(518, 181)
        Me.semester.Margin = New System.Windows.Forms.Padding(2)
        Me.semester.Name = "semester"
        Me.semester.Size = New System.Drawing.Size(161, 29)
        Me.semester.TabIndex = 6
        '
        'courseID
        '
        Me.courseID.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseID.Location = New System.Drawing.Point(518, 268)
        Me.courseID.Margin = New System.Windows.Forms.Padding(2)
        Me.courseID.Name = "courseID"
        Me.courseID.Size = New System.Drawing.Size(161, 29)
        Me.courseID.TabIndex = 7
        '
        'gradeUpdate
        '
        Me.gradeUpdate.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeUpdate.Location = New System.Drawing.Point(41, 344)
        Me.gradeUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.gradeUpdate.Name = "gradeUpdate"
        Me.gradeUpdate.Size = New System.Drawing.Size(110, 29)
        Me.gradeUpdate.TabIndex = 8
        Me.gradeUpdate.Text = "Update"
        Me.gradeUpdate.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(179, 344)
        Me.Reset.Margin = New System.Windows.Forms.Padding(2)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(110, 29)
        Me.Reset.TabIndex = 9
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Close
        '
        Me.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close.Location = New System.Drawing.Point(315, 344)
        Me.Close.Margin = New System.Windows.Forms.Padding(2)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(110, 29)
        Me.Close.TabIndex = 10
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Close
        Me.ClientSize = New System.Drawing.Size(759, 396)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.gradeUpdate)
        Me.Controls.Add(Me.courseID)
        Me.Controls.Add(Me.semester)
        Me.Controls.Add(Me.studentID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents studentID As TextBox
    Friend WithEvents semester As TextBox
    Friend WithEvents courseID As TextBox
    Friend WithEvents gradeUpdate As Button
    Friend WithEvents Reset As Button
    Friend WithEvents Close As Button
End Class
