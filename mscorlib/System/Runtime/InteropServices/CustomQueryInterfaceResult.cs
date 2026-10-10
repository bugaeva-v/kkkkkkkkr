using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет значения, возвращаемые методом <see cref="M:System.Runtime.InteropServices.ICustomQueryInterface.GetInterface(System.Guid@,System.IntPtr@)" />.</summary>
	// Token: 0x02000717 RID: 1815
	[ComVisible(false)]
	[Serializable]
	public enum CustomQueryInterfaceResult
	{
		/// <summary>Указатель интерфейса, возвращаемый методом <see cref="M:System.Runtime.InteropServices.ICustomQueryInterface.GetInterface(System.Guid@,System.IntPtr@)" />, можно использовать в качестве результата метода IUnknown::QueryInterface.</summary>
		// Token: 0x04002AFC RID: 11004
		Handled,
		/// <summary>Пользовательский интерфейс <see langword="QueryInterface" /> не используется. Вместо него следует использовать реализацию по умолчанию метода IUnknown::QueryInterface.</summary>
		// Token: 0x04002AFD RID: 11005
		NotHandled,
		/// <summary>Интерфейс, соответствующий определенному идентификатору интерфейса, недоступен. В этом случае возвращается интерфейс <see langword="null" />. Объекту, вызвавшему метод IUnknown::QueryInterface, возвращается значение E_NOINTERFACE.</summary>
		// Token: 0x04002AFE RID: 11006
		Failed
	}
}
