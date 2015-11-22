using System;
using System.IO;

class RPG
{
	public static string playerName;
	public static string playerConfirmation;
	public static string playerGender;
	public static string friendsName;
	public static string friendsConfirmation;
	public static string friendsGender;

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
		friendsName = Console.ReadLine ();
		Console.WriteLine ("");
		Console.WriteLine ("Do You Confirm That Your Friend's Name Is " + friendsName + "? y/n");
		FriendsName2 ();
	}

	public static void FriendsName2 ()
	{
		friendsConfirmation = Console.ReadLine ();
		Console.WriteLine ("");
		if (friendsConfirmation == "y")
		{
			Console.WriteLine ("Sweet We Can Almost Start The Game");
			Continuing ();
		}else if (friendsConfirmation == "n")
		{
			Console.WriteLine ("That's Okay Just Hurry The Enemies Are Coming Rewrite Your Friends Name Please!!");
			FriendName ();
		}else 
		{
			Console.WriteLine ("That Isn't A Answer Try Again");
			Console.WriteLine ("Do You Confirm That Your Friends Name Is " + friendsName + "? y/n");
			FriendsName2 ();
		}

	}

	public static void Continuing ()
	{
		Console.WriteLine ("");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine ("Are You A Boy Or A Girl");
		playerGender = Console.ReadLine ();
		if (playerGender == "Boy")
		{

		}
	}
}