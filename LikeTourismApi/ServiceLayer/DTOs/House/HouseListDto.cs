using ServiceLayer.DTOs.FamousCity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.House
{
    public class HouseListDto
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public string CityName { get; set; }
        public int Prise { get; set; }
        public float Rating { get; set; }
        public string RatingCommit { get; set; }
        public int FamousCityId { get; set; }
        public FamousCityDto FamousCity { get; set; }

    }
}
