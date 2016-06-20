using RPGSystem.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSystem.Entidades
{
    public class Personagem : IEntidades
    {

        public int IdPersonagem { get; set; }
        public string Especie { get; set; }
        public int idEspecie { get; set; }
        public string Nome { get; set; }
        public Boolean Genero { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }
        public int Nivel { get; set; }

        public Personagem()
        {
            this.IdPersonagem = int.MaxValue;
        }

        public Personagem(int AIdPersonagem, string AEspecie, string ANome, Boolean AGenero, int AAtaque, int ADefesa, int ANivel)
        {
            this.IdPersonagem = int.MaxValue;
            this.Nome = ANome;
            this.Especie = AEspecie;
            this.Ataque = AAtaque;
            this.Defesa = ADefesa;
            this.Nivel = ANivel;
            this.Genero = AGenero;

        }

        public void Excluir()
        {
            PersonagemDAO dao = new PersonagemDAO();
            if (IdPersonagem != int.MaxValue)
            {
                dao.Excluir(this.IdPersonagem);
            }
            else if (dao.ListarPersonagem().Exists(x => x.Nome == this.Nome))
            {
                dao.Excluir(dao.ListarPersonagem().Find(x => x.Nome == this.Nome).IdPersonagem);
            }
            else
            {
                throw new ArgumentNullException("Personagem ainda não foi incluido e não pode ser excluido!");
            }
        }

        public void DiscoverEspecie()
        {
            this.Especie = Entidades.Especie.ListarTodas().Find(x => x.idEspecie == this.idEspecie).nome;
        }


        public void Salvar()
        {
            PersonagemDAO dao = new PersonagemDAO();

            if (this.IdPersonagem != int.MaxValue && dao.ListarPersonagem().Exists(x => x.IdPersonagem == this.IdPersonagem))
            {
                dao.Alterar(this, this.IdPersonagem);
            }
            else
            {
                dao.Criar(this);
            }
        }

        public static List<Personagem> ListarTodos()
        {
            PersonagemDAO dao = new PersonagemDAO();
            return dao.ListarPersonagem();
        }
    }
}
