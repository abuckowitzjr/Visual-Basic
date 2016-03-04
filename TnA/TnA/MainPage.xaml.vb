Imports System.Windows.Media.Animation
Imports System.Threading
Imports System
Imports System.Windows.Threading
Imports System.Windows.Media
Imports System.Windows.SystemColors
Imports System.Windows
Imports System.Collections.Generic
Imports System.Resources

Partial Public Class MainPage
    Inherits UserControl

    Private WithEvents _gameSurface As GameSurface = GameSurface.GetInstance

    ' Arthur's Variables
    Dim GameStart As Boolean = False
    Dim Easy As Boolean = False
    Dim Medium As Boolean = False
    Dim Hard As Boolean = False

    Dim CharSelChekLft As Boolean = True
    Dim CharSelChekRit As Boolean = True
    Dim d As DispatcherTimer
    Dim time As Date
    Dim backspeed As Integer
    Dim forespeed As Integer
    Dim rightDown As Boolean ' Right and left were duplicated. Took out one.
    Dim leftDown As Boolean
    Dim upDown As Boolean
    Dim downDown As Boolean
    Dim spaceDown As Boolean
    Dim animRunning As Boolean
    Dim xbackPos As Double
    Dim xforePos As Double
    Dim ArthurSelect As Boolean = False
    Dim TravisSelect As Boolean = False
    Dim reverse As Boolean = False
    ' Declare array to hold base zombies
    Public Undead() As BaseZombie
    ' Delcare collection to hold projectiles. (May replace with LinkedList(Of Projectiles)
    'Public Ammo_List As Collection
    ' Declare hero variable
    Dim bkh1 As ButtKickingHeroes
    '  Declare linked list of projectiles.  Linked list stores objects and references to the next object on the list.
    '   If an object in the list is removed, the reference automaticallly points to the next item on the list.
    Dim Ammo As New LinkedList(Of Projectile) ' Try to use linked list instead of collection
    Dim firing As Boolean
    Dim rnd As New Random
    Dim bulletTime As Date 'jay
    Dim timeKeeper As Date
    Dim elapsed As Integer

    'temporary test zombie
    Private z As Zombie
    'temporary test player
    Private h As Hero




    Public Sub New()
        InitializeComponent()

        xbackPos = 0
        xforePos = 0
        rightDown = False
        leftDown = False
        upDown = False
        downDown = False
        spaceDown = False
        animRunning = False

        Ammo = New LinkedList(Of Projectile)

        d = New DispatcherTimer()
        time = Now
        backspeed = 50
        forespeed = 150
        d.Interval = New TimeSpan(0, 0, 0, 0, 1)
        AddHandler d.Tick, AddressOf Do_Work

        bulletTime = Now() 'jay
        timeKeeper = Now()





    End Sub



    Private Sub MainPage_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        ' For now, we are starting the game at the beginging of the first level.  Will get rid of later.
        d.Start()
        TitleLoad.Begin()
        TitleLights.Begin()







        'CanvasSoldierBlueStanding.Visibility = Windows.Visibility.Visible
        'ArthurSelect = True
        'Create_GameObjects()
        'GameStart = True

        'Show the level 1 background
        'Level1Background.Visibility = Windows.Visibility.Visible
        'Level1Foreground.Visibility = Windows.Visibility.Visible
        'Moon.Visibility = Windows.Visibility.Visible

        'ESTABLISHES GAME SURFACE
        _gameSurface.Width = LayoutRoot.Width
        _gameSurface.Height = LayoutRoot.Height
        _gameSurface.SetValue(Canvas.BackgroundProperty, New SolidColorBrush(Colors.Transparent))
        Canvas.SetLeft(_gameSurface, 0)
        Canvas.SetTop(_gameSurface, 0)
        LayoutRoot.Children.Add(_gameSurface)


        'ADD A ZOMBIE TO GAME SURFACE
        z = New Zombie
        _gameSurface.Children.Add(z)
        Canvas.SetLeft(z, 490)
        Canvas.SetTop(z, 400)
        z.ZombieWalkAnimation.Begin()

        'ADD PLAYER TO GAME SURFACE
        h = New Hero
        _gameSurface.Children.Add(h)
        Canvas.SetLeft(h, 350)
        Canvas.SetTop(h, 400)






        'Canvas.SetTop(CanvasSoldierBlue, 0)
        'Dim temp As New Canvas()

    End Sub

    Private Sub MainPage_KeyDown(sender As Object, e As System.Windows.Input.KeyEventArgs) Handles Me.KeyDown

        'PLAYER FLIP CODE
        'If e.Key = Key.Right Then
        '    Dim flipya As ScaleTransform = New ScaleTransform
        '    flipya.ScaleX = -1
        '    Canvas.SetLeft(h, 440)
        '    z.RenderTransform = flipya
        'End If

        'If e.Key = Key.Left Then
        '    Dim flipya As ScaleTransform = New ScaleTransform
        '    flipya.ScaleX = 1
        '    Canvas.SetLeft(h, 350)
        '    z.RenderTransform = flipya
        'End If

        'ZOMBIE FLIP CODE
        If e.Key = Key.Right Then
            Dim flipya As ScaleTransform = New ScaleTransform
            flipya.ScaleX = -1
            Canvas.SetLeft(z, 440)
            z.RenderTransform = flipya

        End If

        If e.Key = Key.Left Then
            Dim flipya As ScaleTransform = New ScaleTransform
            flipya.ScaleX = 1
            Canvas.SetLeft(z, 400)
            z.RenderTransform = flipya
        End If

        '       If e.Key = Key.Right Then
        '           rightDown = True
        '           leftDown = False
        '           bkh1.DirRight = True
        '           bkh1.DirLeft = False
        '           reverse = False
        '       End If
        '       If e.Key = Key.Left Then
        '           leftDown = True
        'rightDown = False
        '           bkh1.DirLeft = True
        '           bkh1.DirRight = False
        '           reverse = True
        '       End If
        '       If e.Key = Key.Up Then
        '           upDown = True
        '       End If
        '       If e.Key = Key.Down Then
        '           downDown = True
        '       End If
        '       If e.Key = Key.Space Then
        '           If spaceDown = False Then
        '               bulletTime = Now
        '               spaceDown = True
        '               Create_Projectile()
        '           End If

        '       End If
    End Sub

    Private Sub MainPage_KeyUp(sender As Object, e As System.Windows.Input.KeyEventArgs) Handles Me.KeyUp





        'If e.Key = Key.Right Then
        '    rightDown = False
        '    bkh1.DirRight = False
        '    If ArthurSelect = True Then
        '        SoldierBlueRunningAnimation.Stop()
        '        SoldierBlueRevRunningAnimation.Stop()
        '        CanvasSoldierBlue.Visibility = Windows.Visibility.Collapsed
        '        CanvasSoldierRevBlue.Visibility = Windows.Visibility.Collapsed
        '        CanvasSoldierBlueStanding.Visibility = Windows.Visibility.Visible
        '    Else
        '        SoldierRedRunningAnimation.Stop()
        '        SoldierRedRevRunningAnimation.Stop()
        '        CanvasSoldierRed.Visibility = Windows.Visibility.Collapsed
        '        CanvasSoldierRevRed.Visibility = Windows.Visibility.Collapsed
        '        CanvasSoldierRedStanding.Visibility = Windows.Visibility.Visible
        '    End If
        'End If
        'If e.Key = Key.Left Then
        '    leftDown = False
        '    bkh1.DirLeft = False
        '    If ArthurSelect = True Then
        '        SoldierBlueRevRunningAnimation.Stop()
        '        SoldierBlueRunningAnimation.Stop()
        '        CanvasSoldierRevBlue.Visibility = Windows.Visibility.Collapsed
        '        CanvasSoldierBlue.Visibility = Windows.Visibility.Collapsed
        '        CanvasSoldierRevBlueStanding.Visibility = Windows.Visibility.Visible
        '    Else
        '        SoldierRedRevRunningAnimation.Stop()
        '        SoldierRedRunningAnimation.Stop()
        '        CanvasSoldierRevRed.Visibility = Windows.Visibility.Collapsed
        '        CanvasSoldierRed.Visibility = Windows.Visibility.Collapsed
        '        CanvasSoldierRevRedStanding.Visibility = Windows.Visibility.Visible
        '    End If
        'End If
        'If e.Key = Key.Up Then
        '    upDown = False
        'End If
        'If e.Key = Key.Down Then
        '    downDown = False
        'End If
        'If e.Key = Key.Space Then
        '    spaceDown = False
        'End If
    End Sub

    Public Sub AnimateBlueChar()
        If reverse = False Then
            If SoldierBlueRunningAnimation.GetCurrentState = ClockState.Active Then
                Exit Sub
            Else
                CanvasSoldierBlueStanding.Visibility = Windows.Visibility.Collapsed
                CanvasSoldierRevBlue.Visibility = Windows.Visibility.Collapsed
                CanvasSoldierRevBlueStanding.Visibility = Windows.Visibility.Collapsed
                CanvasSoldierBlue.Visibility = Windows.Visibility.Visible
                SoldierBlueRunningAnimation.Begin()
            End If
        Else
            If SoldierBlueRevRunningAnimation.GetCurrentState = ClockState.Active Then
                Exit Sub
            Else
                CanvasSoldierRevBlueStanding.Visibility = Windows.Visibility.Collapsed
                CanvasSoldierBlue.Visibility = Windows.Visibility.Collapsed
                CanvasSoldierBlueStanding.Visibility = Windows.Visibility.Collapsed
                CanvasSoldierRevBlue.Visibility = Windows.Visibility.Visible
                SoldierBlueRevRunningAnimation.Begin()
            End If
        End If
    End Sub

    Public Sub AnimateRedChar()
        If reverse = False Then
            If SoldierRedRunningAnimation.GetCurrentState = ClockState.Active Then
                Exit Sub
            Else
                CanvasSoldierRedStanding.Visibility = Windows.Visibility.Collapsed
                CanvasSoldierRevRed.Visibility = Windows.Visibility.Collapsed
                CanvasSoldierRevRedStanding.Visibility = Windows.Visibility.Collapsed
                CanvasSoldierRed.Visibility = Windows.Visibility.Visible
                SoldierRedRunningAnimation.Begin()
            End If
        Else
            If SoldierRedRevRunningAnimation.GetCurrentState = ClockState.Active Then
                Exit Sub
            Else
                CanvasSoldierRevRedStanding.Visibility = Windows.Visibility.Collapsed
                CanvasSoldierRed.Visibility = Windows.Visibility.Collapsed
                CanvasSoldierRedStanding.Visibility = Windows.Visibility.Collapsed
                CanvasSoldierRevRed.Visibility = Windows.Visibility.Visible
                SoldierRedRevRunningAnimation.Begin()
            End If
        End If
    End Sub

    Private Sub GameLoop(Sender As Object, e As RenderFrameEventArgs) Handles _gameSurface.RenderFrame

        ' This is the real game loop we will be using

        elapsed = e.ElapsedTime.TotalMilliseconds

    End Sub

    Public Sub Do_Work()
        If GameStart = True Then
            Background_ForeGround_Start_Animation()
            time = Now
            elapsed = (Now - timeKeeper).TotalMilliseconds 'jay
            'Step 1 Move player
            'bkh1.MoveObject(elapsed)
            'Step 2: Move bullets
            For Each Bullet As Projectile In Ammo
                Bullet.MoveObject(elapsed)
            Next
            'Step 3: Create new bullets
            'Fire a bullet if space is pressed based on a bullets per second value - hard coded right now
            Create_New_Bullets()
            'Step 4: Check zombie/bullet collision
            'Check if a bullet hits a zombie - jay
            Check_ZombieBullet_Collision()
            'Step X: Get rid of bullets off screen
            'Destroy bullets off screen
            Destroy_Bullets_Off_Screen()
            'Step 5: Move zombies
            Move_Zombies()
            'Step 6: Undead_Zombie_Attack
            Undead_Zombie_Attack()
            ' Set TimeKeeper as now
            timeKeeper = Now()
        End If
    End Sub

    Private Sub Background_ForeGround_Start_Animation()
        If rightDown Then
            If xbackPos > -7200 Then
                xbackPos -= backspeed * (Now - time).TotalSeconds
                Canvas.SetLeft(Level1Background, xbackPos)
            Else
                Canvas.SetLeft(Level1Background, 0)
                xbackPos = 0
            End If
            If xforePos > -7200 Then
                xforePos -= forespeed * (Now - time).TotalSeconds
                Canvas.SetLeft(Level1Foreground, xforePos)
            Else
                Canvas.SetLeft(Level1Foreground, 0)
                xforePos = 0
            End If
            If ArthurSelect = True Then
                AnimateBlueChar()
            End If
            If TravisSelect = True Then
                AnimateRedChar()
            End If
        End If
        If leftDown Then

            If xbackPos < 0 Then
                xbackPos += backspeed * (Now - time).TotalSeconds
                Canvas.SetLeft(Level1Background, xbackPos)
            Else
                Canvas.SetLeft(Level1Background, -7200)
                xbackPos = -7200
            End If
            If xforePos < 0 Then
                xforePos += forespeed * (Now - time).TotalSeconds
                Canvas.SetLeft(Level1Foreground, xforePos)
            Else
                Canvas.SetLeft(Level1Foreground, -7200)
                xforePos = -7200
            End If
            If ArthurSelect = True Then
                AnimateBlueChar()
            End If
            If TravisSelect = True Then
                AnimateRedChar()
            End If
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles btnStart.Click
        TitleScreen.Visibility = Windows.Visibility.Collapsed
        CharacterSelection.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub CharacterLeft_MouseEnter(sender As Object, e As System.Windows.Input.MouseEventArgs) Handles CharacterLeft.MouseEnter
        If CharSelChekLft = True Then
            CharacterSelectLeft.Begin()
        End If
        CharSelChekLft = False
        CharSelChekRit = True
    End Sub

    Private Sub CharacterRight_MouseEnter(sender As Object, e As System.Windows.Input.MouseEventArgs) Handles CharacterRight.MouseEnter
        If CharSelChekRit = True Then
            CharacterSelectRight.Begin()
        End If
        CharSelChekRit = False
        CharSelChekLft = True
    End Sub

    Private Sub SoldierBlue_MouseLeftButtonDown(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles SoldierBlue.MouseLeftButtonDown
        ArthurBioPaneAnim()
    End Sub

    Private Sub SoldierRed_MouseLeftButtonDown(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles SoldierRed.MouseLeftButtonDown
        TravisBioPaneAnim()
    End Sub

    Private Sub ArthurBioSelectBtn_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles ArthurBioSelectBtn.Click
        Level1Background.Visibility = Windows.Visibility.Visible
        Level1Foreground.Visibility = Windows.Visibility.Visible
        Moon.Visibility = Windows.Visibility.Visible
        CharacterSelection.Visibility = Windows.Visibility.Collapsed
        ArthurBioPane1.Visibility = Windows.Visibility.Collapsed
        CanvasSoldierBlueStanding.Visibility = Windows.Visibility.Visible
        ArthurSelect = True
        Create_GameObjects()
        GameStart = True
    End Sub

    Private Sub ArthurBioCancelBtn_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles ArthurBioCancelBtn.Click
        ArthurBioPane.Seek(TimeSpan.FromTicks(0))
        ArthurBioPane.Stop()
    End Sub

    Private Sub TravisBioSelectBtn_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles TravisBioSelectBtn.Click
        Level1Background.Visibility = Windows.Visibility.Visible
        Level1Foreground.Visibility = Windows.Visibility.Visible
        Moon.Visibility = Windows.Visibility.Visible
        CharacterSelection.Visibility = Windows.Visibility.Collapsed
        TravisBioPane1.Visibility = Windows.Visibility.Collapsed
        CanvasSoldierRedStanding.Visibility = Windows.Visibility.Visible
        TravisSelect = True
        Create_GameObjects()
        GameStart = True
    End Sub

    Private Sub TravisBioCancelBtn_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles TravisBioCancelBtn.Click
        TravisBioPane.Seek(TimeSpan.FromTicks(0))
        TravisBioPane.Stop()
    End Sub

    Private Sub TravisBioPaneAnim()
        Dim bioAnim As Storyboard = New Storyboard
        bioAnim = Me.Resources("TravisBioPane")
        bioAnim.Begin()
    End Sub

    Private Sub ArthurBioPaneAnim()
        Dim bioAnim As Storyboard = New Storyboard
        bioAnim = Me.Resources("ArthurBioPane")
        bioAnim.Begin()
    End Sub

    Private Sub txtEasy_MouseLeftButtonDown(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles txtEasy.MouseLeftButtonDown
        Easy = True
        Hard = False
        Medium = False
        txtEasy.Foreground = New SolidColorBrush(Color.FromArgb(255, 159, 5, 5))
        txtMedium.Foreground = New SolidColorBrush(Color.FromArgb(255, 255, 255, 255))
        txtHard.Foreground = New SolidColorBrush(Color.FromArgb(255, 255, 255, 255))
        EyeCopyGreen.Visibility = Windows.Visibility.Visible
        EyeCopyYellow.Visibility = Windows.Visibility.Collapsed
        EyeCopyRed.Visibility = Windows.Visibility.Collapsed
    End Sub

    Private Sub txtHard_MouseLeftButtonDown(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles txtHard.MouseLeftButtonDown
        Hard = True
        Easy = False
        Medium = False
        txtHard.Foreground = New SolidColorBrush(Color.FromArgb(255, 159, 5, 5))
        txtEasy.Foreground = New SolidColorBrush(Color.FromArgb(255, 255, 255, 255))
        txtMedium.Foreground = New SolidColorBrush(Color.FromArgb(255, 255, 255, 255))
        EyeCopyRed.Visibility = Windows.Visibility.Visible
        EyeCopyGreen.Visibility = Windows.Visibility.Collapsed
        EyeCopyYellow.Visibility = Windows.Visibility.Collapsed
    End Sub

    Private Sub txtMedium_MouseLeftButtonDown(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles txtMedium.MouseLeftButtonDown
        Medium = True
        Easy = False
        Hard = False
        txtMedium.Foreground = New SolidColorBrush(Color.FromArgb(255, 159, 5, 5))
        txtHard.Foreground = New SolidColorBrush(Color.FromArgb(255, 255, 255, 255))
        txtEasy.Foreground = New SolidColorBrush(Color.FromArgb(255, 255, 255, 255))
        EyeCopyYellow.Visibility = Windows.Visibility.Visible
        EyeCopyRed.Visibility = Windows.Visibility.Collapsed
        EyeCopyGreen.Visibility = Windows.Visibility.Collapsed
    End Sub

    Private Sub OptionScreenAcceptbtn_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles OptionScreenAcceptbtn.Click
        OptionsScreen.Visibility = Windows.Visibility.Collapsed
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles btnOptions.Click
        OptionsScreen.Visibility = Windows.Visibility.Visible
    End Sub

    Public Sub Create_GameObjects()

        'Create Butt Kicking Hero
        Dim bkhHealth As Integer = 20
        Dim bkhSpeed As Integer = 10
        Dim bkhXPos As Integer = LayoutRoot.ActualWidth / 2 - 37
        Dim bkhYpos As Integer = 350
        Dim bkhCanvas As Canvas = New Canvas
        bkhCanvas.Width = 75
        bkhCanvas.Height = 150
        bkhCanvas.Background = New SolidColorBrush(Colors.Transparent)
        bkh1 = New ButtKickingHeroes(bkhSpeed, bkhXPos, bkhYpos, False, False, False, False, False, bkhCanvas, bkhHealth)
        LayoutRoot.Children.Add(bkhCanvas)
        Canvas.SetLeft(bkhCanvas, bkhXPos)
        Canvas.SetTop(bkhCanvas, bkhYpos)

        'Create(zombies)

        For i As Integer = 0 To 2
            'Resize array to fit another zombie
            If Undead Is Nothing Then
                ReDim Undead(0)
            Else
                ReDim Preserve Undead(Undead.Length)
            End If

            'Basic zombie values
            Dim BzSpeed As Integer = rnd.Next(100, 301)
            Dim BzHealth As Integer = 2
            Dim BzXPos As Integer
            Dim BzYPos As Integer = 325

            Dim ZombieColor As New SolidColorBrush(Color.FromArgb(255, rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)))
            Dim bzCanvas As New Canvas
            bzCanvas.Height = 100
            bzCanvas.Width = 75
            bzCanvas.Background = ZombieColor
            BzXPos = rnd.Next(-800, -100)
            Dim Zombie_Attack As Boolean = False
            Dim z1 As New BaseZombie(BzSpeed, BzXPos, BzYPos,
                True, False, True, False, False, bzCanvas, BzHealth, bkh1, False)

            LayoutRoot.Children.Add(bzCanvas)
            Canvas.SetLeft(bzCanvas, BzXPos)
            Canvas.SetTop(bzCanvas, BzYPos)
            Undead(i) = z1

        Next

        For i As Integer = 3 To 5
            'Resize array to fit another zombie
            If Undead Is Nothing Then
                ReDim Undead(0)
            Else
                ReDim Preserve Undead(Undead.Length)
            End If

            'Basic zombie values
            Dim BzSpeed As Integer
            Dim BzHealth As Integer
            If Easy = True Then
                BzHealth = 1
                BzSpeed = 100
            ElseIf Hard = True Then
                BzHealth = rnd.Next(1, 20)
                BzSpeed = rnd.Next(100, 301)
            Else
                BzHealth = rnd.Next(1, 10)
                BzSpeed = rnd.Next(100, 201)
            End If
            Dim BzXPos As Integer
            Dim BzYPos As Integer = 325

            Dim ZombieColor As New SolidColorBrush(Color.FromArgb(255, rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)))
            Dim bzCanvas As New Canvas
            bzCanvas.Height = 100
            bzCanvas.Width = 75
            bzCanvas.Background = ZombieColor
            BzXPos = rnd.Next(1000, 1101)
            Dim Zombie_Attack As Boolean = False
            Dim z1 As New BaseZombie(BzSpeed, BzXPos, BzYPos,
                True, True, False, False, False, bzCanvas, BzHealth, bkh1, False)

            LayoutRoot.Children.Add(bzCanvas)
            Canvas.SetLeft(bzCanvas, BzXPos)
            Canvas.SetTop(bzCanvas, BzYPos)
            Undead(i) = z1

        Next


    End Sub

    Public Sub Create_Projectile()

        Dim proSpeed As Integer = 500 ' jay - You can't control the right and left down with keyup because of the way it is working now
        If bkh1.DirLeft Then
            proSpeed *= -1
        ElseIf bkh1.DirRight Then
            proSpeed *= 1
        End If

        Dim proXpos As Integer = 300
        If bkh1.DirLeft = True Then
            bkh1.DirRight = False
            proXpos = 300
        ElseIf bkh1.DirRight = True Then
            bkh1.DirLeft = False
            proXpos = 500
        End If

        Dim proYpos As Integer = 395
        Dim proColorShow As New SolidColorBrush(Colors.Black)
        Dim proCanvas As New Canvas
        proCanvas.Height = 10
        proCanvas.Width = 10
        proCanvas.Background = proColorShow
        Dim p1 As New Projectile(proSpeed, proXpos, proYpos, False, False,
                                False, False, False, proCanvas, bkh1)
        LayoutRoot.Children.Add(proCanvas)
        Canvas.SetLeft(proCanvas, proXpos)
        Canvas.SetTop(proCanvas, proYpos)
        'Ammo_List.Add(p1)
        Ammo.AddLast(p1)
        bulletTime = Now()
        firing = True
    End Sub

    'Step 3: Create new bullets
    Public Sub Create_New_Bullets()
        'Fire a bullet if space is pressed based on a bullets per second value - hard coded right now
        If spaceDown = True Then
            Dim bulletElapsed As Integer = (Now - bulletTime).TotalMilliseconds 'jay

            If bulletElapsed > (1000 / 5) Then ' 10 is bullets / second should be stored in the projectile class

                Dim counter As Integer = Math.Floor(bulletElapsed / (1000 / 5)) ' 10 is bullets / second should be stored in the projectile class
                If firing Then
                    counter = 1
                    firing = False
                End If
                For i As Integer = 1 To counter
                    Create_Projectile()
                Next
                'lblHealth_Amount.Content = counter & " " & elapsed & " " & bulletElapsed & " " & firing
            End If
        End If
    End Sub

    'Step 4: Check zombie/bullet collision
    'Check if a bullet hits a zombie - jay
    Public Sub Check_ZombieBullet_Collision()
        For i As Integer = 0 To Undead.Length - 1
            If (Not Undead(i) Is Nothing) AndAlso (Undead(i).XPos > -Undead(i).ObjectImage.Width And Undead(i).XPos < LayoutRoot.ActualWidth) Then

                Dim node As LinkedListNode(Of Projectile) = Ammo.First
                While Not node Is Nothing
                    Dim nextNode = node.Next
                    If GameObject.CheckCollision(Undead(i).ObjectImage, node.Value.ObjectImage) Then
                        Undead(i).Health -= 1
                        LayoutRoot.Children.Remove(node.Value.ObjectImage)
                        Ammo.Remove(node)
                        If Undead(i).Health <= 0 Then
                            Undead(i).Zombie_Attack = False
                            LayoutRoot.Children.Remove(Undead(i).ObjectImage)
                            Undead(i) = Nothing
                            Exit While
                        End If
                    End If
                    node = nextNode
                End While
            End If
        Next
    End Sub

    'Step X: Get rid of bullets off screen
    'Destroy bullets off screen
    Public Sub Destroy_Bullets_Off_Screen()
        Dim node1 As LinkedListNode(Of Projectile) = Ammo.First
        While Not node1 Is Nothing
            Dim nextNode = node1.Next
            If node1.Value.XPos > LayoutRoot.ActualWidth Or node1.Value.XPos < 0 Then
                LayoutRoot.Children.Remove(node1.Value.ObjectImage)
                Ammo.Remove(node1)
            End If
            node1 = nextNode
        End While
    End Sub

    'Step 5: Move zombies
    Public Sub Move_Zombies()
        For i As Integer = 0 To Undead.Length - 1
            If Not Undead(i) Is Nothing Then
                Undead(i).MoveObject(elapsed)
            End If
        Next
    End Sub

    'Step 6: Undead_Zombie_Attack
    Public Sub Undead_Zombie_Attack()
        For i As Integer = 0 To Undead.Length - 1
            If Not Undead(i) Is Nothing Then
                If Undead(i).Zombie_Attack = False Then
                    If GameObject.CheckCollision(Undead(i).ObjectImage, bkh1.ObjectImage) Then
                        Undead(i).Zombie_Attack = True
                        Undead(i).Moving = False
                    End If
                End If
            End If
        Next
    End Sub



End Class

'' check if zombie has contact with player
'For i As Integer = 0 To Undead.Length - 1 ' for every zombie in the zombie array
'    If Not Undead(i) Is Nothing Then        ' if the element in the array is not empty
'        If GameObject.CheckCollision(Undead(i).ObjectImage, bkh1.ObjectImage) Then ' check for a collision between the zombies and the player
'            Dim Zombie_Dinner_Time As Integer = Now.Millisecond ' declare a variable for the moment contact is made

'                For j As Integer = 0 To Undead.Length - 1 ' for every zombie that has made contact...
'                    If Not Undead(j) Is Nothing Then  '  if the elelement in the zombie array is not empty...
'                        If Now.Millisecond - Zombie_Dinner_Time > 1000 Then ' check if more than a second has passed between zombie/player contact 
'                            bkh1.Health -= 1 ' subtract one health if so.
'                            lblHealth_Amount.Content = bkh1.Health.ToString() ' reflect that on the label for health
'                            Zombie_Dinner_Time = Now.Millisecond ' reset zombie dinnertime to "now"
'                        End If
'                    End If
'                Next
'            'ElseIf bkh1.Health <= 0 Then ' If player health is 0 or less...
'            '        Canvas1.Children.Remove(bkh1.ObjectImage) ' remove canvas
'            '        lblHealth_Amount.Content = "Dead!" ' Health displays "dead".
'        End If
'    End If
'Next

'For i As Integer = 0 To Undead.Length - 1
'    Dim k As Integer = Ammo_List.Count
'        For j As Integer = 1 To k
'        If Not Undead(i) Is Nothing Then
'            If GameObject.CheckCollision(Undead(i).ObjectImage, DirectCast(Ammo_List(j), Projectile).ObjectImage) Then
'                Canvas1.Children.Remove(Undead(i).ObjectImage)
'                Canvas1.Children.Remove(DirectCast(Ammo_List(j), Projectile).ObjectImage)
'                Ammo_List.Remove(j)
'                Undead(i) = Nothing
'            k -= 1
'            End If
'        End If
'    Next
'Next

'If rightDown = True Then

'ElseIf leftDown = True Then

'ElseIf upDown = True Then

'ElseIf downDown = True Then

'End If

'Private Sub Canvas1_SizeChanged(sender As Object, e As System.Windows.SizeChangedEventArgs) Handles Canvas1.SizeChanged
'    yPos = Canvas1.ActualHeight / 2
'    xPos = Canvas1.ActualWidth / 2
'End Sub


'For i As Integer = 0 To Undead.Length - 1
'    Dim k As Integer = Ammo_List.Count
'    For j As Integer = 1 To k
'        If GameObject.CheckCollision(Undead(i).ObjectImage, DirectCast(Ammo_List(j), Projectile).ObjectImage) Then
'            Canvas1.Children.Remove(Undead(i).ObjectImage)
'            Undead(i) = Nothing
'            Canvas1.Children.Remove(DirectCast(Ammo_List(j), Projectile).ObjectImage)
'            Ammo_List.Remove(j)
'            k -= 1
'        End If
'    Next
'Next

' This code casts a variable as a projectile type when ussing a collection
' not to self - refer to "Classes Project"
'For i As Integer = 1 To Ammo_List.Count
'    Dim bullet As Projectile
'        bullet = DirectCast(Ammo_List(i), Projectile)
'        bullet.MoveObject()
'Next