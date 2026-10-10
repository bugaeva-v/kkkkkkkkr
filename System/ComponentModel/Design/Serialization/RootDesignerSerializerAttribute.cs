using System;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Определяет базовый сериализатор для объекта корневого конструктора. Этот класс не наследуется.</summary>
	// Token: 0x02000492 RID: 1170
	[Obsolete("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  https://go.microsoft.com/fwlink/?linkid=14202")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	public sealed class RootDesignerSerializerAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.Serialization.RootDesignerSerializerAttribute" /> с помощью указанных атрибутов.</summary>
		/// <param name="serializerType">Тип данных сериализатора.</param>
		/// <param name="baseSerializerType">Базовый тип сериализатора. Класс может содержать несколько сериализаторов, если их базовые типы отличаются друг от друга.</param>
		/// <param name="reloadable">Значение <see langword="true" />, если сериализатор поддерживает динамическую перезагрузку документа; в противном случае — <see langword="false" />.</param>
		// Token: 0x06002557 RID: 9559 RVA: 0x000832A7 File Offset: 0x000814A7
		public RootDesignerSerializerAttribute(Type serializerType, Type baseSerializerType, bool reloadable)
		{
			this.SerializerTypeName = serializerType.AssemblyQualifiedName;
			this.SerializerBaseTypeName = baseSerializerType.AssemblyQualifiedName;
			this.Reloadable = reloadable;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.Serialization.RootDesignerSerializerAttribute" /> с помощью указанных атрибутов.</summary>
		/// <param name="serializerTypeName">Полное имя типа данных сериализатора.</param>
		/// <param name="baseSerializerType">Имя базового типа сериализатора. Класс может содержать несколько сериализаторов, если их базовые типы отличаются друг от друга.</param>
		/// <param name="reloadable">Значение <see langword="true" />, если сериализатор поддерживает динамическую перезагрузку документа; в противном случае — <see langword="false" />.</param>
		// Token: 0x06002558 RID: 9560 RVA: 0x000832CE File Offset: 0x000814CE
		public RootDesignerSerializerAttribute(string serializerTypeName, Type baseSerializerType, bool reloadable)
		{
			this.SerializerTypeName = serializerTypeName;
			this.SerializerBaseTypeName = baseSerializerType.AssemblyQualifiedName;
			this.Reloadable = reloadable;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.Serialization.RootDesignerSerializerAttribute" /> с помощью указанных атрибутов.</summary>
		/// <param name="serializerTypeName">Полное имя типа данных сериализатора.</param>
		/// <param name="baseSerializerTypeName">Имя базового типа сериализатора. Класс может содержать несколько сериализаторов, если их базовые типы отличаются друг от друга.</param>
		/// <param name="reloadable">Значение <see langword="true" />, если сериализатор поддерживает динамическую перезагрузку документа; в противном случае — <see langword="false" />.</param>
		// Token: 0x06002559 RID: 9561 RVA: 0x000832F0 File Offset: 0x000814F0
		public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable)
		{
			this.SerializerTypeName = serializerTypeName;
			this.SerializerBaseTypeName = baseSerializerTypeName;
			this.Reloadable = reloadable;
		}

		/// <summary>Возвращает значение, обозначающее возможность поддержки корневым сериализатором перезагрузки документа проекта без предварительного удаления узла конструктора.</summary>
		/// <returns>Значение <see langword="true" />, если корневой сериализатор поддерживает перезагрузку; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x0600255A RID: 9562 RVA: 0x0008330D File Offset: 0x0008150D
		public bool Reloadable { get; }

		/// <summary>Получает полное имя типа сериализатора.</summary>
		/// <returns>Имя типа сериализатора.</returns>
		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x0600255B RID: 9563 RVA: 0x00083315 File Offset: 0x00081515
		public string SerializerTypeName { get; }

		/// <summary>Получает полное имя типа базового типа сериализатора.</summary>
		/// <returns>Имя базового типа сериализатора.</returns>
		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x0600255C RID: 9564 RVA: 0x0008331D File Offset: 0x0008151D
		public string SerializerBaseTypeName { get; }

		/// <summary>Получает уникальный идентификатор для атрибута данного типа.</summary>
		/// <returns>Объект с уникальным идентификатором для атрибута данного типа.</returns>
		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x0600255D RID: 9565 RVA: 0x00083328 File Offset: 0x00081528
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

		// Token: 0x040014A3 RID: 5283
		private string _typeId;
	}
}
