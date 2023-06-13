using System.Collections.Generic;

namespace RH_Manager.Windows.Core
{
    public class Estados
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public int Id { get; set; }

        public List<Estados> ObterTodosEstados()
        {
            var listaDeEstados = new List<Estados>();

            listaDeEstados.Add(new Estados
            {
                Id = 14,
                Nome = "Roraima",
                Sigla = "RR"
            }) ;

            listaDeEstados.Add(new Estados
            {
                Id = 11,
                Nome = "Rondônia",
                Sigla = "RO"
            });

            listaDeEstados.Add(new Estados
            {
                Id = 12,
                Nome = "Acre",
                Sigla = "AC"
            }) ;

            listaDeEstados.Add(new Estados
            {
                Id = 15,
                Nome = "Pará",
                Sigla = "PA"
            });

            listaDeEstados.Add(new Estados
            {
                Id = 16,
                Nome = "Amapá",
                Sigla = "AP"
            });

            listaDeEstados.Add(new Estados
            {
                Id = 17,
                Nome = "Tocantins",
                Sigla = "TO"
            });

            listaDeEstados.Add(new Estados
            {
                Id = 21,
                Nome = "Maranhão",
                Sigla = "MA"
            });

            listaDeEstados.Add(new Estados
            {
                Id =22,
                Nome = "Piauí",
                Sigla = "PI"
            });

            listaDeEstados.Add(new Estados
            {
                Id = 23,
                Nome = "Ceará",
                Sigla = "CE"
            });

            listaDeEstados.Add(new Estados
            {
                Id = 24,
                Nome = "Rio Grande do Norte",
                Sigla = "RN"
            });

            listaDeEstados.Add(new Estados
            {
                Id = 2,
                Nome = "Paraíba",
                Sigla = "PB"
            });

            listaDeEstados.Add(new Estados
            {
                Id = 2,
                Nome = "Pernambuco",
                Sigla = "PE"
            });

            

            return listaDeEstados;
        }
    }
}
