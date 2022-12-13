﻿
namespace OOPTask.Models
{
    public class ProductImageFile : BaseEntity<int>
    {
        public string FileName { get; set; } = null!;
        public string Path { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}
