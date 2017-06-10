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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.bar = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.pro = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recor = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.win = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bat = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.min = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.sec = New System.Windows.Forms.Label()
        Me.millisec = New System.Windows.Forms.Label()
        Me.savebutton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.suc = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.suc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.bar, Me.pro, Me.RectangleShape1, Me.recor, Me.RectangleShape3, Me.win})
        Me.ShapeContainer1.Size = New System.Drawing.Size(470, 290)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'bar
        '
        Me.bar.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.bar.FillGradientColor = System.Drawing.Color.SteelBlue
        Me.bar.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.bar.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.bar.Location = New System.Drawing.Point(41, 21)
        Me.bar.Name = "bar"
        Me.bar.Size = New System.Drawing.Size(1, 16)
        '
        'pro
        '
        Me.pro.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pro.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pro.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.pro.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.pro.Location = New System.Drawing.Point(41, 22)
        Me.pro.Name = "pro"
        Me.pro.Size = New System.Drawing.Size(397, 15)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RectangleShape1.Location = New System.Drawing.Point(13, 149)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(427, 66)
        '
        'recor
        '
        Me.recor.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.recor.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.recor.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.recor.Location = New System.Drawing.Point(14, 21)
        Me.recor.Name = "recor"
        Me.recor.Size = New System.Drawing.Size(12, 13)
        Me.recor.Visible = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RectangleShape3.Location = New System.Drawing.Point(10, 245)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(448, 41)
        '
        'win
        '
        Me.win.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.win.FillGradientColor = System.Drawing.Color.SkyBlue
        Me.win.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.win.Location = New System.Drawing.Point(-26, -1)
        Me.win.Name = "win"
        Me.win.Size = New System.Drawing.Size(494, 3)
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Button1.Location = New System.Drawing.Point(355, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Stop"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'bat
        '
        Me.bat.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.bat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bat.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.bat.Location = New System.Drawing.Point(248, 251)
        Me.bat.Name = "bat"
        Me.bat.Size = New System.Drawing.Size(101, 27)
        Me.bat.TabIndex = 1
        Me.bat.Text = "Record"
        Me.bat.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(14, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Frames: "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Button2.Location = New System.Drawing.Point(141, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 27)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Capture"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(14, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Time: "
        '
        'min
        '
        Me.min.AutoSize = True
        Me.min.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min.ForeColor = System.Drawing.Color.Gainsboro
        Me.min.Location = New System.Drawing.Point(65, 104)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(19, 13)
        Me.min.TabIndex = 6
        Me.min.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(14, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(65, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nothing yet.."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(65, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "0"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'sec
        '
        Me.sec.AutoSize = True
        Me.sec.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec.ForeColor = System.Drawing.Color.Gainsboro
        Me.sec.Location = New System.Drawing.Point(84, 104)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(19, 13)
        Me.sec.TabIndex = 10
        Me.sec.Text = "00"
        '
        'millisec
        '
        Me.millisec.AutoSize = True
        Me.millisec.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.millisec.ForeColor = System.Drawing.Color.Gainsboro
        Me.millisec.Location = New System.Drawing.Point(105, 104)
        Me.millisec.Name = "millisec"
        Me.millisec.Size = New System.Drawing.Size(19, 13)
        Me.millisec.TabIndex = 11
        Me.millisec.Text = "00"
        '
        'savebutton
        '
        Me.savebutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.savebutton.Enabled = False
        Me.savebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.savebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savebutton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebutton.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.savebutton.Location = New System.Drawing.Point(17, 252)
        Me.savebutton.Name = "savebutton"
        Me.savebutton.Size = New System.Drawing.Size(101, 27)
        Me.savebutton.TabIndex = 12
        Me.savebutton.Text = "Save Video"
        Me.savebutton.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Button4.Location = New System.Drawing.Point(337, 157)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 34)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Output"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 500
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.Desktop
        Me.ToolTip1.ForeColor = System.Drawing.SystemColors.Info
        Me.ToolTip1.ToolTipTitle = "Click to Edit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(136, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "C:\temp"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(30, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Recorded Videos: "
        '
        'Timer4
        '
        '
        'Timer5
        '
        Me.Timer5.Interval = 1000
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Timer6
        '
        Me.Timer6.Enabled = True
        '
        'suc
        '
        Me.suc.Image = Global.ScreenCap.My.Resources.Resources.sender_sendcomplete
        Me.suc.Location = New System.Drawing.Point(198, 44)
        Me.suc.Name = "suc"
        Me.suc.Size = New System.Drawing.Size(75, 73)
        Me.suc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.suc.TabIndex = 22
        Me.suc.TabStop = False
        Me.suc.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.ScreenCap.My.Resources.Resources.igm
        Me.PictureBox5.Location = New System.Drawing.Point(130, 252)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(27, 26)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 21
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ScreenCap.My.Resources.Resources.cam2
        Me.PictureBox4.Location = New System.Drawing.Point(235, 252)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(27, 26)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 20
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ScreenCap.My.Resources.Resources.edit
        Me.PictureBox2.Location = New System.Drawing.Point(414, 91)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(307, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(470, 290)
        Me.Controls.Add(Me.suc)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.savebutton)
        Me.Controls.Add(Me.millisec)
        Me.Controls.Add(Me.sec)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.min)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bat)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScreenPhoton"
        CType(Me.suc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bat As System.Windows.Forms.Button
    Friend WithEvents win As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents min As System.Windows.Forms.Label
    Friend WithEvents recor As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents sec As System.Windows.Forms.Label
    Friend WithEvents millisec As System.Windows.Forms.Label
    Friend WithEvents savebutton As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents bar As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents pro As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer6 As System.Windows.Forms.Timer
    Friend WithEvents suc As System.Windows.Forms.PictureBox

End Class
