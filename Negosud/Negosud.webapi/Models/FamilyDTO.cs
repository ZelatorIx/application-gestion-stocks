﻿namespace Negosud.webapi.Models
{
    public class FamilyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<ItemDTO>? Items { get; set; }
    }
}