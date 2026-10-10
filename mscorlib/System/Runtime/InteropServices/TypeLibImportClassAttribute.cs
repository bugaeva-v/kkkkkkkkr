using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Определяет, какой тип <see cref="T:System.Type" /> использует интерфейс исключительным образом. Этот класс не наследуется.</summary>
	// Token: 0x020006EC RID: 1772
	[AttributeUsage(AttributeTargets.Interface, Inherited = false)]
	[ComVisible(true)]
	public sealed class TypeLibImportClassAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.TypeLibImportClassAttribute" />, задавая тип <see cref="T:System.Type" />, исключительным образом использующий интерфейс.</summary>
		/// <param name="importClass">Объект <see cref="T:System.Type" />, использующий интерфейс исключительным образом.</param>
		// Token: 0x0600406E RID: 16494 RVA: 0x000E0FCA File Offset: 0x000DF1CA
		public TypeLibImportClassAttribute(Type importClass)
		{
			this._importClassName = importClass.ToString();
		}

		/// <summary>Возвращает имя объекта <see cref="T:System.Type" />, который использует интерфейс исключительным образом.</summary>
		/// <returns>Имя объекта <see cref="T:System.Type" />, который использует интерфейс исключительным образом.</returns>
		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x0600406F RID: 16495 RVA: 0x000E0FDE File Offset: 0x000DF1DE
		public string Value
		{
			get
			{
				return this._importClassName;
			}
		}

		// Token: 0x04002A3B RID: 10811
		internal string _importClassName;
	}
}
