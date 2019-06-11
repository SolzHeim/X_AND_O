using System;

namespace X_AND_O
{
	class MainClass
	{
		public static void Main (string[] args)
   		{
			string[,] X_OArray = new string[3, 3];
			for (int rt1 = 0;rt1  < 3; rt1++) 
			for (int rt2 = 0;rt2  < 3; rt2++) 
			X_OArray [rt2, rt1] = "|";
			string a = "X";
			for (int yu = 1; yu <= 9; yu ++) 
			{	
				try 
				{
					int whilee = 55;
					while (whilee != 2)
					{
						Console.Write ("stolb -> ");
						int stolb1 = (Convert.ToInt32 (Console.ReadLine ()))-1;
					    Console.Write ("\nstroky -> ");
					    int stroka1 = (Convert.ToInt32 (Console.ReadLine ()))-1;
						if (X_OArray [stolb1, stroka1] == "|")
						{
							X_OArray [stolb1, stroka1] = a;
							whilee = 2;
							if ((X_OArray [0,0] == "X") && (X_OArray [1,1] == "X") && (X_OArray [2,2] == "X") 
							|| ((X_OArray [2,0] == "X") && (X_OArray [1,1] == "X") && (X_OArray [0,2] == "X")) ||
							(X_OArray [0,0] == "O") && (X_OArray [1,1] == "O") && (X_OArray [2,2] == "O") 
							|| ((X_OArray [2,0] == "O") && (X_OArray [1,1] == "O") && (X_OArray [0,2] == "O")))
							{
								for (int rr1 = 0; rr1 <= 2; rr1++) 
								{
									Console.WriteLine (X_OArray [0, rr1] + X_OArray [1, rr1] + X_OArray [2, rr1]);
								}
								Console.Write(a + " wins-s-s-s-s-s-s(-_-)!!!!!");
								Console.ReadKey();
								return;
							}
							for (int e = 0; e < 3; e++)
							{
								if ((X_OArray [e,1] == "X") && (X_OArray [e,2] == "X") && (X_OArray [e,0] == "X") || (X_OArray [e,1] == "O") && (X_OArray [e,2] == "O") && (X_OArray [e,0] == "O"))
								{
						     		for (int rr1 = 0; rr1 <= 2; rr1++) 
									{
										Console.WriteLine (X_OArray [0, rr1] + X_OArray [1, rr1] + X_OArray [2, rr1]);
									}
									Console.Write(a + " wins-s-s-s-s-s-s(-_-)!!!!!");
									Console.ReadKey();
									return;
								}
							}
							for (int uu = 0; uu < 3; uu++)
							{
								if (((X_OArray [2,uu] == "X") && (X_OArray [0,uu] == "X") && (X_OArray [1,uu] == "X")) 
								|| ((X_OArray [2,uu] == "O") && (X_OArray [0,uu] == "O") && (X_OArray [1,uu] == "O")))
								{
								    for (int rr1 = 0; rr1 <= 2; rr1++) 
									{
										Console.WriteLine (X_OArray [0, rr1] + X_OArray [1, rr1] + X_OArray [2, rr1]);
									}
									Console.Write(a + " wins-s-s-s-s-s-s(-_-)!!!!!");
									Console.ReadKey();
									return;
								}
							}
							if (a == "X")
							a = "O";
							else
							a = "X";
				  		}
						else
						{
							Console.WriteLine("TbI lllO?!");
						}
					}
				}
				catch (IndexOutOfRangeException) 
				{
					Console.WriteLine ("\nIndexOutOfRangeException in X_OArray!!!\n");
				}
				for (int rr1 = 0; rr1 <= 2; rr1++) 
				{
					Console.WriteLine (X_OArray [0, rr1] + X_OArray [1, rr1] + X_OArray [2, rr1]);
				}
				if (yu == 9) 
				{
					Console.WriteLine ("Ничья!");
					Console.ReadKey ();
					return;
				}
			}
		}
	}
}

	
