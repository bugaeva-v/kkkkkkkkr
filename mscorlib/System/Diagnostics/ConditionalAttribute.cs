using System;

namespace System.Diagnostics
{
	/// <summary>Указывает компиляторам, что вызов метода или атрибут следует игнорировать, если не определен заданный символ условной компиляции.</summary>
	// Token: 0x020009AE RID: 2478
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
	[Serializable]
	public sealed class ConditionalAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.ConditionalAttribute" />.</summary>
		/// <param name="conditionString">Строка, в которой связанный с атрибутом символ условной компиляции задан с учетом регистра.</param>
		// Token: 0x0600598A RID: 22922 RVA: 0x00132EB3 File Offset: 0x001310B3
		public ConditionalAttribute(string conditionString)
		{
			this.ConditionString = conditionString;
		}

		/// <summary>Возвращает символ условной компиляции, связанный с атрибутом <see cref="T:System.Diagnostics.ConditionalAttribute" />.</summary>
		/// <returns>Строка, в которой связанный с атрибутом <see cref="T:System.Diagnostics.ConditionalAttribute" /> символ условной компиляции задан с учетом регистра.</returns>
		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x0600598B RID: 22923 RVA: 0x00132EC2 File Offset: 0x001310C2
		public string ConditionString { get; }
	}
}
