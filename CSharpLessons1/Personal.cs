
using System;

namespace CSharpLesson1
{


	public class Personal : Account {

		//Put in special stuff for a Personal account
		public string FirstName { get; set; }
		public string LastName { get; set; }
		
		
		// Create the Constructor
		public Personal() 
			 :base()
		{
			
			
		}
		
		//have inputs
		public Personal(string FName, string LName, decimal amount, DateTime invoiceDate) 
			 :base(amount, invoiceDate)
		{
            FirstName = FName;
            LastName = LName;
			
		}

        //Create methods
        //implement abstract methods
        public override void CalculateDueDate()
        {
            //set duedate to one month from now
            DateTime newDue = InvoiceDate;
            newDue.AddMonths(1);
            _dueDate = newDue;
            
        }

        //Create toString
        public override string ToString() {
			
			return "Name: " + FirstName + " " + LastName + " " + base.ToString();
		}
	}
	
}