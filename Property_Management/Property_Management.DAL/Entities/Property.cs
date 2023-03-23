﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Property_Management.DAL.Entities
{
    public  class Property
    {
        [Key]
        public string PropertyId {  get; set; }    
        public string? PropertyName { get; set; }   
        public string Description { get; set; }   = string.Empty;

        [Precision(18, 2)]
        public decimal Price { get; set; }  
        public  string propertyTypeId { get; set; }
        public string managerId { get; set; }  
        public bool Status { get; set; }
        public byte[]? Concurrency { get; set; }
        public TenantDetail?  TenantDetail { get; set; }  

    }
}