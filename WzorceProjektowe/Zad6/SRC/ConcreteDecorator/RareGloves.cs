public class RareGloves : Decorator
{
    bool OnHero;
    const int HPValue = 10, AttackValue = 3, DefenseValue = 4;

    public RareGloves(Hero _hero,bool onHero) : base(_hero)
    {
        OnHero = onHero;
    }

    public override int Attack()
    {
        switch (OnHero)
        {
            case true:
                    return base.Attack() - AttackValue;
            case false:
                    return base.Attack() + AttackValue;
        }
    }

    public override int Defense()
    {
        switch (OnHero)
        {
            case true:
                return base.Defense() - DefenseValue;
            case false:
                return base.Defense() + DefenseValue;
        }
    }

    public override int Health()
    {
        switch (OnHero)
        {
            case true:
                return base.Health() - HPValue;
            case false:
                return base.Health() + HPValue;
        }
       
    }
}
