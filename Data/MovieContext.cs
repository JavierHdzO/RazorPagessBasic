using Microsoft.EntityFrameworkCore;
using razorpagesbases.Models;

namespace razorpagesbases.Data;
public class MovieContext: DbContext 
{
    public DbSet<Movie> Movie {get; set;} = null!;
    
    public MovieContext(DbContextOptions<MovieContext> options):base(options){ }

    protected override void OnModelCreating(ModelBuilder modelBuilder){

        modelBuilder.Entity<Movie>(
            movieEntity => {
                movieEntity.Property( movie => movie.Title ).HasColumnType("VARCHAR(100)");
                movieEntity.Property( movie => movie.ReleaseDate ).HasColumnType("DATETIME");
                movieEntity.Property( movie => movie.Genre ).HasColumnType("VARCHAR(20)");
                movieEntity.Property( movie => movie.Price ).HasColumnType("MONEY").HasDefaultValue(0.0f);
            }
        );

        
    }

}