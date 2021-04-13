﻿using GamingApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Entities
{
    public class Customer : IEntities
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalityId { get; set; }
    }
}
