﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tuan5.DAL.Database;

namespace tuan5.BUS
{
    public class FacultyService
    {
        public List<Faculty> GetAll()
        {
            StudentDB context = new StudentDB();
            return context.Faculties.ToList();
        }
    }
}