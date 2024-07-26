namespace Start.Intermediate_OOP
{
    public class Ivan : Iperson
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public String Town { get; set; }
        public void Shout()
        {
            Console.WriteLine("Ivan kreshti");
        }
    }
}
