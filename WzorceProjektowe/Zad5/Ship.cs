class Ship : IUnit,IWaterUnit
{
    int HealthPoints, Damage, AttackSpeed, MovmentSpeed;
    bool CanTravelThroughWater, CanTravelThroughLand, CanTravelThroughAir;
    public Ship()
    {
        HealthPoints = 80;
        Damage = 15;
        AttackSpeed = 1;
        MovmentSpeed = 5;
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