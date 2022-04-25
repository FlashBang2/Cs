class Tank : IUnit, ILandUnit
{
    int HealthPoints, Damage, AttackSpeed,MovmentSpeed;
    bool CanTravelThroughWater, CanTravelThroughLand, CanTravelThroughAir;
    public Tank()
    {
        HealthPoints = 120;
        Damage = 20;
        AttackSpeed = 2;
        MovmentSpeed = 4;
        CanTravelThroughWater = false;
        CanTravelThroughLand = true;
        CanTravelThroughAir = false;

    }
    public void Destroy()
    {
        
    }
    public void BoardHelicopter()
    {
        

    }
    public void BoardShip()
    {
        

    }
    public void ChangePostion()
    {
        

    }
    public void ReceiveDamage()
    {
        

    }
    public void Shoot()
    {
        

    }
}