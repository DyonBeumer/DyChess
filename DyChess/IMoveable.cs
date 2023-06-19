namespace DyChess
{
    public interface IMoveable
    {
        DestinationEvent? Move(Position toPosition);
    }
}
