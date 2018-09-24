namespace ConsoleLibrary.Models
{
    public class Magazine
    {
        public string Title { get; private set; }

        public string ISBN { get; private set; }

        public string Published { get; private set; }

        public bool Available { get; set; }

        public Magazine(string title, string isbn, string published, bool available = true)
        {
            Title = title;
            ISBN = isbn;
            Published = published;
            Available = available;
        }
    }
}

