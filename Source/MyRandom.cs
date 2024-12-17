static class MyRandom
{
    private static Random? _random;
    public static Random random 
    {
        get
        {
            if (_random == null)
                _random = new Random();
            
            return _random;
        }
    }

    public static int Next(int maxValue)
    {
        return random.Next(maxValue);
    }
    
    public static (int x, int y) NextVector((int x, int y) limit)
    {
        (int x, int y) result;
        result.x = random.Next(limit.x);
        result.y = random.Next(limit.y);
        
        return result;
    }
}