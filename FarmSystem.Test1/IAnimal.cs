namespace FarmSystem.Test1
{
    public interface IAnimal
    {
        string Id { get; set; }
        int NoOfLegs { get; set; }
        void Run();
        void Talk();
    }
}