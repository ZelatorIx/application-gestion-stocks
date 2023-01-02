﻿namespace Negosud.webapi.Models
{
    public class FamilyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public ItemDTO[]? Items { get; set; }
    }
}