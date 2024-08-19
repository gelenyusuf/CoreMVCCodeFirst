using CoreMVCCodeFirst.Models.Entıtıes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCCodeFirst.Models.Configurations
{
    public abstract class BaseConfigurations<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual  void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x=>x.CreatedDate).HasColumnName("Yaratılma Tarihi");
        }
    }
}
