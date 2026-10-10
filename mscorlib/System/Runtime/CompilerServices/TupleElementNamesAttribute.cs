using System;
using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает, что использование кортежа значений для элемента должно обрабатываться как кортеж с именами элементов.</summary>
	// Token: 0x02000808 RID: 2056
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	[CLSCompliant(false)]
	public sealed class TupleElementNamesAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.TupleElementNamesAttribute" />.</summary>
		/// <param name="transformNames">Строковый массив, который указывает (в обходе в глубину в прямом порядке конструкции типа), каким вхождениям кортежа значений будут назначаться имена элементов.</param>
		// Token: 0x06004624 RID: 17956 RVA: 0x000E594A File Offset: 0x000E3B4A
		public TupleElementNamesAttribute(string[] transformNames)
		{
			if (transformNames == null)
			{
				throw new ArgumentNullException("transformNames");
			}
			this._transformNames = transformNames;
		}

		/// <summary>Указывает, в обходе в глубину в прямом порядке конструкции типа, каким элементам кортежа значений будут назначаться имена элементов.</summary>
		/// <returns>Массив, указывающий, каким элементам кортежа значений будут назначаться имена элементов.</returns>
		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06004625 RID: 17957 RVA: 0x000E5967 File Offset: 0x000E3B67
		public IList<string> TransformNames
		{
			get
			{
				return this._transformNames;
			}
		}

		// Token: 0x04002D42 RID: 11586
		private readonly string[] _transformNames;
	}
}
