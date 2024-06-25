using lab2;

public class ObserverPatternTests
{
    [Fact]
    public void Subject_Can_Register_Observer()
    {
        // Arrange
        Subject subject = new Subject();
        TestObserver observer = new TestObserver();

        // Act
        subject.RegisterObserver(observer);

        // Assert
        subject.Message = "Test Message";
        Assert.Equal("Test Message", observer.ReceivedMessage);
    }

    [Fact]
    public void Subject_Can_Remove_Observer()
    {
        // Arrange
        Subject subject = new Subject();
        TestObserver observer = new TestObserver();

        // Act
        subject.RegisterObserver(observer);
        subject.RemoveObserver(observer);
        subject.Message = "Test Message";

        // Assert
        Assert.Null(observer.ReceivedMessage);
    }

    [Fact]
    public void Subject_Notifies_All_Observers()
    {
        // Arrange
        Subject subject = new Subject();
        TestObserver observer1 = new TestObserver();
        TestObserver observer2 = new TestObserver();

        // Act
        subject.RegisterObserver(observer1);
        subject.RegisterObserver(observer2);
        subject.Message = "Test Message";

        // Assert
        Assert.Equal("Test Message", observer1.ReceivedMessage);
        Assert.Equal("Test Message", observer2.ReceivedMessage);
    }

    [Fact]
    public void Observer_Receives_Update_When_Message_Changes()
    {
        // Arrange
        Subject subject = new Subject();
        TestObserver observer = new TestObserver();

        subject.RegisterObserver(observer);

        // Act
        subject.Message = "Test Message";

        // Assert
        Assert.Equal("Test Message", observer.ReceivedMessage);
    }

    private class TestObserver : IObserver
    {
        public string ReceivedMessage { get; private set; }

        public void Update(string message)
        {
            ReceivedMessage = message;
        }
    }
}
