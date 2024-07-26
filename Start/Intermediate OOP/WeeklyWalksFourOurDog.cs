namespace Start.Intermediate_OOP
{
    public class WeeklyWalksForOurDog : Pet
    {
        public string text;

        public void PrintAnimalClassName()
        {
           DogWalk(text: "Our labrador is going for walk");
        }

        public string WhatIsHappenEveryMorning()
        {
            return text;
        }


    }
}
