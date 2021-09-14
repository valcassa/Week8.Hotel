using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManageFunds.EF.Configurations
{
    public class ExpensesConfiguration : IEntityTypeConfiguration<Expenses>
    {
        public void Configure(EntityTypeBuilder<Expenses> builder)
        {
            builder.ToTable("Expenses");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(6);
        }

    }
}