using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Management_System.Data;

namespace Student_Management_System.Pages.Enrollments
{
    public class DetailsModel : PageModel
    {
        private readonly Student_Management_System.Data.SchoolContext _context;

        public DetailsModel(Student_Management_System.Data.SchoolContext context)
        {
            _context = context;
        }

        public Enrollment Enrollment { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollment = await _context.Enrollments.FirstOrDefaultAsync(m => m.EnrollmentID == id);
            if (enrollment == null)
            {
                return NotFound();
            }
            else
            {
                Enrollment = enrollment;
            }
            return Page();
        }
    }
}
