using System;

namespace System.IO
{
	/// <summary>
	///         Указывает, является ли базовый дескриптор наследуемым дочерними процессами.
	///       </summary>
	// Token: 0x02000333 RID: 819
	[Serializable]
	public enum HandleInheritability
	{
		/// <summary>
		///         Указывает, что дескриптор не наследуется дочерними процессами.
		///       </summary>
		// Token: 0x04000BEC RID: 3052
		None,
		/// <summary>
		///         Указывает, что дескриптор наследоваться дочерними процессами.
		///       </summary>
		// Token: 0x04000BED RID: 3053
		Inheritable
	}
}
