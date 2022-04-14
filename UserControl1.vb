Imports System.Drawing.Drawing2D
Public Class UserControl1
    Dim theStartColor As Color = Color.Red
    Dim theEndColor As Color = Color.White
    Dim theGradientMode As LinearGradientMode = LinearGradientMode.ForwardDiagonal

    Property StartColor() As Color
        Get
            Return (theStartColor)
        End Get
        Set(value As Color)
            theStartColor = value
            Me.Invalidate()
        End Set
    End Property

    Property EndColor() As Color
        Get
            Return (theEndColor)
        End Get
        Set(value As Color)
            theEndColor = value
            Me.Invalidate()
        End Set
    End Property

    Property GradientMode() As LinearGradientMode
        Get
            Return (theGradientMode)
        End Get
        Set(value As LinearGradientMode)
            theGradientMode = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim myBrush As New LinearGradientBrush(Me.ClientRectangle, theStartColor, theEndColor, theGradientMode)
        e.Graphics.FillRectangle(myBrush, Me.ClientRectangle)

        myBrush.Dispose()

        MyBase.OnPaint(e)
    End Sub


End Class
