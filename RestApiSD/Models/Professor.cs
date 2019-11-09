using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace RestApiSD.Models
{
    [DataContract]
    public class Professor
    {
        [DataMember(Name="id")]
        public int id { get; set; }

        [DataMember(Name="nome")]
        public string nome { get; set; }

        [DataMember(Name="nascimento")]
        public DateTime nascimento { get; set; }
    }

    public class RetornaProfessor
    {
        public List<Professor> Lista()
        {
            var lista = new List<Professor>()
            {
                new Professor { id = 1, nascimento = DateTime.Now.AddYears(-40), nome = "Vandeir Topzera" },
                new Professor { id = 2, nascimento = DateTime.Now.AddYears(-60), nome = "Marco Miquejonson" },
                new Professor { id = 3, nascimento = DateTime.Now.AddYears(-70), nome = "Mendeleck Binário" }
            };

            return lista;
        }

        public Professor Objeto(int id)
        {
            return this.Lista().Where(x => x.id == id).FirstOrDefault();
        }
    }
}