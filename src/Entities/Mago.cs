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
           if(Bonus > 6)
            return this.Nome + " lançou uma magia  efetiva com um bonus de " + Bonus;
           else
            return this.Nome + " lançou uma magia  pouco efetiva com um bonus de " + Bonus;
       }    
    }
}