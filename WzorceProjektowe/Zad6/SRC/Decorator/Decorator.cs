public class Decorator : Hero
{
    protected Hero hero;

    public Decorator(Hero _hero)
    {
        hero = _hero;
    }

    public override int Attack()
    {
        return hero.Attack();
    }

    public override int Defense()
    {
        return hero.Defense();
    }

    public override int Health()
    {
        return hero.Health();
    }

}