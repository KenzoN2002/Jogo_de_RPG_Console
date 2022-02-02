namespace src.Entities
{
    public class Cavaleiro : Hero
    {
        public Cavaleiro(string nome, int level,string tipo) : base( nome, level, tipo)
        {
            this.Nome = nome;
            this.Level = level;
            this.HeroType = tipo;
        }
    }
}