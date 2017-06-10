'****README FIRST*************
'
'Copyright (c) 2017 Raisy Clutch
'your free to use this code in anyway you want , for anything but at your own risk, i wont be responsible for what happens to your computer, released under the MIT Licence
'if you love something set it free
'features
'-- screen capture
'-- screen record 
'-- photo Edit
'-- TODO: screen to GIF
'-- screen to Images(temp folder)
'-- preview
'
'copy ffmpeg.exe to your bin/Debug and Release folder
' Donate to raisycltch@gmail.com i need a cup of coffee
'blog: raisyclutch.wordpress.com
'********THE END***************


Public Class Form1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim second As Integer
    Dim frame As Long
    Dim temp As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\SCREENGRAB"  'tmp folder for storing images
    Dim doc As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\ScreenPhoton"  'default save videopath
    Dim ty = TimeOfDay
    Dim str As String
    Dim proc As New Process
    Dim proci As New ProcessStartInfo
    Private endo As Integer = 0  'talks to the bgworker
    Dim tym = TimeOfDay.ToBinary  'video file name
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Private Sub bat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bat.Click
        'record sound and start capture
        mciSendString("open new Type waveaudio Alias recsound", "", 0, 0)
        mciSendString("record recsound", "", 0, 0)
        Button1.Enabled = True
        Timer4.Enabled = True
        Timer4.Start()
        Timer2.Enabled = True
        Timer2.Start()
        recor.Visible = True
        Label5.Text = "Recording..."
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.CreateDirectory(temp)
        My.Computer.FileSystem.CreateDirectory(doc)
        Label3.Text = doc
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'ANIMATING THE THIN BAR ONTOP
        second = second + 1
        If second = 5 Then
            win.FillColor = Color.Green
        ElseIf second = 10 Then
            win.FillColor = Color.DodgerBlue
        ElseIf second = 15 Then
            win.FillColor = Color.Orange
        ElseIf second = 20 Then
            win.FillColor = Color.Silver
        ElseIf second = 30 Then
            win.FillColor = Color.DarkSlateGray
        ElseIf second = 35 Then
            win.FillColor = Color.Black
        ElseIf second = 40 Then
            win.FillColor = Color.DarkOrange
        ElseIf second = 45 Then
            win.FillColor = Color.DarkRed
        ElseIf second = 50 Then
            win.FillColor = Color.Aquamarine
        ElseIf second = 55 Then
            win.FillColor = Color.GhostWhite
        ElseIf second = 60 Then
            win.FillColor = Color.DeepSkyBlue
            second = 0



        End If


    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        'incase you remove the window border DRAGGING WILL BE ENABLED
        drag = True
        mousex = Windows.Forms.Cursor.Position.Y = Me.Left
        mousey = Windows.Forms.Cursor.Position.X = Me.Top
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'incase you remove the window border DRAGGING WILL BE ENABLED
        If drag = True Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey

        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        'incase you remove the window border
        drag = False


    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If millisec.Text < 59 Then
            millisec.Text = Val(millisec.Text) + 1
            If millisec.Text < 10 Then
                millisec.Text = "0" + millisec.Text
            End If
        Else
            millisec.Text = 0
            If sec.Text < 59 Then
                sec.Text = Val(sec.Text) + 1
                If sec.Text < 10 Then
                    sec.Text = "0" + sec.Text
                End If
            Else
                sec.Text = 0
                If min.Text < 59 Then
                    min.Text = Val(min.Text) + 1
                    If min.Text < 10 Then
                        min.Text = "0" + min.Text
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        PictureBox1.Image = screenshot
        Timer3.Enabled = False
        Dim savefiledialog1 As New SaveFileDialog
        Try
            savefiledialog1.Title = "Save File"
            savefiledialog1.FileName = "IMG"
            savefiledialog1.Filter = "Bitmap (*.bmp;*.dib)|*.bmp;*.dib|JPEG (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|GIF (*.gif)|*.gif|TIFF (*.tif;*.tiff)|*.tif;*.tiff|PNG (*.png)|*.png"
            If savefiledialog1.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image.Save(savefiledialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        Catch ex As Exception
            'Do Nothing
        End Try

        Me.Opacity = 98%
        PictureBox2.Visible = True
        Label5.Text = "Screen Captured"

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Opacity = 0
        Timer3.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If Not Me.PictureBox1.Image Is Nothing Then
            Dim s As String = System.IO.Path.GetTempFileName()
            PictureBox1.Image.Save(s, System.Drawing.Imaging.ImageFormat.Png)
            Dim p As Process = Process.Start("mspaint.exe", s)
        End If
    End Sub

    Private Sub PictureBox1_DockChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DockChanged
        ToolTip1.Show("Click to Edit Screenshot", PictureBox1)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'edits image with paint
        If Not Me.PictureBox1.Image Is Nothing Then
            Dim s As String = System.IO.Path.GetTempFileName()
            PictureBox1.Image.Save(s, System.Drawing.Imaging.ImageFormat.Png)
            Dim p As Process = Process.Start("mspaint.exe", s)
        End If
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.BackColor = Color.SteelBlue
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = Color.FromArgb(45, 45, 45)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FolderBrowserDialog1.ShowDialog()
        Label3.Text = FolderBrowserDialog1.SelectedPath
        Label3.ForeColor = Color.Silver

    End Sub

    Private Sub Timer4_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        'capture screen and saves to temp dir
        Dim area As Rectangle
        Dim gfx As Graphics
        Dim captured As Bitmap
        area = Screen.PrimaryScreen.Bounds
        captured = New System.Drawing.Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        gfx = Graphics.FromImage(captured)
        gfx.CopyFromScreen(area.X, area.Y, 0, 0, area.Size, CopyPixelOperation.SourceCopy)
        Cursor.Draw(gfx, New Rectangle(New Point(Cursor.Position.X - Cursor.HotSpot.X, Cursor.Position.Y - Cursor.HotSpot.Y), Cursor.Size)) 'draw the cursor
        Dim framecount As String
        framecount = frame
        captured.Save(temp & "\" & framecount & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        frame += 1
        Label6.Text = frame
        Timer2.Enabled = True
    End Sub
    Private Sub createvid()
        Dim tym = TimeOfDay.ToBinary
        Dim vc As Integer
        vc = vc + 1
        Dim args As String
        Timer5.Enabled = True
        args = "-r 1/.1 -i " & temp & "\%01d.jpg -c:v libx264 -r 30 -pix_fmt yuv420p " & Chr(34) & Label3.Text & "\" & tym & ".mp4" & Chr(34)

        proci.Arguments = args
        proci.FileName = "ffmpeg.exe"
        proci.CreateNoWindow = True
        proci.UseShellExecute = False
        proci.WindowStyle = ProcessWindowStyle.Hidden
        proc.StartInfo = proci
        proc.Start()

        Do Until proc.HasExited = True


        Loop
        Timer5.Enabled = False
        IO.Directory.Delete(temp, True)
        endo = 10
        Dim bx
        bx = MsgBox("Successfully: " & Label3.Text & "\" & tym & ".mp4", MsgBoxStyle.Information)
        If bx = vbOK Then
            endo = 100
        End If

    End Sub
    Private Sub savebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savebutton.Click
        endo = 2
        Timer5.Enabled = True
        BackgroundWorker1.RunWorkerAsync()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'records sound and saves it
        mciSendString("save recsound " & Label3.Text & "\" & tym & ".wav", "", 0, 0)
        mciSendString("close recsound", "", 0, 0)
        Timer4.Enabled = False
        Timer2.Enabled = False
        recor.Visible = False
        savebutton.Enabled = True
        Label6.Text = 0
        min.Text = 0
        sec.Text = 0
        millisec.Text = 0
        Label5.Text = "last recorded: " & ty
        PictureBox1.ImageLocation = My.Computer.FileSystem.SpecialDirectories.Temp & "\SCREENGRAB\1.jpg"

    End Sub


    Function valu(ByVal e As Integer)
        bar.Width = e / 100 * pro.Width 'converts bar width to percentage
        Return e
    End Function

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        second = second + 1
        'this animates the progressbar
        Select Case second
            Case 1
                valu(10)
            Case 2
                valu(20)
            Case 3
                valu(20)
            Case 4
                valu(20)
            Case 5
                valu(25)
            Case 6
                valu(28)
            Case 7
                valu(30)
            Case 8
                valu(35)
            Case 9
                valu(38)
            Case 10
                valu(38)
            Case 11
                valu(39)
            Case 12
                valu(40)
            Case 13
                valu(45)
            Case 14
                valu(48)
            Case 60
                valu(50)
            Case 120
                valu(60)
            Case 240
                valu(70)
            Case 480
                valu(77)
            Case 560
                valu(79)
            Case 600
                valu(80)
            Case 1000
                valu(82)
            Case 3600
                valu(84)
            Case 7200
                valu(88)
            Case 14400
                valu(90)


        End Select

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        createvid() 'start bgworker
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        If endo = 10 Then
            valu(100)
        ElseIf endo = 100 Then
            Timer5.Enabled = False
            Me.Text = "ScreenPhoton"
            Label5.Text = "Video Saved at " & Label3.Text
            endo = 1 'talks to the bgworker
            valu(0) 'progress bar set to 0
            second = 0
            suc.Visible = True
        ElseIf endo = 2 Then
            Me.Text = "Please Wait Saving Video..."
            Label5.Text = "saving video please wait..."
            suc.Visible = False
        End If
    End Sub
End Class
