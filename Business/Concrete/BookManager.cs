using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public void Add(Book book)
        {
            //iş kodları
            if (_bookDal.Get(b => b.Name == book.Name && b.AuthorId == book.AuthorId) == null)
            {
                _bookDal.Add(book);
            }
            else
            {
                throw new Exception("Bu kitap adı zaten mevcut");
            }

        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetByAuthorId(int id)
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
