Imports System.Windows.Threading
Imports System.Windows.SystemColors
Imports System.Windows.Media
Imports System.Windows
Imports System
Imports System.Collections.Generic


Public Class MainPage
    Inherits UserControl

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
    'Dim xPos As Integer
    'Dim yPos As Integer

    Dim rightDown As Boolean
    Dim leftDown As Boolean
    Dim upDown As Boolean
    Dim downDown As Boolean
    Dim spaceDown As Boolean

    Dim d As DispatcherTimer
    Dim t As DispatcherTimer
    Dim k As Integer = 0

    Dim rnd As New Random
    Dim cycleCounter As Integer = 0
    Dim zombieCounter As Integer = 0

    Dim Direction As Integer

    Dim bulletTime As Date 'jay
    Dim timeKeeper As Date


    Public Sub New()
        InitializeComponent()

        rightDown = False
        leftDown = False
        upDown = False
        downDown = False


        Create_GameObjects()

        lblHealth_Amount.Content = "Progress Bar Not Draining."

        'Ammo_List = New Collection
        Ammo = New LinkedList(Of Projectile)

        d = New DispatcherTimer()
        d.Interval = New TimeSpan(0, 0, 0, 0, 1)
        AddHandler d.Tick, AddressOf Do_Work
        bulletTime = Now() 'jay
        timeKeeper = Now()

    End Sub


    Public Sub Do_Work()

        Dim elapsed As Integer = (Now - timeKeeper).TotalMilliseconds 'jay

        'debug lblHealth_Amount.Content = elapsed & " " & Undead(0).XPos 'bkh1.Health.ToString()

        'Step 1 Move player
        bkh1.MoveObject(elapsed)

        'Step 2: Move bullets
        For Each Bullet As Projectile In Ammo
            Bullet.MoveObject(elapsed)
        Next

        'Step 3: Create new bullets
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



        'Step 4: Check zombie/bullet collision
        'Check if a bullet hits a zombie - jay
        For i As Integer = 0 To Undead.Length - 1
            If (Not Undead(i) Is Nothing) AndAlso (Undead(i).XPos > -Undead(i).ObjectImage.Width And Undead(i).XPos < Canvas1.ActualWidth) Then

                Dim node As LinkedListNode(Of Projectile) = Ammo.First
                While Not node Is Nothing
                    Dim nextNode = node.Next
                    If GameObject.CheckCollision(Undead(i).ObjectImage, node.Value.ObjectImage) Then
                        Undead(i).Health -= 1
                        Canvas1.Children.Remove(node.Value.ObjectImage)
                        Ammo.Remove(node)
                        If Undead(i).Health <= 0 Then
                            Undead(i).Zombie_Attack = False
                            lblHealth_Amount.Content = "Progress bar not draining"
                            Canvas1.Children.Remove(Undead(i).ObjectImage)
                            Undead(i) = Nothing
                            Exit While
                        End If
                    End If
                    node = nextNode
                End While
            End If
        Next

        'Step X: Get rid of bullets off screen
        'Destroy bullets off screen
        Dim node1 As LinkedListNode(Of Projectile) = Ammo.First
        While Not node1 Is Nothing
            Dim nextNode = node1.Next
            If node1.Value.XPos > Canvas1.ActualWidth Or node1.Value.XPos < 0 Then
                Canvas1.Children.Remove(node1.Value.ObjectImage)
                Ammo.Remove(node1)
            End If
            node1 = nextNode
        End While

        'Step 5: Move zombies
        For i As Integer = 0 To Undead.Length - 1
            If Not Undead(i) Is Nothing Then
                Undead(i).MoveObject(elapsed)
            End If
        Next

        'Step 6: 
        For i As Integer = 0 To Undead.Length - 1
            If Not Undead(i) Is Nothing Then
                If Undead(i).Zombie_Attack = False Then
                    If GameObject.CheckCollision(Undead(i).ObjectImage, bkh1.ObjectImage) Then
                        Undead(i).Zombie_Attack = True
                        Undead(i).Moving = False
                        lblHealth_Amount.Content = "Progress bar Draining"
                    End If
                End If
            End If
        Next

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
        timeKeeper = Now()


    End Sub

    Private Sub MainPage_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        d.Start()
    End Sub

    Private Sub MainPage_KeyDown(sender As Object, e As System.Windows.Input.KeyEventArgs) Handles Me.KeyDown
        If e.Key = Key.Right Then
            rightDown = True
            leftDown = False
            bkh1.DirRight = True
            bkh1.DirLeft = False
        End If
        If e.Key = Key.Left Then
            leftDown = True
            rightDown = False
            bkh1.DirLeft = True
            bkh1.DirRight = False
        End If
        If e.Key = Key.Up Then
            upDown = True
        End If
        If e.Key = Key.Down Then
            downDown = True
        End If
        If e.Key = Key.Space Then
            If spaceDown = False Then
                bulletTime = Now
                spaceDown = True
                Create_Projectile()
            End If

        End If

    End Sub

    Private Sub MainPage_KeyUp(sender As Object, e As System.Windows.Input.KeyEventArgs) Handles Me.KeyUp
        If e.Key = Key.Right Then
            rightDown = False
            bkh1.DirRight = False
        End If
        If e.Key = Key.Left Then
            leftDown = False
            bkh1.DirLeft = False
        End If
        If e.Key = Key.Up Then
            upDown = False
        End If
        If e.Key = Key.Down Then
            downDown = False
        End If
        If e.Key = Key.Space Then
            spaceDown = False
        End If

    End Sub

    Public Sub Create_GameObjects()

        'Create Butt Kicking Hero
        Dim bkhHealth As Integer = 20
        Dim bkhSpeed As Integer = 10
        Dim bkhXPos As Integer = Canvas1.ActualWidth / 2 - 37
        Dim bkhYpos As Integer = 350
        Dim HeroColor As New SolidColorBrush(Colors.Red)
        Dim bkhCanvas As New Canvas
        bkhCanvas.Background = HeroColor
        bkhCanvas.Height = 100
        bkhCanvas.Width = 75
        bkh1 = New ButtKickingHeroes(bkhSpeed, bkhXPos, bkhYpos, False, False, False, False, False, bkhCanvas, bkhHealth)
        Canvas1.Children.Add(bkhCanvas)
        Canvas.SetLeft(bkhCanvas, bkhXPos)
        Canvas.SetTop(bkhCanvas, bkhYpos)

        'Create(zombies)

        For i As Integer = 0 To 99
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
            Dim BzYPos As Integer = 350

            Dim ZombieColor As New SolidColorBrush(Color.FromArgb(255, rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)))
            Dim bzCanvas As New Canvas
            bzCanvas.Height = 100
            bzCanvas.Width = 75
            bzCanvas.Background = ZombieColor
            BzXPos = rnd.Next(-22700, -400)
            Dim Zombie_Attack As Boolean = False
            Dim z1 As New BaseZombie(BzSpeed, BzXPos, BzYPos,
                True, False, True, False, False, bzCanvas, BzHealth, bkh1, False)

            Canvas1.Children.Add(bzCanvas)
            Canvas.SetLeft(bzCanvas, BzXPos)
            Canvas.SetTop(bzCanvas, BzYPos)
            Undead(i) = z1



        Next

        For i As Integer = 100 To 199
            'Resize array to fit another zombie
            If Undead Is Nothing Then
                ReDim Undead(0)
            Else
                ReDim Preserve Undead(Undead.Length)
            End If

            'Basic zombie values
            Dim BzSpeed As Integer = rnd.Next(100, 201)
            Dim BzHealth As Integer = 1
            Dim BzXPos As Integer
            Dim BzYPos As Integer = 350

            Dim ZombieColor As New SolidColorBrush(Color.FromArgb(255, rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)))
            Dim bzCanvas As New Canvas
            bzCanvas.Height = 100
            bzCanvas.Width = 75
            bzCanvas.Background = ZombieColor
            BzXPos = rnd.Next(1000, 22700)
            Dim Zombie_Attack As Boolean = False
            Dim z1 As New BaseZombie(BzSpeed, BzXPos, BzYPos,
                True, True, False, False, False, bzCanvas, BzHealth, bkh1, False)

            Canvas1.Children.Add(bzCanvas)
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
        Canvas1.Children.Add(proCanvas)
        Canvas.SetLeft(proCanvas, proXpos)
        Canvas.SetTop(proCanvas, proYpos)
        'Ammo_List.Add(p1)
        Ammo.AddLast(p1)
        bulletTime = Now()
        firing = True
    End Sub



End Class



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