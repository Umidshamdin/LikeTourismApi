using ServiceLayer.DTOs.RoomImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IRoomImagesService
    {
        Task<List<RoomImagesDto>> GetAllAsync();
        Task InsertAsync(CreateRoomImageDto slider);


    }
}
