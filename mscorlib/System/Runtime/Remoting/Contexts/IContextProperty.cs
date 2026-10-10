using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Собирает информацию о именах из контекстного свойства и определяет, приемлем ли новый контекст для контекстного свойства.</summary>
	// Token: 0x02000595 RID: 1429
	[ComVisible(true)]
	public interface IContextProperty
	{
		/// <summary>Возвращает имя свойства, под которым оно будет добавлено в контекст.</summary>
		/// <returns>Имя свойства.</returns>
		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060037D1 RID: 14289
		string Name { get; }

		/// <summary>Вызывается, если контекст заморожен.</summary>
		/// <param name="newContext">Замораживаемый контекст.</param>
		// Token: 0x060037D2 RID: 14290
		void Freeze(Context newContext);

		/// <summary>Возвращает логическое значение, указывающее, совместимо ли контекстное свойство с новым контекстом.</summary>
		/// <param name="newCtx">Новый контекст, в котором было создано контекстное свойство <see cref="T:System.Runtime.Remoting.Contexts.ContextProperty" />.</param>
		/// <returns>Принимает значение <see langword="true" />, если контекстное свойство может существовать в данном контексте одновременно с другими его контекстными свойствами; иначе —<see langword="false" />.</returns>
		// Token: 0x060037D3 RID: 14291
		bool IsNewContextOK(Context newCtx);
	}
}
