//using section
using System;
using static System.Console;


//project name space
namespace CSharpLesson1 {

	//Driver class
	public class Program  {

		//Main to create and execute stuff
		static void Main(string[] args){
			
			//Create a Business and personal account
			Business mybus = new Business("Joe's Stuff", 600, DateTime.Today);
			
			Personal mypers = new Personal("Sam", "Spade", 200, DateTime.Today);
			
			//output the stuff
			WriteLine(mypers.ToString());
			WriteLine(mybus.ToString());

            //Pay all the bills
            mybus.Pay();
            mypers.Pay();
			
			//Hold the console
			ReadKey();
			
		}
	
	
	}
	
	
}