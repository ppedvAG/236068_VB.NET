Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim meinAuto As Auto 'deklaration
        meinAuto = New Auto("gelb") 'instanzierung

        meinAuto.Hersteller = "Porsche"
        'meinAuto.Farbe = "gelb"
        meinAuto.Model = "311"
        meinAuto.PS = -27

        ZeigeAuto(meinAuto)

        Dim zweitWagen As Auto = New Auto() 'deklaration & instanzierung
        zweitWagen.Hersteller = "BMW"
        zweitWagen.Model = "lala"
        zweitWagen.PS = 44
        zweitWagen.Farbe = "rosa"
        ZeigeAuto(zweitWagen)
        zweitWagen.MachSchneller()
        ZeigeAuto(zweitWagen)
        zweitWagen.MachSchneller()
        ZeigeAuto(zweitWagen)

    End Sub

    Sub ZeigeAuto(auto As Auto)
        Console.WriteLine($"{auto.Hersteller} {auto.Model} {auto.Farbe} {auto.PS}PS")
    End Sub

End Module
