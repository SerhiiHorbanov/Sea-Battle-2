enum ShootingResult
{
    Miss,
    Hit,
}

enum TileType
{
    Sea,
    Ship,
}

struct Tile
{
    public readonly TileType Type;
    public bool WasShot { get; private set; }

    public Tile(TileType type, bool wasShot)
    {
        Type = type;
        WasShot = wasShot;
    }

    public ShootingResult TakeShot()
    {
        ShootingResult shootingResult = GetShootingResult();
        WasShot = true;
        
        return shootingResult;
    }

    private ShootingResult GetShootingResult()
        => Type switch
        {
            TileType.Sea => ShootingResult.Miss,
            TileType.Ship => ShootingResult.Hit,
        };
}