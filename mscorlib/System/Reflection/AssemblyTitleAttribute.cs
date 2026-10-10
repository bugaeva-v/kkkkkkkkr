using System;

namespace System.Reflection
{
	/// <summary>Задает описание сборки.</summary>
	// Token: 0x0200088F RID: 2191
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyTitleAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyTitleAttribute" />.</summary>
		/// <param name="title">Заголовок сборки.</param>
		// Token: 0x06004874 RID: 18548 RVA: 0x000EE189 File Offset: 0x000EC389
		public AssemblyTitleAttribute(string title)
		{
			this.Title = title;
		}

		/// <summary>Возвращает сведения о заголовке сборки.</summary>
		/// <returns>Заголовок сборки.</returns>
		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06004875 RID: 18549 RVA: 0x000EE198 File Offset: 0x000EC398
		public string Title { get; }
	}
}
