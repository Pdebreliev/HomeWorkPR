namespace Start.Intermediate_OOP
{
    public class ClassImplementationPlamen : Iperson
    {
        public string Name { get; set; }
       public int Age { get; set; }
       public String Town { get; set; }
        public void Shout()
        {
            Console.WriteLine("Plamen vika");
        }
    }
}
