using Cynosura.EF;
using Cynosura.Studio.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cynosura.Studio.Data.DataContextModule
{
    public class FieldModule : IDbContextModule
    {
        public void CreateModel(ModelBuilder builder)
        {
            builder.Entity<Field>();
        }
    }
}
