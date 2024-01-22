Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("*** MINI - RECHNER ***")

        Console.WriteLine("Bitte eine Zahl eingeben:")
        Dim eingabe As String = Console.ReadLine()
        Console.WriteLine($"Eingabe: {eingabe}")

        Dim eingabeAlsZahl As Double = eingabe
        Console.WriteLine($"Das doppelte: {eingabeAlsZahl * 2}")

        Console.WriteLine("Ende")
    End Sub
End Module
