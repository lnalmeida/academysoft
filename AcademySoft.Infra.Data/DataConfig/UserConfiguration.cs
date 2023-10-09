using Microsoft.EntityFrameworkCore;
using AcademySoft.Domain.Entities.Account;

namespace AcademySoft.Infra.Data.DataConfig
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");

            builder.HasKey(k => k.Id);
            builder.Property(k => k.Id)
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .HasColumnType("varchar(150)")
                .IsRequired();
            builder.Property(t => t.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder.Property(t => t.UserName)
                .HasColumnType("varchar(80)")
                .IsRequired();

        }
    }
}
