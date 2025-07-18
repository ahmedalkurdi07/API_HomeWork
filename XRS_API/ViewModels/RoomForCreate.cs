﻿using XRS_API.Models;

namespace XRS_API.ViewModels
{
    public class RoomForCreate
    {
        public int Number { get; set; }
        public int FloorNumber { get; set; }
        public Status Status { get; set; }
        public int HotelId { get; set; }
        public bool IsActive { get; set; } = true;
        public int RoomTypeId { get; set; }
    }
}
