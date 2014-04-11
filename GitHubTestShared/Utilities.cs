using System;

namespace GitHubTestShared {
	public static class Utilities {

		public static string NewGuid() {
			return Guid.NewGuid().ToString("N").ToUpper();
		}

	}
}