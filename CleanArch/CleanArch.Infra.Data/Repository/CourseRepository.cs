﻿using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private CleanArchDBContext _context;


        public CourseRepository(CleanArchDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> getCourses()
        {
            return _context.Courses; 
        }
    }
}
