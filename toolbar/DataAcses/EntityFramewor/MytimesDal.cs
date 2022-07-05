using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using toolbar.Entities;

namespace toolbar.DataAcses.EntityFramewor
{
    public class MytimesDal
    {
        public void Add(MyTimes entity)
        {
            using (MytimesContext context = new MytimesContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(MyTimes entity)
        {
            using (MytimesContext context = new MytimesContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public MyTimes Get(Expression<Func<MyTimes, bool>> filter)
        {
            using (MytimesContext context = new MytimesContext())
            {
                return context.Set<MyTimes>().SingleOrDefault(filter);
            }
        }

        public List<MyTimes> GetAll(Expression<Func<MyTimes, bool>> filter = null)
        {
            using (MytimesContext context = new MytimesContext())
            {
                return filter == null ?
                    context.Set<MyTimes>().ToList() :
                    context.Set<MyTimes>().Where(filter).ToList();
            }
        }

        public void Update(MyTimes entity)
        {
            using (MytimesContext context = new MytimesContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
