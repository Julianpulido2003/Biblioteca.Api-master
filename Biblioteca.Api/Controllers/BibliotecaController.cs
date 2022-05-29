#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Api.Data;
using Biblioteca.Api.Modelo;

namespace Biblioteca.Api.Controllers
{
    [Route("[controller]/[action]")]
    public class BibliotecaController : ControllerBase
    {
        private readonly BibliotecaApiContext _context;

        public BibliotecaController(BibliotecaApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ConsultaLibro()
        {
            return Ok(await _context.Libro.ToListAsync());
        }


        [HttpPost]
        public async Task<IActionResult> AgregarLibro( Libro libro)
        {
            _context.Libro.Add(libro);
            await _context.SaveChangesAsync();
            return Ok(libro);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarLibro(Libro libro)
        {
            _context.Update(libro);
            await _context.SaveChangesAsync();
            return Ok(libro);
        }

        [HttpDelete]
        public async Task<IActionResult> BorrarLibro(Libro libro)
        {
            _context.Remove(libro);
            await _context.SaveChangesAsync();
            return Ok();
        }


        [HttpGet]
        public async Task<IActionResult> ConsultaUsuario()
        {
            return Ok(await _context.Usuario.ToListAsync());
        }


        [HttpPost]
        public async Task<IActionResult> AgregarUsuario(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            await _context.SaveChangesAsync();
            return Ok(usuario);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarUsuario(Usuario usuario)
        {
            _context.Update(usuario);
            await _context.SaveChangesAsync();
            return Ok(usuario);
        }

        [HttpDelete]
        public async Task<IActionResult> BorrarUsuario(Usuario usuario)
        {
            _context.Remove(usuario);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> ConsultaProveedor()
        {
            return Ok(await _context.Proveedor.ToListAsync());
        }


        [HttpPost]
        public async Task<IActionResult> AgregarProveedor(Proveedor proveedor)
        {
            _context.Proveedor.Add(proveedor);
            await _context.SaveChangesAsync();
            return Ok(proveedor);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarProveedor(Proveedor proveedor)
        {
            _context.Update(proveedor);
            await _context.SaveChangesAsync();
            return Ok(proveedor);
        }

        [HttpDelete]
        public async Task<IActionResult> BorrarProveedor(Proveedor proveedor)
        {
            _context.Remove(proveedor);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }

}
