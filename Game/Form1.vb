Public Class Form1
    Dim r As New Random
    Dim score As Integer
    Dim Progressbar As Integer

    Sub randmove(P As PictureBox)
        Dim x As Integer
        Dim y As Integer
        x = r.Next(-10, 11)
        y = r.Next(-10, 11)
        MoveTo(P, x, y)
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.R
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX)
            Case Keys.T
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipXY)
            Case Keys.Y
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY)
            Case Keys.Up, Keys.W
                MoveTo(PictureBox1, 0, -10)
            Case Keys.Down, Keys.S
                MoveTo(PictureBox1, 0, +10)
            Case Keys.Left, Keys.A
                MoveTo(PictureBox1, -10, 0)
            Case Keys.Right, Keys.D
                MoveTo(PictureBox1, 10, 0)
            Case Keys.Space
                Bullet.Location = PictureBox1.Location
                Bullet.Visible = True
                bullettimer.Enabled = True
        End Select
    End Sub
    Sub follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(PictureBox1.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub

    Public Sub chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > PictureBox1.Location.X Then
            x = -5
        Else
            x = 5
        End If
        MoveTo(p, x, 0)
        If p.Location.Y < PictureBox1.Location.Y Then
            y = 5
        Else
            y = -5
        End If
        MoveTo(p, x, y)
    End Sub
    Function Collision(p As PictureBox, t As String, Optional ByRef other As Object = vbNull)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If obj.Visible AndAlso p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
                other = obj
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean
        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function

    'Moves and object (won't move onto objects containing  "wall" and turns green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If
        If p.Name = "PictureBox1" And Collision(p, "WIN") Then
            Me.BackgroundImage = Picturebox4.Image
            Return
        End If
        Dim other As Object = Nothing
        If p.Name = "Bullet" And Collision(p, "bird", other) Then
            other.Visible = False
            ProgressBar1.Value = ProgressBar1.Value + 1
            Return
        End If
        If p.Name = "PictureBox1" And Collision(p, "bird") Then
            Me.BackgroundImage = PictureBox2.Image
            Return
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles bird1timer.Tick
        chase(bird1)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles bullettimer.Tick
        MoveTo(Bullet, 25, 0)
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles bird2timer.Tick
        chase(bird2)
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles bird3timer.Tick
        chase(bird3)
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles bird4timer.Tick
        chase(bird4)
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles bird5timer.Tick
        chase(bird5)
    End Sub

    Private Sub Gravity_Tick(sender As Object, e As EventArgs) Handles Gravity.Tick
        MoveTo(PictureBox1, 0, 0.5)
    End Sub

    Private Sub bird6timer_Tick(sender As Object, e As EventArgs) Handles bird6timer.Tick
        chase(bird6)
    End Sub
    Private Sub bird7timer_Tick(sender As Object, e As EventArgs) Handles bird7timer.Tick
        chase(bird7)
    End Sub
End Class


