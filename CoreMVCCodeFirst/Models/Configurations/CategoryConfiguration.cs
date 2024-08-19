using CoreMVCCodeFirst.Models.Entıtıes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCCodeFirst.Models.Configurations
{
    public class CategoryConfiguration:BaseConfigurations<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);//Configure metodunun BaseClasstaki  orjinal görevinin korunması için bu kodu burada bırakalım
            builder.ToTable("Kategoriler");
        }
    }
}
