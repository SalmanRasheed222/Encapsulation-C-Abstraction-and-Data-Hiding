using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_with_Abstraction
{
	

	public class student
	{
		public string name { get; set; }
		public string fathername { get; set; }
		private int rollno;
		public int obtainmarks;
		private int tmarks;
		private decimal aggregate;	
		

		
		public int roll
		{
			get
			{
				return rollno;
			}

			set
			{
				if (value < 0)
				{
					Console.WriteLine("Your Roll Number Can't be Less  Then 0. And by Default set to=");
					rollno = 1;
				}
				else
				{
					rollno = value;
				}
			}
		}

		public int totalmarks 
		{
			get { return tmarks=1100; }
			//set { tmarks = 1100; }
		}


		public decimal percentage
		{
			
			get
			{			
				return Convert.ToDecimal(obtainmarks) /Convert.ToDecimal(totalmarks)* 100;
			}
			//set
			//{
			//	percentage = value;
			//}
		}









		

		public void print()
		{
			
			Console.WriteLine(name);
			Console.WriteLine(fathername);
			Console.WriteLine(rollno);
			Console.WriteLine(obtainmarks);
			Console.WriteLine(percentage);

		}


	}







}
