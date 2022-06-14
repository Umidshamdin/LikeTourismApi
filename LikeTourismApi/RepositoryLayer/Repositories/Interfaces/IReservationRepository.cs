﻿using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IReservationRepository:IRepository<Reservation>
    {
        Task<Reservation> GetReservationAsync(int id);
    }
}
