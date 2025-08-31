using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        //animal Animal = new animal();
       dog DOG = new dog("","");
       cat CAT = new cat("","");
       DOG.speak("dog","woof");
       CAT.speak("cat","meows");
    }
}
class animal{
    public string animalName;
    public string animalSound;
    public animal(string animal,string sound){
        this.animalName = animal;
        this.animalSound = sound;
    }
    public virtual  void speak(string animalName,string animalSound){
        Console.WriteLine($"The {animalName} goes {animalSound}..");
    }
    }
class dog : animal{
    public dog(string animalName, string animalSound) : base(animalName, animalSound) { }
    public override void speak(string animalName,string animalSound){
        Console.WriteLine($"The {animalName} goes {animalSound}..");
    }
}
class cat : animal{
     public cat(string animalName ,string animalSound) : base( animalName, animalSound) {}
     public override void speak(string animalName,string animalSound){
         Console.WriteLine($"The {animalName} goes {animalSound}..");
    }
}