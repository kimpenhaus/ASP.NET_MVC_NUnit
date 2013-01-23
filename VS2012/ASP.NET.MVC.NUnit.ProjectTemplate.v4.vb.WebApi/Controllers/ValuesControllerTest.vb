Imports System
Imports System.Collections.Generic
Imports System.Net.Http
Imports System.Text
Imports System.Web.Http
Imports NUnit.Framework
Imports $mvcprojectnamespace$

Imports NIs = NUnit.Framework.Is

<TestFixture()> Public Class ValuesControllerTest
    <Test()> Public Sub GetValues()
        'Arrange
        Dim controller As New ValuesController()

        'Act
        Dim result As IEnumerable(Of String) = controller.GetValues()

        'Assert
        Assert.That(result, NIs.Not.Null)
        Assert.That(2, NIs.EqualTo(result.Count()))
        Assert.That("value1", NIs.EqualTo(result.ElementAt(0)))
        Assert.That("value2", NIs.EqualTo(result.ElementAt(1)))
    End Sub

    <Test()> Public Sub GetValueById()
        'Arrange
        Dim controller As New ValuesController()

        'Act
        Dim result As String = controller.GetValue(5)

        'Assert
        Assert.That("value", NIs.EqualTo(result))
    End Sub

    <Test()> Public Sub PostValue()
        'Arrange
        Dim controller As New ValuesController()

        'Act
        controller.PostValue("value")

        'Assert
    End Sub

    <Test()> Public Sub PutValue()
        'Arrange
        Dim controller As New ValuesController()

        'Act
        controller.PutValue(5, "value")

        'Assert
    End Sub

    <Test()> Public Sub DeleteValue()
        'Arrange
        Dim controller As New ValuesController()

        'Act
        controller.DeleteValue(5)

        'Assert
    End Sub
End Class
