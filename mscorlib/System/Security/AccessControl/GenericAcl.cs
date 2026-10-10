using System;
using System.Collections;

namespace System.Security.AccessControl
{
	/// <summary>Представляет список управления доступом и является базовым классом для классов <see cref="T:System.Security.AccessControl.CommonAcl" />, <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />, <see cref="T:System.Security.AccessControl.RawAcl" /> и <see cref="T:System.Security.AccessControl.SystemAcl" />.</summary>
	// Token: 0x0200052D RID: 1325
	public abstract class GenericAcl : ICollection, IEnumerable
	{
		/// <summary>Возвращает длину в байтах двоичного представления текущего объекта <see cref="T:System.Security.AccessControl.GenericAcl" />. Эту длину необходимо использовать перед маршалингом списка управления доступом в двоичный массив с помощью метода <see cref="M:System.Security.AccessControl.GenericAcl.GetBinaryForm(System.Byte[],System.Int32)" />.</summary>
		/// <returns>Длина в байтах двоичного представления текущего объекта <see cref="T:System.Security.AccessControl.GenericAcl" />.</returns>
		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x0600347A RID: 13434
		public abstract int BinaryLength { get; }

		/// <summary>Возвращает количество элементов управления доступом в текущем объекте <see cref="T:System.Security.AccessControl.GenericAcl" />.</summary>
		/// <returns>Количество элементов управления доступом в текущем объекте <see cref="T:System.Security.AccessControl.GenericAcl" />.</returns>
		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600347B RID: 13435
		public abstract int Count { get; }

		/// <summary>Данное свойство всегда имеет значение <see langword="false" />. Оно реализовано только потому, что необходимо для реализации интерфейса <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>Всегда <see langword="false" />.</returns>
		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600347C RID: 13436 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Security.AccessControl.GenericAce" /> с заданным индексом.</summary>
		/// <param name="index">Индекс (с нуля) возвращаемого или задаваемого <see cref="T:System.Security.AccessControl.GenericAce" />.</param>
		/// <returns>Параметр <see cref="T:System.Security.AccessControl.GenericAce" /> по указанному индексу.</returns>
		// Token: 0x1700072B RID: 1835
		public abstract GenericAce this[int index]
		{
			get;
			set;
		}

		/// <summary>Возвращает уровень редакции объекта <see cref="T:System.Security.AccessControl.GenericAcl" />.</summary>
		/// <returns>Байтовое значение, определяющее уровень редакции объекта <see cref="T:System.Security.AccessControl.GenericAcl" />.</returns>
		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x0600347F RID: 13439
		public abstract byte Revision { get; }

		/// <summary>Данное свойство всегда возвращает значение <see langword="null" />. Оно реализовано только потому, что необходимо для реализации интерфейса <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>Всегда возвращает значение <see langword="null" />.</returns>
		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06003480 RID: 13440 RVA: 0x0000270D File Offset: 0x0000090D
		public virtual object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Копирует каждый <see cref="T:System.Security.AccessControl.GenericAce" /> текущего объекта <see cref="T:System.Security.AccessControl.GenericAcl" /> в указанный массив.</summary>
		/// <param name="array">Массив, в котором размещаются копии объектов <see cref="T:System.Security.AccessControl.GenericAce" />, содержащихся в текущем <see cref="T:System.Security.AccessControl.GenericAcl" />.</param>
		/// <param name="index">Отсчитываемый от нуля индекс <paramref name="array" />, указывающий начало копирования.</param>
		// Token: 0x06003481 RID: 13441 RVA: 0x000BF4D8 File Offset: 0x000BD6D8
		public void CopyTo(GenericAce[] array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0 || array.Length - index < this.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index must be non-negative integer and must not exceed array length - count");
			}
			for (int i = 0; i < this.Count; i++)
			{
				array[i + index] = this[i];
			}
		}

		/// <summary>Копирует каждый <see cref="T:System.Security.AccessControl.GenericAce" /> текущего объекта <see cref="T:System.Security.AccessControl.GenericAcl" /> в указанный массив.</summary>
		/// <param name="array">Массив, в котором размещаются копии объектов <see cref="T:System.Security.AccessControl.GenericAce" />, содержащихся в текущем <see cref="T:System.Security.AccessControl.GenericAcl" />.</param>
		/// <param name="index">Отсчитываемый от нуля индекс <paramref name="array" />, указывающий начало копирования.</param>
		// Token: 0x06003482 RID: 13442 RVA: 0x000BF531 File Offset: 0x000BD731
		void ICollection.CopyTo(Array array, int index)
		{
			this.CopyTo((GenericAce[])array, index);
		}

		/// <summary>Маршалирует содержимое объекта <see cref="T:System.Security.AccessControl.GenericAcl" /> в указанный массив байтов, начиная с указанной позиции.</summary>
		/// <param name="binaryForm">Массив байтов, в который маршалируется содержимое объекта <see cref="T:System.Security.AccessControl.GenericAcl" />.</param>
		/// <param name="offset">Позиция, с которой начинается маршалинг.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="offset" /> является отрицательным или слишком велико, чтобы разрешить копирование всего <see cref="T:System.Security.AccessControl.GenericAcl" /> в <paramref name="array" />.</exception>
		// Token: 0x06003483 RID: 13443
		public abstract void GetBinaryForm(byte[] binaryForm, int offset);

		/// <summary>Извлекает объект, который можно использовать для итерации по записям управления доступом (ACE) в списке управления доступом (ACL).</summary>
		/// <returns>Объект перечислителя.</returns>
		// Token: 0x06003484 RID: 13444 RVA: 0x000BF540 File Offset: 0x000BD740
		public AceEnumerator GetEnumerator()
		{
			return new AceEnumerator(this);
		}

		/// <summary>Возвращает новый экземпляр класса <see cref="T:System.Security.AccessControl.AceEnumerator" />, приведенный как экземпляр интерфейса <see cref="T:System.Collections.IEnumerator" />.</summary>
		/// <returns>Новый объект <see cref="T:System.Security.AccessControl.AceEnumerator" />, приведенный как экземпляр интерфейса <see cref="T:System.Collections.IEnumerator" />.</returns>
		// Token: 0x06003485 RID: 13445 RVA: 0x000BF548 File Offset: 0x000BD748
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06003486 RID: 13446
		internal abstract string GetSddlForm(ControlFlags sdFlags, bool isDacl);

		/// <summary>Уровень редакции текущего объекта <see cref="T:System.Security.AccessControl.GenericAcl" />. Это значение возвращается свойством <see cref="P:System.Security.AccessControl.GenericAcl.Revision" /> для списков управления доступом (ACL), которые связаны с объектами служб каталогов.</summary>
		// Token: 0x040024A7 RID: 9383
		public static readonly byte AclRevision = 2;

		/// <summary>Уровень редакции текущего объекта <see cref="T:System.Security.AccessControl.GenericAcl" />. Это значение возвращается свойством <see cref="P:System.Security.AccessControl.GenericAcl.Revision" /> для списков управления доступом (ACL), которые связаны с объектами служб каталогов.</summary>
		// Token: 0x040024A8 RID: 9384
		public static readonly byte AclRevisionDS = 4;

		/// <summary>Максимально допустимая двоичная длина объекта <see cref="T:System.Security.AccessControl.GenericAcl" />.</summary>
		// Token: 0x040024A9 RID: 9385
		public static readonly int MaxBinaryLength = 65536;
	}
}
