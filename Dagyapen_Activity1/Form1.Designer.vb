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
        label1 = New Label()
        txtfirstNum = New TextBox()
        label2 = New Label()
        txtsecondNum = New TextBox()
        Btn1 = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(12, 9)
        label1.Name = "label1"
        label1.Size = New Size(76, 15)
        label1.TabIndex = 0
        label1.Text = "First Number"
        ' 
        ' txtfirstNum
        ' 
        txtfirstNum.Location = New Point(12, 27)
        txtfirstNum.Name = "txtfirstNum"
        txtfirstNum.Size = New Size(100, 23)
        txtfirstNum.TabIndex = 1
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(12, 53)
        label2.Name = "label2"
        label2.Size = New Size(93, 15)
        label2.TabIndex = 2
        label2.Text = "Second Number"
        ' 
        ' txtsecondNum
        ' 
        txtsecondNum.Location = New Point(12, 71)
        txtsecondNum.Name = "txtsecondNum"
        txtsecondNum.Size = New Size(100, 23)
        txtsecondNum.TabIndex = 3
        ' 
        ' Btn1
        ' 
        Btn1.Location = New Point(12, 112)
        Btn1.Name = "Btn1"
        Btn1.Size = New Size(75, 23)
        Btn1.TabIndex = 4
        Btn1.Text = "Add"
        Btn1.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(12, 151)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(44, 15)
        lblResult.TabIndex = 5
        lblResult.Text = "answer"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Controls.Add(Btn1)
        Controls.Add(txtsecondNum)
        Controls.Add(label2)
        Controls.Add(txtfirstNum)
        Controls.Add(label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents txtfirstNum As TextBox
    Friend WithEvents label2 As Label
    Friend WithEvents txtsecondNum As TextBox
    Friend WithEvents Btn1 As Button
    Friend WithEvents lblResult As Label
End Class
