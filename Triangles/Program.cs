/*
 * Created by SharpDevelop.
 * User: Familia
 * Date: 15/03/2023
 * Time: 2:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Triangles
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter coordinate x of dot A");
			double xA = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter coordinate y of dot A");
			double yA = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter coordinate x of dot B");
			double xB = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter coordinate y of dot B");
			double yB = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter coordinate x of dot C");
			double xC = Double.Parse(Console.ReadLine());
			Console.WriteLine("Enter coordinate y of dot C");
			double yC = Double.Parse(Console.ReadLine());
			
			double aBResult = Math.Sqrt(Math.Pow((xB)-(xA),2) + Math.Pow((yB)-(yA),2));
			double bCResult = Math.Sqrt(Math.Pow((xC)-(xB),2) + Math.Pow((yC)-(yB),2));
			double aCResult = Math.Sqrt(Math.Pow((xC)-(xA),2) + Math.Pow((yC)-(yA),2));
			double perimeter = aBResult + bCResult + aCResult;
			string triangleType;
			
			if ((aBResult == bCResult) && (bCResult == aCResult)){
				triangleType = "Equilateral";
			}
			else if((aBResult == bCResult)||(aBResult == aCResult)||(bCResult == aCResult)){
				triangleType = "Isoceles";
			}
			else
				triangleType = "Escaleno";

			string isEquilateral = triangleType == "Equilateral" ? "IS Equilateral" : "IS NOT Equilateral";
			string isIsoceles = triangleType == "Isoceles" ? "IS Isoceles" : "IS NOT Isoceles";


			
			Console.WriteLine("Length of AB is: " + aBResult);
			Console.WriteLine("Length of BC is: " + bCResult);
			Console.WriteLine("Length of AC is: " + aCResult + "\n");
			Console.WriteLine("Triangle " + isEquilateral);
			Console.WriteLine("Triangle " + isIsoceles);
			Console.WriteLine("Triangle IS Right? \n");
			Console.WriteLine("Perimeter: " + perimeter + "\n");
			Console.WriteLine("Parity numbers in range from 0 to triangle permimeter:");
			for(int i = 0; i<=perimeter;i++){
				if (i % 2 == 0)
				Console.WriteLine(i);
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}