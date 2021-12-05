namespace Dungeons_and_Code_wizards
{
    public interface IAttackable
    {
        void Attack(Character character)
        {
            character.Health--;
        }
    }
}