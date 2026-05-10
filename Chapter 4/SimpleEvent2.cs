//Example of using simple event using built-in EventHandler delegate
using System;
class Button
{
    public event EventHandler Clicked;
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
