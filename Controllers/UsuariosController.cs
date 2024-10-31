using Exo.WebApi.Controllers;
using Exo.WebApi.Models;
using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Mvc;

//UsuariosController.cs(Controller de Usuários)


namespace Exo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuariosController(UsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet] // get endpoint => api/usuario/
        public IActionResult Listar()
        {
            return Ok(_usuarioRepository.Listar());
        }

        [HttpPost] // post endpoint => api/usuario/
        public IActionResult Cadastrar(Usuario usuario)
        {
            _usuarioRepository.Cadastrar(usuario);
            return StatusCode(201);
        }

        [HttpGet("{id}")] // get endpoint (busca pelo 'Id') => api/usuario/
        public IActionResult BuscarPorId(int id)
        {
            Usuario usuario = _usuarioRepository.BuscaPorId(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [HttpPut("{id}")] //  put endpoint (atualiza) => api/usuario/{id}
        public IActionResult Atualizar(int id, Usuario usuario)
        {
            _usuarioRepository.Atualizar(id, usuario);
            return StatusCode(204);
        }

        [HttpDelete("{id}")] //  delete endpoint (exluir) => api/usuario/{id}
        public IActionResult Deletar(int id)
        {
            try  // tratameento de erro ao deletar.
            {
                _usuarioRepository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}













//using Exo.WebApi.Models;
//using Exo.WebApi.Repositories;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using System;
//namespace Exo.WebApi.Controllers
//{
//    [Produces("application/json")]
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UsuariosController : ControllerBase
//    {
//        private readonly UsuarioRepository _usuarioRepository;
//        public UsuariosController(UsuarioRepository
//        usuarioRepository)
//        {
//            _usuarioRepository = usuarioRepository;
//        }
//        // get -> /api/usuarios
//        [HttpGet]
//        public IActionResult Listar()
//        {
//            return Ok(_usuarioRepository.Listar());
//        }
//        // post -> /api/usuarios
//        [HttpPost]
//        public IActionResult Cadastrar(Usuario usuario)
//        {
//            _usuarioRepository.Cadastrar(usuario);
//            return StatusCode(201);
//        }
//        // get -> /api/usuarios/{id}
//        [HttpGet("{id}")] // Faz a busca pelo ID.
//        public IActionResult BuscarPorId(int id)
//        {
//            Usuario usuario = _usuarioRepository.BuscaPorId(id);
//            if (usuario == null)
//            {
//                return NotFound();
//            }
//            return Ok(usuario);
//        }
//        // put -> /api/usuarios/{id}
//        // Atualiza.
//        [HttpPut("{id}")]
//        public IActionResult Atualizar(int id, Usuario usuario)
//        {
//            _usuarioRepository.Atualizar(id, usuario);
//            return StatusCode(204);
//        }
//        // delete -> /api/usuarios/{id}
//        [HttpDelete("{id}")]
//        public IActionResult Deletar(int id)
//        {
//            try
//            {
//                _usuarioRepository.Deletar(id);
//                return StatusCode(204);
//            }
//            catch (Exception e)
//            {
//                return BadRequest();
//            }
//        }
//    }
//}