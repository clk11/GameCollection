using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcVideoGame.Models;
using Pagination;

namespace MvcVideoGame.Controllers
{
    public class VideoGamesController : Controller
    {
        private readonly MvcVideoGameContext _context;

        public VideoGamesController(MvcVideoGameContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        {
            return View(await PaginatedList<VideoGame>.CreateAsync(_context.VideoGame.AsNoTracking(), pageNumber ?? 1, 4));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoGame = _context.VideoGame.Include(v => v.Reviews).FirstOrDefault(x => x.Id == id);
            if (videoGame == null)
                return NotFound();
            return View(videoGame);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateReview(int id, [Bind("Id,Username,Message,Date")] Review review)
        {
            review.Date = DateTime.Now;
            review.VideoGameId = id;
            _context.Add(review);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", new { id });
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        public async Task<IActionResult> ConfirmCreate([Bind("Id,Title,ReleaseDate,Genre,Platform,Developer,Multiplayer,Price")] VideoGame videoGame)
        {
            _context.Add(videoGame);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoGame = await _context.VideoGame.FindAsync(id);
            if (videoGame == null)
            {
                return NotFound();
            }
            return View(videoGame);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmEdit(int id, [Bind("Id,Title,ReleaseDate,Genre,Platform,Developer,Multiplayer,Price")] VideoGame videoGame)
        {
            if (id != videoGame.Id)
            {
                return NotFound();
            }
            _context.Update(videoGame);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoGame = await _context.VideoGame
                .FirstOrDefaultAsync(m => m.Id == id);
            if (videoGame == null)
            {
                return NotFound();
            }

            return View(videoGame);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var videoGame = await _context.VideoGame.FindAsync(id);
            _context.VideoGame.Remove(videoGame);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VideoGameExists(int id)
        {
            return _context.VideoGame.Any(e => e.Id == id);
        }
    }
}
