Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Web.Mvc
Imports NUnit.Framework
Imports $mvcprojectnamespace$
Imports $mvcprojectnamespace$.Controllers

Imports NIs = NUnit.Framework.Is

<TestFixture()> Public Class HomeControllerTest

    <Test()> Public Sub Index()
        ' Arrange
        Dim controller As New HomeController()

        ' Act
        Dim result As ViewResult = DirectCast(controller.Index(), ViewResult)

        ' Assert
        Dim viewData As ViewDataDictionary = result.ViewData
        Assert.That("Modify this template to jump-start your ASP.NET MVC application.", NIs.EqualTo(viewData("Message")))
    End Sub

    <Test()> Public Sub About()
        ' Arrange
        Dim controller As New HomeController()

        ' Act
        Dim result As ViewResult = DirectCast(controller.About(), ViewResult)

        ' Assert
        Assert.That(result, NIs.Not.Null)
    End Sub

    <Test()> Public Sub Contact()
        ' Arrange
        Dim controller As New HomeController()

        ' Act
        Dim result As ViewResult = DirectCast(controller.Contact(), ViewResult)

        ' Assert
        Assert.That(result, NIs.Not.Null)
    End Sub
End Class
