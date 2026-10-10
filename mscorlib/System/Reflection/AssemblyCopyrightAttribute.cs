using System;

namespace System.Reflection
{
	/// <summary>Определяет настраиваемый атрибут уведомления об авторских правах для манифеста сборки.</summary>
	// Token: 0x02000881 RID: 2177
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyCopyrightAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyCopyrightAttribute" />.</summary>
		/// <param name="copyright">Сведения об авторских правах.</param>
		// Token: 0x06004855 RID: 18517 RVA: 0x000EE032 File Offset: 0x000EC232
		public AssemblyCopyrightAttribute(string copyright)
		{
			this.Copyright = copyright;
		}

		/// <summary>Возвращает сведения об авторских правах.</summary>
		/// <returns>Строка, содержащая сведения об авторских правах.</returns>
		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06004856 RID: 18518 RVA: 0x000EE041 File Offset: 0x000EC241
		public string Copyright { get; }
	}
}
