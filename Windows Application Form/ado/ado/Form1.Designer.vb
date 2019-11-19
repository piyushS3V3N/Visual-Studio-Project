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
        Dim St_IDLabel As System.Windows.Forms.Label
        Dim St_NameLabel As System.Windows.Forms.Label
        Dim St_CourseLabel As System.Windows.Forms.Label
        Dim St_SemesterLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.StudentDataSet1 = New ado.StudentDataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New ado.StudentDataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New ado.StudentDataSetTableAdapters.TableAdapterManager()
        Me.St_IDTextBox = New System.Windows.Forms.TextBox()
        Me.St_NameTextBox = New System.Windows.Forms.TextBox()
        Me.St_CourseTextBox = New System.Windows.Forms.TextBox()
        Me.St_SemesterTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        St_IDLabel = New System.Windows.Forms.Label()
        St_NameLabel = New System.Windows.Forms.Label()
        St_CourseLabel = New System.Windows.Forms.Label()
        St_SemesterLabel = New System.Windows.Forms.Label()
        CType(Me.StudentDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'St_IDLabel
        '
        St_IDLabel.AutoSize = True
        St_IDLabel.Location = New System.Drawing.Point(89, 81)
        St_IDLabel.Name = "St_IDLabel"
        St_IDLabel.Size = New System.Drawing.Size(34, 13)
        St_IDLabel.TabIndex = 12
        St_IDLabel.Text = "St ID:"
        '
        'St_NameLabel
        '
        St_NameLabel.AutoSize = True
        St_NameLabel.Location = New System.Drawing.Point(89, 124)
        St_NameLabel.Name = "St_NameLabel"
        St_NameLabel.Size = New System.Drawing.Size(51, 13)
        St_NameLabel.TabIndex = 13
        St_NameLabel.Text = "St Name:"
        '
        'St_CourseLabel
        '
        St_CourseLabel.AutoSize = True
        St_CourseLabel.Location = New System.Drawing.Point(89, 170)
        St_CourseLabel.Name = "St_CourseLabel"
        St_CourseLabel.Size = New System.Drawing.Size(56, 13)
        St_CourseLabel.TabIndex = 14
        St_CourseLabel.Text = "St Course:"
        '
        'St_SemesterLabel
        '
        St_SemesterLabel.AutoSize = True
        St_SemesterLabel.Location = New System.Drawing.Point(89, 198)
        St_SemesterLabel.Name = "St_SemesterLabel"
        St_SemesterLabel.Size = New System.Drawing.Size(67, 13)
        St_SemesterLabel.TabIndex = 15
        St_SemesterLabel.Text = "St Semester:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(227, 280)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(48, 326)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Previous"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(227, 326)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Next"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'StudentDataSet1
        '
        Me.StudentDataSet1.DataSetName = "StudentDataSet"
        Me.StudentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.StudentDataSet1
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = ado.StudentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'St_IDTextBox
        '
        Me.St_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "St_ID", True))
        Me.St_IDTextBox.Location = New System.Drawing.Point(162, 74)
        Me.St_IDTextBox.Name = "St_IDTextBox"
        Me.St_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.St_IDTextBox.TabIndex = 13
        '
        'St_NameTextBox
        '
        Me.St_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "St_Name", True))
        Me.St_NameTextBox.Location = New System.Drawing.Point(162, 121)
        Me.St_NameTextBox.Name = "St_NameTextBox"
        Me.St_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.St_NameTextBox.TabIndex = 14
        '
        'St_CourseTextBox
        '
        Me.St_CourseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "St_Course", True))
        Me.St_CourseTextBox.Location = New System.Drawing.Point(162, 163)
        Me.St_CourseTextBox.Name = "St_CourseTextBox"
        Me.St_CourseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.St_CourseTextBox.TabIndex = 15
        '
        'St_SemesterTextBox
        '
        Me.St_SemesterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "St_Semester", True))
        Me.St_SemesterTextBox.Location = New System.Drawing.Point(162, 198)
        Me.St_SemesterTextBox.Name = "St_SemesterTextBox"
        Me.St_SemesterTextBox.Size = New System.Drawing.Size(100, 20)
        Me.St_SemesterTextBox.TabIndex = 16
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(162, 236)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "New"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 401)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(St_SemesterLabel)
        Me.Controls.Add(Me.St_SemesterTextBox)
        Me.Controls.Add(St_CourseLabel)
        Me.Controls.Add(Me.St_CourseTextBox)
        Me.Controls.Add(St_NameLabel)
        Me.Controls.Add(Me.St_NameTextBox)
        Me.Controls.Add(St_IDLabel)
        Me.Controls.Add(Me.St_IDTextBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.StudentDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents StudentDataSet1 As StudentDataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As StudentDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As StudentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents St_IDTextBox As TextBox
    Friend WithEvents St_NameTextBox As TextBox
    Friend WithEvents St_CourseTextBox As TextBox
    Friend WithEvents St_SemesterTextBox As TextBox
    Friend WithEvents Button5 As Button
End Class
