class Plane : IUnit, IAirUnit
{
    int HealthPoints, Damage, AttackSpeed, MovmentSpeed;
    bool CanTravelThroughWater, CanTravelThroughLand, CanTravelThroughAir;
    public Plane()
    {
        HealthPoints = 120;
        Damage = 40;
        AttackSpeed = 5;
        MovmentSpeed = 6;
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