Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Web.Mvc
Imports NUnit.Framework
Imports $mvcprojectnamespace$
Imports $mvcprojectnamespace$.Controllers

<TestFixture()> Public Class HomeControllerTest

    <Test()> Public Sub Index()
        ' Arrange
        Dim controller As HomeController = New HomeController()

        ' Act
        Dim result As ViewResult = CType(controller.Index(), ViewResult)

        ' Assert
        Dim viewData As ViewDataDictionary = result.ViewData
        Assert.That("Welcome to ASP.NET MVC!", Is.EqualTo(viewData("Message")))
    End Sub

    <Test()> Public Sub About()
        ' Arrange
        Dim controller As HomeController = New HomeController()

        ' Act
        Dim result As ViewResult = CType(controller.About(), ViewResult)

        ' Assert
        Assert.That(result, Is.Not.Null)
    End Sub
End Class
