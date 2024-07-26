namespace Start.Intermediate_OOP
{
    public class Ivan : Iperson
    {
        String Name { get; set; }
        int Age { get; set; }
        String Town { get; set; }
        public void Shout()
        {
            Console.WriteLine("Ivan kreshti");
        }
    }
}
