Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports PalindromeCheck

<TestClass()> Public Class PalindromeCheckTest

    <TestMethod()> Public Sub PalindromeCheck_ShouldReturnTrue_ForPalindromeNumber()
        Assert.IsTrue(PalindromeCheckPage.IsPalindrome(121))
    End Sub

    <TestMethod()> Public Sub PalindromeCheck_ShouldReturnFalse_ForNonPalindrome()
        Assert.IsFalse(PalindromeCheckPage.IsPalindrome(123))
    End Sub

    <TestMethod()> Public Sub PalindromeCheck_ShouldReturnTrue_ForSingleDigit()
        Assert.IsTrue(PalindromeCheckPage.IsPalindrome(5))
    End Sub

End Class