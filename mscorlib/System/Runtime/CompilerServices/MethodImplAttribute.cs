using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
	/// <summary>Сообщает подробные сведения о реализации метода. Этот класс не наследуется.</summary>
	// Token: 0x02000845 RID: 2117
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
	[ComVisible(true)]
	[Serializable]
	public sealed class MethodImplAttribute : Attribute
	{
		// Token: 0x060046BF RID: 18111 RVA: 0x000E717C File Offset: 0x000E537C
		internal MethodImplAttribute(MethodImplAttributes methodImplAttributes)
		{
			MethodImplOptions methodImplOptions = MethodImplOptions.Unmanaged | MethodImplOptions.ForwardRef | MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall | MethodImplOptions.Synchronized | MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining | MethodImplOptions.NoOptimization;
			this._val = (MethodImplOptions)(methodImplAttributes & (MethodImplAttributes)methodImplOptions);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.MethodImplAttribute" /> заданным значением <see cref="T:System.Runtime.CompilerServices.MethodImplOptions" />.</summary>
		/// <param name="methodImplOptions">Значение <see cref="T:System.Runtime.CompilerServices.MethodImplOptions" />, задающее свойства метода с атрибутами.</param>
		// Token: 0x060046C0 RID: 18112 RVA: 0x000E719E File Offset: 0x000E539E
		public MethodImplAttribute(MethodImplOptions methodImplOptions)
		{
			this._val = methodImplOptions;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.MethodImplAttribute" /> заданным значением <see cref="T:System.Runtime.CompilerServices.MethodImplOptions" />.</summary>
		/// <param name="value">Битовая маска, представляющая нужное значение <see cref="T:System.Runtime.CompilerServices.MethodImplOptions" />, задающее свойства метода с атрибутами.</param>
		// Token: 0x060046C1 RID: 18113 RVA: 0x000E719E File Offset: 0x000E539E
		public MethodImplAttribute(short value)
		{
			this._val = (MethodImplOptions)value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.MethodImplAttribute" />.</summary>
		// Token: 0x060046C2 RID: 18114 RVA: 0x00002050 File Offset: 0x00000250
		public MethodImplAttribute()
		{
		}

		/// <summary>Возвращает значение <see cref="T:System.Runtime.CompilerServices.MethodImplOptions" />, описывающее метод с атрибутами.</summary>
		/// <returns>Значение <see cref="T:System.Runtime.CompilerServices.MethodImplOptions" />, описывающее метод с атрибутами.</returns>
		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x060046C3 RID: 18115 RVA: 0x000E71AD File Offset: 0x000E53AD
		public MethodImplOptions Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002D8D RID: 11661
		internal MethodImplOptions _val;

		/// <summary>Значение <see cref="T:System.Runtime.CompilerServices.MethodCodeType" />, указывающее, какого вида реализация предусмотрена для этого метода.</summary>
		// Token: 0x04002D8E RID: 11662
		public MethodCodeType MethodCodeType;
	}
}
