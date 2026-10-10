using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает, какую реализацию <see langword="IDispatch" /> следует использовать для определенного класса.</summary>
	// Token: 0x020006F2 RID: 1778
	[ComVisible(true)]
	[Obsolete("The IDispatchImplAttribute is deprecated.", false)]
	[Serializable]
	public enum IDispatchImplType
	{
		/// <summary>Указывает, что среда CLR принимает решение, какую реализацию <see langword="IDispatch" /> использовать.</summary>
		// Token: 0x04002A40 RID: 10816
		SystemDefinedImpl,
		/// <summary>Указывает, что реализация <see langword="IDispatch" /> предоставляется средой выполнения.</summary>
		// Token: 0x04002A41 RID: 10817
		InternalImpl,
		/// <summary>Указывает, что реализация <see langword="IDispatch" /> предоставляется путем передачи информации о типе для объекта в метод API COM <see langword="CreateStdDispatch" />.</summary>
		// Token: 0x04002A42 RID: 10818
		CompatibleImpl
	}
}
