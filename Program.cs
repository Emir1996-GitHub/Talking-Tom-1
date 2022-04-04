using System.Threading;
using System;

using static System.Console;

	
public class Program 
 {
   static string gameLowerThanSelExp = "LowerThan.GameInt";
  	static string gameGreaterThanSelExp = "GreaterThan.GameInt";
   public static void Main (String[] args) 
	 {
		int minNumForSelection = 1;
		int maxNumForSelection = 16;
    int hits = 0;
		int ResetHits = 0;
    while(true){
     WriteLine("Talking Tom");
     WriteLine("1: Hit Tom");
     WriteLine("2: Make Tom eat bird Larry");
     WriteLine("3: Make Tom Repeat You.");
     WriteLine("4: Make Tom drink milk");
     WriteLine("5: Make Tom throw pie");//
     WriteLine("6: Make noise with Tom");//
     WriteLine("7: Make Tom eat spicy pepper");//
     WriteLine("8: Make Tom eat sandwich");//
	  	WriteLine("9: Make Tom eat cake");//
	 	 WriteLine("10: Make Tom eat ice cream");//
	  	WriteLine("11: Make Tom eat watermelon");//
		 WriteLine("12: Touch Tom's tail");
		 WriteLine("13: Touch Tom's left leg");
		 WriteLine("14: Touch Tom's right leg");
		 WriteLine("15: Touch Tom's belly");
		 WriteLine("16: Make Tom fart");
		 Write("Enter Number: ");
     int r = int.Parse(Console.ReadLine());
     if(r == 1){
       if(hits < 3 ){
        WriteLine("OW!");
        hits += 1;
		 	 Thread.Sleep(600);
		 	 Clear();
       }
        else if (hits >= 3){
				
         WriteLine("*Tom falled.*");
				ResetHits += 1;
				hits = 0;
      }
      Thread.Sleep(600);
      Clear();
			
    }
    if(r == 2)
    {
			
      WriteLine("Tom Couldn't eat the bird :(");
      Thread.Sleep(600);
      Clear();
			
    }
    if(r == 3)
    {

      Write("Enter Message: ");
      string text = ReadLine();
      WriteLine("Tom: " + text);
      Thread.Sleep(600);
      Clear();
		}
    if(r == 4)
    {

			WriteLine("Tom: *sip sip gulp gulp*");
      WriteLine("*THAT WAS A M A Z I N G  !");
      Thread.Sleep(600);
      Clear();

    }
    if(r == 5)
    {
		
     WriteLine("*Tom throws pie at you*");
			Thread.Sleep(600);
			Clear();
		 
    }
		// Some comments for extending that line number!
		if(r == 6)
		{
		
			WriteLine("*You and Tom made noise :)*");
			Thread.Sleep(600);
			Clear();
			
		}
		if(r == 7)
		{
			
			WriteLine("*TOM NEEDS COLD WATER (AAAAAAAAAAAAAAAAAA!)*");
			Thread.Sleep(600);
			Clear();
		}
		if(r == 8)
		{
			WriteLine("*Hmm.. That was TASTY!*");
			Thread.Sleep(600);
			Clear();
		}
		if(r == 9)
		{
			WriteLine("*You throw the cake at Tom's face but Tom likes the cake! :)*");
			Thread.Sleep(600);
			Clear();
		}
		if(r == 10)
		{
			WriteLine("*Tom got his tounge stuck*");
			Thread.Sleep(600);
			Clear();
		}
		if(r == 11)
		{
			WriteLine("*Tom has became a gun!*");
			Thread.Sleep(600);
			Clear();
		}
		if(r == 12)
		{
			WriteLine("NO!!!!");
			Thread.Sleep(600);
			Clear();
		}
		if(r == 13)
		{
			string leftLegSoundSFX = "AIEEEOOOO";
			WriteLine(leftLegSoundSFX);
			Thread.Sleep(600);
			Clear();
		
		}
		if(r == 14)
		{
			string rightLegSoundSFX = "AWEAWEEOWWW!!";
			WriteLine(rightLegSoundSFX);
			Thread.Sleep(600);
			Clear();
			
		}
		if(r == 15)
		{
			
			WriteLine("*Tom scratches you*");
			Thread.Sleep(600);
			Clear();
			
		}
		if(r == 16)
		{
			WriteLine("*fart sfx pls*");
			Thread.Sleep(600);
			Clear();
		}
		if(r > maxNumForSelection)
		{
			
			NotASelection2();
		}
		if(r < minNumForSelection)
		{
			
			WriteLine("Exeption:");
			NotASelection();
		}
	 }
		static void NotASelection()
		{
			//Hey!
			
		  WriteLine("Error: Not a selection! :( errCode: " + gameLowerThanSelExp);
			Thread.Sleep(600);
			Clear();

		}
		static void NotASelection2()
		{
			//Hi! I'm a green comment

			WriteLine("Error: Not a selection! :( errCode: " + gameGreaterThanSelExp);
			Thread.Sleep(600);
			Clear();

	 	}
   }
}

