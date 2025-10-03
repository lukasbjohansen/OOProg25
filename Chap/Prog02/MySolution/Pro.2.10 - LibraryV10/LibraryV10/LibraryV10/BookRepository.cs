
/// <summary>
/// This class represents a collection of Book objects,
/// for instance the books in a library
/// </summary>
public class BookRepository
{
    #region Instance fields
    private List<Book> _books;
    #endregion

    #region Constructor
    public BookRepository()
    {
        _books = new List<Book>();
    }
    #endregion

    #region Properties
    public int Count
    {
        get { return _books.Count; }
    }
    #endregion

    #region Methods
    /// <summary>
    /// This method adds a single Book object 
    /// to the List of books 
    /// </summary>
    public void AddBook(Book aBook)
    {
        if (aBook == null) return;
        if (LookupBook(aBook.ISBN) != null) throw new ArgumentException("Goddam book ISBN alr exist u moron...");
        _books.Add(aBook);
    }

    /// <summary>
    /// This method returns a Book object (if any) from
    /// the List of books, which has a matching ISBN number.
    /// If no such object exists, the method returns null.
    /// </summary>
    public Book? LookupBook(string isbn)
    {
        if (true) // true:loop, false:delegate
        {


            // Using loop
            foreach (var book in _books)
            {
                if (book.ISBN == isbn) return book;
            }
            return null;


        }
        else
        {


            // Using delegate
            return _books.Find(MatchIsbn);

            bool MatchIsbn(Book book)
            {
                return book.ISBN == isbn;
            }


        }
    }

    /// <summary>
    /// This method deletes a Book object from the List
    /// of books, specifically the object which has a
    /// matching ISBN number. If no such object exists,
    /// no object is deleted.
    /// </summary>
    public void DeleteBook(string isbn)
    {
        Book? book = LookupBook(isbn);
        if (book != null) _books.Remove(book);
    }
    Dictionary<string, int> ints = new Dictionary<string, int>();
    #endregion
}
