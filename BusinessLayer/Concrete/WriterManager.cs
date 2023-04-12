﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public List<Writer> TGetAllList(int id)
        {
            return _writerDal.GetAllList(x=>x.WriterID==id);
        }

        public Writer TGetByID(int id)
        {
            return _writerDal.GetByID(id);
        }

        public List<Writer> TGetList()
        {
            return _writerDal.GetAllList();
        }

        public void TInsert(Writer c)
        {
            _writerDal.Insert(c);
        }

        public void TUpdate(Writer t)
        {
            _writerDal.Update(t);
        }
    }
}