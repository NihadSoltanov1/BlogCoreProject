using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : IGenericService<Category>
    {
        EfCategoryRepository efCategoryRepository;

        public CategoryManager(EfCategoryRepository efCategoryRepository)
        {
            this.efCategoryRepository = efCategoryRepository;
        }


        public void TDelete(Category t)
        {
           efCategoryRepository.Delete(t);
        }


        public Category TGetByID(int id)
        {
            return efCategoryRepository.GetByID(id);
        }


        public List<Category> TGetList()
        {
            return efCategoryRepository.GetAllList();
        }


        public void TInsert(Category t)
        {
            efCategoryRepository.Insert(t);
        }

        public void TUpdate(Category t)
        {
            efCategoryRepository.Update(t);
        }
    }
}
