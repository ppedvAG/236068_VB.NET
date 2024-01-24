Imports System
Imports System.Net
Imports Fahrzeugpark

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine($"InstanzZähler: {Fahrzeug.InstanzZähler}")
        Dim pkw1 As PKW = New PKW()
        Console.WriteLine(pkw1.ToString())
        pkw1.MaximalGeschwindigkeit = 250
        Console.WriteLine(pkw1.BeschreibeMich())
        ZeigeFahrzeug(pkw1)
        Console.WriteLine($"InstanzZähler: {Fahrzeug.InstanzZähler}")

        Dim zahl As Integer = 12
        Console.WriteLine(zahl)
        ChangeNumer(zahl)
        Console.WriteLine(zahl)

        Dim meinF As Fahrzeug = Nothing
        meinF = New PKW()
        Console.WriteLine($"InstanzZähler: {Fahrzeug.InstanzZähler}")

        ZeigeFahrzeug(meinF)

        meinF.MaximalGeschwindigkeit = 200
        meinF.StarteMotor()
        meinF.Beschleunige(12)
        Console.WriteLine(meinF.BeschreibeMich())
        ChangeGesch(meinF)
        Console.WriteLine(meinF.BeschreibeMich())

        Dim liste = New List(Of PKW)
        While True
            liste.Add(New PKW)
        End While

    End Sub

    Private Sub ZeigeFahrzeug(meinF As Fahrzeug)
        Console.WriteLine($"ZeigeFahrzeug: {meinF.BeschreibeMich()} OK:{meinF.IstFahrbereit()}")
    End Sub

    Private Sub ChangeGesch(meinF As Fahrzeug)
        meinF.MaximalGeschwindigkeit = 666
    End Sub

    Private Sub ChangeNumer(ByRef zahl As Integer)
        zahl = 666
    End Sub
End Module
