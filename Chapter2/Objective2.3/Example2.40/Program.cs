
namespace Example2._40
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface ILeft
    {
        void Move();
    }

    interface IRight
    {
        void Move();
    }

    class MovableObject : ILeft, IRight
    {
        void ILeft.Move() { }

        void IRight.Move() { }
    }
}
