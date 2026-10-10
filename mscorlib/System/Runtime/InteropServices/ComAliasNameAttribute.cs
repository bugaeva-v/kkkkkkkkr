using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает псевдоним COM для типа параметра или поля.</summary>
	// Token: 0x02000709 RID: 1801
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = false)]
	public sealed class ComAliasNameAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.ComAliasNameAttribute" />, используя псевдоним для поля или параметра с атрибутом.</summary>
		/// <param name="alias">Псевдоним поля или параметра, обнаруженный в библиотеке типов при импортировании.</param>
		// Token: 0x060040AD RID: 16557 RVA: 0x000E1524 File Offset: 0x000DF724
		public ComAliasNameAttribute(string alias)
		{
			this._val = alias;
		}

		/// <summary>Возвращает псевдоним поля или параметра, обнаруженный в библиотеке типов при импортировании.</summary>
		/// <returns>Псевдоним поля или параметра, обнаруженный в библиотеке типов при импортировании.</returns>
		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x060040AE RID: 16558 RVA: 0x000E1533 File Offset: 0x000DF733
		public string Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002AE0 RID: 10976
		internal string _val;
	}
}
