﻿using SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcademico.Data
{
    public class DBInitializer
    {
        public static void Initialize(SistemaAcademicoContext context) {
            context.Database.EnsureCreated();

            //Busca si existen registros en la tabla categoría
            if (context.Categoria.Any()) {
                return;
            }
            var categorias = new Categoria[] {
                new Categoria{ Nombre = "Programación", Descripcion= "Cursos de programación", Estado = true},
                                new Categoria{ Nombre = "Diseño Gráfico", Descripcion= "Cursos de diseño gráfico", Estado = true}
            };

            foreach (Categoria c in categorias) {
                context.Categoria.Add(c);
            }
            context.SaveChanges();
            
        }
    }
}
