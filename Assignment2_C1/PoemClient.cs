using System;

public class PoemClient {
	public static void Main(string[] args) 
	{
		HyggeService proxy = new HyggeService(); 
		while (true) 
		{
			Console.WriteLine("Enter a poem file name (Options available: sea.txt, sky.txt and forest.txt)"); 
			string fileName = Console.ReadLine(); 
			Console.WriteLine(proxy.FetchPoem(fileName)); 
		}
	}
}