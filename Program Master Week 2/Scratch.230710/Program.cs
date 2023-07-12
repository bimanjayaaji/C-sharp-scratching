namespace week2;

class Program
{
    static void Main(string[] args)
    {
        // Usage example
        Button button = new Button();
        Subscriber subscriber = new Subscriber();

        // Subscribe to the button's click event
        button.Click += subscriber.HandleClick;

        // Simulate a button click
        button.SimulateClick("Hello, events!");
    }
}

class Button
{
    // Define a delegate type for the event
    public delegate void ClickHandler(string message);

    // Define an event of the delegate type
    public event ClickHandler Click;

    // Method to simulate the button click and raise the event
    public void SimulateClick(string message)
    {
        Console.WriteLine("Button clicked: " + message);
        Click?.Invoke(message);
    }
}

class Subscriber
{
    public void HandleClick(string message)
    {
        Console.WriteLine("Subscriber received click event: " + message);
    }
}
