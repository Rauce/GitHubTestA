﻿using System;
using GitHubTestShared;

namespace GitHubTestA {
	class Program {

		static void Main(string[] args) {

			Console.WriteLine("Hello, your GUID is: {0}", Utilities.NewGuid());

			Console.WriteLine();
			Console.WriteLine("- Press any key to continue -");
			Console.ReadKey();

		}

	}
}