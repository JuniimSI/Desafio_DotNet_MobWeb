using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_dotNet_Mobweb.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio_dotNet_Mobweb.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly UsuarioDBContext _context;

        public UsuarioController(UsuarioDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Usuario());
            }
            else
            {
                var usuario = await _context.Usuarios.FindAsync(id);
                if(usuario == null)
                {
                    return NotFound();
                }
                return View(usuario);
            }
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("Id, Nome, Apelido, Email, Senha, Telefone")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    _context.Add(usuario);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(usuario);
                        Console.WriteLine(usuario);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!UsuarioExists(usuario.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }

                return Json(new { isValid = true, 
                html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Usuarios.ToList()) });
            }
            return Json(new { isValid = false,
                html = Helper.RenderRazorViewToString(this, "AddOrEdit", usuario) });
            
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return Json(new
            {
               
                html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Usuarios.ToList())
            });
        }



        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }
    }
}
