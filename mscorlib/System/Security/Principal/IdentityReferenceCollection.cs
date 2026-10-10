using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Security.Principal
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.Security.Principal.IdentityReference" /> и обеспечивает средства преобразования наборов объектов, производных от <see cref="T:System.Security.Principal.IdentityReference" />, в типы, производные от <see cref="T:System.Security.Principal.IdentityReference" />.</summary>
	// Token: 0x020004E5 RID: 1253
	[ComVisible(false)]
	public class IdentityReferenceCollection : IEnumerable, ICollection<IdentityReference>, IEnumerable<IdentityReference>
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> нулевыми элементами в коллекции.</summary>
		// Token: 0x060031FB RID: 12795 RVA: 0x000B7BF0 File Offset: 0x000B5DF0
		public IdentityReferenceCollection()
		{
			this._list = new ArrayList();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.IdentityReferenceCollection" />, используя заданный исходный размер.</summary>
		/// <param name="capacity">Исходное число элементов в коллекции. Значение параметра <paramref name="capacity" /> служит только в качестве подсказки; необязательно создается максимальное число элементов.</param>
		// Token: 0x060031FC RID: 12796 RVA: 0x000B7C03 File Offset: 0x000B5E03
		public IdentityReferenceCollection(int capacity)
		{
			this._list = new ArrayList(capacity);
		}

		/// <summary>Возвращает число элементов в коллекции <see cref="T:System.Security.Principal.IdentityReferenceCollection" />.</summary>
		/// <returns>Число объектов <see cref="T:System.Security.Principal.IdentityReference" /> в коллекции <see cref="T:System.Security.Principal.IdentityReferenceCollection" />.</returns>
		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060031FD RID: 12797 RVA: 0x000B7C17 File Offset: 0x000B5E17
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		/// <summary>Возвращает значение, указывающее на то, доступна ли коллекция <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> только для чтения.</summary>
		/// <returns>Всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060031FE RID: 12798 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Устанавливает или возвращает узел по заданному индексу коллекции <see cref="T:System.Security.Principal.IdentityReferenceCollection" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс в коллекции <see cref="T:System.Security.Principal.IdentityReferenceCollection" />.</param>
		/// <returns>Объект <see cref="T:System.Security.Principal.IdentityReference" />, содержащийся в коллекции по указанному индексу. Если значение параметра <paramref name="index" /> больше или равно числу узлов в коллекции, возвращается значение <see langword="null" />.</returns>
		// Token: 0x170006A9 RID: 1705
		public IdentityReference this[int index]
		{
			get
			{
				if (index >= this._list.Count)
				{
					return null;
				}
				return (IdentityReference)this._list[index];
			}
			set
			{
				this._list[index] = value;
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.Security.Principal.IdentityReference" /> в коллекцию <see cref="T:System.Security.Principal.IdentityReferenceCollection" />.</summary>
		/// <param name="identity">Объект <see cref="T:System.Security.Principal.IdentityReference" /> для добавления в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identity" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003201 RID: 12801 RVA: 0x000B7C56 File Offset: 0x000B5E56
		public void Add(IdentityReference identity)
		{
			this._list.Add(identity);
		}

		/// <summary>Удаляет все объекты <see cref="T:System.Security.Principal.IdentityReference" /> из коллекции <see cref="T:System.Security.Principal.IdentityReferenceCollection" />.</summary>
		// Token: 0x06003202 RID: 12802 RVA: 0x000B7C65 File Offset: 0x000B5E65
		public void Clear()
		{
			this._list.Clear();
		}

		/// <summary>Указывает, содержит ли коллекция <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> заданный объект <see cref="T:System.Security.Principal.IdentityReference" />.</summary>
		/// <param name="identity">Объект <see cref="T:System.Security.Principal.IdentityReference" /> для проверки.</param>
		/// <returns>
		///   <see langword="true" />, если коллекция содержит заданный объект.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identity" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003203 RID: 12803 RVA: 0x000B7C74 File Offset: 0x000B5E74
		public bool Contains(IdentityReference identity)
		{
			using (IEnumerator enumerator = this._list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((IdentityReference)enumerator.Current).Equals(identity))
					{
						return true;
					}
				}
			}
			return false;
		}

		/// <summary>Копирует коллекцию <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> в массив <see cref="T:System.Security.Principal.IdentityReferenceCollection" />, начиная с указанного индекса.</summary>
		/// <param name="array">Объект массива <see cref="T:System.Security.Principal.IdentityReferenceCollection" />, в который должна быть скопирована коллекция <see cref="T:System.Security.Principal.IdentityReferenceCollection" />.</param>
		/// <param name="offset">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, который обозначает позицию для копирования коллекции <see cref="T:System.Security.Principal.IdentityReferenceCollection" />.</param>
		// Token: 0x06003204 RID: 12804 RVA: 0x000479F8 File Offset: 0x00045BF8
		public void CopyTo(IdentityReference[] array, int offset)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает перечислитель, который может использоваться для выполнения итерации по коллекции <see cref="T:System.Security.Principal.IdentityReferenceCollection" />.</summary>
		/// <returns>Перечислитель для коллекции <see cref="T:System.Security.Principal.IdentityReferenceCollection" />.</returns>
		// Token: 0x06003205 RID: 12805 RVA: 0x000479F8 File Offset: 0x00045BF8
		public IEnumerator<IdentityReference> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает перечислитель, который может использоваться для выполнения итерации по коллекции <see cref="T:System.Security.Principal.IdentityReferenceCollection" />.</summary>
		/// <returns>Перечислитель для коллекции <see cref="T:System.Security.Principal.IdentityReferenceCollection" />.</returns>
		// Token: 0x06003206 RID: 12806 RVA: 0x000479F8 File Offset: 0x00045BF8
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.Security.Principal.IdentityReference" /> из коллекции.</summary>
		/// <param name="identity">Удаляемый объект <see cref="T:System.Security.Principal.IdentityReference" />.</param>
		/// <returns>
		///   <see langword="true" />, если заданный объект был удален из коллекции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identity" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003207 RID: 12807 RVA: 0x000B7CD4 File Offset: 0x000B5ED4
		public bool Remove(IdentityReference identity)
		{
			foreach (object obj in this._list)
			{
				IdentityReference identityReference = (IdentityReference)obj;
				if (identityReference.Equals(identity))
				{
					this._list.Remove(identityReference);
					return true;
				}
			}
			return false;
		}

		/// <summary>Преобразует объекты коллекции в указанный тип. Этот метод вызывается так же, как метод <see cref="M:System.Security.Principal.IdentityReferenceCollection.Translate(System.Type,System.Boolean)" /> со значением <see langword="false" /> второго параметра. Это означает, что для элементов, преобразование которых завершается неудачно, исключения выдаваться не будут.</summary>
		/// <param name="targetType">Тип, в который преобразуются элементы коллекции.</param>
		/// <returns>Коллекция <see cref="T:System.Security.Principal.IdentityReferenceCollection" />, представляющая преобразованное содержимое исходной коллекции.</returns>
		// Token: 0x06003208 RID: 12808 RVA: 0x000479F8 File Offset: 0x00045BF8
		public IdentityReferenceCollection Translate(Type targetType)
		{
			throw new NotImplementedException();
		}

		/// <summary>Преобразует объекты коллекции в указанный тип и использует заданную отказоустойчивость для обработки или игнорирования ошибок, связанных с типом, не имеющим сопоставление преобразования.</summary>
		/// <param name="targetType">Тип, в который преобразуются элементы коллекции.</param>
		/// <param name="forceSuccess">Логическое значение, определяющее способ обработки ошибок преобразования.  
		/// Если параметр <paramref name="forceSuccess" /> имеет значение <see langword="true" />, ошибки преобразования из-за необнаружения сопоставления во время преобразования приводят к сбою преобразования и вызову исключений.  
		/// Если параметр <paramref name="forceSuccess" /> имеет значение <see langword="false" />, типы, которые не удалось преобразовать из-за необнаружения сопоставления во время преобразования, копируются в возвращаемую коллекцию без преобразования.</param>
		/// <returns>Коллекция <see cref="T:System.Security.Principal.IdentityReferenceCollection" />, представляющая преобразованное содержимое исходной коллекции.</returns>
		// Token: 0x06003209 RID: 12809 RVA: 0x000479F8 File Offset: 0x00045BF8
		public IdentityReferenceCollection Translate(Type targetType, bool forceSuccess)
		{
			throw new NotImplementedException();
		}

		// Token: 0x040022C0 RID: 8896
		private ArrayList _list;
	}
}
