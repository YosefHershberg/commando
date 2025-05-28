namespace OOP
{
    public interface IBreakable
    {
        string Status { get; set; }
        int MaxHits { get; }
        int CurrentHits { get; set; }
        void Hit();
    }
}