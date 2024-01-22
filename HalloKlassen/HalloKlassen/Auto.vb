Class Auto

    'Auto-Property
    Public Property Hersteller As String

    'Auto-Property
    Public Property Model As String

    Private _PS As Integer
    Public Property PS As Integer
        Get
            Return _PS
        End Get
        Set(value As Integer)
            If value < 0 Then
                value *= -1
            End If
            _PS = value
        End Set
    End Property

    'backing field
    Private _farbe As String

    'full property
    Public Property Farbe() As String
        Get
            Return _farbe
        End Get
        Set(value As String)
            If value = "rosa" Then
                _farbe = "schwarz"
            Else
                _farbe = value
            End If
        End Set
    End Property


    Private Sub MachSuperSchnell()
        PS += 100
    End Sub

    Public Sub MachSchneller()
        If Model.Contains("tuned") Then
            MachSuperSchnell()
        Else
            PS += 10
            Model += " tuned"
        End If
    End Sub

    'default konstructor
    Sub New()
        _farbe = "blau"
    End Sub

    'konstructor
    Sub New(farbe As String)
        'Me.Farbe = farbe
        _farbe = farbe
    End Sub

End Class
