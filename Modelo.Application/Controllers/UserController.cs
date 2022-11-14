using Microsoft.AspNetCore.Mvc;
using Modelo.Domain.Interface;
using Modelo.Domain.Models;

namespace Modelo.Application.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService= userService;
        }

        [HttpGet]
        public IEnumerable<User> GetContatos()
        {
            var users = _userService.GetAll();
            return users;
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetContato(int id)
        {
            var contato = _userService.GetById(id);
            if (contato == null)
            {
                return NotFound(new { message = $"Contato de id={id} não encontrado" });
            }
            return contato;
        }
    }
}
