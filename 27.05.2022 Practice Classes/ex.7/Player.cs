using System.Xml.XPath;

namespace ex._7;

public class Player
{
    public int PositionX { get; private set; }
    public int PositionY { get; private set; }
    public int PositionZ { get; private set; }
    public double Experience { get; private set; }
    public int Lives { get; private set; }
    public double Balance { get; private set; }

    public Player(int positionX, int positionY, int positionZ, int experience, int lives, double balance)
    {
        PositionX = positionX;
        PositionY = positionY;
        PositionZ = positionZ;
        Experience = experience;
        Lives = lives;
        Balance = balance;
    }

    public void TakeTax()
    {
        Balance -= Balance * 0.25;
    }

    public void IncreaseExperience()
    {
        Experience += Experience * 0.1;
    }

    public override string ToString()
    {
        return $"Position: {PositionX} {PositionY} {PositionZ}; Lives: {Lives}; Balance: {Balance}; XP: {Experience}";
    }
}