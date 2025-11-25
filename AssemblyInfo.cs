using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("RenderCore.Editor")]

namespace RenderCore
{
	public static class AssemblyInfo
	{
		internal const string AssemblyVersion = "2.7.0";




		public static Version version => new Version(AssemblyVersion);
	}
}