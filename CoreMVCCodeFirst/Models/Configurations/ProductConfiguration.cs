using CoreMVCCodeFirst.Models.Entıtıes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCCodeFirst.Models.Configurations
{
    public class ProductConfiguration:BaseConfigurations<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.ToTable("Ürünler");
            builder.Property(x=>x.UnitPrice).HasColumnType("money");
        }
    }
}
