using System;

namespace System.Reflection
{
	/// <summary>Предоставляет текстовое описание сборки.</summary>
	// Token: 0x02000885 RID: 2181
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyDescriptionAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyDescriptionAttribute" />.</summary>
		/// <param name="description">Описание сборки.</param>
		// Token: 0x0600485D RID: 18525 RVA: 0x000EE08E File Offset: 0x000EC28E
		public AssemblyDescriptionAttribute(string description)
		{
			this.Description = description;
		}

		/// <summary>Возвращает сведения об описании сборки.</summary>
		/// <returns>Строка, содержащая описание сборки.</returns>
		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x0600485E RID: 18526 RVA: 0x000EE09D File Offset: 0x000EC29D
		public string Description { get; }
	}
}
