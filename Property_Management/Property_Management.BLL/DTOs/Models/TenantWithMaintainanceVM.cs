﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_Management.BLL.Models
{
    public class TenantWithMaintenaceVM
    {

        public int TenantId { get; set; }
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }


        public IEnumerable<MaintenaceVM> Maintenances { get; set; }


    }

}