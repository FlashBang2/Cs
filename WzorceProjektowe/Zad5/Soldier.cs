class Soldier : IUnit,ILandUnit
{
    int HealthPoints,Damage,AttackSpeed,MovmentSpeed;
    bool CanTravelThroughWater,CanTravelThroughLand,CanTravelThroughAir;
    public Soldier()
    {
        CanTravelThroughAir = false;
        CanTravelThroughWater = false;
        CanTravelThroughLand = true;
        HealthPoints = 60;
        MovmentSpeed =3;
        Damage = 10;
        AttackSpeed = 1;
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
    public void ChangePostion()
    {
        
    }
    public void BoardShip()
    {
        
    }
    public void BoardHelicopter()
    {
        
    }
}