using System;
using GitHubTestShared;

namespace GitHubTestA {
	class Program {

		static void Main(string[] args) {

			Console.WriteLine("Your GUID is: {0}", Utilities.NewGuid());

			Console.WriteLine();
			Console.WriteLine("-- Press any key to continue --");
			Console.ReadKey();

		}

	}
}