Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim myPizzaSize As PizzaSize = PizzaSize.Large

        Select Case myPizzaSize
            Case PizzaSize.Small
                Console.WriteLine("F�r den kleinen hunger")
            Case PizzaSize.Large
                Console.WriteLine("F�r den gro�en hunger")
            Case PizzaSize.Family
            Case PizzaSize.Party
                Console.WriteLine("F�r den mehrere Personen")
        End Select

        Console.WriteLine(DateTime.Now.DayOfWeek.ToString())

        Select Case DateTime.Now.DayOfWeek
            Case DayOfWeek.Sunday
                Exit Select
            Case DayOfWeek.Monday
                Exit Select
            Case DayOfWeek.Tuesday
                Exit Select
            Case DayOfWeek.Wednesday
                Exit Select
            Case DayOfWeek.Thursday
                Exit Select
            Case DayOfWeek.Friday
                Exit Select
            Case DayOfWeek.Saturday
                Exit Select
        End Select

    End Sub

    Enum PizzaSize
        Small = 7
        Large = 12
        Family = 25
        Party = 99
    End Enum

End Module
