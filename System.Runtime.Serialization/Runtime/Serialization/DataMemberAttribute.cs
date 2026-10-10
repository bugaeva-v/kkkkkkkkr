using System;

namespace System.Runtime.Serialization
{
	/// <summary>При применении к элементу типа указывает, что этот элемент является частью контракта данных и сериализуется <see cref="T:System.Runtime.Serialization.DataContractSerializer" />.</summary>
	// Token: 0x020000CB RID: 203
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class DataMemberAttribute : Attribute
	{
		/// <summary>Возвращает или задает имя элемента данных.</summary>
		/// <returns>Имя элемента данных. Значение по умолчанию — это имя целевого объекта, к которому применяется атрибут.</returns>
		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x00031ADA File Offset: 0x0002FCDA
		// (set) Token: 0x06000BEC RID: 3052 RVA: 0x00031AE2 File Offset: 0x0002FCE2
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
				this.isNameSetExplicitly = true;
			}
		}

		/// <summary>Получает значение, указывающее, был ли объект <see cref="P:System.Runtime.Serialization.DataMemberAttribute.Name" /> задан явно.</summary>
		/// <returns>
		///   <see langword="true" /> Если имя было задано явно; в противном случае <see langword="false" />.</returns>
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x00031AF2 File Offset: 0x0002FCF2
		public bool IsNameSetExplicitly
		{
			get
			{
				return this.isNameSetExplicitly;
			}
		}

		/// <summary>Возвращает или задает порядок сериализации и десериализации элемента.</summary>
		/// <returns>Числовой порядок сериализации или десериализации.</returns>
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00031AFA File Offset: 0x0002FCFA
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x00031B02 File Offset: 0x0002FD02
		public int Order
		{
			get
			{
				return this.order;
			}
			set
			{
				if (value < 0)
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidDataContractException(SR.GetString("Property 'Order' in DataMemberAttribute attribute cannot be a negative number.")));
				}
				this.order = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее модулю сериализации, что чтение и десериализация производятся при наличии элемента.</summary>
		/// <returns>Значение <see langword="true" />, если требуется наличие элемента; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент отсутствует.</exception>
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00031B24 File Offset: 0x0002FD24
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00031B2C File Offset: 0x0002FD2C
		public bool IsRequired
		{
			get
			{
				return this.isRequired;
			}
			set
			{
				this.isRequired = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, следует ли сериализовать значение по умолчанию сериализуемого поля или свойства.</summary>
		/// <returns>Значение <see langword="true" />, если значение по умолчанию для элемента должно быть создано в потоке сериализации; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00031B35 File Offset: 0x0002FD35
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x00031B3D File Offset: 0x0002FD3D
		public bool EmitDefaultValue
		{
			get
			{
				return this.emitDefaultValue;
			}
			set
			{
				this.emitDefaultValue = value;
			}
		}

		// Token: 0x040004C0 RID: 1216
		private string name;

		// Token: 0x040004C1 RID: 1217
		private bool isNameSetExplicitly;

		// Token: 0x040004C2 RID: 1218
		private int order = -1;

		// Token: 0x040004C3 RID: 1219
		private bool isRequired;

		// Token: 0x040004C4 RID: 1220
		private bool emitDefaultValue = true;
	}
}
