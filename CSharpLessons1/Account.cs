using CSharpLessons1;
using System;

namespace CSharpLesson1
{


	public abstract class Account : IPayMyBill {

        //Class Variables
        protected DateTime _dueDate;

		//Create the properties
		public string Address { get; set; }
		public decimal AmountDue {get; set;}
		public DateTime InvoiceDate { get; set; } = DateTime.Today;
		
		
		
		// Create the Constructor
		public Account() {	
			
		}
		
		public Account(decimal amount, DateTime invoiceDate) 
			:this()
		{
			
			// set the default then call the default
			AmountDue = amount;
            InvoiceDate = invoiceDate;
			
		}

        //Create methods
        //implement interface
        public void Pay()
        {
            AmountDue = 0;
        }
        //abstract methods
        public abstract void CalculateDueDate();
		
		//Create toString
		public override string ToString() {
			return "AmountDue: " + AmountDue.ToString("C") + " Due: " + _dueDate.ToString();
		}
	}
}