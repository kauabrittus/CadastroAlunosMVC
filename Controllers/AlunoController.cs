using Microsoft.AspNetCore.Mvc;
using CadastroAlunosMVC.Models;

namespace CadastroAlunosMVC.Controllers
{
    public class AlunoController : Controller
    {
       
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                
                ViewBag.Mensagem = "Aluno cadastrado com sucesso!";
                return View();
            }

            
            return View(aluno);
        }
    }
}