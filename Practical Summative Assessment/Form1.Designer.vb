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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ProgressBar1 = New ProgressBar()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(22, 273)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(600, 15)
        ProgressBar1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(233, 251)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 19)
        Label1.TabIndex = 1
        Label1.Text = "Loading..."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(328, 251)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 19)
        Label2.TabIndex = 2
        Label2.Text = "0.0%"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(222, 112)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(238, 101)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AllowDrop = True
        Label3.AutoEllipsis = True
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Cursor = Cursors.WaitCursor
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(154, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(385, 27)
        Label3.TabIndex = 4
        Label3.Text = "Practical Summative Assessment "
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(650, 300)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ProgressBar1)
        Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer

End Class
