namespace Dungeons_and_Code_wizards
{
    public interface IHealable
    {
        public void Heal(Character character)
        {
            character.Health++;
        }
    }
}