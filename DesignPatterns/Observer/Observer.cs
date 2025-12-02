// In case you need some guidance: https://refactoring.guru/design-patterns/observer

namespace DesignPattern.Observer
{
    public class ConcreteObserver: IObserver
    {

        private string _userName;
        public string UserName { get => _userName; set => _userName = value; }

        public ConcreteObserver(string userName)
        {
            _userName = userName;
        }
        public void AddSubscriber(ISubject subject)
        {
            subject.RegisterObserver(this);
        }
        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);
        }
        public void Update(string availability)
        {
            Console.WriteLine($"Hello {_userName}, Product is now {availability}");
        }
        // Your code goes here... make sure to add this features:
        //1. Allow to hold the observer's name (e.g. when user Adam wants to observe the subject)
        //2. Creating the Observer
        //3. Registering the Observer with the Subject
        //4. Removing the Observer from the Subject
        //5. Observer will get a notification from the Subject using the following Method
    }
}
