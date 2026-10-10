using System;

namespace System.Runtime.Serialization
{
	/// <summary>Задает типы, которые должны распознаваться <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> при сериализации или десериализации указанного типа.</summary>
	// Token: 0x020000EC RID: 236
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = true, AllowMultiple = true)]
	public sealed class KnownTypeAttribute : Attribute
	{
		// Token: 0x06000D7A RID: 3450 RVA: 0x000254FF File Offset: 0x000236FF
		private KnownTypeAttribute()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.KnownTypeAttribute" /> с указанным типом.</summary>
		/// <param name="type">Тип <see cref="T:System.Type" />, включаемый как известный тип при сериализации или десериализации данных.</param>
		// Token: 0x06000D7B RID: 3451 RVA: 0x00035C5F File Offset: 0x00033E5F
		public KnownTypeAttribute(Type type)
		{
			this.type = type;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.KnownTypeAttribute" /> с именем метода, возвращающего интерфейс известных типов <see cref="T:System.Collections.IEnumerable" />.</summary>
		/// <param name="methodName">Имя метода, возвращающего интерфейс типов <see cref="T:System.Collections.IEnumerable" />, используемых при сериализации или десериализации данных.</param>
		// Token: 0x06000D7C RID: 3452 RVA: 0x00035C6E File Offset: 0x00033E6E
		public KnownTypeAttribute(string methodName)
		{
			this.methodName = methodName;
		}

		/// <summary>Возвращает имя метода, который возвратит список типов, которые должны распознаваться при сериализации или десериализации.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий имя метода типа, определяемого классом <see cref="T:System.Runtime.Serialization.KnownTypeAttribute" />.</returns>
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00035C7D File Offset: 0x00033E7D
		public string MethodName
		{
			get
			{
				return this.methodName;
			}
		}

		/// <summary>Возвращает тип, который должен распознаваться при сериализации или десериализации <see cref="T:System.Runtime.Serialization.DataContractSerializer" />.</summary>
		/// <returns>Тип <see cref="T:System.Type" />, используемый при сериализации или десериализации.</returns>
		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00035C85 File Offset: 0x00033E85
		public Type Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x04000642 RID: 1602
		private string methodName;

		// Token: 0x04000643 RID: 1603
		private Type type;
	}
}
