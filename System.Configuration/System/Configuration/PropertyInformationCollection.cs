using System;
using System.Collections;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Configuration
{
	/// <summary>Содержит коллекцию объектов <see cref="T:System.Configuration.PropertyInformation" />. Этот класс не наследуется.</summary>
	// Token: 0x02000059 RID: 89
	[Serializable]
	public sealed class PropertyInformationCollection : NameObjectCollectionBase
	{
		// Token: 0x060002FE RID: 766 RVA: 0x00008A12 File Offset: 0x00006C12
		internal PropertyInformationCollection() : base(StringComparer.Ordinal)
		{
		}

		/// <summary>Копирует всю коллекцию <see cref="T:System.Configuration.PropertyInformationCollection" /> в совместимый одномерный массив <see cref="T:System.Array" />, начиная с указанного индекса конечного массива.</summary>
		/// <param name="array">Одномерный массив класса <see cref="T:System.Array" />, который является целевым массивом для элементов, копируемых из коллекции <see cref="T:System.Configuration.PropertyInformationCollection" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение свойства <see cref="P:System.Array.Length" /> для <paramref name="array" /> меньше <see cref="P:System.Collections.Specialized.NameObjectCollectionBase.Count" /> + <paramref name="index" />.</exception>
		// Token: 0x060002FF RID: 767 RVA: 0x00008A1F File Offset: 0x00006C1F
		public void CopyTo(PropertyInformation[] array, int index)
		{
			((ICollection)this).CopyTo(array, index);
		}

		/// <summary>Возвращает объект <see cref="T:System.Configuration.PropertyInformation" /> в коллекции на основе указанного имени параметра.</summary>
		/// <param name="propertyName">Имя атрибута конфигурации, находящегося в объекте <see cref="T:System.Configuration.PropertyInformationCollection" />.</param>
		/// <returns>Объект <see cref="T:System.Configuration.PropertyInformation" />.</returns>
		// Token: 0x170000E0 RID: 224
		public PropertyInformation this[string propertyName]
		{
			get
			{
				return (PropertyInformation)base.BaseGet(propertyName);
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IEnumerator" />, используемый для итерации данной коллекции <see cref="T:System.Configuration.PropertyInformationCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, используемый для итерации данной коллекции <see cref="T:System.Configuration.PropertyInformationCollection" />.</returns>
		// Token: 0x06000301 RID: 769 RVA: 0x00008A37 File Offset: 0x00006C37
		public override IEnumerator GetEnumerator()
		{
			return new PropertyInformationCollection.PropertyInformationEnumerator(this);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00008A3F File Offset: 0x00006C3F
		internal void Add(PropertyInformation pi)
		{
			base.BaseAdd(pi.Name, pi);
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации экземпляра <see cref="T:System.Configuration.PropertyInformationCollection" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, требуемые для сериализации экземпляра <see cref="T:System.Configuration.PropertyInformationCollection" />.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий исходный объект и объект назначения для сериализации потока, связанного с экземпляром класса <see cref="T:System.Configuration.PropertyInformationCollection" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> — <see langword="null" />.</exception>
		// Token: 0x06000303 RID: 771 RVA: 0x0000371B File Offset: 0x0000191B
		[MonoTODO]
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0200005A RID: 90
		private class PropertyInformationEnumerator : IEnumerator
		{
			// Token: 0x06000304 RID: 772 RVA: 0x00008A4E File Offset: 0x00006C4E
			public PropertyInformationEnumerator(PropertyInformationCollection collection)
			{
				this.collection = collection;
				this.position = -1;
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x06000305 RID: 773 RVA: 0x00008A64 File Offset: 0x00006C64
			public object Current
			{
				get
				{
					if (this.position < this.collection.Count && this.position >= 0)
					{
						return this.collection.BaseGet(this.position);
					}
					throw new InvalidOperationException();
				}
			}

			// Token: 0x06000306 RID: 774 RVA: 0x00008A9C File Offset: 0x00006C9C
			public bool MoveNext()
			{
				int num = this.position + 1;
				this.position = num;
				return num < this.collection.Count;
			}

			// Token: 0x06000307 RID: 775 RVA: 0x00008ACA File Offset: 0x00006CCA
			public void Reset()
			{
				this.position = -1;
			}

			// Token: 0x04000118 RID: 280
			private PropertyInformationCollection collection;

			// Token: 0x04000119 RID: 281
			private int position;
		}
	}
}
