using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
  public class Image
  {
    public int Id { get; set; }

    public int AlbumId { get; set; }
    public Album Album { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public string Path { get; set; }
    public bool IsHomeImage { get; set; }
  }
}
