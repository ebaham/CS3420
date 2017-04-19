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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(36, 111)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(872, 504)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(873, 65)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Grade Table"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Crimson
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1037, 120)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 65)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Student ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Crimson
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1037, 280)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(319, 65)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Semester"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Crimson
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1037, 446)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(319, 65)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Course ID"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'studentID
        '
        Me.studentID.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentID.Location = New System.Drawing.Point(1036, 189)
        Me.studentID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.studentID.Name = "studentID"
        Me.studentID.Size = New System.Drawing.Size(319, 51)
        Me.studentID.TabIndex = 5
        '
        'semester
        '
        Me.semester.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semester.Location = New System.Drawing.Point(1036, 349)
        Me.semester.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.semester.Name = "semester"
        Me.semester.Size = New System.Drawing.Size(319, 51)
        Me.semester.TabIndex = 6
        '
        'courseID
        '
        Me.courseID.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseID.Location = New System.Drawing.Point(1036, 516)
        Me.courseID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.courseID.Name = "courseID"
        Me.courseID.Size = New System.Drawing.Size(319, 51)
        Me.courseID.TabIndex = 7
        '
        'gradeUpdate
        '
        Me.gradeUpdate.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeUpdate.Location = New System.Drawing.Point(83, 661)
        Me.gradeUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gradeUpdate.Name = "gradeUpdate"
        Me.gradeUpdate.Size = New System.Drawing.Size(220, 56)
        Me.gradeUpdate.TabIndex = 8
        Me.gradeUpdate.Text = "Update"
        Me.gradeUpdate.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(357, 661)
        Me.Reset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(220, 56)
        Me.Reset.TabIndex = 9
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Close
        '
        Me.Close.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close.Location = New System.Drawing.Point(629, 661)
        Me.Close.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(220, 56)
        Me.Close.TabIndex = 10
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(923, 661)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 56)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Add Student"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1519, 761)
        Me.Controls.Add(Me.Button1)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents Button1 As Button
End Class
