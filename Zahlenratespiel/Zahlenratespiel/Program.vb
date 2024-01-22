Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Console.WriteLine("Rate die Zahl:")
        Dim eingabe As Integer = Console.ReadLine()

        Dim random As Integer = New Random().Next(1, 100)
        Console.WriteLine($"Gesuchte zahl: {random}")

        If eingabe < random Then
            Console.WriteLine($"Die eingabe war kleiner")
        ElseIf eingabe > random Then
            Console.WriteLine($"Die eingabe war größer")
        ElseIf eingabe = random Then
            Console.WriteLine($"Die eingabe extaxt getroffen")
        End If

        Console.WriteLine($"Ende")
    End Sub
End Module
