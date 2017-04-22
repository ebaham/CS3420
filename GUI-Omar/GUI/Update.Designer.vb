<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.Close = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.midterm1 = New System.Windows.Forms.TextBox()
        Me.midterm2 = New System.Windows.Forms.TextBox()
        Me.finalExam = New System.Windows.Forms.TextBox()
        Me.classGrade = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Crimson
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 178)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 34)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Class Grade"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 111)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Final Exam"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Crimson
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 34)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Midterm Exam 2"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Crimson
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 34)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Midterm Exam 1"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(39, 241)
        Me.Save.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(110, 29)
        Me.Save.TabIndex = 8
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Close
        '
        Me.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close.Location = New System.Drawing.Point(292, 241)
        Me.Close.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(110, 29)
        Me.Close.TabIndex = 9
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(165, 241)
        Me.Reset.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(110, 29)
        Me.Reset.TabIndex = 10
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'midterm1
        '
        Me.midterm1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midterm1.Location = New System.Drawing.Point(220, 16)
        Me.midterm1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.midterm1.Name = "midterm1"
        Me.midterm1.Size = New System.Drawing.Size(167, 29)
        Me.midterm1.TabIndex = 11
        '
        'midterm2
        '
        Me.midterm2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midterm2.Location = New System.Drawing.Point(220, 68)
        Me.midterm2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.midterm2.Name = "midterm2"
        Me.midterm2.Size = New System.Drawing.Size(167, 29)
        Me.midterm2.TabIndex = 12
        '
        'finalExam
        '
        Me.finalExam.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finalExam.Location = New System.Drawing.Point(220, 119)
        Me.finalExam.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.finalExam.Name = "finalExam"
        Me.finalExam.Size = New System.Drawing.Size(167, 29)
        Me.finalExam.TabIndex = 13
        '
        'classGrade
        '
        Me.classGrade.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classGrade.Location = New System.Drawing.Point(220, 183)
        Me.classGrade.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.classGrade.Name = "classGrade"
        Me.classGrade.Size = New System.Drawing.Size(167, 29)
        Me.classGrade.TabIndex = 14
        '
        'updateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Close
        Me.ClientSize = New System.Drawing.Size(427, 296)
        Me.Controls.Add(Me.classGrade)
        Me.Controls.Add(Me.finalExam)
        Me.Controls.Add(Me.midterm2)
        Me.Controls.Add(Me.midterm1)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "updateForm"
        Me.Text = "Update"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Save As Button
    Friend WithEvents Close As Button
    Friend WithEvents Reset As Button
    Friend WithEvents midterm1 As TextBox
    Friend WithEvents midterm2 As TextBox
    Friend WithEvents finalExam As TextBox
    Friend WithEvents classGrade As TextBox
End Class
