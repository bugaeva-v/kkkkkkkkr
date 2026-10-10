using System;
using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{
	/// <summary>
	///         Указывает, что использование <see cref="T:System.Object" /> на член должен рассматриваться как динамически выполняемый тип.
	///       </summary>
	// Token: 0x020002ED RID: 749
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public sealed class DynamicAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.DynamicAttribute" />.
		///       </summary>
		// Token: 0x060016B5 RID: 5813 RVA: 0x0004C805 File Offset: 0x0004AA05
		public DynamicAttribute()
		{
			this._transformFlags = new bool[]
			{
				true
			};
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.DynamicAttribute" />.
		///       </summary>
		/// <param name="transformFlags">
		///           Указывает в префикса обхода конструкции типа, который <see cref="T:System.Object" /> вхождений предназначены следует рассматривать как динамически выполняемый тип.
		///         </param>
		// Token: 0x060016B6 RID: 5814 RVA: 0x0004C81D File Offset: 0x0004AA1D
		public DynamicAttribute(bool[] transformFlags)
		{
			if (transformFlags == null)
			{
				throw new ArgumentNullException("transformFlags");
			}
			this._transformFlags = transformFlags;
		}

		/// <summary>
		///         Указывает в префикса обхода конструкции типа, который <see cref="T:System.Object" /> вхождений предназначены следует рассматривать как динамически выполняемый тип.
		///       </summary>
		/// <returns>
		///         Список <see cref="T:System.Object" /> которые следует рассматривать как динамически выполняемый тип.
		///       </returns>
		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x0004C83A File Offset: 0x0004AA3A
		public IList<bool> TransformFlags
		{
			get
			{
				return Array.AsReadOnly<bool>(this._transformFlags);
			}
		}

		// Token: 0x04000B64 RID: 2916
		private readonly bool[] _transformFlags;
	}
}
