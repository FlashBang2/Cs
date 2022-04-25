class Helicopter : IUnit, IAirUnit
{
    int HealthPoints, Damage, AttackSpeed, MovmentSpeed;
    bool CanTravelThroughWater, CanTravelThroughLand, CanTravelThroughAir;
    public Helicopter()
    {
        HealthPoints = 200;
        Damage = 5;
        AttackSpeed = 1;
        MovmentSpeed = 10;
        CanTravelThroughWater = true;
        CanTravelThroughLand = true;
        CanTravelThroughAir = true;
    }
    public void ChangePostion()
    {
       
    }
    public void Destroy()
    {
       
    }
    public void ReceiveDamage()
    {
        
    }
    public void Shoot()
    {
        
    }
}