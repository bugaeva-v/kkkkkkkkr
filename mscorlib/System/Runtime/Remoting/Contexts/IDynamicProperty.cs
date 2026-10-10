using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Указывает на то, что реализующее свойство должно быть зарегистрировано во время выполнения с помощью метода <see cref="M:System.Runtime.Remoting.Contexts.Context.RegisterDynamicProperty(System.Runtime.Remoting.Contexts.IDynamicProperty,System.ContextBoundObject,System.Runtime.Remoting.Contexts.Context)" />.</summary>
	// Token: 0x0200059D RID: 1437
	[ComVisible(true)]
	public interface IDynamicProperty
	{
		/// <summary>Возвращает имя динамического свойства.</summary>
		/// <returns>Имя динамического свойства.</returns>
		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060037E0 RID: 14304
		string Name { get; }
	}
}
