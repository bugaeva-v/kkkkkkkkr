using System;
using System.Reflection;
using System.Security;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает физическое расположение полей в неуправляемом представлении класса или структуры.</summary>
	// Token: 0x02000708 RID: 1800
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	public sealed class FieldOffsetAttribute : Attribute
	{
		// Token: 0x060040A9 RID: 16553 RVA: 0x000E14D4 File Offset: 0x000DF6D4
		[SecurityCritical]
		internal static Attribute GetCustomAttribute(RuntimeFieldInfo field)
		{
			int fieldOffset;
			if (field.DeclaringType != null && (fieldOffset = field.GetFieldOffset()) >= 0)
			{
				return new FieldOffsetAttribute(fieldOffset);
			}
			return null;
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x000E1502 File Offset: 0x000DF702
		[SecurityCritical]
		internal static bool IsDefined(RuntimeFieldInfo field)
		{
			return FieldOffsetAttribute.GetCustomAttribute(field) != null;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.FieldOffsetAttribute" />, используя смещение в структуре относительно начала поля.</summary>
		/// <param name="offset">Смещение в байтах от начала структуры до начала поля.</param>
		// Token: 0x060040AB RID: 16555 RVA: 0x000E150D File Offset: 0x000DF70D
		public FieldOffsetAttribute(int offset)
		{
			this._val = offset;
		}

		/// <summary>Возвращает смещение в байтах от начала структуры до начала поля.</summary>
		/// <returns>Смещение в байтах от начала структуры до начала поля.</returns>
		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x060040AC RID: 16556 RVA: 0x000E151C File Offset: 0x000DF71C
		public int Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002ADF RID: 10975
		internal int _val;
	}
}
