using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlowersShop.Data;
using FlowersShop.Models;

namespace FlowersShop.Services
{
    public interface INewService
    {
        IEnumerable<New> Get();
        void Get(Guid id);
        void Edit(New news);
        void Create(New news);
        void Delete(Guid id);
    }
    public class NewService:INewService
    {
        private readonly AppDataContext _appDataContext;

        public NewService(AppDataContext appDataContext)
        {
            _appDataContext = appDataContext;
        }

        public IEnumerable<New> Get()
        {
            return _appDataContext.News;
        }

        public void Get(Guid id)
        {
            _appDataContext.News.FirstOrDefault(n => n.Id == id);
        }

        public void Edit(New news)
        {
            _appDataContext.News.Update(news);
            _appDataContext.SaveChanges();
        }

        public void Create(New news)
        {
            _appDataContext.News.Add(news);
            _appDataContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _appDataContext.News.Remove(_appDataContext.News.FirstOrDefault(n => n.Id == id));
        }
    }
}
