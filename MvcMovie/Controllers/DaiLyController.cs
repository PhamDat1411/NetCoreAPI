using System.Net;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using MvcMovie.Data;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Controllers;
public class DaiLyController : Controller
{
    private readonly ApplicationDbContext _context;
    public DaiLyController (ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        var model = await _context.DaiLy.ToListAsync();
        return View(model);
    }
    [HttpPost]
    public async Task<IActionResult> Index(string KeySearch)
    {
        var model = await _context.DaiLy.Where(x => x.MaDaiLy.Contains(KeySearch)).ToListAsync();
        return View(model);
    }
    public IActionResult Create()
    {
        return  View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("HeThongPhanPhoi,MaDaiLy,TenDaiLy,DiaChi,NguoiDaiDien,DienThoai,MaHTPP")] DaiLy daily)
    {
        if (ModelState.IsValid)
        {
            _context.Add(daily);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(daily);
    }
    public async Task<IActionResult> Edit(string id)
    {
        if(id == null || _context.DaiLy == null)
        {
            return NotFound();
        }
        var daily = await _context.DaiLy.FindAsync(id);
        if (daily == null)
        {
            return NotFound();
        }
        return View(daily);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id,[Bind("HeThongPhanPhoi,MaDaiLy,TenDaiLy,DiaChi,NguoiDaiDien,DienThoai,MaHTPP")]DaiLy daily)
    {
        if (id !=daily.HeThongPhanPhoi)
        {
            return NotFound();
        }
        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(daily);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DaiLyExists(daily.HeThongPhanPhoi))
                {
                    return NotFound();
                }
            else
            {
                throw;
            }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(daily);
    }
    public async Task<IActionResult> Delete(string id)
    {
        if (id == null || _context.DaiLy == null)
        {
            return NotFound();
        }
        var daily = await _context.DaiLy
            .FirstOrDefaultAsync(m => m.HeThongPhanPhoi ==id);
            if (daily == null)
            {
                return NotFound();
            }
            return View(daily);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        if (_context.DaiLy == null)
        {
            return Problem("Entity set 'ApplicationDbContext.DaiLy' is null.");
        }
        var daily = await _context.DaiLy.FindAsync(id);
        if (daily != null)
        {
            _context.DaiLy.Remove(daily);
        }
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    private bool DaiLyExists(string id)
    {
        return (_context.DaiLy?.Any(e => e.HeThongPhanPhoi == id)).GetValueOrDefault();
    }

}