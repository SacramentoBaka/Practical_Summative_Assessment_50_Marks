<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        ListBox1 = New ListBox()
        Panel1 = New Panel()
        Label2 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1038, 3)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(45, 31)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(14, 79)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 23)
        Label1.TabIndex = 1
        Label1.Text = "Please Enter a Word"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(14, 131)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(199, 25)
        TextBox1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gray
        Button1.Cursor = Cursors.AppStarting
        Button1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(56, 198)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 3
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.Gainsboro
        ListBox1.BorderStyle = BorderStyle.None
        ListBox1.Cursor = Cursors.Hand
        ListBox1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBox1.ForeColor = Color.Black
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 23
        ListBox1.Location = New Point(240, 31)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(192, 230)
        ListBox1.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(447, 127)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(214, 50)
        Panel1.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 23)
        Label2.TabIndex = 0
        Label2.Text = "No Value"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = Color.Transparent
        RadioButton1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton1.ForeColor = Color.White
        RadioButton1.Location = New Point(6, 48)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(78, 23)
        RadioButton1.TabIndex = 7
        RadioButton1.TabStop = True
        RadioButton1.Text = "Upper"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = Color.Transparent
        RadioButton2.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton2.ForeColor = Color.White
        RadioButton2.Location = New Point(6, 98)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(78, 23)
        RadioButton2.TabIndex = 8
        RadioButton2.TabStop = True
        RadioButton2.Text = "Lower"
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.BackColor = Color.Transparent
        RadioButton3.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton3.ForeColor = Color.White
        RadioButton3.Location = New Point(6, 48)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(81, 23)
        RadioButton3.TabIndex = 9
        RadioButton3.TabStop = True
        RadioButton3.Text = "Purple"
        RadioButton3.UseVisualStyleBackColor = False
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.BackColor = Color.Transparent
        RadioButton4.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton4.ForeColor = Color.White
        RadioButton4.Location = New Point(6, 98)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(65, 23)
        RadioButton4.TabIndex = 10
        RadioButton4.TabStop = True
        RadioButton4.Text = "Blue"
        RadioButton4.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Cursor = Cursors.Hand
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(681, 79)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(135, 141)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Case"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(RadioButton3)
        GroupBox2.Controls.Add(RadioButton4)
        GroupBox2.Cursor = Cursors.Hand
        GroupBox2.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(863, 79)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(133, 141)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        GroupBox2.Text = "Colour"
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(12F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1083, 291)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Controls.Add(ListBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
