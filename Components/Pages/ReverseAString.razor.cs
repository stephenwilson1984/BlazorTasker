namespace BlazorTasker.Components.Pages;

public partial class ReverseAString
{
    private string message = "Reverse me";
    private string reversedMessage = string.Empty;
    private string displayMessage = string.Empty;
    private bool isPalindrome = false;
    private string cssClass = string.Empty;

    private void ReverseString()
    {
        var charArray = message.ToCharArray();
        Array.Reverse(charArray);
        reversedMessage = new string(charArray);
        displayMessage = $"The reverse of '{message}' is '{reversedMessage}'";

        isPalindrome = string.Equals(message, reversedMessage, StringComparison.OrdinalIgnoreCase);
        if (isPalindrome)
        {
            displayMessage += " (This is a palindrome!)";
        }
        
        cssClass = isPalindrome ? "alert-success" : "alert-info";
    }
}