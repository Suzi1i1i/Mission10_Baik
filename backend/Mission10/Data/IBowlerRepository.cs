using Mission10.Data;

namespace Mission10.data
{
    public interface IBowlerRepository 
    {
        IEnumerable<Bowler> Bowlers { get; }

    }
}
