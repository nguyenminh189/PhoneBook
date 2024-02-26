using Phone;

public class ProgramPhone
{
    static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook();
        phoneBook.Enter();

        phoneBook.searchPhone("MInh");
        phoneBook.searchPhone("Dookki");

        phoneBook.Sort();

        phoneBook.removePhone("Manyo");

        phoneBook.updatePhone("Thu HA", "0123456789");

        phoneBook.searchPhone("MInh");
    }
}

