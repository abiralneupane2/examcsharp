using System;
using static System.Console;

class array
{

  static void Main (string[]args)
  {
      int Bool=0;
    int[] array = { 329, 515, 130, 498, 101, 458, 128 };
    int[] temp = array;
    int temp2;
    Console.Write ("1.View Array in reverse order\n");
    Console.Write ("2.View Specific Element of Array\n");
    Console.Write ("3.Quit\n");
    string val;
    int res;
    string arrind;
    int res2;

    val = Console.ReadLine ();
    res = Convert.ToInt32 (val);
    switch (res)
      {
      case 1:
	for (int i = 0; i < array.Length; i++)
	  {
	    temp2 = array[i];
	    temp[i] = array[array.Length - i - 1];
	  }

	foreach (int i in temp)
	{
	  Console.Write (i + " ");
	}
	break;
      case 2:
	Console.WriteLine ("Enter Position of element");
	arrind = Console.ReadLine ();
	res2 = Convert.ToInt32 (arrind);
	Console.Write ("{0}", array[res2]);
	break;
      case 3:
	System.Environment.Exit (1);
	break;
      }
  }
}
