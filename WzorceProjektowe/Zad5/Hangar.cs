class Hangar : Factory
{
    public override IUnit CreateFirstUnit()
    {
        return new Helicopter();
    }
    public override IUnit CreateSecondUnit()
    {
        return new Plane();
    }
}