using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prj_Cadastro.Entities;
using Prj_Cadastro.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Prj_Cadastro.Controllers
{
    public class CadController : Controller
    {
        // GET: CadController
        public ActionResult Index()
        {
            IPessoaDB pdb = new PessoaDB();
            PessoaServices ps = new PessoaServices(pdb);
            return View(ps.listPessoas());
        }

        // GET: CadController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CadController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pessoa pessoa)
        {
            try
            {
                IPessoaDB pdb = new PessoaDB();
                PessoaServices ps = new PessoaServices(pdb);
                ps.addPessoa(pessoa);
                return RedirectToAction(nameof(Index)); // para que pagina vai depois do cadastro
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: CadController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CadController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CadController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CadController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
