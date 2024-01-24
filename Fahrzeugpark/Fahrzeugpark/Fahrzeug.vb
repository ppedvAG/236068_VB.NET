Public MustInherit Class Fahrzeug
    Inherits Object
    ' Eigenschaften
    Public Property Name As String
    Public Property MaximalGeschwindigkeit As Integer
    Public Property Preis As Decimal
    Public Property AktuelleGeschwindigkeit As Integer = 0
    Public Property Zustand As String = "Stehend"


    Public Shared Property InstanzZähler As Integer = 0

    ' Konstruktoren
    Public Sub New()
        ' Standardkonstruktor
        InstanzZähler += 1
    End Sub

    Public MustOverride Function IstFahrbereit() As Boolean

    Public Sub New(ByVal name As String, ByVal maxGeschwindigkeit As Integer, ByVal preis As Decimal)
        Me.Name = name
        Me.MaximalGeschwindigkeit = maxGeschwindigkeit
        Me.Preis = preis
    End Sub

    ' Methoden
    Public Sub Beschleunige(ByVal geschwindigkeit As Integer)
        If AktuelleGeschwindigkeit + geschwindigkeit <= MaximalGeschwindigkeit Then
            AktuelleGeschwindigkeit += geschwindigkeit
        End If
    End Sub

    Public Sub StarteMotor()
        Zustand = "Fahrend"
    End Sub

    Public Sub StoppeMotor()
        Zustand = "Stehend"
        AktuelleGeschwindigkeit = 0
    End Sub

    Public Overridable Function BeschreibeMich() As String
        Return $"Name: {Name}, Max. Geschwindigkeit: {MaximalGeschwindigkeit}, Preis: {Preis}, Aktuelle Geschwindigkeit: {AktuelleGeschwindigkeit}, Zustand: {Zustand}"
    End Function
End Class
