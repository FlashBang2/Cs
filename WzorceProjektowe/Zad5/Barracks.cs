public class Barracks : Factory
{
    public override IUnit CreateFirstUnit()
    {
        return new Soldier();
    }
    public override IUnit CreateSecondUnit()
    {
        return new Tank();
    }
}