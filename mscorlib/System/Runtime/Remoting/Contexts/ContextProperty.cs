using System;
using System.Runtime.InteropServices;
using Unity;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Хранит пару "имя — значение" имени свойства и объекта, представляющего собой свойство контекста.</summary>
	// Token: 0x02000590 RID: 1424
	[ComVisible(true)]
	public class ContextProperty
	{
		// Token: 0x060037BF RID: 14271 RVA: 0x000C8B05 File Offset: 0x000C6D05
		private ContextProperty(string name, object prop)
		{
			this.name = name;
			this.prop = prop;
		}

		/// <summary>Возвращает имя класса T:System.Runtime.Remoting.Contexts.ContextProperty.</summary>
		/// <returns>Имя класса <see cref="T:System.Runtime.Remoting.Contexts.ContextProperty" />.</returns>
		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060037C0 RID: 14272 RVA: 0x000C8B1B File Offset: 0x000C6D1B
		public virtual string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Возвращает объект, представляющий свойство контекста.</summary>
		/// <returns>Объект, представляющий свойство контекста.</returns>
		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060037C1 RID: 14273 RVA: 0x000C8B23 File Offset: 0x000C6D23
		public virtual object Property
		{
			get
			{
				return this.prop;
			}
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x000173AD File Offset: 0x000155AD
		internal ContextProperty()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040025B2 RID: 9650
		private string name;

		// Token: 0x040025B3 RID: 9651
		private object prop;
	}
}
