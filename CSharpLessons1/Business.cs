using System;


namespace CSharpLesson1
{


	public class Business : Account {

		//Put in special stuff for a Personal account
		public string BusinessName { get; set; }
		
		
		// Create the Constructor
		public Business() 
			 :base()
		{
			
			
		}
		
		//Constructor with inputs
		public Business(string Name, decimal amount, DateTime invoiceDate) 
			 :base(amount, invoiceDate)
		{
			BusinessName = Name;
			
		}

        //Create methods
        //implement abstract methods
        public override void CalculateDueDate()
        {
            //set duedate to one month from now
            DateTime newDue = InvoiceDate;
            newDue.AddMonths(2);
            _dueDate = newDue;

        }

        
        //Create toString
        public override string ToString() {
			
			return "Name: " + BusinessName + " " +base.ToString();
		}
	}
	
}