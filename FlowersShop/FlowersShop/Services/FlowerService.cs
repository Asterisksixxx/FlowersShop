using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlowersShop.Data;
using FlowersShop.Models;

namespace FlowersShop.Services
{
    public interface IFlowerService
    {
        IEnumerable<Flower> Get();
        void Get(Guid id);
        void Edit(Flower flower);
        void Create(Flower flower);
        void Delete(Guid id);
        void AddToKorzina(Flower flower);
    }
    public class FlowerService:IFlowerService
    {
        private readonly AppDataContext _appDataContext;

        public FlowerService(AppDataContext appDataContext)
        {
            _appDataContext = appDataContext;
        }

        public IEnumerable<Flower> Get()
        {
            return _appDataContext.Flowers;
        }

        public void Get(Guid id)
        {
            _appDataContext.Flowers.FirstOrDefault(fl => fl.Id == id);
        }

        public void Edit(Flower flower)
        {
            _appDataContext.Flowers.Update(flower);
            _appDataContext.SaveChanges();
        }

        public void Create(Flower flower)
        {
            _appDataContext.Flowers.Add(flower);
            _appDataContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _appDataContext.Flowers.Remove(_appDataContext.Flowers.FirstOrDefault(fl => fl.Id == id));
            _appDataContext.SaveChanges();
            
        }

        void AddToKorzina(Flower flower)
        {
            _appDataContext.Korzinas.Add(flower);

        }
    }
}
