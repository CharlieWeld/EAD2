// demo of Events and Event handling using delegates

using System;

// a delegate defining signature of method to be called when birthday event raised
public delegate void BirthdayHandler(String name);

// a class to store details about a friend
class Friend
{
    public event BirthdayHandler Birthday;			// notification of a birthday

    private String name;							// friend's name
    private DateTime dateOfBirth;					// friend's dob

    public Friend(String name, DateTime dateOfBirth)
    {
        this.name = name;
        this.dateOfBirth = dateOfBirth;
    }

    public void NotifyMeOfBirthday()
    {
        // if today is friend's birthday then notify
        if ((DateTime.Today.Day == dateOfBirth.Day) && (DateTime.Today.Month == dateOfBirth.Month))
        {  
            if (Birthday != null)
            {
                Console.WriteLine("Event processing starting");
                Birthday(name);                         // raise the event if there are handlers
                Console.WriteLine("Event processing completed");
            }
        }
    }
}

// a diary
class Diary
{
    static void Main()
    {
        Friend myFriend = new Friend("Tulisa", new DateTime(1988, 05, 02));	// year, month, day

        Diary d = new Diary();

        // add event handler call SayHappyBirthday whenever birthday event
        // is raised by myFriend
        myFriend.Birthday += new BirthdayHandler(d.SayHappyBirthday1);

        // can have more than 1 handler:
        myFriend.Birthday += new BirthdayHandler(d.SayHappyBirthday2);

        // use a lambda expression to define another handler
        myFriend.Birthday += (name) => { Console.WriteLine("Happy Birthday v3 " + name + " :-)"); }; 
        
        // force myFriend to raise event and have event handler called
        myFriend.NotifyMeOfBirthday();
    }

    // handler for birthday event
    void SayHappyBirthday1(String name)
    {
        Console.WriteLine("Happy Birthday v1 " + name + " :-)");
    }

    // handler for birthday event
    void SayHappyBirthday2(String name)
    {
        Console.WriteLine("Happy Birthday v2 " + name + " :-)");
    }

}