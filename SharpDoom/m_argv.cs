/*
 * Creato da SharpDevelop.
 * Utente: Mattias Cibien
 * Data: 24/05/2009
 * Ora: 11.59
 * 
 * 
 */
using System;

namespace Doomed
{
	/// <summary>
	/// Stores sommand-line paramenters
	/// </summary>
	public class ArgStore
	{
		public static string[] Args
		{
			get; set;
		}
		
		/// <summary>
		/// Checks for the given parameter
		/// in the program's command line arguments.
		/// Returns ture if present
		/// or false if not.
		/// </summary>
		public static bool CheckParam(string check)
		{
			foreach (string s in Args)
			{
				if (s.ToLower() == check.ToLower())
				{
					return true;
				}
			}
			return false;
		}
	}
}
