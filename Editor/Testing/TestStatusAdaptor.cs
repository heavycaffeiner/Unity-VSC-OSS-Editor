using System;

namespace Microsoft.Unity.VSCodeUniversal.Editor.Testing
{
	[Serializable]
	internal enum TestStatusAdaptor
	{
		Passed,
		Skipped,
		Inconclusive,
		Failed,
	}
}
