using EFDiyetProgramiProje.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje.DAL.Repositories
{
    public class GenericRepository<TEntity> where TEntity : class, new()
    {
        public AppDBContext context;

        public GenericRepository()
        {
            context = new AppDBContext();
        }

        public List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            try
            {
                return context.Set<TEntity>().Find(id);

            }
            catch (Exception)
            {
                throw new Exception("Aranılan kayıt bulunamadı");
            }
        }

        public int Add(TEntity entity)
        {
            try
            {
                context.Set<TEntity>().Add(entity);

                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Kayıt gerçekleştirilemedi" + ex.Message);

            }
        }

        public int Delete(int id)
        {
            try
            {
                TEntity entityToDelete = GetById(id);

                context.Set<TEntity>().Remove(entityToDelete);
                return context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Silme işlemi gerçekleştirilemedi");
            }
        }

        public int Update(TEntity entity)
        {
            try
            {
                context.Set<TEntity>().Update(entity);
                return context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Güncelleme işlemi başarısız oldu");
            }
        }
    }

}

