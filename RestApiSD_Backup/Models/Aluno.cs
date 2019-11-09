using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace RestApiSD_Backup.Models
{
    [DataContract]
    public class Aluno
    {
        [DataMember(Name="id")]
        public int id { get; set; }

        [DataMember(Name="nome")]
        public string nome { get; set; }

        [DataMember(Name= "curso")]
        public string curso { get; set; }
    }

    public class RetornaAluno
    {
        public List<Aluno> Lista()
        {
            var lista = new List<Aluno>()
            {
                new Aluno { id = 1, curso = "Ciência da Computação", nome = "Márcio Lindão" },
                new Aluno { id = 2, curso = "Ciência da Computação", nome = "Gustavo Secão" },
                new Aluno { id = 3, curso = "Ciência da Computação", nome = "Ítalo Bomba de Cavalo" }
            };

            return lista;
        }

        public Aluno Objeto(int id)
        {
            return this.Lista().Where(x => x.id == id).FirstOrDefault();
        }
    }
}