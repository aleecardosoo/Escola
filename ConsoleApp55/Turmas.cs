﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Turmas
    {
        public string _nome { get; set; }
        public string _codigo { get; set; }
        public Turmas(string nome, string codigo, List<Aluno> a, List<Professor> p, List<Cursos> c)
        {
            _nome = nome;
            _codigo = codigo;
        }
    }
}