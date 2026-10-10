using System;
using System.Reflection;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Указывает, что член может быть определен с помощью перечисления.
	///       </summary>
	// Token: 0x020002CD RID: 717
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false)]
	public class XmlChoiceIdentifierAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlChoiceIdentifierAttribute" />.
		///       </summary>
		// Token: 0x06001B4A RID: 6986 RVA: 0x000021EA File Offset: 0x000003EA
		public XmlChoiceIdentifierAttribute()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlChoiceIdentifierAttribute" />.
		///       </summary>
		/// <param name="name">
		///           Имя члена, возвращающего перечисление, используемое для определения выбора.
		///         </param>
		// Token: 0x06001B4B RID: 6987 RVA: 0x0009BD6D File Offset: 0x00099F6D
		public XmlChoiceIdentifierAttribute(string name)
		{
			this.name = name;
		}

		/// <summary>
		///         Возвращает или задает имя поля, возвращающего перечисление для использования при определении типов.
		///       </summary>
		/// <returns>
		///         Имя поля, возвращающего перечисление.
		///       </returns>
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x0009BD7C File Offset: 0x00099F7C
		// (set) Token: 0x06001B4D RID: 6989 RVA: 0x0009BD92 File Offset: 0x00099F92
		public string MemberName
		{
			get
			{
				if (this.name != null)
				{
					return this.name;
				}
				return string.Empty;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x0009BD9B File Offset: 0x00099F9B
		// (set) Token: 0x06001B4F RID: 6991 RVA: 0x0009BDA3 File Offset: 0x00099FA3
		internal MemberInfo MemberInfo
		{
			get
			{
				return this.memberInfo;
			}
			set
			{
				this.memberInfo = value;
			}
		}

		// Token: 0x040019E7 RID: 6631
		private string name;

		// Token: 0x040019E8 RID: 6632
		private MemberInfo memberInfo;
	}
}
