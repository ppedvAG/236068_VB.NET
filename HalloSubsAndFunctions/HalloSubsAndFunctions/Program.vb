Imports System

Module Program
    Sub Main(args As String())

        If args.Contains("help") Then
            ShowHelp()
        End If

        SagHallo()
        SagHallo()
        SagHallo("Fred")
        Dim fünf As Integer = GibMirFünf()
        SagHallo("Fred", fünf)

        Console.WriteLine($"Summ: {Summe(1, 5, 7)}")
        Console.WriteLine($"Summ: {Summe(1, 5, 7, 5, 67, 999, 3, 4, 4)}")
    End Sub

    Private Sub ShowHelp()
        Console.WriteLine("Ein tolle test Programm für Functions")
    End Sub

    Function Summe(ParamArray values() As Integer) As Integer
        Return values.Sum()
    End Function

    Function GibMirFünf() As Integer

        If DateTime.Now.DayOfWeek <> DayOfWeek.Monday Then
            Return 2
        End If

        Return 5
    End Function

    Sub SagHallo()
        Console.WriteLine("Hallo")
    End Sub

    Sub SagHallo(name As String)
        Console.WriteLine($"Hallo {name}")
    End Sub

    Sub SagHallo(name As String, nummer As Integer)
        Console.WriteLine($"Hallo {name} Nummer {nummer}")
    End Sub

End Module
