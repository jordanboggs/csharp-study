namespace TreehouseDefense
{
  class Invader
  {
    private readonly Path _path;
    private int _pathStep = 0;
    
    public MapLocation Location => _path.GetLocationAt(_pathStep);
    
    public int Health { get; private set; } = 2;

    // True if the Invader has reached the end of the map
    public bool HasScored => _pathStep >= _path.Length;

    // True if the Invader's health is zero
    public bool IsNeutralized => Health <= 0;

    public bool IsActive => !(IsNeutralized || HasScored);

    public Invader(Path path)
    {
      _path = path;
    }

    public void Move() => _pathStep++;

    public void DecreaseHealth(int factor)
    {
      Health -= factor;
    }
  }
}