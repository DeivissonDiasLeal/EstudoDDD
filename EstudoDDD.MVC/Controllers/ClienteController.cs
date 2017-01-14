using AutoMapper;
using EstudoDDD.Application;
using EstudoDDD.Application.Interfaces;
using EstudoDDD.Domain.Entities;
using EstudoDDD.MVC.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstudoDDD.MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IAppServiceCliente db;

        public ClienteController(IAppServiceCliente clienteService)
        {
            db = clienteService;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            var clientes = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(db.GetAll());
            return View(clientes);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            var cliente = db.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(clienteViewModel);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel clienteViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
                    db.Add(clienteDomain);
                    return RedirectToAction("Index");
                }
                return View(clienteViewModel);
            }
            catch(Exception ex)
            {
                return View(clienteViewModel);
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = db.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(clienteViewModel);
            
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel clienteViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
                    db.Update(clienteDomain);
                    return RedirectToAction("Index");
                }
                return View(clienteViewModel);
            }
            catch
            {
                return View(clienteViewModel);
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            var cliente = db.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(clienteViewModel);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var cliente = db.GetById(id);
            db.Remove(cliente);

            return RedirectToAction("Index");           
        }

        public ActionResult ClientesEspeciais()
        {
            var clientes = db.ObterClientesEspeciais(db.GetAll());

            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(clientes);

            return View(clienteViewModel);
        }

    }
}
