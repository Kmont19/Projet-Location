Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class ItemInfo
        Public StartTime As DateTime
        Public EndTime As DateTime
        Public Text As String
        Public A As Integer
        Public R As Integer
        Public G As Integer
        Public B As Integer
        Private pattern As HatchStyle
        Private patternColor As Color

        Public Sub New()
        End Sub

        Public Sub New(ByVal startTime As DateTime, ByVal endTime As DateTime, ByVal text As String, ByVal color As Color)
            startTime = startTime
            endTime = endTime
            text = text
            A = color.A
            R = color.R
            G = color.G
            B = color.B
        End Sub
    End Class

