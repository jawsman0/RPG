using System;
using System.IO;

class RPG
{
	public static string playerName;
	public static string playerConfirmation;
	public static string friendsName;

	public static void Main ()
	{
		playerConfirmation = "";
		playerName = "";
		friendsName = "";
		Console.ForegroundColor = ConsoleColor.DarkMagenta;
		Console.WriteLine ("Welcome To Enemy Destroyer");
		Console.ForegroundColor = ConsoleColor.DarkGreen;
		Console.WriteLine ("");
		name ();
	}

	public static void name ()
	{
		Console.WriteLine ("Write Your Name!");
		Console.WriteLine ("");
		playerName = Console.ReadLine ();
		Console.WriteLine ("");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine ("Do You Confirm That Your Name Is " + playerName + "? y/n");
		confirmation ();
	}

	public static void confirmation ()
	{
		playerConfirmation = Console.ReadLine ();
		if (playerConfirmation == "y")
		{
			other ();
		}else if (playerConfirmation == "n")
		{
			Console.WriteLine ("");
			Console.WriteLine ("Try Again Than!");
			name ();
		}else
		{
			Console.WriteLine ("");
			Console.WriteLine ("That Is Not An Answer");
			Console.WriteLine ("y/n is this your name");
			confirmation ();
		}
	}

	public static void other ()
	{
		Console.WriteLine ("");
		Console.ForegroundColor = ConsoleColor.DarkYellow; 
		Console.WriteLine ("Let's Continue");
		Console.WriteLine ("What Is Your Friends Name");
		Console.WriteLine ("");
		FriendName ();
	}

	public static void FriendName ()
	{

	}
}