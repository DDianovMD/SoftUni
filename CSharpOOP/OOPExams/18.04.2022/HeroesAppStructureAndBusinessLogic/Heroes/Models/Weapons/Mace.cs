namespace Heroes.Models.Weapons
{
    public class Mace : Weapon
    {
        public Mace(string name, int durability) 
            : base(name, durability)
        {
        }

        public override int DoDamage()
        {
            if (this.Durability >= 1)
            {
                this.Durability -= 1;
                return 25;
            }
            else
            {
                return 0;
            }
        }
    }
}
