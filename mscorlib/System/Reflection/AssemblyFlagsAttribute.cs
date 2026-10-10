using System;

namespace System.Reflection
{
	/// <summary>Определяет побитовое сочетание флагов <see cref="T:System.Reflection.AssemblyNameFlags" /> для сборки, описывающих параметры JIT-компилятора, возможность переопределить целевые объекты сборки, а также вид открытого ключа сборки — полный или измененный с использованием маркера. Этот класс не наследуется.</summary>
	// Token: 0x02000887 RID: 2183
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyFlagsAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyFlagsAttribute" /> с указанным сочетанием флагов <see cref="T:System.Reflection.AssemblyNameFlags" />, приведенным к беззнаковому целочисленному значению.</summary>
		/// <param name="flags">Побитовое сочетание флагов <see cref="T:System.Reflection.AssemblyNameFlags" />, приведенных к беззнаковому целочисленному значению, которые представляют параметры JIT-компилятора, долговременность, возможность переопределить целевые объекты сборки, а также вид ее открытого ключа — полный или измененный с использованием маркера.</param>
		// Token: 0x06004861 RID: 18529 RVA: 0x000EE0CA File Offset: 0x000EC2CA
		[Obsolete("This constructor has been deprecated. Please use AssemblyFlagsAttribute(AssemblyNameFlags) instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		[CLSCompliant(false)]
		public AssemblyFlagsAttribute(uint flags)
		{
			this._flags = (AssemblyNameFlags)flags;
		}

		/// <summary>Возвращает беззнаковое целочисленное значение, представляющее сочетание флагов <see cref="T:System.Reflection.AssemblyNameFlags" />, определенных при создании этого экземпляра атрибута.</summary>
		/// <returns>Беззнаковое целочисленное значение, представляющее битовую комбинацию флагов <see cref="T:System.Reflection.AssemblyNameFlags" />.</returns>
		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06004862 RID: 18530 RVA: 0x000EE0D9 File Offset: 0x000EC2D9
		[CLSCompliant(false)]
		[Obsolete("This property has been deprecated. Please use AssemblyFlags instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		public uint Flags
		{
			get
			{
				return (uint)this._flags;
			}
		}

		/// <summary>Возвращает целочисленное значение, представляющее сочетание флагов <see cref="T:System.Reflection.AssemblyNameFlags" />, определенных при создании этого экземпляра атрибута.</summary>
		/// <returns>Целочисленное значение, представляющее битовую комбинацию флагов <see cref="T:System.Reflection.AssemblyNameFlags" />.</returns>
		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06004863 RID: 18531 RVA: 0x000EE0D9 File Offset: 0x000EC2D9
		public int AssemblyFlags
		{
			get
			{
				return (int)this._flags;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyFlagsAttribute" /> с указанным сочетанием флагов <see cref="T:System.Reflection.AssemblyNameFlags" />, приведенным к целочисленному значению.</summary>
		/// <param name="assemblyFlags">Побитовое сочетание флагов <see cref="T:System.Reflection.AssemblyNameFlags" />, приведенных к целочисленному значению, которые представляют параметры JIT-компилятора, долговременность, возможность переопределить целевые объекты сборки, а также вид ее открытого ключа — полный или измененный с использованием маркера.</param>
		// Token: 0x06004864 RID: 18532 RVA: 0x000EE0CA File Offset: 0x000EC2CA
		[Obsolete("This constructor has been deprecated. Please use AssemblyFlagsAttribute(AssemblyNameFlags) instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		public AssemblyFlagsAttribute(int assemblyFlags)
		{
			this._flags = (AssemblyNameFlags)assemblyFlags;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyFlagsAttribute" /> с указанным сочетанием флагов <see cref="T:System.Reflection.AssemblyNameFlags" />.</summary>
		/// <param name="assemblyFlags">Побитовое сочетание флагов <see cref="T:System.Reflection.AssemblyNameFlags" />, представляющих параметры JIT-компилятора, долговременность, возможность переопределить целевые объекты сборки, а также вид ее открытого ключа — полный или измененный с использованием маркера.</param>
		// Token: 0x06004865 RID: 18533 RVA: 0x000EE0CA File Offset: 0x000EC2CA
		public AssemblyFlagsAttribute(AssemblyNameFlags assemblyFlags)
		{
			this._flags = assemblyFlags;
		}

		// Token: 0x04002E55 RID: 11861
		private AssemblyNameFlags _flags;
	}
}
