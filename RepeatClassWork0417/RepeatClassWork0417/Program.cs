using RepeatClassWork0417.Moduls;

namespace RepeatClassWork0417
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("ybhb", "jnnj");
            Book book2 = new Book("ybhb", "jnnj");
            Library library = new Library();
            library.Add(book);
            library.Add(book2);

            Book book3 = library[2];
            Console.WriteLine(book3.Name+" "+ book3.Author);
        }
    }
}
