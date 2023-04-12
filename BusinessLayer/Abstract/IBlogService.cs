using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService:IGenericService<Blog>
	{
        List<Blog> TGetListWithCategory();
        List<Blog> TGetBlogByID(int id);
        List<Blog> GetListBlogWithWriterID(int id);
    }
}
