using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Punto4.DbConfig;
using Punto4.Models.Grades;
using Punto4.Services.Implementation;
using Punto4.Services.Interface;
using System.Collections.Generic;

namespace Punto4.Controllers
{
    public class GradesController : Controller
    {

        private readonly Context _context;

        public GradesController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<AcademicRecord> records = _context.AcademicRecord;
            return View(records);
        }

        [HttpGet]
        public IActionResult CreateRecord()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateRecord(AcademicRecord record)
        {
            if (ModelState.IsValid)
            {
                _context.AcademicRecord.Add(record);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }

        [HttpGet]
        public IActionResult UpdateRecord(int id)
        {
            AcademicRecord academicRecord = _context.AcademicRecord.Find(id);
            if (academicRecord == null)
            {
                return NotFound();
            }
            return View(academicRecord);
        }

        [HttpPost]
        public IActionResult UpdateRecord(AcademicRecord record)
        {
            if (ModelState.IsValid)
            {
                _context.AcademicRecord.Update(record);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }

        [HttpGet]
        public IActionResult DeleteRecord(int id)
        {
            AcademicRecord academicRecord = _context.AcademicRecord.Find(id);
            if (academicRecord == null)
            {
                return NotFound();
            }
            return View(academicRecord);
        }

        [HttpPost]
        public IActionResult Delete(int recordId)
        {
            AcademicRecord academicRecord = _context.AcademicRecord.Find(recordId);

            _context.AcademicRecord.Remove(academicRecord);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}

