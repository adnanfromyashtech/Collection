
namespace collectionsdemo
{
    internal class Books: IComparable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        static Books()
        {
            Console.WriteLine("Static called");
        }

        public Books()
        {
            Console.WriteLine("Default called");
        }

        public Books(int id, string author)
        {
            Id = id;
            Author = author;
            Console.WriteLine("para called");
            

        }

        

        // public int CompareTo(Books b)
        // {
        //     return this.Price.CompareTo(b.Price);
        // }

        // public int CompareTo(object? obj)
        // {
        //     Books book = obj as Books;
        //     return string.Compare(this.Author, book.Author);
        // }

        // public int CompareTo(object? obj)
        // {
        //     Books book = obj as Books;
        //     return string.Compare(this.Title, book.Title);
        // }

        // 1. Price 2. Title 3.Author


        public int CompareTo(object? obj)
    {
        // Compare by Price first
        Books other = obj as Books;
        int priceComparison = this.Price.CompareTo(other.Price);
        if (priceComparison != 0)
            return priceComparison;
 
        // If Prices are the same, compare by Author
        int authorComparison = this.Author.CompareTo(other.Author);
        if (authorComparison != 0)
            return authorComparison;
 
        // If Authors are also the same, compare by Title
        return this.Title.CompareTo(other.Title);
    }

        public override string ToString()
      {
        return  $"Book id : {Id} , Book Title : {Title} , Book Auhor: {Author} , Book Price {Price}";
      }
    }
}