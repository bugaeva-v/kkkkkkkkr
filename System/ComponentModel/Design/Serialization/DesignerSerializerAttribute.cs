using System;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Обозначает сериализатор, использующийся диспетчером сериализации при сериализации значений типа, к которому применяется данный атрибут. Этот класс не наследуется.</summary>
	// Token: 0x02000484 RID: 1156
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	public sealed class DesignerSerializerAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.Serialization.DesignerSerializerAttribute" />.</summary>
		/// <param name="serializerType">Тип данных сериализатора.</param>
		/// <param name="baseSerializerType">Базовый тип данных сериализатора. Поскольку сериализаторы имеют различные базовые типы, классу может быть предоставлено несколько сериализаторов.</param>
		// Token: 0x0600250F RID: 9487 RVA: 0x00082BD2 File Offset: 0x00080DD2
		public DesignerSerializerAttribute(Type serializerType, Type baseSerializerType)
		{
			this.SerializerTypeName = serializerType.AssemblyQualifiedName;
			this.SerializerBaseTypeName = baseSerializerType.AssemblyQualifiedName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.Serialization.DesignerSerializerAttribute" />.</summary>
		/// <param name="serializerTypeName">Полное имя типа данных сериализатора.</param>
		/// <param name="baseSerializerType">Базовый тип данных сериализатора. Поскольку сериализаторы имеют различные базовые типы, классу может быть предоставлено несколько сериализаторов.</param>
		// Token: 0x06002510 RID: 9488 RVA: 0x00082BF2 File Offset: 0x00080DF2
		public DesignerSerializerAttribute(string serializerTypeName, Type baseSerializerType)
		{
			this.SerializerTypeName = serializerTypeName;
			this.SerializerBaseTypeName = baseSerializerType.AssemblyQualifiedName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.Serialization.DesignerSerializerAttribute" />.</summary>
		/// <param name="serializerTypeName">Полное имя типа данных сериализатора.</param>
		/// <param name="baseSerializerTypeName">Полное имя базового типа данных сериализатора. Поскольку сериализаторы имеют различные базовые типы, классу может быть предоставлено несколько сериализаторов.</param>
		// Token: 0x06002511 RID: 9489 RVA: 0x00082C0D File Offset: 0x00080E0D
		public DesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName)
		{
			this.SerializerTypeName = serializerTypeName;
			this.SerializerBaseTypeName = baseSerializerTypeName;
		}

		/// <summary>Получает полное имя типа сериализатора.</summary>
		/// <returns>Полное имя типа сериализатора.</returns>
		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x00082C23 File Offset: 0x00080E23
		public string SerializerTypeName { get; }

		/// <summary>Получает полное имя базового типа сериализатора.</summary>
		/// <returns>Полное имя базового типа сериализатора.</returns>
		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x00082C2B File Offset: 0x00080E2B
		public string SerializerBaseTypeName { get; }

		/// <summary>Указывает уникальный идентификатор для атрибута данного типа.</summary>
		/// <returns>Уникальный идентификатор для атрибута данного типа.</returns>
		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x00082C34 File Offset: 0x00080E34
		public override object TypeId
		{
			get
			{
				if (this._typeId == null)
				{
					string text = this.SerializerBaseTypeName;
					int num = text.IndexOf(',');
					if (num != -1)
					{
						text = text.Substring(0, num);
					}
					this._typeId = base.GetType().FullName + text;
				}
				return this._typeId;
			}
		}

		// Token: 0x04001494 RID: 5268
		private string _typeId;
	}
}
