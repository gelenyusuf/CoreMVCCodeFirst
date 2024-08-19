using CoreMVCCodeFirst.Models.Entıtıes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCCodeFirst.Models.Configurations
{
    public class OrderDetailConfiguration:BaseConfigurations<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            builder.ToTable("SiparişDetayları");
            builder.Ignore(x=>x.ID);
            builder.HasKey(x => new
            {
                x.OrderID,
                x.ProductID

            });
        }
    }
}
