namespace Dungeons_and_Code_wizards
{
    public class Character
    {
        public string _name { get; set; }
        public float _baseHealth { get; set; }
        public float _health { get; set; }
        public float _baseArmor { get; set; }
        public float _armor { get; set; }
        public float _abilityPoints { get; set; }
        public Bag _bag { get; set; }
        public bool IsAlive { get; set; }
        public float _restHealMultiplier = 0.2f;

        public Character(bool isAlive)
        {
            IsAlive = isAlive;
        }
    }
}