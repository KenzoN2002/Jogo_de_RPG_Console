namespace src.Entities
{
    public abstract class Hero // abstract é uma classe que as outras classes pdoem usa, apenas, herdar
    {
        public Hero(string nome, int level, string tipo)
        { 
            this.Nome = nome;
            this.Level = level;
            this.HeroType = tipo;
        }
       
        public string Nome { get; set; }
        public int Level { get; set; }
        public string HeroType{get; set;}

        
        public override string ToString()
        {
            return this.Nome + " " + this.Level + " " + this.HeroType;
        }
        public virtual string Ataque()
        {
            return this.Nome + "com sua espada";
        }
    }
}