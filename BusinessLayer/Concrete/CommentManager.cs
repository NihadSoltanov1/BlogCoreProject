using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }


        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }


        public Comment TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetComments(int id)
        {
            return _commentDal.GetAllList(x => x.BlogID == id);
        }

        public List<Comment> TGetList()
        {
            throw new NotImplementedException();
        }


        public void TInsert(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();

        }
    }
}
