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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bird1timer = New System.Windows.Forms.Timer(Me.components)
        Me.bird1 = New System.Windows.Forms.PictureBox()
        Me.Win = New System.Windows.Forms.PictureBox()
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.bullettimer = New System.Windows.Forms.Timer(Me.components)
        Me.Picturebox4 = New System.Windows.Forms.PictureBox()
        Me.bird2 = New System.Windows.Forms.PictureBox()
        Me.bird3 = New System.Windows.Forms.PictureBox()
        Me.bird4 = New System.Windows.Forms.PictureBox()
        Me.bird5 = New System.Windows.Forms.PictureBox()
        Me.bird2timer = New System.Windows.Forms.Timer(Me.components)
        Me.bird3timer = New System.Windows.Forms.Timer(Me.components)
        Me.bird4timer = New System.Windows.Forms.Timer(Me.components)
        Me.bird5timer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Gravity = New System.Windows.Forms.Timer(Me.components)
        Me.bird6 = New System.Windows.Forms.PictureBox()
        Me.bird6timer = New System.Windows.Forms.Timer(Me.components)
        Me.bird7timer = New System.Windows.Forms.Timer(Me.components)
        Me.bird7 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bird1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Win, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picturebox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bird2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bird3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bird4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bird5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bird6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bird7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Game.My.Resources.Resources.luigi_official_art
        Me.PictureBox1.Location = New System.Drawing.Point(2, 258)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'bird1timer
        '
        Me.bird1timer.Enabled = True
        '
        'bird1
        '
        Me.bird1.BackColor = System.Drawing.Color.Transparent
        Me.bird1.Image = Global.Game.My.Resources.Resources.bird_clipart_animated_14
        Me.bird1.Location = New System.Drawing.Point(610, 12)
        Me.bird1.Name = "bird1"
        Me.bird1.Size = New System.Drawing.Size(30, 37)
        Me.bird1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bird1.TabIndex = 1
        Me.bird1.TabStop = False
        '
        'Win
        '
        Me.Win.BackColor = System.Drawing.Color.Transparent
        Me.Win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Win.Image = Global.Game.My.Resources.Resources._829896_flag_512x512
        Me.Win.Location = New System.Drawing.Point(761, 60)
        Me.Win.Name = "Win"
        Me.Win.Size = New System.Drawing.Size(91, 140)
        Me.Win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Win.TabIndex = 2
        Me.Win.TabStop = False
        '
        'Bullet
        '
        Me.Bullet.BackColor = System.Drawing.Color.Transparent
        Me.Bullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bullet.Image = Global.Game.My.Resources.Resources.projectile_fireball
        Me.Bullet.Location = New System.Drawing.Point(2, 216)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(58, 36)
        Me.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Bullet.TabIndex = 3
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'bullettimer
        '
        Me.bullettimer.Enabled = True
        '
        'Picturebox4
        '
        Me.Picturebox4.Image = Global.Game.My.Resources.Resources.download__11_
        Me.Picturebox4.Location = New System.Drawing.Point(24, 12)
        Me.Picturebox4.Name = "Picturebox4"
        Me.Picturebox4.Size = New System.Drawing.Size(64, 57)
        Me.Picturebox4.TabIndex = 4
        Me.Picturebox4.TabStop = False
        Me.Picturebox4.Visible = False
        '
        'bird2
        '
        Me.bird2.BackColor = System.Drawing.Color.Transparent
        Me.bird2.Image = Global.Game.My.Resources.Resources.bird_clipart_animated_14
        Me.bird2.Location = New System.Drawing.Point(740, 309)
        Me.bird2.Name = "bird2"
        Me.bird2.Size = New System.Drawing.Size(46, 48)
        Me.bird2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bird2.TabIndex = 5
        Me.bird2.TabStop = False
        '
        'bird3
        '
        Me.bird3.BackColor = System.Drawing.Color.Transparent
        Me.bird3.Image = Global.Game.My.Resources.Resources.bird_clipart_animated_14
        Me.bird3.Location = New System.Drawing.Point(610, 309)
        Me.bird3.Name = "bird3"
        Me.bird3.Size = New System.Drawing.Size(48, 31)
        Me.bird3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bird3.TabIndex = 6
        Me.bird3.TabStop = False
        '
        'bird4
        '
        Me.bird4.BackColor = System.Drawing.Color.Transparent
        Me.bird4.Image = Global.Game.My.Resources.Resources.bird_clipart_animated_14
        Me.bird4.Location = New System.Drawing.Point(678, 89)
        Me.bird4.Name = "bird4"
        Me.bird4.Size = New System.Drawing.Size(47, 45)
        Me.bird4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bird4.TabIndex = 7
        Me.bird4.TabStop = False
        '
        'bird5
        '
        Me.bird5.BackColor = System.Drawing.Color.Transparent
        Me.bird5.Image = Global.Game.My.Resources.Resources.bird_clipart_animated_14
        Me.bird5.Location = New System.Drawing.Point(707, 12)
        Me.bird5.Name = "bird5"
        Me.bird5.Size = New System.Drawing.Size(49, 42)
        Me.bird5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bird5.TabIndex = 8
        Me.bird5.TabStop = False
        '
        'bird2timer
        '
        Me.bird2timer.Enabled = True
        '
        'bird3timer
        '
        Me.bird3timer.Enabled = True
        '
        'bird4timer
        '
        Me.bird4timer.Enabled = True
        '
        'bird5timer
        '
        Me.bird5timer.Enabled = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Game.My.Resources.Resources.download__5_
        Me.PictureBox2.Location = New System.Drawing.Point(24, 84)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Gravity
        '
        Me.Gravity.Enabled = True
        '
        'bird6
        '
        Me.bird6.BackColor = System.Drawing.Color.Transparent
        Me.bird6.Image = Global.Game.My.Resources.Resources.bird_clipart_animated_14
        Me.bird6.Location = New System.Drawing.Point(591, 92)
        Me.bird6.Name = "bird6"
        Me.bird6.Size = New System.Drawing.Size(49, 42)
        Me.bird6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bird6.TabIndex = 10
        Me.bird6.TabStop = False
        '
        'bird6timer
        '
        Me.bird6timer.Enabled = True
        '
        'bird7timer
        '
        Me.bird7timer.Enabled = True
        '
        'bird7
        '
        Me.bird7.BackColor = System.Drawing.Color.Transparent
        Me.bird7.Image = Global.Game.My.Resources.Resources.bird_clipart_animated_14
        Me.bird7.Location = New System.Drawing.Point(487, 207)
        Me.bird7.Name = "bird7"
        Me.bird7.Size = New System.Drawing.Size(47, 45)
        Me.bird7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bird7.TabIndex = 11
        Me.bird7.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(2, 418)
        Me.ProgressBar1.Maximum = 7
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(796, 41)
        Me.ProgressBar1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Game.My.Resources.Resources.images__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(798, 457)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.bird7)
        Me.Controls.Add(Me.bird6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.bird5)
        Me.Controls.Add(Me.bird4)
        Me.Controls.Add(Me.bird3)
        Me.Controls.Add(Me.bird2)
        Me.Controls.Add(Me.Picturebox4)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.Win)
        Me.Controls.Add(Me.bird1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Luigi's Evil Birds"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bird1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Win, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picturebox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bird2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bird3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bird4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bird5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bird6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bird7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bird1timer As Timer
    Friend WithEvents bird1 As PictureBox
    Friend WithEvents Win As PictureBox
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents bullettimer As Timer
    Friend WithEvents Picturebox4 As PictureBox
    Friend WithEvents bird2 As PictureBox
    Friend WithEvents bird3 As PictureBox
    Friend WithEvents bird4 As PictureBox
    Friend WithEvents bird5 As PictureBox
    Friend WithEvents bird2timer As Timer
    Friend WithEvents bird3timer As Timer
    Friend WithEvents bird4timer As Timer
    Friend WithEvents bird5timer As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Gravity As Timer
    Friend WithEvents bird6 As PictureBox
    Friend WithEvents bird6timer As Timer
    Friend WithEvents bird7timer As Timer
    Friend WithEvents bird7 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
