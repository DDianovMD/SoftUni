namespace Heroes.Models.Weapons
{
    public class Claymore : Weapon
    {
        public Claymore(string name, int durability) 
            : base(name, durability)
        {
        }

        public override int DoDamage()
        {
            if (this.Durability >= 1)
            {
                this.Durability -= 1;
                return 20;
            }
            else
            {
                return 0;
            }

            //if (this.Durability == 0)
            //{
                
            //}

            
        }
    }
}
