using book.Models;
using System;
using System.Collections.Generic;

namespace book.Helpers
{
    public static class BookFactoryHelper
    {
        public static List<Book> CreateBooks()
        {
            return new List<Book>
            {
                new Book
                {
                    Code = Guid.Parse("3872339b-5556-4c94-b7ca-2cc8abde32d8"),
                    Title = "Domain-Driven Design: Atacando as complexidades no coração do software",
                    TotalPages = 528,
                    ISBN = "978-8550800653",
                    Year = 2016,
                    Language = "Português",
                    Author = "Eric Evans"
                },
                new Book
                {
                    Code = Guid.Parse("6ef14d71-cd31-4c94-b88d-9d2dc26e3fb1"),
                    Title = "Arquitetura limpa: O guia do artesão para estrutura e design de software",
                    TotalPages = 432,
                    ISBN = "978-8550804606",
                    Year = 2019,
                    Language = "Português",
                    Author = "Robert C. Martin"
                },
                new Book
                {
                    Code = Guid.Parse("24eca492-67f3-4dac-a66e-1643bc6766e8"),
                    Title = "Código limpo: Habilidades práticas do Agile Software",
                    TotalPages = 425,
                    ISBN = "978-8576082675",
                    Year = 2009,
                    Language = "Português",
                    Author = "Robert C. Martin"
                },
                new Book
                {
                    Code = Guid.Parse("2307feb3-d6e2-4758-968f-069833510018"),
                    Title = "Refatoração: Aperfeiçoando o Design de Códigos Existentes",
                    TotalPages = 456,
                    ISBN = "978-8575227244",
                    Year = 2020,
                    Language = "Português",
                    Author = "Martin Fowler"
                },
                new Book
                {
                    Code = Guid.Parse("22d1e9b8-af4e-4859-a55b-5c6fd573736a"),
                    Title = "Padrões de Projetos: Soluções Reutilizáveis de Software Orientados a Objetos",
                    TotalPages = 368,
                    ISBN = "978-8573076103",
                    Year = 2000,
                    Language = "Português",
                    Author = "Erich Gamma"
                }
            };
        }
    }
}
