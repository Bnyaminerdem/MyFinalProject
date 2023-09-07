using Business.Abstarct;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //İş Kodları
           return _categoryDal.GetAll();
        }

        public Category GetById(int categoryid)
        {
           return _categoryDal.Get(C=>C.CategoryId == categoryid);
        }
    }
}
