

Public Class PKW
    Inherits Fahrzeug

    'Public Function BeschreibePKW() As String
    '    Return $"{MyBase.BeschreibeMich()} ist ein PKW"
    'End Function

    Public Overrides Function BeschreibeMich() As String
        Return MyBase.BeschreibeMich() + " Das ist ein PKW"
    End Function

    Public Overrides Function IstFahrbereit() As Boolean
        Return True
    End Function

    Public Overrides Function ToString() As String
        Return "LALA bin ein PKW"
    End Function
End Class
