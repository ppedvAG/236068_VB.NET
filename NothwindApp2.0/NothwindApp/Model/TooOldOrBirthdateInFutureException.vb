Class TooOldOrBirthdateInFutureException
    Inherits Exception
    Public ReadOnly Property Birthdate As Date
    Public ReadOnly Property Today As Date

    Sub New(msg As String, birthdate As DateTime, today As DateTime)
        MyBase.New(msg)
        Me.Birthdate = birthdate
        Me.Today = today
    End Sub
End Class
