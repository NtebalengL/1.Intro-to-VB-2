<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnClickHere = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        Label1 = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' btnClickHere
        ' 
        btnClickHere.Location = New Point(376, 387)
        btnClickHere.Name = "btnClickHere"
        btnClickHere.Size = New Size(112, 34)
        btnClickHere.TabIndex = 0
        btnClickHere.Text = "Click Here"
        btnClickHere.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(355, 202)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(355, 281)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 1
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(734, 47)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(75, 29)
        RadioButton1.TabIndex = 2
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(734, 82)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(93, 29)
        RadioButton2.TabIndex = 2
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(734, 117)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(82, 29)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Other"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(205, 202)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 3
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(195, 287)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 25)
        Label2.TabIndex = 3
        Label2.Text = "Surname"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Student", "Teacher", "Principal", "Governor", "Parent"})
        ComboBox1.Location = New Point(355, 117)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 4
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(734, 321)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(131, 29)
        CheckBox2.TabIndex = 5
        CheckBox2.Text = "Sign Me Up"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(734, 254)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(115, 29)
        CheckBox1.TabIndex = 5
        CheckBox1.Text = "Subscribe"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(205, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 25)
        Label3.TabIndex = 6
        Label3.Text = "Profession"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(195, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(537, 49)
        Label4.TabIndex = 7
        Label4.Text = "Sign Me up for Mindworx LMS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(941, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(CheckBox1)
        Controls.Add(CheckBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(btnClickHere)
        Name = "Form1"
        Text = "Subscribe"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClickHere As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
