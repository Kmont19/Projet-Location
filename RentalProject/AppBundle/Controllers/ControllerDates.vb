Public Class ControllerDates

    Shared instance As ControllerDates = Nothing

    Public Shared Function getInstance() As ControllerDates
        If IsNothing(instance) Then
            instance = New ControllerDates()
        End If
        Return instance
    End Function

    ''' <summary>
    ''' Cette fonction vérifie une date passé en paramètre
    ''' pour s'assurer que la date ne soit pas pendant une
    ''' fin de semaine ou une journée fériée.
    ''' </summary>
    ''' <param name="returnDate"></param>
    ''' <returns></returns>
    Public Function isValidReturnDate(returnDate As Date) As Boolean
        Dim returnDayOfWeek As DayOfWeek = returnDate.DayOfWeek
        Dim returnDayOfYear As Integer = returnDate.DayOfYear
        ''' Vérifie si c'est une année bisextile.
        Dim isLeapYear As Boolean = DateTime.IsLeapYear(returnDate.Year)
        Dim returnMonth As Integer = returnDate.Month
        If returnDayOfWeek = DayOfWeek.Saturday Or returnDayOfWeek = DayOfWeek.Sunday Then
            Return False
        End If
        Select Case returnMonth
            Case 1
                ''' Vérifie le nouvel an
                If returnDayOfYear = 1 Then
                    Return False
                End If
            Case 12
                ''' Si c'est une année bisextile on ajoute 1
                ''' a tous les jours apres le mois de février.
                Dim leap As Integer = 0
                If isLeapYear Then
                    leap = 1
                End If
                ''' Vérifie veille du nouvel an
                If returnDayOfYear = (365 + leap) Then
                    Return False
                End If
                ''' Vérifier Noel
                If returnDayOfYear = (359 + leap) Then
                    Return False
                End If
                ''' Vérifie la veille de Noel
                If returnDayOfYear = (358 + leap) Then
                    Return False
                End If
        End Select
        Return True
    End Function
End Class
