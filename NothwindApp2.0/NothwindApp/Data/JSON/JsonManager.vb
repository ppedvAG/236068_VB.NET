Imports System.IO
Imports System.Text.Encodings.Web
Imports System.Text.Json
Imports System.Text.Unicode

Public Class JsonManager
    Implements IEmployeeRepository

    Dim fileName As String

    Public Sub New(fileName As String)
        Me.fileName = fileName
    End Sub

    Public Sub SaveAll(employees As List(Of Employee)) Implements IEmployeeRepository.SaveAll

        Dim ops = New JsonSerializerOptions With {
                            .Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.All),
                            .WriteIndented = True
                            }
        Dim json = JsonSerializer.Serialize(employees, ops)
        File.WriteAllText(fileName, json)

    End Sub

    Public Function GetAll() As List(Of Employee) Implements IEmployeeRepository.GetAll

        Dim json = File.ReadAllText(fileName)

        Return JsonSerializer.Deserialize(Of List(Of Employee))(json)

    End Function
End Class
