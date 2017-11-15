using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCProject.Models;

namespace MVCProject.Controllers
{
    public class LessonItemViewModelsController : Controller
    {
        private readonly MVCLessonsContext _context;

        public LessonItemViewModelsController(MVCLessonsContext context)
        {
            _context = context;    
        }

        // GET: LessonItemViewModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.LessonItemViewModel.ToListAsync());
        }

        // GET: LessonItemViewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lessonItemViewModel = await _context.LessonItemViewModel
                .SingleOrDefaultAsync(m => m.ID == id);
            if (lessonItemViewModel == null)
            {
                return NotFound();
            }

            return View(lessonItemViewModel);
        }

        // GET: LessonItemViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LessonItemViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Group,Room,Trainer")] LessonItemViewModel lessonItemViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lessonItemViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(lessonItemViewModel);
        }

        // GET: LessonItemViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lessonItemViewModel = await _context.LessonItemViewModel.SingleOrDefaultAsync(m => m.ID == id);
            if (lessonItemViewModel == null)
            {
                return NotFound();
            }
            return View(lessonItemViewModel);
        }

        // POST: LessonItemViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Group,Room,Trainer")] LessonItemViewModel lessonItemViewModel)
        {
            if (id != lessonItemViewModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lessonItemViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LessonItemViewModelExists(lessonItemViewModel.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(lessonItemViewModel);
        }

        // GET: LessonItemViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lessonItemViewModel = await _context.LessonItemViewModel
                .SingleOrDefaultAsync(m => m.ID == id);
            if (lessonItemViewModel == null)
            {
                return NotFound();
            }

            return View(lessonItemViewModel);
        }

        // POST: LessonItemViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lessonItemViewModel = await _context.LessonItemViewModel.SingleOrDefaultAsync(m => m.ID == id);
            _context.LessonItemViewModel.Remove(lessonItemViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool LessonItemViewModelExists(int id)
        {
            return _context.LessonItemViewModel.Any(e => e.ID == id);
        }
    }
}
