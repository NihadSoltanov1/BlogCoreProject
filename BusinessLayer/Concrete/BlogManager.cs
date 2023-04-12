using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IGenericService<Blog>
	{
		EfBlogRepository _efBlogRepository;

		public BlogManager(EfBlogRepository efBlogRepository)
		{
			_efBlogRepository = efBlogRepository;
		}
		

		public void TDelete(Blog t)
		{
			_efBlogRepository.Delete(t);
		}

		

		public List<Blog> TGetList()
		{
			return _efBlogRepository.GetAllList();
		}

		public List<Blog> TGetListWithCategory()
		{
			return _efBlogRepository.GetListWithCategory();
		}

		public void TInsert(Blog t)
		{
			_efBlogRepository.Insert(t);
		}

		public void TUpdate(Blog t)
		{
			_efBlogRepository.Update(t);
		}

		public List<Blog> TGetBlogByID(int id)
		{
			return _efBlogRepository.GetAllList(x => x.BlogID == id);
		}

		public Blog TGetByID(int id)
		{
            return _efBlogRepository.GetByID(id);
        }

		public List<Blog> GetListBlogWithWriterID(int id)
		{
			return _efBlogRepository.GetAllList(x => x.WriterID == id);
		}
	}
}
