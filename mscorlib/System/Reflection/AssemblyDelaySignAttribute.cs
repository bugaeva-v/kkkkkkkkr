using System;

namespace System.Reflection
{
	/// <summary>Указывает, что сборка не подписывается полностью при создании.</summary>
	// Token: 0x02000884 RID: 2180
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyDelaySignAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyDelaySignAttribute" />.</summary>
		/// <param name="delaySign">Значение <see langword="true" />, если элемент, представленный данным атрибутом, активирован. В противном случае — значение <see langword="false" />.</param>
		// Token: 0x0600485B RID: 18523 RVA: 0x000EE077 File Offset: 0x000EC277
		public AssemblyDelaySignAttribute(bool delaySign)
		{
			this.DelaySign = delaySign;
		}

		/// <summary>Возвращает значение, указывающее состояние атрибута.</summary>
		/// <returns>Значение <see langword="true" />, если эта сборка была собрана как сборка с отложенным подписанием. В обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x0600485C RID: 18524 RVA: 0x000EE086 File Offset: 0x000EC286
		public bool DelaySign { get; }
	}
}
