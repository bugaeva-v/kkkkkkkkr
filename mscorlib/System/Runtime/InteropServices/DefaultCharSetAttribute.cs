using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Определяет значение перечисления <see cref="T:System.Runtime.InteropServices.CharSet" />. Этот класс не наследуется.</summary>
	// Token: 0x02000711 RID: 1809
	[AttributeUsage(AttributeTargets.Module, Inherited = false)]
	[ComVisible(true)]
	public sealed class DefaultCharSetAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.DefaultCharSetAttribute" /> заданным значением <see cref="T:System.Runtime.InteropServices.CharSet" />.</summary>
		/// <param name="charSet">Одно из значений перечисления <see cref="T:System.Runtime.InteropServices.CharSet" />.</param>
		// Token: 0x060040C3 RID: 16579 RVA: 0x000E1637 File Offset: 0x000DF837
		public DefaultCharSetAttribute(CharSet charSet)
		{
			this._CharSet = charSet;
		}

		/// <summary>Возвращает значение по умолчанию <see cref="T:System.Runtime.InteropServices.CharSet" /> для любого вызова атрибута <see cref="T:System.Runtime.InteropServices.DllImportAttribute" />.</summary>
		/// <returns>Значение по умолчанию <see cref="T:System.Runtime.InteropServices.CharSet" /> для любого вызова атрибута <see cref="T:System.Runtime.InteropServices.DllImportAttribute" />.</returns>
		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x060040C4 RID: 16580 RVA: 0x000E1646 File Offset: 0x000DF846
		public CharSet CharSet
		{
			get
			{
				return this._CharSet;
			}
		}

		// Token: 0x04002AEF RID: 10991
		internal CharSet _CharSet;
	}
}
