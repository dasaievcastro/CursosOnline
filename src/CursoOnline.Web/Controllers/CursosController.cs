﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoOnline.Dominio.Cursos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CursoOnline.Web.Controllers
{
    public class CursosController : Controller
    {
        private readonly ArmazenadorDeCurso armazenador;
        //public CursosController(ArmazenadorDeCurso armazenador)
        //{
        //    armazenador = armazenador;
        //}
        // GET: /<controller>/
        public Curso Index()
        {
            return new Curso("Teste", 0, 0, "");
        }
    }
}
