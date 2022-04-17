Imports System.Drawing.Drawing2D
Public Class UserControl1
    '--------------------------------------------------------------------------------
    '-                      File Name: UserControl1                                 -
    '-                      Part of Project: custom framework control program       -
    '--------------------------------------------------------------------------------
    '-                      Written By: Andrew A. Loesel                            -
    '-                      Written On: April 14, 2022                              -
    '--------------------------------------------------------------------------------
    '- File Purpose:                                                                -
    '-                                                                              -
    '- This file contains the definition of how we want our custom control to       -
    '- function.                                                                    -
    '--------------------------------------------------------------------------------
    '- Program Purpose:                                                             -
    '-                                                                              -
    '- The purpose of this program is to create a custom control for windows forms, -
    '- and implement this crontrol on a forms application.                          -
    '--------------------------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):                                 -
    '- theEndColor - the end color of our gradient.                                 -
    '- theGradientMode - the gradient mode of our control.                          -
    '- theStartColor - the start color of our gradient.                             -
    '--------------------------------------------------------------------------------
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
        '------------------------------------------------------------------------------
        '-                      Subprogram Name: OnPaint                              -
        '------------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                          -
        '-                      Written On: April 14, 2022                             -
        '------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                        -
        '-                                                                            -
        '- The purpose of this subprogram is to add a new student into our list and   -
        '- make sure their data is displayed and used in excel. We first try to create-
        '- a new student object from the textbox values, if an exception is triggered -
        '- during this we print out a message to tell the user to use the specified   -
        '- format in the textbox hints. We then clear all of our textboxes.           -
        '------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                 -
        '- e - Holds the EventArgs object sent to the routine.                        -
        '------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                -
        '- myBrush - a linear gradient brush that we will use to put a linear gradient-
        '-           on the control.                                                  -
        '------------------------------------------------------------------------------
        Dim myBrush As New LinearGradientBrush(Me.ClientRectangle, theStartColor, theEndColor, theGradientMode)
        e.Graphics.FillRectangle(myBrush, Me.ClientRectangle)

        myBrush.Dispose()

        MyBase.OnPaint(e)
    End Sub


End Class
