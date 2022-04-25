class Submarine : IUnit,IWaterUnit
{
    int HealthPoints, Damage, AttackSpeed, MovmentSpeed;
    bool CanTravelThroughWater, CanTravelThroughLand, CanTravelThroughAir;
    public Submarine()
    {
        HealthPoints = 100;
        Damage = 25;
        AttackSpeed = 3;
        MovmentSpeed = 4;
        CanTravelThroughAir = false;
        CanTravelThroughLand = false;
        CanTravelThroughWater = true;
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