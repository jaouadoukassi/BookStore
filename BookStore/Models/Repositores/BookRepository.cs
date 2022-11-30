namespace BookStore.Models.Repositores
{
    public class BookRepository : IBookRepositore<Books>
    {

        List<Books> books;

        public BookRepository()
        {
            books = new List<Books>()
                {
                    new Books()
                    {
                        Id= 1, Title = "C Sharp Programming", Description = "This Book Allow to Learn Basic of C# Language"
                    },
                     new Books()
                    {
                        Id= 2, Title = "C++ Programming", Description = "This Book Allow to Learn Basic of C++ Language"
                    },
                      new Books()
                    {
                        Id= 3, Title = "Python Programming", Description = "This Book Allow to Learn Basic of Python Language"
                    },
                };
        }

        public void Add(Books entity)
        {
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);

            books.Remove(book);
        }

        public Books Find(int id)
        {
            var book = books.SingleOrDefault(x => x.Id == id);
            if (book == null)
            {
                throw new NotImplementedException();
            }
            return book;
        }

        public IList<Books> list()
        {
            return books;
        }

        public void Update(int id, Books newbook)
        {
            var book = Find(id);

            book.Title = newbook.Title;
            book.Description = newbook.Description;
            book.Author = newbook.Author;
        }
    }
}
