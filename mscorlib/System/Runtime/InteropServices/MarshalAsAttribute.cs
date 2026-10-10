using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает способ маршалинга данных между управляемым и неуправляемым кодом.</summary>
	// Token: 0x0200074C RID: 1868
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = false)]
	[ComVisible(true)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class MarshalAsAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.MarshalAsAttribute" /> заданным значением <see cref="T:System.Runtime.InteropServices.UnmanagedType" />.</summary>
		/// <param name="unmanagedType">Значение, в виде которого будут маршалированы данные.</param>
		// Token: 0x06004234 RID: 16948 RVA: 0x000E3A82 File Offset: 0x000E1C82
		public MarshalAsAttribute(short unmanagedType)
		{
			this.utype = (UnmanagedType)unmanagedType;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.MarshalAsAttribute" /> с указанным членом перечисления <see cref="T:System.Runtime.InteropServices.UnmanagedType" />.</summary>
		/// <param name="unmanagedType">Значение, в виде которого будут маршалированы данные.</param>
		// Token: 0x06004235 RID: 16949 RVA: 0x000E3A82 File Offset: 0x000E1C82
		public MarshalAsAttribute(UnmanagedType unmanagedType)
		{
			this.utype = unmanagedType;
		}

		/// <summary>Получает значение <see cref="T:System.Runtime.InteropServices.UnmanagedType" />, используемое для маршалинга данных.</summary>
		/// <returns>Значение типа <see cref="T:System.Runtime.InteropServices.UnmanagedType" />, используемого для маршалинга данных.</returns>
		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06004236 RID: 16950 RVA: 0x000E3A91 File Offset: 0x000E1C91
		public UnmanagedType Value
		{
			get
			{
				return this.utype;
			}
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x000E3A99 File Offset: 0x000E1C99
		internal MarshalAsAttribute Copy()
		{
			return (MarshalAsAttribute)base.MemberwiseClone();
		}

		/// <summary>Предоставляет дополнительные сведения для настраиваемого модуля маршалинга.</summary>
		// Token: 0x04002BD4 RID: 11220
		public string MarshalCookie;

		/// <summary>Задает полное имя настраиваемого модуля маршалинга.</summary>
		// Token: 0x04002BD5 RID: 11221
		[ComVisible(true)]
		public string MarshalType;

		/// <summary>Реализует поле <see cref="F:System.Runtime.InteropServices.MarshalAsAttribute.MarshalType" /> в виде типа.</summary>
		// Token: 0x04002BD6 RID: 11222
		[ComVisible(true)]
		[PreserveDependency("GetCustomMarshalerInstance", "System.Runtime.InteropServices.Marshal")]
		public Type MarshalTypeRef;

		/// <summary>Указывает определенный пользователем тип элемента для поля <see cref="F:System.Runtime.InteropServices.UnmanagedType.SafeArray" />.</summary>
		// Token: 0x04002BD7 RID: 11223
		public Type SafeArrayUserDefinedSubType;

		// Token: 0x04002BD8 RID: 11224
		private UnmanagedType utype;

		/// <summary>Задает тип элемента неуправляемого массива <see cref="F:System.Runtime.InteropServices.UnmanagedType.LPArray" /> или <see cref="F:System.Runtime.InteropServices.UnmanagedType.ByValArray" />.</summary>
		// Token: 0x04002BD9 RID: 11225
		public UnmanagedType ArraySubType;

		/// <summary>Показывает тип элемента для поля <see cref="F:System.Runtime.InteropServices.UnmanagedType.SafeArray" />.</summary>
		// Token: 0x04002BDA RID: 11226
		public VarEnum SafeArraySubType;

		/// <summary>Показывает количество элементов в массиве фиксированной длины или количество знаков (не байтов) в импортируемой строке.</summary>
		// Token: 0x04002BDB RID: 11227
		public int SizeConst;

		/// <summary>Задает индекс параметра неуправляемого атрибута <see langword="iid_is" />, используемого в COM.</summary>
		// Token: 0x04002BDC RID: 11228
		public int IidParameterIndex;

		/// <summary>Указывает параметр, содержащий отсчитываемое от нуля количество элементов массива, аналогичный параметру <see langword="size_is" /> в COM.</summary>
		// Token: 0x04002BDD RID: 11229
		public short SizeParamIndex;
	}
}
