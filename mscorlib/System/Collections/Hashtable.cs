using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System.Collections
{
	/// <summary>Представляет коллекцию пар «ключ-значение», которые упорядочены по хэш-коду ключа.</summary>
	// Token: 0x02000A48 RID: 2632
	[DebuggerTypeProxy(typeof(Hashtable.HashtableDebugView))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable
	{
		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x06005E43 RID: 24131 RVA: 0x0013C4E8 File Offset: 0x0013A6E8
		private static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable
		{
			get
			{
				return LazyInitializer.EnsureInitialized<ConditionalWeakTable<object, SerializationInfo>>(ref Hashtable.s_serializationInfoTable);
			}
		}

		/// <summary>Получает или задает объект, который может распределять хэш-коды.</summary>
		/// <returns>Объект, который может распределять хэш-коды.</returns>
		/// <exception cref="T:System.ArgumentException">Свойству присвоено значение, однако хэш-таблица была создана с помощью объекта <see cref="T:System.Collections.IEqualityComparer" />.</exception>
		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06005E44 RID: 24132 RVA: 0x0013C4F4 File Offset: 0x0013A6F4
		// (set) Token: 0x06005E45 RID: 24133 RVA: 0x0013C528 File Offset: 0x0013A728
		[Obsolete("Please use EqualityComparer property.")]
		protected IHashCodeProvider hcp
		{
			get
			{
				if (this._keycomparer is CompatibleComparer)
				{
					return ((CompatibleComparer)this._keycomparer).HashCodeProvider;
				}
				if (this._keycomparer == null)
				{
					return null;
				}
				throw new ArgumentException("The usage of IKeyComparer and IHashCodeProvider/IComparer interfaces cannot be mixed; use one or the other.");
			}
			set
			{
				if (this._keycomparer is CompatibleComparer)
				{
					CompatibleComparer compatibleComparer = (CompatibleComparer)this._keycomparer;
					this._keycomparer = new CompatibleComparer(value, compatibleComparer.Comparer);
					return;
				}
				if (this._keycomparer == null)
				{
					this._keycomparer = new CompatibleComparer(value, null);
					return;
				}
				throw new ArgumentException("The usage of IKeyComparer and IHashCodeProvider/IComparer interfaces cannot be mixed; use one or the other.");
			}
		}

		/// <summary>Получает или задает интерфейс <see cref="T:System.Collections.IComparer" /> для использования применительно к коллекции <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IComparer" />, предназначенный для использования применительно к коллекции <see cref="T:System.Collections.Hashtable" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойству присвоено значение, однако хэш-таблица была создана с помощью объекта <see cref="T:System.Collections.IEqualityComparer" />.</exception>
		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06005E46 RID: 24134 RVA: 0x0013C581 File Offset: 0x0013A781
		// (set) Token: 0x06005E47 RID: 24135 RVA: 0x0013C5B8 File Offset: 0x0013A7B8
		[Obsolete("Please use KeyComparer properties.")]
		protected IComparer comparer
		{
			get
			{
				if (this._keycomparer is CompatibleComparer)
				{
					return ((CompatibleComparer)this._keycomparer).Comparer;
				}
				if (this._keycomparer == null)
				{
					return null;
				}
				throw new ArgumentException("The usage of IKeyComparer and IHashCodeProvider/IComparer interfaces cannot be mixed; use one or the other.");
			}
			set
			{
				if (this._keycomparer is CompatibleComparer)
				{
					CompatibleComparer compatibleComparer = (CompatibleComparer)this._keycomparer;
					this._keycomparer = new CompatibleComparer(compatibleComparer.HashCodeProvider, value);
					return;
				}
				if (this._keycomparer == null)
				{
					this._keycomparer = new CompatibleComparer(null, value);
					return;
				}
				throw new ArgumentException("The usage of IKeyComparer and IHashCodeProvider/IComparer interfaces cannot be mixed; use one or the other.");
			}
		}

		/// <summary>Получает объект <see cref="T:System.Collections.IEqualityComparer" />, предназначенный для использования применительно к коллекции <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEqualityComparer" />, предназначенный для использования применительно к коллекции <see cref="T:System.Collections.Hashtable" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойству присвоено значение, однако хэш-таблица была создана с помощью интерфейсов <see cref="T:System.Collections.IHashCodeProvider" /> и <see cref="T:System.Collections.IComparer" />.</exception>
		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06005E48 RID: 24136 RVA: 0x0013C611 File Offset: 0x0013A811
		protected IEqualityComparer EqualityComparer
		{
			get
			{
				return this._keycomparer;
			}
		}

		// Token: 0x06005E49 RID: 24137 RVA: 0x0000259F File Offset: 0x0000079F
		internal Hashtable(bool trash)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Hashtable" /> с заданными по умолчанию начальной емкостью, показателем загрузки, поставщиком хэш-кода и объектом сравнения.</summary>
		// Token: 0x06005E4A RID: 24138 RVA: 0x0013C619 File Offset: 0x0013A819
		public Hashtable() : this(0, 1f)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Hashtable" /> с указанной исходной емкостью и заданными по умолчанию показателем загрузки, поставщиком хэш-кода и объектом сравнения.</summary>
		/// <param name="capacity">Приблизительное количество элементов, которое может первоначально содержать объект <see cref="T:System.Collections.Hashtable" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше нуля.</exception>
		// Token: 0x06005E4B RID: 24139 RVA: 0x0013C627 File Offset: 0x0013A827
		public Hashtable(int capacity) : this(capacity, 1f)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Hashtable" /> с указанными исходной емкостью и показателем загрузки и заданными по умолчанию поставщиком хэш-кода и объектом сравнения.</summary>
		/// <param name="capacity">Приблизительное количество элементов, которое может первоначально содержать объект <see cref="T:System.Collections.Hashtable" />.</param>
		/// <param name="loadFactor">Число в диапазоне от 0,1 до 1,0, умноженное на значение по умолчанию, обеспечивающее наилучшую производительность. Результат определяет максимальное отношение количества элементов к количеству сегментов.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше нуля.  
		/// -или- 
		///  Значение <paramref name="loadFactor" /> меньше 0,1.  
		/// -или- 
		///  Значение <paramref name="loadFactor" /> больше 1,0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="capacity" /> приводит к переполнению.</exception>
		// Token: 0x06005E4C RID: 24140 RVA: 0x0013C638 File Offset: 0x0013A838
		public Hashtable(int capacity, float loadFactor)
		{
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", "Non-negative number required.");
			}
			if (loadFactor < 0.1f || loadFactor > 1f)
			{
				throw new ArgumentOutOfRangeException("loadFactor", SR.Format("Load factor needs to be between 0.1 and 1.0.", 0.1, 1.0));
			}
			this._loadFactor = 0.72f * loadFactor;
			double num = (double)((float)capacity / this._loadFactor);
			if (num > 2147483647.0)
			{
				throw new ArgumentException("Hashtable's capacity overflowed and went negative. Check load factor, capacity and the current size of the table.", "capacity");
			}
			int num2 = (num > 3.0) ? HashHelpers.GetPrime((int)num) : 3;
			this._buckets = new Hashtable.bucket[num2];
			this._loadsize = (int)(this._loadFactor * (float)num2);
			this._isWriterInProgress = false;
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Hashtable" /> с указанными исходной емкостью, показателем загрузки и объектом сравнения <see cref="T:System.Collections.IEqualityComparer" />.</summary>
		/// <param name="capacity">Приблизительное количество элементов, которое может первоначально содержать объект <see cref="T:System.Collections.Hashtable" />.</param>
		/// <param name="loadFactor">Число в диапазоне от 0,1 до 1,0, умноженное на значение по умолчанию, обеспечивающее наилучшую производительность. Результат определяет максимальное отношение количества элементов к количеству сегментов.</param>
		/// <param name="equalityComparer">
		///   <see cref="T:System.Collections.IEqualityComparer" /> — это объект, определяющий поставщик хэш-кода и объект сравнения для использования с объектом <see cref="T:System.Collections.Hashtable" />.  
		/// -или- 
		///  Значение <see langword="null" /> предусмотрено для использования поставщика хэш-кодов по умолчанию и объекта сравнения по умолчанию. Поставщик хэш-кода по умолчанию является реализацией метода <see cref="M:System.Object.GetHashCode" />, а средство сравнения по умолчанию является реализацией метода <see cref="M:System.Object.Equals(System.Object)" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше нуля.  
		/// -или- 
		///  Значение <paramref name="loadFactor" /> меньше 0,1.  
		/// -или- 
		///  Значение <paramref name="loadFactor" /> больше 1,0.</exception>
		// Token: 0x06005E4D RID: 24141 RVA: 0x0013C710 File Offset: 0x0013A910
		public Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer) : this(capacity, loadFactor)
		{
			this._keycomparer = equalityComparer;
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Hashtable" /> с заданными по умолчанию исходной емкостью и показателем загрузки и указанными поставщиком хэш-кода и объектом сравнения.</summary>
		/// <param name="hcp">Интерфейс <see cref="T:System.Collections.IHashCodeProvider" /> — это объект, поставляющий хэш-коды для всех ключей в объекте <see cref="T:System.Collections.Hashtable" />.  
		/// -или- 
		///  Значение <see langword="null" /> предусмотрено для использования поставщика хэш-кода по умолчанию, являющегося реализацией метода <see cref="M:System.Object.GetHashCode" /> для каждого ключа.</param>
		/// <param name="comparer">Интерфейс <see cref="T:System.Collections.IComparer" />, который используется для определения равенства двух ключей.  
		/// -или- 
		///  Значение <see langword="null" /> для использования блока сравнения по умолчанию, который является реализацией метода <see cref="M:System.Object.Equals(System.Object)" /> для каждого ключа.</param>
		// Token: 0x06005E4E RID: 24142 RVA: 0x0013C721 File Offset: 0x0013A921
		[Obsolete("Please use Hashtable(IEqualityComparer) instead.")]
		public Hashtable(IHashCodeProvider hcp, IComparer comparer) : this(0, 1f, hcp, comparer)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Hashtable" /> с заданными по умолчанию исходной емкостью и показателем загрузки и указанным объектом сравнения <see cref="T:System.Collections.IEqualityComparer" />.</summary>
		/// <param name="equalityComparer">
		///   <see cref="T:System.Collections.IEqualityComparer" /> — это объект, определяющий поставщик хэш-кода и объект сравнения для использования с объектом <see cref="T:System.Collections.Hashtable" />.  
		/// -или- 
		///  Значение <see langword="null" /> предусмотрено для использования поставщика хэш-кодов по умолчанию и объекта сравнения по умолчанию. Поставщик хэш-кода по умолчанию является реализацией метода <see cref="M:System.Object.GetHashCode" />, а средство сравнения по умолчанию является реализацией метода <see cref="M:System.Object.Equals(System.Object)" />.</param>
		// Token: 0x06005E4F RID: 24143 RVA: 0x0013C731 File Offset: 0x0013A931
		public Hashtable(IEqualityComparer equalityComparer) : this(0, 1f, equalityComparer)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Hashtable" /> с указанными исходной емкостью, поставщиком хэш-кода и объектом сравнения и заданным по умолчанию показателем загрузки.</summary>
		/// <param name="capacity">Приблизительное количество элементов, которое может первоначально содержать объект <see cref="T:System.Collections.Hashtable" />.</param>
		/// <param name="hcp">Интерфейс <see cref="T:System.Collections.IHashCodeProvider" /> — это объект, поставляющий хэш-коды для всех ключей в объекте <see cref="T:System.Collections.Hashtable" />.  
		/// -или- 
		///  Значение <see langword="null" /> предусмотрено для использования поставщика хэш-кода по умолчанию, являющегося реализацией метода <see cref="M:System.Object.GetHashCode" /> для каждого ключа.</param>
		/// <param name="comparer">Интерфейс <see cref="T:System.Collections.IComparer" />, который используется для определения равенства двух ключей.  
		/// -или- 
		///  Значение <see langword="null" /> для использования блока сравнения по умолчанию, который является реализацией метода <see cref="M:System.Object.Equals(System.Object)" /> для каждого ключа.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше нуля.</exception>
		// Token: 0x06005E50 RID: 24144 RVA: 0x0013C740 File Offset: 0x0013A940
		[Obsolete("Please use Hashtable(int, IEqualityComparer) instead.")]
		public Hashtable(int capacity, IHashCodeProvider hcp, IComparer comparer) : this(capacity, 1f, hcp, comparer)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Hashtable" /> с указанными исходной емкостью и объектом сравнения <see cref="T:System.Collections.IEqualityComparer" /> и заданным по умолчанию показателем загрузки.</summary>
		/// <param name="capacity">Приблизительное количество элементов, которое может первоначально содержать объект <see cref="T:System.Collections.Hashtable" />.</param>
		/// <param name="equalityComparer">
		///   <see cref="T:System.Collections.IEqualityComparer" /> — это объект, определяющий поставщик хэш-кода и объект сравнения для использования с объектом <see cref="T:System.Collections.Hashtable" />.  
		/// -или- 
		///  Значение <see langword="null" /> предусмотрено для использования поставщика хэш-кодов по умолчанию и объекта сравнения по умолчанию. Поставщик хэш-кода по умолчанию является реализацией метода <see cref="M:System.Object.GetHashCode" />, а средство сравнения по умолчанию является реализацией метода <see cref="M:System.Object.Equals(System.Object)" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше нуля.</exception>
		// Token: 0x06005E51 RID: 24145 RVA: 0x0013C750 File Offset: 0x0013A950
		public Hashtable(int capacity, IEqualityComparer equalityComparer) : this(capacity, 1f, equalityComparer)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Hashtable" /> посредством копирования элементов из указанного словаря в новый объект <see cref="T:System.Collections.Hashtable" />. У нового объекта <see cref="T:System.Collections.Hashtable" /> исходная емкость равна числу копируемых элементов, и он обладает заданными по умолчанию показателем загрузки, поставщиком хэш-кода и объектом сравнения.</summary>
		/// <param name="d">Объект <see cref="T:System.Collections.IDictionary" />, предназначенный для копирования в новый объект <see cref="T:System.Collections.Hashtable" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="d" /> — <see langword="null" />.</exception>
		// Token: 0x06005E52 RID: 24146 RVA: 0x0013C75F File Offset: 0x0013A95F
		public Hashtable(IDictionary d) : this(d, 1f)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Hashtable" /> посредством копирования элементов из указанного словаря в новый объект <see cref="T:System.Collections.Hashtable" />. У нового объекта <see cref="T:System.Collections.Hashtable" /> исходная емкость равна числу копируемых элементов, и он обладает указанным показателем загрузки и заданными по умолчанию поставщиком хэш-кода и объектом сравнения.</summary>
		/// <param name="d">Объект <see cref="T:System.Collections.IDictionary" />, предназначенный для копирования в новый объект <see cref="T:System.Collections.Hashtable" />.</param>
		/// <param name="loadFactor">Число в диапазоне от 0,1 до 1,0, умноженное на значение по умолчанию, обеспечивающее наилучшую производительность. Результат определяет максимальное отношение количества элементов к количеству сегментов.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="d" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="loadFactor" /> меньше 0,1.  
		/// -или- 
		///  Значение <paramref name="loadFactor" /> больше 1,0.</exception>
		// Token: 0x06005E53 RID: 24147 RVA: 0x0013C76D File Offset: 0x0013A96D
		public Hashtable(IDictionary d, float loadFactor) : this(d, loadFactor, null)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Hashtable" /> посредством копирования элементов из указанного словаря в новый объект <see cref="T:System.Collections.Hashtable" />. У нового объекта <see cref="T:System.Collections.Hashtable" /> исходная емкость равна числу копируемых элементов, и он обладает заданным по умолчанию показателем загрузки и указанными поставщиком хэш-кода и объектом сравнения. Этот API устарел. См. <see cref="M:System.Collections.Hashtable.#ctor(System.Collections.IDictionary,System.Collections.IEqualityComparer)" /> для альтернативных шагов.</summary>
		/// <param name="d">Объект <see cref="T:System.Collections.IDictionary" />, предназначенный для копирования в новый объект <see cref="T:System.Collections.Hashtable" />.</param>
		/// <param name="hcp">Интерфейс <see cref="T:System.Collections.IHashCodeProvider" /> — это объект, поставляющий хэш-коды для всех ключей в объекте <see cref="T:System.Collections.Hashtable" />.  
		/// -или- 
		///  Значение <see langword="null" /> предусмотрено для использования поставщика хэш-кода по умолчанию, являющегося реализацией метода <see cref="M:System.Object.GetHashCode" /> для каждого ключа.</param>
		/// <param name="comparer">Интерфейс <see cref="T:System.Collections.IComparer" />, который используется для определения равенства двух ключей.  
		/// -или- 
		///  Значение <see langword="null" /> для использования блока сравнения по умолчанию, который является реализацией метода <see cref="M:System.Object.Equals(System.Object)" /> для каждого ключа.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="d" /> — <see langword="null" />.</exception>
		// Token: 0x06005E54 RID: 24148 RVA: 0x0013C778 File Offset: 0x0013A978
		[Obsolete("Please use Hashtable(IDictionary, IEqualityComparer) instead.")]
		public Hashtable(IDictionary d, IHashCodeProvider hcp, IComparer comparer) : this(d, 1f, hcp, comparer)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Hashtable" /> посредством копирования элементов из указанного словаря в новый объект <see cref="T:System.Collections.Hashtable" />. У нового объекта <see cref="T:System.Collections.Hashtable" /> исходная емкость равна числу копируемых элементов, и он обладает заданным по умолчанию показателем загрузки и указанным объектом сравнения <see cref="T:System.Collections.IEqualityComparer" />.</summary>
		/// <param name="d">Объект <see cref="T:System.Collections.IDictionary" />, предназначенный для копирования в новый объект <see cref="T:System.Collections.Hashtable" />.</param>
		/// <param name="equalityComparer">
		///   <see cref="T:System.Collections.IEqualityComparer" /> — это объект, определяющий поставщик хэш-кода и объект сравнения для использования с объектом <see cref="T:System.Collections.Hashtable" />.  
		/// -или- 
		///  Значение <see langword="null" /> предусмотрено для использования поставщика хэш-кодов по умолчанию и объекта сравнения по умолчанию. Поставщик хэш-кода по умолчанию является реализацией метода <see cref="M:System.Object.GetHashCode" />, а средство сравнения по умолчанию является реализацией метода <see cref="M:System.Object.Equals(System.Object)" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="d" /> — <see langword="null" />.</exception>
		// Token: 0x06005E55 RID: 24149 RVA: 0x0013C788 File Offset: 0x0013A988
		public Hashtable(IDictionary d, IEqualityComparer equalityComparer) : this(d, 1f, equalityComparer)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Hashtable" /> с указанными начальной емкостью, показателем загрузки, поставщиком хэш-кода и объектом сравнения.</summary>
		/// <param name="capacity">Приблизительное количество элементов, которое может первоначально содержать объект <see cref="T:System.Collections.Hashtable" />.</param>
		/// <param name="loadFactor">Число в диапазоне от 0,1 до 1,0, умноженное на значение по умолчанию, обеспечивающее наилучшую производительность. Результат определяет максимальное отношение количества элементов к количеству сегментов.</param>
		/// <param name="hcp">Интерфейс <see cref="T:System.Collections.IHashCodeProvider" /> — это объект, поставляющий хэш-коды для всех ключей в объекте <see cref="T:System.Collections.Hashtable" />.  
		/// -или- 
		///  Значение <see langword="null" /> предусмотрено для использования поставщика хэш-кода по умолчанию, являющегося реализацией метода <see cref="M:System.Object.GetHashCode" /> для каждого ключа.</param>
		/// <param name="comparer">Интерфейс <see cref="T:System.Collections.IComparer" />, который используется для определения равенства двух ключей.  
		/// -или- 
		///  Значение <see langword="null" /> для использования блока сравнения по умолчанию, который является реализацией метода <see cref="M:System.Object.Equals(System.Object)" /> для каждого ключа.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше нуля.  
		/// -или- 
		///  Значение <paramref name="loadFactor" /> меньше 0,1.  
		/// -или- 
		///  Значение <paramref name="loadFactor" /> больше 1,0.</exception>
		// Token: 0x06005E56 RID: 24150 RVA: 0x0013C797 File Offset: 0x0013A997
		[Obsolete("Please use Hashtable(int, float, IEqualityComparer) instead.")]
		public Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) : this(capacity, loadFactor)
		{
			if (hcp != null || comparer != null)
			{
				this._keycomparer = new CompatibleComparer(hcp, comparer);
			}
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Hashtable" /> посредством копирования элементов из указанного словаря в новый объект <see cref="T:System.Collections.Hashtable" />. У нового объекта <see cref="T:System.Collections.Hashtable" /> исходная емкость равна числу копируемых элементов, и он обладает указанными показателем загрузки, поставщиком хэш-кода и объектом сравнения.</summary>
		/// <param name="d">Объект <see cref="T:System.Collections.IDictionary" />, предназначенный для копирования в новый объект <see cref="T:System.Collections.Hashtable" />.</param>
		/// <param name="loadFactor">Число в диапазоне от 0,1 до 1,0, умноженное на значение по умолчанию, обеспечивающее наилучшую производительность. Результат определяет максимальное отношение количества элементов к количеству сегментов.</param>
		/// <param name="hcp">Интерфейс <see cref="T:System.Collections.IHashCodeProvider" /> — это объект, поставляющий хэш-коды для всех ключей в объекте <see cref="T:System.Collections.Hashtable" />.  
		/// -или- 
		///  Значение <see langword="null" /> предусмотрено для использования поставщика хэш-кода по умолчанию, являющегося реализацией метода <see cref="M:System.Object.GetHashCode" /> для каждого ключа.</param>
		/// <param name="comparer">Интерфейс <see cref="T:System.Collections.IComparer" />, который используется для определения равенства двух ключей.  
		/// -или- 
		///  Значение <see langword="null" /> для использования блока сравнения по умолчанию, который является реализацией метода <see cref="M:System.Object.Equals(System.Object)" /> для каждого ключа.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="d" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="loadFactor" /> меньше 0,1.  
		/// -или- 
		///  Значение <paramref name="loadFactor" /> больше 1,0.</exception>
		// Token: 0x06005E57 RID: 24151 RVA: 0x0013C7B8 File Offset: 0x0013A9B8
		[Obsolete("Please use Hashtable(IDictionary, float, IEqualityComparer) instead.")]
		public Hashtable(IDictionary d, float loadFactor, IHashCodeProvider hcp, IComparer comparer) : this((d != null) ? d.Count : 0, loadFactor, hcp, comparer)
		{
			if (d == null)
			{
				throw new ArgumentNullException("d", "Dictionary cannot be null.");
			}
			IDictionaryEnumerator enumerator = d.GetEnumerator();
			while (enumerator.MoveNext())
			{
				this.Add(enumerator.Key, enumerator.Value);
			}
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Hashtable" /> посредством копирования элементов из указанного словаря в новый объект <see cref="T:System.Collections.Hashtable" />. У нового объекта <see cref="T:System.Collections.Hashtable" /> исходная емкость равна числу копируемых элементов, и он обладает указанными показателем загрузки и объектом сравнения <see cref="T:System.Collections.IEqualityComparer" />.</summary>
		/// <param name="d">Объект <see cref="T:System.Collections.IDictionary" />, предназначенный для копирования в новый объект <see cref="T:System.Collections.Hashtable" />.</param>
		/// <param name="loadFactor">Число в диапазоне от 0,1 до 1,0, умноженное на значение по умолчанию, обеспечивающее наилучшую производительность. Результат определяет максимальное отношение количества элементов к количеству сегментов.</param>
		/// <param name="equalityComparer">
		///   <see cref="T:System.Collections.IEqualityComparer" /> — это объект, определяющий поставщик хэш-кода и объект сравнения для использования с объектом <see cref="T:System.Collections.Hashtable" />.  
		/// -или- 
		///  Значение <see langword="null" /> предусмотрено для использования поставщика хэш-кодов по умолчанию и объекта сравнения по умолчанию. Поставщик хэш-кода по умолчанию является реализацией метода <see cref="M:System.Object.GetHashCode" />, а средство сравнения по умолчанию является реализацией метода <see cref="M:System.Object.Equals(System.Object)" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="d" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="loadFactor" /> меньше 0,1.  
		/// -или- 
		///  Значение <paramref name="loadFactor" /> больше 1,0.</exception>
		// Token: 0x06005E58 RID: 24152 RVA: 0x0013C814 File Offset: 0x0013AA14
		public Hashtable(IDictionary d, float loadFactor, IEqualityComparer equalityComparer) : this((d != null) ? d.Count : 0, loadFactor, equalityComparer)
		{
			if (d == null)
			{
				throw new ArgumentNullException("d", "Dictionary cannot be null.");
			}
			IDictionaryEnumerator enumerator = d.GetEnumerator();
			while (enumerator.MoveNext())
			{
				this.Add(enumerator.Key, enumerator.Value);
			}
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Hashtable" />, который может быть сериализован с помощью объектов <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сведения, которые требуются для сериализации объекта <see cref="T:System.Collections.Hashtable" />.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий исходный объект и объект назначения для сериализованного потока, связанного с коллекцией <see cref="T:System.Collections.Hashtable" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> — <see langword="null" />.</exception>
		// Token: 0x06005E59 RID: 24153 RVA: 0x0013C86B File Offset: 0x0013AA6B
		protected Hashtable(SerializationInfo info, StreamingContext context)
		{
			Hashtable.SerializationInfoTable.Add(this, info);
		}

		// Token: 0x06005E5A RID: 24154 RVA: 0x0013C880 File Offset: 0x0013AA80
		private uint InitHash(object key, int hashsize, out uint seed, out uint incr)
		{
			uint num = (uint)(this.GetHash(key) & int.MaxValue);
			seed = num;
			incr = 1U + seed * 101U % (uint)(hashsize - 1);
			return num;
		}

		/// <summary>Добавляет элемент с указанными ключом и значением в словарь <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <param name="key">Ключ добавляемого элемента.</param>
		/// <param name="value">Добавляемое значение элемента. Допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Элемент с таким ключом уже существует в <see cref="T:System.Collections.Hashtable" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Hashtable" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.Hashtable" /> имеет фиксированный размер.</exception>
		// Token: 0x06005E5B RID: 24155 RVA: 0x0013C8AD File Offset: 0x0013AAAD
		public virtual void Add(object key, object value)
		{
			this.Insert(key, value, true);
		}

		/// <summary>Удаляет из коллекции <see cref="T:System.Collections.Hashtable" /> все элементы.</summary>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Hashtable" /> доступен только для чтения.</exception>
		// Token: 0x06005E5C RID: 24156 RVA: 0x0013C8B8 File Offset: 0x0013AAB8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public virtual void Clear()
		{
			if (this._count == 0 && this._occupancy == 0)
			{
				return;
			}
			this._isWriterInProgress = true;
			for (int i = 0; i < this._buckets.Length; i++)
			{
				this._buckets[i].hash_coll = 0;
				this._buckets[i].key = null;
				this._buckets[i].val = null;
			}
			this._count = 0;
			this._occupancy = 0;
			this.UpdateVersion();
			this._isWriterInProgress = false;
		}

		/// <summary>Создает неполную копию <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>Неполная копия <see cref="T:System.Collections.Hashtable" />.</returns>
		// Token: 0x06005E5D RID: 24157 RVA: 0x0013C948 File Offset: 0x0013AB48
		public virtual object Clone()
		{
			Hashtable.bucket[] buckets = this._buckets;
			Hashtable hashtable = new Hashtable(this._count, this._keycomparer);
			hashtable._version = this._version;
			hashtable._loadFactor = this._loadFactor;
			hashtable._count = 0;
			int i = buckets.Length;
			while (i > 0)
			{
				i--;
				object key = buckets[i].key;
				if (key != null && key != buckets)
				{
					hashtable[key] = buckets[i].val;
				}
			}
			return hashtable;
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Collections.Hashtable" /> указанный ключ.</summary>
		/// <param name="key">Ключ, который требуется найти в <see cref="T:System.Collections.Hashtable" />.</param>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Collections.Hashtable" /> содержит элемент с указанным ключом, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x06005E5E RID: 24158 RVA: 0x0013C9C7 File Offset: 0x0013ABC7
		public virtual bool Contains(object key)
		{
			return this.ContainsKey(key);
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Collections.Hashtable" /> указанный ключ.</summary>
		/// <param name="key">Ключ, который требуется найти в <see cref="T:System.Collections.Hashtable" />.</param>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Collections.Hashtable" /> содержит элемент с указанным ключом, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x06005E5F RID: 24159 RVA: 0x0013C9D0 File Offset: 0x0013ABD0
		public virtual bool ContainsKey(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", "Key cannot be null.");
			}
			Hashtable.bucket[] buckets = this._buckets;
			uint num2;
			uint num3;
			uint num = this.InitHash(key, buckets.Length, out num2, out num3);
			int num4 = 0;
			int num5 = (int)(num2 % (uint)buckets.Length);
			for (;;)
			{
				Hashtable.bucket bucket = buckets[num5];
				if (bucket.key == null)
				{
					break;
				}
				if ((long)(bucket.hash_coll & 2147483647) == (long)((ulong)num) && this.KeyEquals(bucket.key, key))
				{
					return true;
				}
				num5 = (int)(((long)num5 + (long)((ulong)num3)) % (long)((ulong)buckets.Length));
				if (bucket.hash_coll >= 0 || ++num4 >= buckets.Length)
				{
					return false;
				}
			}
			return false;
		}

		/// <summary>Определяет, содержит ли коллекция <see cref="T:System.Collections.Hashtable" /> указанное значение.</summary>
		/// <param name="value">Значение, которое требуется найти в словаре <see cref="T:System.Collections.Hashtable" />. Допускается значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Collections.Hashtable" /> содержит элемент с указанным значением параметра <paramref name="value" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005E60 RID: 24160 RVA: 0x0013CA70 File Offset: 0x0013AC70
		public virtual bool ContainsValue(object value)
		{
			if (value == null)
			{
				int num = this._buckets.Length;
				while (--num >= 0)
				{
					if (this._buckets[num].key != null && this._buckets[num].key != this._buckets && this._buckets[num].val == null)
					{
						return true;
					}
				}
			}
			else
			{
				int num2 = this._buckets.Length;
				while (--num2 >= 0)
				{
					object val = this._buckets[num2].val;
					if (val != null && val.Equals(value))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06005E61 RID: 24161 RVA: 0x0013CB0C File Offset: 0x0013AD0C
		private void CopyKeys(Array array, int arrayIndex)
		{
			Hashtable.bucket[] buckets = this._buckets;
			int num = buckets.Length;
			while (--num >= 0)
			{
				object key = buckets[num].key;
				if (key != null && key != this._buckets)
				{
					array.SetValue(key, arrayIndex++);
				}
			}
		}

		// Token: 0x06005E62 RID: 24162 RVA: 0x0013CB54 File Offset: 0x0013AD54
		private void CopyEntries(Array array, int arrayIndex)
		{
			Hashtable.bucket[] buckets = this._buckets;
			int num = buckets.Length;
			while (--num >= 0)
			{
				object key = buckets[num].key;
				if (key != null && key != this._buckets)
				{
					DictionaryEntry dictionaryEntry = new DictionaryEntry(key, buckets[num].val);
					array.SetValue(dictionaryEntry, arrayIndex++);
				}
			}
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.Hashtable" /> в экземпляр класса одномерного массива <see cref="T:System.Array" /> по указанному индексу.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, который является назначением для объектов <see cref="T:System.Collections.DictionaryEntry" />, копируемых из коллекции <see cref="T:System.Collections.Hashtable" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="arrayIndex">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="arrayIndex" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		/// -или- 
		/// Число элементов в исходной коллекции <see cref="T:System.Collections.Hashtable" /> больше доступного места от положения, заданного значением параметра <paramref name="arrayIndex" />, до конца массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип исходного массива <see cref="T:System.Collections.Hashtable" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x06005E63 RID: 24163 RVA: 0x0013CBB8 File Offset: 0x0013ADB8
		public virtual void CopyTo(Array array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array", "Array cannot be null.");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "Non-negative number required.");
			}
			if (array.Length - arrayIndex < this.Count)
			{
				throw new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
			}
			this.CopyEntries(array, arrayIndex);
		}

		// Token: 0x06005E64 RID: 24164 RVA: 0x0013CC28 File Offset: 0x0013AE28
		internal virtual KeyValuePairs[] ToKeyValuePairsArray()
		{
			KeyValuePairs[] array = new KeyValuePairs[this._count];
			int num = 0;
			Hashtable.bucket[] buckets = this._buckets;
			int num2 = buckets.Length;
			while (--num2 >= 0)
			{
				object key = buckets[num2].key;
				if (key != null && key != this._buckets)
				{
					array[num++] = new KeyValuePairs(key, buckets[num2].val);
				}
			}
			return array;
		}

		// Token: 0x06005E65 RID: 24165 RVA: 0x0013CC90 File Offset: 0x0013AE90
		private void CopyValues(Array array, int arrayIndex)
		{
			Hashtable.bucket[] buckets = this._buckets;
			int num = buckets.Length;
			while (--num >= 0)
			{
				object key = buckets[num].key;
				if (key != null && key != this._buckets)
				{
					array.SetValue(buckets[num].val, arrayIndex++);
				}
			}
		}

		/// <summary>Возвращает или задает значение, связанное с указанным ключом.</summary>
		/// <param name="key">Задаваемое или получаемое значение ключа.</param>
		/// <returns>Значение, связанное с указанным ключом. Если указанный ключ не найден, при попытке его получения возвращается значение <see langword="null" />, а при попытке задания ключа создается новый элемент с использованием указанного ключа.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Свойство задано, и список <see cref="T:System.Collections.Hashtable" /> доступен только для чтения.  
		/// -или- 
		/// Свойство задано, <paramref name="key" /> не существует в коллекции, а <see cref="T:System.Collections.Hashtable" /> имеет фиксированный размер.</exception>
		// Token: 0x17001079 RID: 4217
		public virtual object this[object key]
		{
			get
			{
				if (key == null)
				{
					throw new ArgumentNullException("key", "Key cannot be null.");
				}
				Hashtable.bucket[] buckets = this._buckets;
				uint num2;
				uint num3;
				uint num = this.InitHash(key, buckets.Length, out num2, out num3);
				int num4 = 0;
				int num5 = (int)(num2 % (uint)buckets.Length);
				Hashtable.bucket bucket;
				for (;;)
				{
					SpinWait spinWait = default(SpinWait);
					for (;;)
					{
						int version = this._version;
						bucket = buckets[num5];
						if (!this._isWriterInProgress && version == this._version)
						{
							break;
						}
						spinWait.SpinOnce();
					}
					if (bucket.key == null)
					{
						break;
					}
					if ((long)(bucket.hash_coll & 2147483647) == (long)((ulong)num) && this.KeyEquals(bucket.key, key))
					{
						goto Block_5;
					}
					num5 = (int)(((long)num5 + (long)((ulong)num3)) % (long)((ulong)buckets.Length));
					if (bucket.hash_coll >= 0 || ++num4 >= buckets.Length)
					{
						goto IL_CA;
					}
				}
				return null;
				Block_5:
				return bucket.val;
				IL_CA:
				return null;
			}
			set
			{
				this.Insert(key, value, false);
			}
		}

		// Token: 0x06005E68 RID: 24168 RVA: 0x0013CDC8 File Offset: 0x0013AFC8
		private void expand()
		{
			int newsize = HashHelpers.ExpandPrime(this._buckets.Length);
			this.rehash(newsize);
		}

		// Token: 0x06005E69 RID: 24169 RVA: 0x0013CDEA File Offset: 0x0013AFEA
		private void rehash()
		{
			this.rehash(this._buckets.Length);
		}

		// Token: 0x06005E6A RID: 24170 RVA: 0x0013CDFA File Offset: 0x0013AFFA
		private void UpdateVersion()
		{
			this._version++;
		}

		// Token: 0x06005E6B RID: 24171 RVA: 0x0013CE10 File Offset: 0x0013B010
		private void rehash(int newsize)
		{
			this._occupancy = 0;
			Hashtable.bucket[] array = new Hashtable.bucket[newsize];
			for (int i = 0; i < this._buckets.Length; i++)
			{
				Hashtable.bucket bucket = this._buckets[i];
				if (bucket.key != null && bucket.key != this._buckets)
				{
					int hashcode = bucket.hash_coll & int.MaxValue;
					this.putEntry(array, bucket.key, bucket.val, hashcode);
				}
			}
			this._isWriterInProgress = true;
			this._buckets = array;
			this._loadsize = (int)(this._loadFactor * (float)newsize);
			this.UpdateVersion();
			this._isWriterInProgress = false;
		}

		/// <summary>Возвращает перечислитель, который осуществляет итерацию по коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x06005E6C RID: 24172 RVA: 0x0013CEB1 File Offset: 0x0013B0B1
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Hashtable.HashtableEnumerator(this, 3);
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IDictionaryEnumerator" />, осуществляющий перебор <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IDictionaryEnumerator" /> для <see cref="T:System.Collections.Hashtable" />.</returns>
		// Token: 0x06005E6D RID: 24173 RVA: 0x0013CEB1 File Offset: 0x0013B0B1
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return new Hashtable.HashtableEnumerator(this, 3);
		}

		/// <summary>Возвращает хэш-код указанного ключа.</summary>
		/// <param name="key">Объект <see cref="T:System.Object" />, для которого необходимо вернуть хэш-код.</param>
		/// <returns>Хэш-код параметра <paramref name="key" />.</returns>
		/// <exception cref="T:System.NullReferenceException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x06005E6E RID: 24174 RVA: 0x0013CEBA File Offset: 0x0013B0BA
		protected virtual int GetHash(object key)
		{
			if (this._keycomparer != null)
			{
				return this._keycomparer.GetHashCode(key);
			}
			return key.GetHashCode();
		}

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Collections.Hashtable" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.Hashtable" /> доступен только для чтения; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06005E6F RID: 24175 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, имеет ли список <see cref="T:System.Collections.Hashtable" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Collections.Hashtable" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06005E70 RID: 24176 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.Hashtable" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.Hashtable" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06005E71 RID: 24177 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Сравнивает указанный объект класса <see cref="T:System.Object" /> с указанным ключом, который содержится в коллекции <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <param name="item">Объект класса <see cref="T:System.Object" />, который требуется сравнить со значением ключа <paramref name="key" />.</param>
		/// <param name="key">Ключ, существующий в коллекции <see cref="T:System.Collections.Hashtable" />, который требуется сравнить со значением параметра <paramref name="item" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="item" /> и <paramref name="key" /> равны; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="item" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x06005E72 RID: 24178 RVA: 0x0013CED7 File Offset: 0x0013B0D7
		protected virtual bool KeyEquals(object item, object key)
		{
			if (this._buckets == item)
			{
				return false;
			}
			if (item == key)
			{
				return true;
			}
			if (this._keycomparer != null)
			{
				return this._keycomparer.Equals(item, key);
			}
			return item != null && item.Equals(key);
		}

		/// <summary>Получает коллекцию <see cref="T:System.Collections.ICollection" />, содержащую ключи из коллекции <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, содержащая ключи из коллекции <see cref="T:System.Collections.Hashtable" />.</returns>
		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06005E73 RID: 24179 RVA: 0x0013CF0C File Offset: 0x0013B10C
		public virtual ICollection Keys
		{
			get
			{
				if (this._keys == null)
				{
					this._keys = new Hashtable.KeyCollection(this);
				}
				return this._keys;
			}
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.ICollection" />, содержащий значения из <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, содержащая значения из словаря <see cref="T:System.Collections.Hashtable" />.</returns>
		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06005E74 RID: 24180 RVA: 0x0013CF28 File Offset: 0x0013B128
		public virtual ICollection Values
		{
			get
			{
				if (this._values == null)
				{
					this._values = new Hashtable.ValueCollection(this);
				}
				return this._values;
			}
		}

		// Token: 0x06005E75 RID: 24181 RVA: 0x0013CF44 File Offset: 0x0013B144
		private void Insert(object key, object nvalue, bool add)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", "Key cannot be null.");
			}
			if (this._count >= this._loadsize)
			{
				this.expand();
			}
			else if (this._occupancy > this._loadsize && this._count > 100)
			{
				this.rehash();
			}
			uint num2;
			uint num3;
			uint num = this.InitHash(key, this._buckets.Length, out num2, out num3);
			int num4 = 0;
			int num5 = -1;
			int num6 = (int)(num2 % (uint)this._buckets.Length);
			for (;;)
			{
				if (num5 == -1 && this._buckets[num6].key == this._buckets && this._buckets[num6].hash_coll < 0)
				{
					num5 = num6;
				}
				if (this._buckets[num6].key == null || (this._buckets[num6].key == this._buckets && ((long)this._buckets[num6].hash_coll & (long)((ulong)-2147483648)) == 0L))
				{
					break;
				}
				if ((long)(this._buckets[num6].hash_coll & 2147483647) == (long)((ulong)num) && this.KeyEquals(this._buckets[num6].key, key))
				{
					goto Block_12;
				}
				if (num5 == -1 && this._buckets[num6].hash_coll >= 0)
				{
					Hashtable.bucket[] buckets = this._buckets;
					int num7 = num6;
					buckets[num7].hash_coll = (buckets[num7].hash_coll | int.MinValue);
					this._occupancy++;
				}
				num6 = (int)(((long)num6 + (long)((ulong)num3)) % (long)((ulong)this._buckets.Length));
				if (++num4 >= this._buckets.Length)
				{
					goto Block_16;
				}
			}
			if (num5 != -1)
			{
				num6 = num5;
			}
			this._isWriterInProgress = true;
			this._buckets[num6].val = nvalue;
			this._buckets[num6].key = key;
			Hashtable.bucket[] buckets2 = this._buckets;
			int num8 = num6;
			buckets2[num8].hash_coll = (buckets2[num8].hash_coll | (int)num);
			this._count++;
			this.UpdateVersion();
			this._isWriterInProgress = false;
			return;
			Block_12:
			if (add)
			{
				throw new ArgumentException(SR.Format("Item has already been added. Key in dictionary: '{0}'  Key being added: '{1}'", this._buckets[num6].key, key));
			}
			this._isWriterInProgress = true;
			this._buckets[num6].val = nvalue;
			this.UpdateVersion();
			this._isWriterInProgress = false;
			return;
			Block_16:
			if (num5 != -1)
			{
				this._isWriterInProgress = true;
				this._buckets[num5].val = nvalue;
				this._buckets[num5].key = key;
				Hashtable.bucket[] buckets3 = this._buckets;
				int num9 = num5;
				buckets3[num9].hash_coll = (buckets3[num9].hash_coll | (int)num);
				this._count++;
				this.UpdateVersion();
				this._isWriterInProgress = false;
				return;
			}
			throw new InvalidOperationException("Hashtable insert failed. Load factor too high. The most common cause is multiple threads writing to the Hashtable simultaneously.");
		}

		// Token: 0x06005E76 RID: 24182 RVA: 0x0013D214 File Offset: 0x0013B414
		private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode)
		{
			uint num = (uint)(1 + hashcode * 101 % (newBuckets.Length - 1));
			int num2 = hashcode % newBuckets.Length;
			while (newBuckets[num2].key != null && newBuckets[num2].key != this._buckets)
			{
				if (newBuckets[num2].hash_coll >= 0)
				{
					int num3 = num2;
					newBuckets[num3].hash_coll = (newBuckets[num3].hash_coll | int.MinValue);
					this._occupancy++;
				}
				num2 = (int)(((long)num2 + (long)((ulong)num)) % (long)((ulong)newBuckets.Length));
			}
			newBuckets[num2].val = nvalue;
			newBuckets[num2].key = key;
			int num4 = num2;
			newBuckets[num4].hash_coll = (newBuckets[num4].hash_coll | hashcode);
		}

		/// <summary>Удаляет элемент с указанным ключом из <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <param name="key">Ключ элемента, который требуется удалить.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Hashtable" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.Hashtable" /> имеет фиксированный размер.</exception>
		// Token: 0x06005E77 RID: 24183 RVA: 0x0013D2C8 File Offset: 0x0013B4C8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public virtual void Remove(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", "Key cannot be null.");
			}
			uint num2;
			uint num3;
			uint num = this.InitHash(key, this._buckets.Length, out num2, out num3);
			int num4 = 0;
			int num5 = (int)(num2 % (uint)this._buckets.Length);
			for (;;)
			{
				Hashtable.bucket bucket = this._buckets[num5];
				if ((long)(bucket.hash_coll & 2147483647) == (long)((ulong)num) && this.KeyEquals(bucket.key, key))
				{
					break;
				}
				num5 = (int)(((long)num5 + (long)((ulong)num3)) % (long)((ulong)this._buckets.Length));
				if (bucket.hash_coll >= 0 || ++num4 >= this._buckets.Length)
				{
					return;
				}
			}
			this._isWriterInProgress = true;
			Hashtable.bucket[] buckets = this._buckets;
			int num6 = num5;
			buckets[num6].hash_coll = (buckets[num6].hash_coll & int.MinValue);
			if (this._buckets[num5].hash_coll != 0)
			{
				this._buckets[num5].key = this._buckets;
			}
			else
			{
				this._buckets[num5].key = null;
			}
			this._buckets[num5].val = null;
			this._count--;
			this.UpdateVersion();
			this._isWriterInProgress = false;
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.Hashtable" />.</returns>
		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06005E78 RID: 24184 RVA: 0x0013D406 File Offset: 0x0013B606
		public virtual object SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					Interlocked.CompareExchange<object>(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		/// <summary>Возвращает число пар "ключ-значение", содержащихся в словаре <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>Число пар "ключ-значение", содержащихся в словаре <see cref="T:System.Collections.Hashtable" />.</returns>
		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06005E79 RID: 24185 RVA: 0x0013D428 File Offset: 0x0013B628
		public virtual int Count
		{
			get
			{
				return this._count;
			}
		}

		/// <summary>Возвращает синхронизированную (потокобезопасную) оболочку коллекции <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <param name="table">Коллекция <see cref="T:System.Collections.Hashtable" />, которую требуется синхронизировать.</param>
		/// <returns>Синхронизированная (потокобезопасная) оболочка коллекции <see cref="T:System.Collections.Hashtable" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="table" /> — <see langword="null" />.</exception>
		// Token: 0x06005E7A RID: 24186 RVA: 0x0013D430 File Offset: 0x0013B630
		public static Hashtable Synchronized(Hashtable table)
		{
			if (table == null)
			{
				throw new ArgumentNullException("table");
			}
			return new Hashtable.SyncHashtable(table);
		}

		/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Serialization.ISerializable" /> и возвращает данные, необходимые для сериализации коллекции <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, требуемые для сериализации коллекции <see cref="T:System.Collections.Hashtable" />.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий исходный объект и объект назначения для сериализованного потока, связанного с коллекцией <see cref="T:System.Collections.Hashtable" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Коллекция была изменена.</exception>
		// Token: 0x06005E7B RID: 24187 RVA: 0x0013D448 File Offset: 0x0013B648
		[SecurityCritical]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			object syncRoot = this.SyncRoot;
			lock (syncRoot)
			{
				int version = this._version;
				info.AddValue("LoadFactor", this._loadFactor);
				info.AddValue("Version", this._version);
				IEqualityComparer keycomparer = this._keycomparer;
				if (keycomparer == null)
				{
					info.AddValue("Comparer", null, typeof(IComparer));
					info.AddValue("HashCodeProvider", null, typeof(IHashCodeProvider));
				}
				else if (keycomparer is CompatibleComparer)
				{
					CompatibleComparer compatibleComparer = keycomparer as CompatibleComparer;
					info.AddValue("Comparer", compatibleComparer.Comparer, typeof(IComparer));
					info.AddValue("HashCodeProvider", compatibleComparer.HashCodeProvider, typeof(IHashCodeProvider));
				}
				else
				{
					info.AddValue("KeyComparer", keycomparer, typeof(IEqualityComparer));
				}
				info.AddValue("HashSize", this._buckets.Length);
				object[] array = new object[this._count];
				object[] array2 = new object[this._count];
				this.CopyKeys(array, 0);
				this.CopyValues(array2, 0);
				info.AddValue("Keys", array, typeof(object[]));
				info.AddValue("Values", array2, typeof(object[]));
				if (this._version != version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
			}
		}

		/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Serialization.ISerializable" /> и вызывает событие десериализации при завершении десериализации.</summary>
		/// <param name="sender">Источник события десериализации.</param>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, связанный с текущей коллекцией <see cref="T:System.Collections.Hashtable" />, недействителен.</exception>
		// Token: 0x06005E7C RID: 24188 RVA: 0x0013D5E4 File Offset: 0x0013B7E4
		public virtual void OnDeserialization(object sender)
		{
			if (this._buckets != null)
			{
				return;
			}
			SerializationInfo serializationInfo;
			Hashtable.SerializationInfoTable.TryGetValue(this, out serializationInfo);
			if (serializationInfo == null)
			{
				throw new SerializationException("OnDeserialization method was called while the object was not being deserialized.");
			}
			int num = 0;
			IComparer comparer = null;
			IHashCodeProvider hashCodeProvider = null;
			object[] array = null;
			object[] array2 = null;
			SerializationInfoEnumerator enumerator = serializationInfo.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string name = enumerator.Name;
				uint num2 = <PrivateImplementationDetails>.ComputeStringHash(name);
				if (num2 <= 1613443821U)
				{
					if (num2 != 891156946U)
					{
						if (num2 != 1228509323U)
						{
							if (num2 == 1613443821U)
							{
								if (name == "Keys")
								{
									array = (object[])serializationInfo.GetValue("Keys", typeof(object[]));
								}
							}
						}
						else if (name == "KeyComparer")
						{
							this._keycomparer = (IEqualityComparer)serializationInfo.GetValue("KeyComparer", typeof(IEqualityComparer));
						}
					}
					else if (name == "Comparer")
					{
						comparer = (IComparer)serializationInfo.GetValue("Comparer", typeof(IComparer));
					}
				}
				else if (num2 <= 2484309429U)
				{
					if (num2 != 2370642523U)
					{
						if (num2 == 2484309429U)
						{
							if (name == "HashCodeProvider")
							{
								hashCodeProvider = (IHashCodeProvider)serializationInfo.GetValue("HashCodeProvider", typeof(IHashCodeProvider));
							}
						}
					}
					else if (name == "Values")
					{
						array2 = (object[])serializationInfo.GetValue("Values", typeof(object[]));
					}
				}
				else if (num2 != 3356145248U)
				{
					if (num2 == 3483216242U)
					{
						if (name == "LoadFactor")
						{
							this._loadFactor = serializationInfo.GetSingle("LoadFactor");
						}
					}
				}
				else if (name == "HashSize")
				{
					num = serializationInfo.GetInt32("HashSize");
				}
			}
			this._loadsize = (int)(this._loadFactor * (float)num);
			if (this._keycomparer == null && (comparer != null || hashCodeProvider != null))
			{
				this._keycomparer = new CompatibleComparer(hashCodeProvider, comparer);
			}
			this._buckets = new Hashtable.bucket[num];
			if (array == null)
			{
				throw new SerializationException("The keys for this dictionary are missing.");
			}
			if (array2 == null)
			{
				throw new SerializationException("The values for this dictionary are missing.");
			}
			if (array.Length != array2.Length)
			{
				throw new SerializationException("The keys and values arrays have different sizes.");
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					throw new SerializationException("One of the serialized keys is null.");
				}
				this.Insert(array[i], array2[i], true);
			}
			this._version = serializationInfo.GetInt32("Version");
			Hashtable.SerializationInfoTable.Remove(this);
		}

		// Token: 0x040038F5 RID: 14581
		internal const int HashPrime = 101;

		// Token: 0x040038F6 RID: 14582
		private const int InitialSize = 3;

		// Token: 0x040038F7 RID: 14583
		private const string LoadFactorName = "LoadFactor";

		// Token: 0x040038F8 RID: 14584
		private const string VersionName = "Version";

		// Token: 0x040038F9 RID: 14585
		private const string ComparerName = "Comparer";

		// Token: 0x040038FA RID: 14586
		private const string HashCodeProviderName = "HashCodeProvider";

		// Token: 0x040038FB RID: 14587
		private const string HashSizeName = "HashSize";

		// Token: 0x040038FC RID: 14588
		private const string KeysName = "Keys";

		// Token: 0x040038FD RID: 14589
		private const string ValuesName = "Values";

		// Token: 0x040038FE RID: 14590
		private const string KeyComparerName = "KeyComparer";

		// Token: 0x040038FF RID: 14591
		private Hashtable.bucket[] _buckets;

		// Token: 0x04003900 RID: 14592
		private int _count;

		// Token: 0x04003901 RID: 14593
		private int _occupancy;

		// Token: 0x04003902 RID: 14594
		private int _loadsize;

		// Token: 0x04003903 RID: 14595
		private float _loadFactor;

		// Token: 0x04003904 RID: 14596
		private volatile int _version;

		// Token: 0x04003905 RID: 14597
		private volatile bool _isWriterInProgress;

		// Token: 0x04003906 RID: 14598
		private ICollection _keys;

		// Token: 0x04003907 RID: 14599
		private ICollection _values;

		// Token: 0x04003908 RID: 14600
		private IEqualityComparer _keycomparer;

		// Token: 0x04003909 RID: 14601
		private object _syncRoot;

		// Token: 0x0400390A RID: 14602
		private static ConditionalWeakTable<object, SerializationInfo> s_serializationInfoTable;

		// Token: 0x02000A49 RID: 2633
		private struct bucket
		{
			// Token: 0x0400390B RID: 14603
			public object key;

			// Token: 0x0400390C RID: 14604
			public object val;

			// Token: 0x0400390D RID: 14605
			public int hash_coll;
		}

		// Token: 0x02000A4A RID: 2634
		[Serializable]
		private class KeyCollection : ICollection, IEnumerable
		{
			// Token: 0x06005E7D RID: 24189 RVA: 0x0013D8CA File Offset: 0x0013BACA
			internal KeyCollection(Hashtable hashtable)
			{
				this._hashtable = hashtable;
			}

			// Token: 0x06005E7E RID: 24190 RVA: 0x0013D8DC File Offset: 0x0013BADC
			public virtual void CopyTo(Array array, int arrayIndex)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (array.Rank != 1)
				{
					throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
				}
				if (arrayIndex < 0)
				{
					throw new ArgumentOutOfRangeException("arrayIndex", "Non-negative number required.");
				}
				if (array.Length - arrayIndex < this._hashtable._count)
				{
					throw new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
				}
				this._hashtable.CopyKeys(array, arrayIndex);
			}

			// Token: 0x06005E7F RID: 24191 RVA: 0x0013D951 File Offset: 0x0013BB51
			public virtual IEnumerator GetEnumerator()
			{
				return new Hashtable.HashtableEnumerator(this._hashtable, 1);
			}

			// Token: 0x17001081 RID: 4225
			// (get) Token: 0x06005E80 RID: 24192 RVA: 0x0013D95F File Offset: 0x0013BB5F
			public virtual bool IsSynchronized
			{
				get
				{
					return this._hashtable.IsSynchronized;
				}
			}

			// Token: 0x17001082 RID: 4226
			// (get) Token: 0x06005E81 RID: 24193 RVA: 0x0013D96C File Offset: 0x0013BB6C
			public virtual object SyncRoot
			{
				get
				{
					return this._hashtable.SyncRoot;
				}
			}

			// Token: 0x17001083 RID: 4227
			// (get) Token: 0x06005E82 RID: 24194 RVA: 0x0013D979 File Offset: 0x0013BB79
			public virtual int Count
			{
				get
				{
					return this._hashtable._count;
				}
			}

			// Token: 0x0400390E RID: 14606
			private Hashtable _hashtable;
		}

		// Token: 0x02000A4B RID: 2635
		[Serializable]
		private class ValueCollection : ICollection, IEnumerable
		{
			// Token: 0x06005E83 RID: 24195 RVA: 0x0013D986 File Offset: 0x0013BB86
			internal ValueCollection(Hashtable hashtable)
			{
				this._hashtable = hashtable;
			}

			// Token: 0x06005E84 RID: 24196 RVA: 0x0013D998 File Offset: 0x0013BB98
			public virtual void CopyTo(Array array, int arrayIndex)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (array.Rank != 1)
				{
					throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
				}
				if (arrayIndex < 0)
				{
					throw new ArgumentOutOfRangeException("arrayIndex", "Non-negative number required.");
				}
				if (array.Length - arrayIndex < this._hashtable._count)
				{
					throw new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
				}
				this._hashtable.CopyValues(array, arrayIndex);
			}

			// Token: 0x06005E85 RID: 24197 RVA: 0x0013DA0D File Offset: 0x0013BC0D
			public virtual IEnumerator GetEnumerator()
			{
				return new Hashtable.HashtableEnumerator(this._hashtable, 2);
			}

			// Token: 0x17001084 RID: 4228
			// (get) Token: 0x06005E86 RID: 24198 RVA: 0x0013DA1B File Offset: 0x0013BC1B
			public virtual bool IsSynchronized
			{
				get
				{
					return this._hashtable.IsSynchronized;
				}
			}

			// Token: 0x17001085 RID: 4229
			// (get) Token: 0x06005E87 RID: 24199 RVA: 0x0013DA28 File Offset: 0x0013BC28
			public virtual object SyncRoot
			{
				get
				{
					return this._hashtable.SyncRoot;
				}
			}

			// Token: 0x17001086 RID: 4230
			// (get) Token: 0x06005E88 RID: 24200 RVA: 0x0013DA35 File Offset: 0x0013BC35
			public virtual int Count
			{
				get
				{
					return this._hashtable._count;
				}
			}

			// Token: 0x0400390F RID: 14607
			private Hashtable _hashtable;
		}

		// Token: 0x02000A4C RID: 2636
		[Serializable]
		private class SyncHashtable : Hashtable, IEnumerable
		{
			// Token: 0x06005E89 RID: 24201 RVA: 0x0013DA42 File Offset: 0x0013BC42
			internal SyncHashtable(Hashtable table) : base(false)
			{
				this._table = table;
			}

			// Token: 0x06005E8A RID: 24202 RVA: 0x0013DA52 File Offset: 0x0013BC52
			internal SyncHashtable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005E8B RID: 24203 RVA: 0x0001B98B File Offset: 0x00019B8B
			public override void GetObjectData(SerializationInfo info, StreamingContext context)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x17001087 RID: 4231
			// (get) Token: 0x06005E8C RID: 24204 RVA: 0x0013DA61 File Offset: 0x0013BC61
			public override int Count
			{
				get
				{
					return this._table.Count;
				}
			}

			// Token: 0x17001088 RID: 4232
			// (get) Token: 0x06005E8D RID: 24205 RVA: 0x0013DA6E File Offset: 0x0013BC6E
			public override bool IsReadOnly
			{
				get
				{
					return this._table.IsReadOnly;
				}
			}

			// Token: 0x17001089 RID: 4233
			// (get) Token: 0x06005E8E RID: 24206 RVA: 0x0013DA7B File Offset: 0x0013BC7B
			public override bool IsFixedSize
			{
				get
				{
					return this._table.IsFixedSize;
				}
			}

			// Token: 0x1700108A RID: 4234
			// (get) Token: 0x06005E8F RID: 24207 RVA: 0x000040F7 File Offset: 0x000022F7
			public override bool IsSynchronized
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700108B RID: 4235
			public override object this[object key]
			{
				get
				{
					return this._table[key];
				}
				set
				{
					object syncRoot = this._table.SyncRoot;
					lock (syncRoot)
					{
						this._table[key] = value;
					}
				}
			}

			// Token: 0x1700108C RID: 4236
			// (get) Token: 0x06005E92 RID: 24210 RVA: 0x0013DAE4 File Offset: 0x0013BCE4
			public override object SyncRoot
			{
				get
				{
					return this._table.SyncRoot;
				}
			}

			// Token: 0x06005E93 RID: 24211 RVA: 0x0013DAF4 File Offset: 0x0013BCF4
			public override void Add(object key, object value)
			{
				object syncRoot = this._table.SyncRoot;
				lock (syncRoot)
				{
					this._table.Add(key, value);
				}
			}

			// Token: 0x06005E94 RID: 24212 RVA: 0x0013DB40 File Offset: 0x0013BD40
			public override void Clear()
			{
				object syncRoot = this._table.SyncRoot;
				lock (syncRoot)
				{
					this._table.Clear();
				}
			}

			// Token: 0x06005E95 RID: 24213 RVA: 0x0013DB8C File Offset: 0x0013BD8C
			public override bool Contains(object key)
			{
				return this._table.Contains(key);
			}

			// Token: 0x06005E96 RID: 24214 RVA: 0x0013DB9A File Offset: 0x0013BD9A
			public override bool ContainsKey(object key)
			{
				if (key == null)
				{
					throw new ArgumentNullException("key", "Key cannot be null.");
				}
				return this._table.ContainsKey(key);
			}

			// Token: 0x06005E97 RID: 24215 RVA: 0x0013DBBC File Offset: 0x0013BDBC
			public override bool ContainsValue(object key)
			{
				object syncRoot = this._table.SyncRoot;
				bool result;
				lock (syncRoot)
				{
					result = this._table.ContainsValue(key);
				}
				return result;
			}

			// Token: 0x06005E98 RID: 24216 RVA: 0x0013DC0C File Offset: 0x0013BE0C
			public override void CopyTo(Array array, int arrayIndex)
			{
				object syncRoot = this._table.SyncRoot;
				lock (syncRoot)
				{
					this._table.CopyTo(array, arrayIndex);
				}
			}

			// Token: 0x06005E99 RID: 24217 RVA: 0x0013DC58 File Offset: 0x0013BE58
			public override object Clone()
			{
				object syncRoot = this._table.SyncRoot;
				object result;
				lock (syncRoot)
				{
					result = Hashtable.Synchronized((Hashtable)this._table.Clone());
				}
				return result;
			}

			// Token: 0x06005E9A RID: 24218 RVA: 0x0013DCB0 File Offset: 0x0013BEB0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this._table.GetEnumerator();
			}

			// Token: 0x06005E9B RID: 24219 RVA: 0x0013DCB0 File Offset: 0x0013BEB0
			public override IDictionaryEnumerator GetEnumerator()
			{
				return this._table.GetEnumerator();
			}

			// Token: 0x1700108D RID: 4237
			// (get) Token: 0x06005E9C RID: 24220 RVA: 0x0013DCC0 File Offset: 0x0013BEC0
			public override ICollection Keys
			{
				get
				{
					object syncRoot = this._table.SyncRoot;
					ICollection keys;
					lock (syncRoot)
					{
						keys = this._table.Keys;
					}
					return keys;
				}
			}

			// Token: 0x1700108E RID: 4238
			// (get) Token: 0x06005E9D RID: 24221 RVA: 0x0013DD0C File Offset: 0x0013BF0C
			public override ICollection Values
			{
				get
				{
					object syncRoot = this._table.SyncRoot;
					ICollection values;
					lock (syncRoot)
					{
						values = this._table.Values;
					}
					return values;
				}
			}

			// Token: 0x06005E9E RID: 24222 RVA: 0x0013DD58 File Offset: 0x0013BF58
			public override void Remove(object key)
			{
				object syncRoot = this._table.SyncRoot;
				lock (syncRoot)
				{
					this._table.Remove(key);
				}
			}

			// Token: 0x06005E9F RID: 24223 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public override void OnDeserialization(object sender)
			{
			}

			// Token: 0x06005EA0 RID: 24224 RVA: 0x0013DDA4 File Offset: 0x0013BFA4
			internal override KeyValuePairs[] ToKeyValuePairsArray()
			{
				return this._table.ToKeyValuePairsArray();
			}

			// Token: 0x04003910 RID: 14608
			protected Hashtable _table;
		}

		// Token: 0x02000A4D RID: 2637
		[Serializable]
		private class HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
		{
			// Token: 0x06005EA1 RID: 24225 RVA: 0x0013DDB1 File Offset: 0x0013BFB1
			internal HashtableEnumerator(Hashtable hashtable, int getObjRetType)
			{
				this._hashtable = hashtable;
				this._bucket = hashtable._buckets.Length;
				this._version = hashtable._version;
				this._current = false;
				this._getObjectRetType = getObjRetType;
			}

			// Token: 0x06005EA2 RID: 24226 RVA: 0x000231CD File Offset: 0x000213CD
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x1700108F RID: 4239
			// (get) Token: 0x06005EA3 RID: 24227 RVA: 0x0013DDEA File Offset: 0x0013BFEA
			public virtual object Key
			{
				get
				{
					if (!this._current)
					{
						throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
					}
					return this._currentKey;
				}
			}

			// Token: 0x06005EA4 RID: 24228 RVA: 0x0013DE08 File Offset: 0x0013C008
			public virtual bool MoveNext()
			{
				if (this._version != this._hashtable._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				while (this._bucket > 0)
				{
					this._bucket--;
					object key = this._hashtable._buckets[this._bucket].key;
					if (key != null && key != this._hashtable._buckets)
					{
						this._currentKey = key;
						this._currentValue = this._hashtable._buckets[this._bucket].val;
						this._current = true;
						return true;
					}
				}
				this._current = false;
				return false;
			}

			// Token: 0x17001090 RID: 4240
			// (get) Token: 0x06005EA5 RID: 24229 RVA: 0x0013DEB2 File Offset: 0x0013C0B2
			public virtual DictionaryEntry Entry
			{
				get
				{
					if (!this._current)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return new DictionaryEntry(this._currentKey, this._currentValue);
				}
			}

			// Token: 0x17001091 RID: 4241
			// (get) Token: 0x06005EA6 RID: 24230 RVA: 0x0013DED8 File Offset: 0x0013C0D8
			public virtual object Current
			{
				get
				{
					if (!this._current)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					if (this._getObjectRetType == 1)
					{
						return this._currentKey;
					}
					if (this._getObjectRetType == 2)
					{
						return this._currentValue;
					}
					return new DictionaryEntry(this._currentKey, this._currentValue);
				}
			}

			// Token: 0x17001092 RID: 4242
			// (get) Token: 0x06005EA7 RID: 24231 RVA: 0x0013DF2E File Offset: 0x0013C12E
			public virtual object Value
			{
				get
				{
					if (!this._current)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return this._currentValue;
				}
			}

			// Token: 0x06005EA8 RID: 24232 RVA: 0x0013DF4C File Offset: 0x0013C14C
			public virtual void Reset()
			{
				if (this._version != this._hashtable._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				this._current = false;
				this._bucket = this._hashtable._buckets.Length;
				this._currentKey = null;
				this._currentValue = null;
			}

			// Token: 0x04003911 RID: 14609
			private Hashtable _hashtable;

			// Token: 0x04003912 RID: 14610
			private int _bucket;

			// Token: 0x04003913 RID: 14611
			private int _version;

			// Token: 0x04003914 RID: 14612
			private bool _current;

			// Token: 0x04003915 RID: 14613
			private int _getObjectRetType;

			// Token: 0x04003916 RID: 14614
			private object _currentKey;

			// Token: 0x04003917 RID: 14615
			private object _currentValue;

			// Token: 0x04003918 RID: 14616
			internal const int Keys = 1;

			// Token: 0x04003919 RID: 14617
			internal const int Values = 2;

			// Token: 0x0400391A RID: 14618
			internal const int DictEntry = 3;
		}

		// Token: 0x02000A4E RID: 2638
		internal class HashtableDebugView
		{
			// Token: 0x06005EA9 RID: 24233 RVA: 0x0013DFA1 File Offset: 0x0013C1A1
			public HashtableDebugView(Hashtable hashtable)
			{
				if (hashtable == null)
				{
					throw new ArgumentNullException("hashtable");
				}
				this._hashtable = hashtable;
			}

			// Token: 0x17001093 RID: 4243
			// (get) Token: 0x06005EAA RID: 24234 RVA: 0x0013DFBE File Offset: 0x0013C1BE
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public KeyValuePairs[] Items
			{
				get
				{
					return this._hashtable.ToKeyValuePairsArray();
				}
			}

			// Token: 0x0400391B RID: 14619
			private Hashtable _hashtable;
		}
	}
}
