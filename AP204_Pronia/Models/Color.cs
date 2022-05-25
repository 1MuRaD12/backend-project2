using System.Collections.Generic;

namespace AP204_Pronia.Models
{
    public class Color
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Plant> plants { get; set; }
    }
}
