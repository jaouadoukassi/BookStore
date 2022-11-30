namespace BookStore.Models.Repositores
{
    public class AuthorRepository : IBookRepositore<Author>
    {
        IList<Author> _authors;
        public AuthorRepository()
        {
            _authors = new List<Author>()
            {
                new Author () {Id = 1, FullName = "Jaouad Oukassi"},
                new Author () {Id = 2, FullName = "Hassan Oukassi"},
                new Author () {Id = 3, FullName = "Abdelghani Oukassi"},
            };                                                      
                                                                   
        }                                                          

        public void Add(Author entity)
        {
            _authors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = Find(id);
            if (author != null)
            {
                _authors.Remove(author);
            }
        }

        public Author Find(int id)
        {
            var author = _authors.SingleOrDefault(a => a.Id == id);
            return author;
        }

        public IList<Author> list()
        {
            return _authors;
        }

        public void Update(int id, Author newAuthor)
        {
            var author = Find(id);
            
            author.FullName = newAuthor.FullName;            
        }
    }
}
