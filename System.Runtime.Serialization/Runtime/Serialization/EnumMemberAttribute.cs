using System;

namespace System.Runtime.Serialization
{
	/// <summary>Указывает, что поле является элементом перечисления и должно быть сериализовано.</summary>
	// Token: 0x020000D2 RID: 210
	[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class EnumMemberAttribute : Attribute
	{
		/// <summary>Возвращает или задает значение, связанное с элементом перечисления, к которому применяется атрибут.</summary>
		/// <returns>Значение, связанное с элементом перечисления.</returns>
		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x00032B82 File Offset: 0x00030D82
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x00032B8A File Offset: 0x00030D8A
		public string Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.value = value;
				this.isValueSetExplicitly = true;
			}
		}

		/// <summary>Возвращает значение, указывающее, был ли объект <see cref="P:System.Runtime.Serialization.EnumMemberAttribute.Value" /> задан явно.</summary>
		/// <returns>Значение <see langword="true" />, если это значение было задано явно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x00032B9A File Offset: 0x00030D9A
		public bool IsValueSetExplicitly
		{
			get
			{
				return this.isValueSetExplicitly;
			}
		}

		// Token: 0x04000515 RID: 1301
		private string value;

		// Token: 0x04000516 RID: 1302
		private bool isValueSetExplicitly;
	}
}
