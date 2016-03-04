Public MustInherit Class GameObject
    Private _speed As Integer
    Private _xPos As Integer
    Private _yPos As Integer
    Private _Moving As Boolean
    Private _dirLeft As Boolean
    Private _dirRight As Boolean
    Private _dirUp As Boolean
    Private _dirDown As Boolean
    Private _objectImage As Canvas

    Public Sub New(ByVal Speed As Integer, ByVal XPos As Integer, ByVal YPos As Integer,
                   ByVal Moving As Boolean, ByVal DirLeft As Boolean, ByVal DirRight As Boolean,
                    ByVal DirUp As Boolean, ByVal DirDown As Boolean, ByVal ObjectImage As Canvas)
        Me.Speed = Speed
        Me.XPos = XPos
        Me.YPos = YPos
        Me.Moving = Moving
        Me.DirLeft = DirLeft
        Me.DirRight = DirRight
        Me.DirUp = DirUp
        Me.DirDown = DirDown
        Me.ObjectImage = ObjectImage
    End Sub


    Public Property Speed As Integer
        Get
            Return Me._speed
        End Get
        Set(ByVal value As Integer)
            Me._speed = value
        End Set
    End Property

    Public Property XPos As Integer
        Get
            Return Me._xPos
        End Get
        Set(value As Integer)
            Me._xPos = value
        End Set
    End Property

    Public Property YPos As Integer
        Get
            Return Me._yPos
        End Get
        Set(value As Integer)
            Me._yPos = value
        End Set
    End Property

    Public Property Moving As Boolean
        Get
            Return Me._Moving
        End Get
        Set(value As Boolean)
            Me._Moving = value
        End Set
    End Property

    Public Property DirLeft As Boolean
        Get
            Return Me._dirLeft
        End Get
        Set(value As Boolean)
            Me._dirLeft = value
        End Set
    End Property

    Public Property DirRight As Boolean
        Get
            Return Me._dirRight
        End Get
        Set(value As Boolean)
            Me._dirRight = value
        End Set
    End Property

    Public Property DirUp As Boolean
        Get
            Return Me._dirUp
        End Get
        Set(value As Boolean)
            Me._dirUp = value
        End Set
    End Property

    Public Property DirDown As Boolean
        Get
            Return Me._dirDown
        End Get
        Set(value As Boolean)
            Me._dirDown = value
        End Set
    End Property

    Public Property ObjectImage As Canvas
        Get
            Return Me._objectImage
        End Get
        Set(value As Canvas)
            Me._objectImage = value
        End Set
    End Property

    Public MustOverride Sub MoveObject(elapsed As Integer)


    ' Static method to check if 2 XAML elements are overlapping taken from
    ' http://codesnipets.wordpress.com/2012/02/25/wpf-or-silverlight-xaml-element-collision-detection/
    ' and converted to VB.NET -jay
    Public Shared Function CheckCollision(ctl1 As FrameworkElement, ctl2 As FrameworkElement) As Boolean ' declares two objects to check for coll

        Dim retval As Boolean = False
        Dim ptTopLeft As Point = New Point(Convert.ToDouble(ctl1.GetValue(Canvas.LeftProperty)),
             Convert.ToDouble(ctl1.GetValue(Canvas.TopProperty)))
        Dim ptBottomRight As Point = New Point(Convert.ToDouble(ctl1.GetValue(Canvas.LeftProperty)) + ctl1.Width,
             Convert.ToDouble(ctl1.GetValue(Canvas.TopProperty)) + ctl1.Height)
        Dim r1 As Rect = New Rect(ptTopLeft, ptBottomRight)

        '//System.Diagnostics.Debug.WriteLine("+++x:" + ptTopLeft.X.ToString() + " Y " + ptTopLeft.Y.ToString() + " " + 
        '   ptBottomRight.X.ToString() + " " + ptBottomRight.Y.ToString());

        Dim ptTopLeft2 As Point = New Point(Convert.ToDouble(ctl2.GetValue(Canvas.LeftProperty)),
            Convert.ToDouble(ctl2.GetValue(Canvas.TopProperty)))
        Dim ptBottomRight2 As Point = New Point(Convert.ToDouble(ctl2.GetValue(Canvas.LeftProperty)) + ctl2.Width,
             Convert.ToDouble(ctl2.GetValue(Canvas.TopProperty)) + ctl2.Height)
        Dim r2 As Rect = New Rect(ptTopLeft2, ptBottomRight2)

        r1.Intersect(r2)
        If Not r1.IsEmpty Then
            retval = True
        End If

        Return retval
    End Function


End Class