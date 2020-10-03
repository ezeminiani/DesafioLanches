using DesafioLanche.Domain;
using DesafioLanche.Repository.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DesafioLanche.Repository.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly DesafioLancheContext ctx;
        private readonly DbSet<T> dataset;


        public GenericRepository(DesafioLancheContext ctx)
        {
            this.ctx = ctx;
            dataset = this.ctx.Set<T>();
        }

        public virtual async Task<T> Create(T item)
        {
            try
            {
                dataset.Add(item);
                await this.ctx.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }


        public virtual async Task<bool> Delete(long id)
        {
            var result = dataset.FirstOrDefaultAsync(i => i.Id.Equals(id)).Result;

            try
            {
                if (result != null) dataset.Remove(result);
                return (await this.ctx.SaveChangesAsync()) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public virtual async Task<bool> Exists(long? id)
        {
            return await dataset.AnyAsync(a => a.Id.Equals(id));
        }


        public virtual async Task<List<T>> FindAllAsync(bool asNoTracking = false)
        {
            if (asNoTracking)
                dataset.AsNoTracking();

            return await dataset.ToListAsync();

        }


        public virtual async Task<T> FindByIdAsync(long id, bool asNoTracking = false)
        {
            if (asNoTracking)
                dataset.AsNoTracking();

            return await dataset.FirstOrDefaultAsync(p => p.Id.Equals(id));
        }


        public virtual async Task<T> Update(T item)
        {
            if (!Exists(item.Id).Result) return null;

            var result = dataset.FirstOrDefaultAsync(i => i.Id.Equals(item.Id)).Result;

            if (result != null)
            {
                try
                {
                    this.ctx.Entry(result).CurrentValues.SetValues(item);
                    await this.ctx.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return result;
        }

      
    }
}
