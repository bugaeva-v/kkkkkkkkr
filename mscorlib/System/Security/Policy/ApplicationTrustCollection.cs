using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Security.Policy
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.Security.Policy.ApplicationTrust" />. Этот класс не наследуется.</summary>
	// Token: 0x02000404 RID: 1028
	[ComVisible(true)]
	public sealed class ApplicationTrustCollection : ICollection, IEnumerable
	{
		// Token: 0x06002A01 RID: 10753 RVA: 0x000985C5 File Offset: 0x000967C5
		internal ApplicationTrustCollection()
		{
			this._list = new ArrayList();
		}

		/// <summary>Получает количество элементов, содержащихся в коллекции.</summary>
		/// <returns>Количество элементов в коллекции.</returns>
		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06002A02 RID: 10754 RVA: 0x000985D8 File Offset: 0x000967D8
		public int Count
		{
			[SecuritySafeCritical]
			get
			{
				return this._list.Count;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли доступ к коллекции синхронизированным (потокобезопасным).</summary>
		/// <returns>Значение <see langword="false" /> во всех случаях.</returns>
		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool IsSynchronized
		{
			[SecuritySafeCritical]
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает объект, который можно использовать для синхронизации доступа к коллекции.</summary>
		/// <returns>Объект, используемый для синхронизации доступа к коллекции.</returns>
		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06002A04 RID: 10756 RVA: 0x0000270D File Offset: 0x0000090D
		public object SyncRoot
		{
			[SecuritySafeCritical]
			get
			{
				return this;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Policy.ApplicationTrust" />, размещенный по указанному индексу в коллекции.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс объекта в коллекции.</param>
		/// <returns>Объект <see cref="T:System.Security.Policy.ApplicationTrust" /> по указанному индексу в коллекции.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> больше или равно количеству объектов в коллекции.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="index" /> является отрицательным значением.</exception>
		// Token: 0x1700052F RID: 1327
		public ApplicationTrust this[int index]
		{
			get
			{
				return (ApplicationTrust)this._list[index];
			}
		}

		/// <summary>Получает объект <see cref="T:System.Security.Policy.ApplicationTrust" /> из указанного приложения.</summary>
		/// <param name="appFullName">Полное имя приложения.</param>
		/// <returns>Объект <see cref="T:System.Security.Policy.ApplicationTrust" /> для заданного приложения или значение <see langword="null" />, если объект не найден.</returns>
		// Token: 0x17000530 RID: 1328
		public ApplicationTrust this[string appFullName]
		{
			get
			{
				for (int i = 0; i < this._list.Count; i++)
				{
					ApplicationTrust applicationTrust = this._list[i] as ApplicationTrust;
					if (applicationTrust.ApplicationIdentity.FullName == appFullName)
					{
						return applicationTrust;
					}
				}
				return null;
			}
		}

		/// <summary>Добавляет элемент в коллекцию.</summary>
		/// <param name="trust">Добавляемый объект <see cref="T:System.Security.Policy.ApplicationTrust" />.</param>
		/// <returns>Индекс, указывающий, куда был вставлен новый элемент.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="trust" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Policy.ApplicationTrust.ApplicationIdentity" /> объекта <see cref="T:System.Security.Policy.ApplicationTrust" />, указанного в <paramref name="trust" />, равно <see langword="null" />.</exception>
		// Token: 0x06002A07 RID: 10759 RVA: 0x00098643 File Offset: 0x00096843
		public int Add(ApplicationTrust trust)
		{
			if (trust == null)
			{
				throw new ArgumentNullException("trust");
			}
			if (trust.ApplicationIdentity == null)
			{
				throw new ArgumentException(Locale.GetText("ApplicationTrust.ApplicationIdentity can't be null."), "trust");
			}
			return this._list.Add(trust);
		}

		/// <summary>Копирует элементы указанного массива <see cref="T:System.Security.Policy.ApplicationTrust" /> в конец коллекции.</summary>
		/// <param name="trusts">Массив типа <see cref="T:System.Security.Policy.ApplicationTrust" />, содержащий объекты для добавления к коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="trusts" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Policy.ApplicationTrust.ApplicationIdentity" /> объекта <see cref="T:System.Security.Policy.ApplicationTrust" />, указанного в <paramref name="trust" />, равно <see langword="null" />.</exception>
		// Token: 0x06002A08 RID: 10760 RVA: 0x0009867C File Offset: 0x0009687C
		public void AddRange(ApplicationTrust[] trusts)
		{
			if (trusts == null)
			{
				throw new ArgumentNullException("trusts");
			}
			foreach (ApplicationTrust applicationTrust in trusts)
			{
				if (applicationTrust.ApplicationIdentity == null)
				{
					throw new ArgumentException(Locale.GetText("ApplicationTrust.ApplicationIdentity can't be null."), "trust");
				}
				this._list.Add(applicationTrust);
			}
		}

		/// <summary>Копирует элементы указанного объекта <see cref="T:System.Security.Policy.ApplicationTrustCollection" /> в конец коллекции.</summary>
		/// <param name="trusts">Объект <see cref="T:System.Security.Policy.ApplicationTrustCollection" />, содержащий объекты для добавления в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="trusts" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Policy.ApplicationTrust.ApplicationIdentity" /> объекта <see cref="T:System.Security.Policy.ApplicationTrust" />, указанного в <paramref name="trust" />, равно <see langword="null" />.</exception>
		// Token: 0x06002A09 RID: 10761 RVA: 0x000986D8 File Offset: 0x000968D8
		public void AddRange(ApplicationTrustCollection trusts)
		{
			if (trusts == null)
			{
				throw new ArgumentNullException("trusts");
			}
			foreach (ApplicationTrust applicationTrust in trusts)
			{
				if (applicationTrust.ApplicationIdentity == null)
				{
					throw new ArgumentException(Locale.GetText("ApplicationTrust.ApplicationIdentity can't be null."), "trust");
				}
				this._list.Add(applicationTrust);
			}
		}

		/// <summary>Удаляет все доверия приложения из коллекции.</summary>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Policy.ApplicationTrust.ApplicationIdentity" /> элемента в коллекции имеет значение <see langword="null" />.</exception>
		// Token: 0x06002A0A RID: 10762 RVA: 0x00098735 File Offset: 0x00096935
		public void Clear()
		{
			this._list.Clear();
		}

		/// <summary>Копирует коллекцию в совместимый одномерный массив, начиная с указанного индекса массива назначения.</summary>
		/// <param name="array">Одномерный массив типа <see cref="T:System.Security.Policy.ApplicationTrust" />, который является объектом назначения для элементов, копируемых из текущей коллекции.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="array" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Количество элементов в коллекции <see cref="T:System.Security.Policy.ApplicationTrustCollection" /> превышает размер доступного места, начиная с индекса <paramref name="index" /> и до конца массива назначения <paramref name="array" />.</exception>
		// Token: 0x06002A0B RID: 10763 RVA: 0x00098742 File Offset: 0x00096942
		public void CopyTo(ApplicationTrust[] array, int index)
		{
			this._list.CopyTo(array, index);
		}

		/// <summary>Копирует элементы объекта <see cref="T:System.Collections.ICollection" /> в указанный массив <see cref="T:System.Array" />, начиная с заданного индекса <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы коллекции <see cref="T:System.Collections.ICollection" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Число элементов в исходной коллекции <see cref="T:System.Collections.ICollection" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
		// Token: 0x06002A0C RID: 10764 RVA: 0x00098742 File Offset: 0x00096942
		void ICollection.CopyTo(Array array, int index)
		{
			this._list.CopyTo(array, index);
		}

		/// <summary>Получает доверия приложения в коллекции, соответствующей заданной идентификации приложения.</summary>
		/// <param name="applicationIdentity">Объект <see cref="T:System.ApplicationIdentity" />, описывающий искомое приложение.</param>
		/// <param name="versionMatch">Одно из значений перечисления <see cref="T:System.Security.Policy.ApplicationVersionMatch" />.</param>
		/// <returns>Объект <see cref="T:System.Security.Policy.ApplicationTrustCollection" />, содержащий все соответствующие объекты <see cref="T:System.Security.Policy.ApplicationTrust" />.</returns>
		// Token: 0x06002A0D RID: 10765 RVA: 0x00098754 File Offset: 0x00096954
		public ApplicationTrustCollection Find(ApplicationIdentity applicationIdentity, ApplicationVersionMatch versionMatch)
		{
			if (applicationIdentity == null)
			{
				throw new ArgumentNullException("applicationIdentity");
			}
			string text = applicationIdentity.FullName;
			if (versionMatch != ApplicationVersionMatch.MatchExactVersion)
			{
				if (versionMatch != ApplicationVersionMatch.MatchAllVersions)
				{
					throw new ArgumentException("versionMatch");
				}
				int num = text.IndexOf(", Version=");
				if (num >= 0)
				{
					text = text.Substring(0, num);
				}
			}
			ApplicationTrustCollection applicationTrustCollection = new ApplicationTrustCollection();
			foreach (object obj in this._list)
			{
				ApplicationTrust applicationTrust = (ApplicationTrust)obj;
				if (applicationTrust.ApplicationIdentity.FullName.StartsWith(text))
				{
					applicationTrustCollection.Add(applicationTrust);
				}
			}
			return applicationTrustCollection;
		}

		/// <summary>Возвращает объект, который может использоваться для перебора элементов коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Security.Policy.ApplicationTrustEnumerator" />, который может использоваться для перебора коллекции.</returns>
		// Token: 0x06002A0E RID: 10766 RVA: 0x00098810 File Offset: 0x00096A10
		public ApplicationTrustEnumerator GetEnumerator()
		{
			return new ApplicationTrustEnumerator(this);
		}

		/// <summary>Возвращает перечислитель, выполняющий перебор элементов в коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x06002A0F RID: 10767 RVA: 0x00098810 File Offset: 0x00096A10
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new ApplicationTrustEnumerator(this);
		}

		/// <summary>Удаляет из коллекции указанное доверие приложения.</summary>
		/// <param name="trust">Удаляемый объект <see cref="T:System.Security.Policy.ApplicationTrust" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="trust" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Policy.ApplicationTrust.ApplicationIdentity" /> объекта <see cref="T:System.Security.Policy.ApplicationTrust" />, указанного параметром <paramref name="trust" />, равно <see langword="null" />.</exception>
		// Token: 0x06002A10 RID: 10768 RVA: 0x00098818 File Offset: 0x00096A18
		public void Remove(ApplicationTrust trust)
		{
			if (trust == null)
			{
				throw new ArgumentNullException("trust");
			}
			if (trust.ApplicationIdentity == null)
			{
				throw new ArgumentException(Locale.GetText("ApplicationTrust.ApplicationIdentity can't be null."), "trust");
			}
			this.RemoveAllInstances(trust);
		}

		/// <summary>Удаляет из коллекции все доверия приложения, которые соответствуют заданному критерию.</summary>
		/// <param name="applicationIdentity">Объект <see cref="T:System.ApplicationIdentity" /> удаляемого объекта <see cref="T:System.Security.Policy.ApplicationTrust" />.</param>
		/// <param name="versionMatch">Одно из значений перечисления <see cref="T:System.Security.Policy.ApplicationVersionMatch" />.</param>
		// Token: 0x06002A11 RID: 10769 RVA: 0x0009884C File Offset: 0x00096A4C
		public void Remove(ApplicationIdentity applicationIdentity, ApplicationVersionMatch versionMatch)
		{
			foreach (ApplicationTrust trust in this.Find(applicationIdentity, versionMatch))
			{
				this.RemoveAllInstances(trust);
			}
		}

		/// <summary>Удаляет из коллекции объекты доверия приложения в указанном массиве.</summary>
		/// <param name="trusts">Одномерный массив типа <see cref="T:System.Security.Policy.ApplicationTrust" />, который содержит элементы, удаляемые из текущей коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="trusts" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002A12 RID: 10770 RVA: 0x00098880 File Offset: 0x00096A80
		public void RemoveRange(ApplicationTrust[] trusts)
		{
			if (trusts == null)
			{
				throw new ArgumentNullException("trusts");
			}
			foreach (ApplicationTrust trust in trusts)
			{
				this.RemoveAllInstances(trust);
			}
		}

		/// <summary>Удаляет из коллекции объекты доверия приложения в указанной коллекции.</summary>
		/// <param name="trusts">Объект <see cref="T:System.Security.Policy.ApplicationTrustCollection" />, который содержит элементы, удаляемые из текущей коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="trusts" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002A13 RID: 10771 RVA: 0x000988B8 File Offset: 0x00096AB8
		public void RemoveRange(ApplicationTrustCollection trusts)
		{
			if (trusts == null)
			{
				throw new ArgumentNullException("trusts");
			}
			foreach (ApplicationTrust trust in trusts)
			{
				this.RemoveAllInstances(trust);
			}
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x000988F4 File Offset: 0x00096AF4
		internal void RemoveAllInstances(ApplicationTrust trust)
		{
			for (int i = this._list.Count - 1; i >= 0; i--)
			{
				if (trust.Equals(this._list[i]))
				{
					this._list.RemoveAt(i);
				}
			}
		}

		// Token: 0x04001F61 RID: 8033
		private ArrayList _list;
	}
}
