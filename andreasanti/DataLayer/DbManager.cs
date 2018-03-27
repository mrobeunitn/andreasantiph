using System;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Models;
using System.IO;
namespace DataLayer
{
  public class DbManager : DbContext
  {
    public DbSet<Album> Albums { get; set; }
    public DbSet<Image> Images { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql(@"Host=localhost;Database=andreasanti;Username=postgres;Password=postgres");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Album>(entity =>
      {
        entity.ToTable("albums");
        entity.HasKey(key => new { key.Id });
      });

      modelBuilder.Entity<Image>(entity =>
      {
        entity.ToTable("images");
        entity.HasKey(key => new { key.Id });
      });

    }
    
    public void InsertData() {
      //\wwwroot\res\ballerina\1.jpg

      Albums.Add(new Album {
         Name = "aurora",
         Path = @"wwwroot/res/aurora"
      });
      Albums.Add(new Album
      {
        Name = "ballerina",
        Path = @"wwwroot/res/ballerina"
      });
      Albums.Add(new Album
      {
        Name = "barbara",
        Path = @"wwwroot/res/barbara"
      });
      Albums.Add(new Album
      {
        Name = "eden",
        Path = @"wwwroot/res/eden"
      });
      Albums.Add(new Album
      {
        Name = "giappone",
        Path = @"wwwroot/res/giappone"
      });

      Albums.Add(new Album
      {
        Name = "hanami",
        Path = @"wwwroot/res/hanami"
      });
      this.SaveChanges();
      Albums.Add(new Album
      {
        Name = "ivon",
        Path = @"wwwroot/res/ivon"
      });
      Albums.Add(new Album
      {
        Name = "miao",
        Path = @"wwwroot/res/miao"
      });
      Albums.Add(new Album
      {
        Name = "palazzoni",
        Path = @"wwwroot/res/palazzoni"
      });
      Albums.Add(new Album
      {
        Name = "raki",
        Path = @"wwwroot/res/raki"
      });
      Albums.Add(new Album
      {
        Name = "yassine",
        Path = @"wwwroot/res/yassine"
      });

      this.SaveChanges();
      int w;
      int h;


      for(int i = 1; i <= 2; i++)
      {
        if (i == 1)
        {
          System.Drawing.Image img1 = new System.Drawing.Bitmap($"wwwroot/res/aurora/{i}.jpg");
          w = img1.Width;
          h = img1.Height;
          Images.Add(new Image
          {
            AlbumId = 1,
            IsHomeImage = true,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
        else
        {
          System.Drawing.Bitmap img = new System.Drawing.Bitmap($"wwwroot/res/aurora/{i}.jpg");
          w = img.Width;
          h = img.Height;
          Images.Add(new Image
          {
            AlbumId = 1,
            IsHomeImage = false,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
      }

      for (int i = 1; i <= 11; i++)
      {
        if (i == 1)
        {
          System.Drawing.Bitmap img1 = new System.Drawing.Bitmap($"wwwroot/res/ballerina/{i}.jpg");
          w = img1.Width;
          h = img1.Height;
          Images.Add(new Image
          {
            AlbumId = 2,
            IsHomeImage = true,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
        else
        {
          System.Drawing.Bitmap img = new System.Drawing.Bitmap($"wwwroot/res/ballerina/{i}.jpg");
          w = img.Width;
          h = img.Height;
          Images.Add(new Image
          {
            AlbumId = 2,
            IsHomeImage = false,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
      }

      for (int i = 1; i <= 11; i++)
      {
        if (i == 1)
        {
          System.Drawing.Bitmap img1 = new System.Drawing.Bitmap($"wwwroot/res/barbara/{i}.jpg");
          w = img1.Width;
          h = img1.Height;
          Images.Add(new Image
          {
            AlbumId = 3,
            IsHomeImage = true,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
        else
        {
          System.Drawing.Bitmap img = new System.Drawing.Bitmap($"wwwroot/res/barbara/{i}.jpg");
          w = img.Width;
          h = img.Height;
          Images.Add(new Image
          {
            AlbumId = 3,
            IsHomeImage = false,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
      }

      for (int i = 1; i <= 16; i++)
      {
        if (i == 1)
        {
          System.Drawing.Bitmap img1 = new System.Drawing.Bitmap($"wwwroot/res/eden/{i}.jpg");
          w = img1.Width;
          h = img1.Height;
          Images.Add(new Image
          {
            AlbumId = 4,
            IsHomeImage = true,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
        else
        {
          System.Drawing.Bitmap img = new System.Drawing.Bitmap($"wwwroot/res/eden/{i}.jpg");
          w = img.Width;
          h = img.Height;
          Images.Add(new Image
          {
            AlbumId = 4,
            IsHomeImage = false,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
      }

      for (int i = 1; i <= 40; i++)
      {
        if (i == 1)
        {
          System.Drawing.Bitmap img1 = new System.Drawing.Bitmap($"wwwroot/res/giappone/{i}.jpg");
          w = img1.Width;
          h = img1.Height;
          Images.Add(new Image
          {
            AlbumId = 5,
            IsHomeImage = true,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
        else
        {
          System.Drawing.Bitmap img = new System.Drawing.Bitmap($"wwwroot/res/giappone/{i}.jpg");
          w = img.Width;
          h = img.Height;
          Images.Add(new Image
          {
            AlbumId = 5,
            IsHomeImage = false,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
      }

      for (int i = 1; i <= 9; i++)
      {
        if (i == 1)
        {
          System.Drawing.Bitmap img1 = new System.Drawing.Bitmap($"wwwroot/res/hanami/{i}.jpg");
          w = img1.Width;
          h = img1.Height;
          Images.Add(new Image
          {
            AlbumId = 6,
            IsHomeImage = true,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
        else
        {
          System.Drawing.Bitmap img = new System.Drawing.Bitmap($"wwwroot/res/hanami/{i}.jpg");
          w = img.Width;
          h = img.Height;
          Images.Add(new Image
          {
            AlbumId = 6,
            IsHomeImage = false,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
      }

      for (int i = 1; i <= 6; i++)
      {
        if (i == 1)
        {
          System.Drawing.Bitmap img1 = new System.Drawing.Bitmap($"wwwroot/res/ivon/{i}.jpg");
          w = img1.Width;
          h = img1.Height;
          Images.Add(new Image
          {
            AlbumId = 7,
            IsHomeImage = true,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
        else
        {
          System.Drawing.Bitmap img = new System.Drawing.Bitmap($"wwwroot/res/ivon/{i}.jpg");
          w = img.Width;
          h = img.Height;
          Images.Add(new Image
          {
            AlbumId = 7,
            IsHomeImage = false,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
      }

      for (int i = 1; i <= 8; i++)
      {
        if (i == 1)
        {
          System.Drawing.Bitmap img = new System.Drawing.Bitmap($"wwwroot/res/miao/{i}.jpg");
          w = img.Width;
          h = img.Height;
          Images.Add(new Image
          {
            AlbumId = 8,
            IsHomeImage = true,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
        else
        {
          System.Drawing.Bitmap img1 = new System.Drawing.Bitmap($"wwwroot/res/miao/{i}.jpg");
          w = img1.Width;
          h = img1.Height;
          Images.Add(new Image
          {
            AlbumId = 8,
            IsHomeImage = false,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
      }

      for (int i = 1; i <= 13; i++)
      {
        if (i == 1)
        {
          System.Drawing.Bitmap img1 = new System.Drawing.Bitmap($"wwwroot/res/palazzoni/{i}.jpg");
          w = img1.Width;
          h = img1.Height;
          Images.Add(new Image
          {
            AlbumId = 9,
            IsHomeImage = true,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
        else
        {
          System.Drawing.Bitmap img = new System.Drawing.Bitmap($"wwwroot/res/palazzoni/{i}.jpg");
          w = img.Width;
          h = img.Height;
          Images.Add(new Image
          {
            AlbumId = 9,
            IsHomeImage = false,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
      }

      for (int i = 1; i <= 10; i++)
      {
        if (i == 1)
        {
          System.Drawing.Bitmap img1 = new System.Drawing.Bitmap($"wwwroot/res/raki/{i}.jpg");
          w = img1.Width;
          h = img1.Height;
          Images.Add(new Image
          {
            AlbumId = 10,
            IsHomeImage = true,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
        else
        {
          System.Drawing.Bitmap img = new System.Drawing.Bitmap($"wwwroot/res/raki/{i}.jpg");
          w = img.Width;
          h = img.Height;
          Images.Add(new Image
          {
            AlbumId = 10,
            IsHomeImage = false,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
      }

      for (int i = 1; i <= 12; i++)
      {
        if (i == 1)
        {
          System.Drawing.Bitmap img1 = new System.Drawing.Bitmap($"wwwroot/res/yassine/{i}.jpg");
          w = img1.Width;
          h = img1.Height;
          Images.Add(new Image
          {
            AlbumId = 11,
            IsHomeImage = true,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
        else
        {
          System.Drawing.Bitmap img = new System.Drawing.Bitmap($"wwwroot/res/yassine/{i}.jpg");
          w = img.Width;
          h = img.Height;
          Images.Add(new Image
          {
            AlbumId = 11,
            IsHomeImage = false,
            Path = $"{i}.jpg",
            Width = w,
            Height = h
          });
        }
      }
      this.SaveChanges();
    }
  }
}
