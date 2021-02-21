using System;
using System.Collections;
using System.Collections.Generic;
using CursosIdra.Models;

namespace CursosIdra{
    public class Banco
    {
        public static Dictionary<long,Modelo> Cursos = new Dictionary<long,Modelo>();
        public static Dictionary<long,Modelo> Estudantes = new Dictionary<long,Modelo>();
        public static Dictionary<long,Modelo> Pagamentos = new Dictionary<long,Modelo>();
        public static Dictionary<long,Modelo> Cartoes = new Dictionary<long,Modelo>();
    }
}