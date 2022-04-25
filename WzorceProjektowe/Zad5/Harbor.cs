class Harbor : Factory
{
    public override IUnit CreateFirstUnit()
    {
        return new Ship();
    }
    public override IUnit CreateSecondUnit()
    {
        return new Submarine();
    }
}