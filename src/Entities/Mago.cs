namespace src.Entities
{
    public class Mago : Hero
    {
        public Mago(string nome, int level,string tipo) : base(nome, level, tipo)
        {
            this.Nome = nome;
            this.Level = level;
            this.HeroType = tipo;

        }
       public override string Ataque()
       {
           return this.Nome + " lançou uma magia";
       }
        public string Ataque(int Bonus)
       {
           return this.Nome + " lançou uma magia com um bonus de " + Bonus;
       }
    }
}