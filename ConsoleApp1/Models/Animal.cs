
namespace ConsoleApp1.Models
{
    internal abstract  class Animal
    {
        public string Name { get; set; }
        public abstract void Test();
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }

    }
}
