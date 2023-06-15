using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace RH_Manager.Windows.Core
{

    public class Estados
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public IList<Estados> ObterTodosEstados()
        {
            var listaDeEstados = new List<Estados>();

            listaDeEstados.Add(new Estados { Sigla = "RO", Nome = "Rondônia" });
            listaDeEstados.Add(new Estados { Sigla = "AC", Nome = "Acre", });
            listaDeEstados.Add(new Estados { Sigla = "ES", Nome = "Espirito Santo" });
            listaDeEstados.Add(new Estados { Sigla = "RJ", Nome = "Rio de Janeiro" });
            listaDeEstados.Add(new Estados { Sigla = "MG", Nome = "Minas Gerais" });
            listaDeEstados.Add(new Estados { Sigla = "SP", Nome = "São Paulo" });
            listaDeEstados.Add(new Estados { Sigla = "RS", Nome = "Rio Grande do Sul" });
            listaDeEstados.Add(new Estados { Sigla = "SC", Nome = "Santa Catarinas" });
            listaDeEstados.Add(new Estados { Sigla = "PR", Nome = "Parana" });
            listaDeEstados.Add(new Estados { Sigla = "BA", Nome = "Bahia" });
            listaDeEstados.Add(new Estados { Sigla = "AL", Nome = "Alagoas" });
            listaDeEstados.Add(new Estados { Sigla = "PE", Nome = "Pernambuco" });
            listaDeEstados.Add(new Estados { Sigla = "SE", Nome = "Sergipe" });
            listaDeEstados.Add(new Estados { Sigla = "CE", Nome = "Ceara" });
            return listaDeEstados;
        }
    }
}