//Example of simple event handling in C# using custom delegate
using System;
class Button
{
    public delegate void ButtonClickHandler(object sender, EventArgs e);
    public event ButtonClickHandler Clicked;
    public void Click()
    {
        Console.WriteLine("Button clicked!");
        Clicked?.Invoke(this, EventArgs.Empty);
    }
}
class Program
{
    static void OnButtonClicked(object sender, EventArgs e)
    {
        Console.WriteLine("Subscriber received event");
    }
    static void Main()
    {
        Button button = new Button();
        button.Clicked += OnButtonClicked;
        button.Click();
    }
}
