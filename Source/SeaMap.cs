using System.Xml;

class SeaMap
{
    private Tile[,] _tiles;

    private SeaMap(Tile[,] tiles)
    {
        _tiles = tiles;
    }

    public Tile GetTile((int x, int y) position)
        => _tiles[position.y, position.x];
    
    public static SeaMap GenerateMap((int x, int y) size, uint shipCount)
    {
        Tile[,] tiles = new Tile[size.y, size.x];

        for (int i = 0; i < shipCount; i++)
        {
            (int x, int y) = MyRandom.NextVector(size);
            ref Tile chosenTile = ref tiles[y, x];
            
             chosenTile = new Tile(TileType.Ship);
        }
        
        return new SeaMap(tiles);
    }

    public ShootingResult TakeShot((int x, int y) position)
        => _tiles[position.y, position.x].TakeShot();
}