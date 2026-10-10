using System;

namespace System.Threading
{
	/// <summary>Обеспечивает процедуры инициализации адаптирующегося типа.</summary>
	// Token: 0x0200028E RID: 654
	public static class LazyInitializer
	{
		/// <summary>Инициализирует целевой ссылочный тип его конструктором типа по умолчанию, если он еще не инициализирован.</summary>
		/// <param name="target">Ссылка типа T, которую необходимо инициализировать, если она еще не инициализирована.</param>
		/// <typeparam name="T">Тип инициализируемой ссылки.</typeparam>
		/// <returns>Инициализируемая ссылка типа <paramref name="T" />.</returns>
		/// <exception cref="T:System.MemberAccessException">Разрешения на доступ к конструктору типа <paramref name="T" /> отсутствовали.</exception>
		/// <exception cref="T:System.MissingMemberException">Тип <paramref name="T" /> не имеет конструктора по умолчанию.</exception>
		// Token: 0x06001D7B RID: 7547 RVA: 0x0006E426 File Offset: 0x0006C626
		public static T EnsureInitialized<T>(ref T target) where T : class
		{
			T result;
			if ((result = Volatile.Read<T>(ref target)) == null)
			{
				result = LazyInitializer.EnsureInitializedCore<T>(ref target);
			}
			return result;
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x0006E440 File Offset: 0x0006C640
		private static T EnsureInitializedCore<T>(ref T target) where T : class
		{
			try
			{
				Interlocked.CompareExchange<T>(ref target, Activator.CreateInstance<T>(), default(T));
			}
			catch (MissingMethodException)
			{
				throw new MissingMemberException("The lazily-initialized type does not have a public, parameterless constructor.");
			}
			return target;
		}

		/// <summary>Инициализирует целевой ссылочный тип с использованием указанной функцией, если он еще не инициализирован.</summary>
		/// <param name="target">Ссылка типа T, которую необходимо инициализировать, если она еще не инициализирована.</param>
		/// <param name="valueFactory">Функция, которая вызывается для инициализации ссылки.</param>
		/// <typeparam name="T">Ссылочный тип инициализируемой ссылки.</typeparam>
		/// <returns>Инициализированное значение типа <paramref name="T" />.</returns>
		/// <exception cref="T:System.MissingMemberException">Тип <paramref name="T" /> не имеет конструктора по умолчанию.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="valueFactory" /> вернул значение NULL (Nothing в Visual Basic).</exception>
		// Token: 0x06001D7D RID: 7549 RVA: 0x0006E488 File Offset: 0x0006C688
		public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) where T : class
		{
			T result;
			if ((result = Volatile.Read<T>(ref target)) == null)
			{
				result = LazyInitializer.EnsureInitializedCore<T>(ref target, valueFactory);
			}
			return result;
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x0006E4A0 File Offset: 0x0006C6A0
		private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) where T : class
		{
			T t = valueFactory();
			if (t == null)
			{
				throw new InvalidOperationException("ValueFactory returned null.");
			}
			Interlocked.CompareExchange<T>(ref target, t, default(T));
			return target;
		}

		/// <summary>Инициализирует целевой ссылочный тип или тип значения его конструктором по умолчанию, если он еще не инициализирован.</summary>
		/// <param name="target">Ссылка или значение типа T, которое необходимо инициализировать, если оно еще не инициализировано.</param>
		/// <param name="initialized">Ссылка на логическое значение, определяющее, инициализирована ли цель.</param>
		/// <param name="syncLock">Ссылка на объект, используемый как взаимоисключающая блокировка для инициализации параметра <paramref name="target" />. Если <paramref name="syncLock" /> равно <see langword="null" />, то нового объект будет создан экземпляр.</param>
		/// <typeparam name="T">Тип инициализируемой ссылки.</typeparam>
		/// <returns>Инициализированное значение типа <paramref name="T" />.</returns>
		/// <exception cref="T:System.MemberAccessException">Разрешения на доступ к конструктору типа <paramref name="T" /> отсутствовали.</exception>
		/// <exception cref="T:System.MissingMemberException">Тип <paramref name="T" /> не имеет конструктора по умолчанию.</exception>
		// Token: 0x06001D7F RID: 7551 RVA: 0x0006E4DE File Offset: 0x0006C6DE
		public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock)
		{
			if (Volatile.Read(ref initialized))
			{
				return target;
			}
			return LazyInitializer.EnsureInitializedCore<T>(ref target, ref initialized, ref syncLock);
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x0006E4F8 File Offset: 0x0006C6F8
		private static T EnsureInitializedCore<T>(ref T target, ref bool initialized, ref object syncLock)
		{
			object obj = LazyInitializer.EnsureLockInitialized(ref syncLock);
			lock (obj)
			{
				if (!Volatile.Read(ref initialized))
				{
					try
					{
						target = Activator.CreateInstance<T>();
					}
					catch (MissingMethodException)
					{
						throw new MissingMemberException("The lazily-initialized type does not have a public, parameterless constructor.");
					}
					Volatile.Write(ref initialized, true);
				}
			}
			return target;
		}

		/// <summary>Инициализирует целевой ссылочный тип или тип значения с использованием указанной функцией, если он еще не инициализирован.</summary>
		/// <param name="target">Ссылка или значение типа T, которое необходимо инициализировать, если оно еще не инициализировано.</param>
		/// <param name="initialized">Ссылка на логическое значение, определяющее, инициализирована ли цель.</param>
		/// <param name="syncLock">Ссылка на объект, используемый как взаимоисключающая блокировка для инициализации параметра <paramref name="target" />. Если <paramref name="syncLock" /> равно <see langword="null" />, то нового объект будет создан экземпляр.</param>
		/// <param name="valueFactory">Функция, которая вызывается для инициализации ссылки или значения.</param>
		/// <typeparam name="T">Тип инициализируемой ссылки.</typeparam>
		/// <returns>Инициализированное значение типа <paramref name="T" />.</returns>
		/// <exception cref="T:System.MemberAccessException">Разрешения на доступ к конструктору типа <paramref name="T" /> отсутствовали.</exception>
		/// <exception cref="T:System.MissingMemberException">Тип <paramref name="T" /> не имеет конструктора по умолчанию.</exception>
		// Token: 0x06001D81 RID: 7553 RVA: 0x0006E56C File Offset: 0x0006C76C
		public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory)
		{
			if (Volatile.Read(ref initialized))
			{
				return target;
			}
			return LazyInitializer.EnsureInitializedCore<T>(ref target, ref initialized, ref syncLock, valueFactory);
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x0006E588 File Offset: 0x0006C788
		private static T EnsureInitializedCore<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory)
		{
			object obj = LazyInitializer.EnsureLockInitialized(ref syncLock);
			lock (obj)
			{
				if (!Volatile.Read(ref initialized))
				{
					target = valueFactory();
					Volatile.Write(ref initialized, true);
				}
			}
			return target;
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x0006E5E4 File Offset: 0x0006C7E4
		public static T EnsureInitialized<T>(ref T target, ref object syncLock, Func<T> valueFactory) where T : class
		{
			T result;
			if ((result = Volatile.Read<T>(ref target)) == null)
			{
				result = LazyInitializer.EnsureInitializedCore<T>(ref target, ref syncLock, valueFactory);
			}
			return result;
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x0006E600 File Offset: 0x0006C800
		private static T EnsureInitializedCore<T>(ref T target, ref object syncLock, Func<T> valueFactory) where T : class
		{
			object obj = LazyInitializer.EnsureLockInitialized(ref syncLock);
			lock (obj)
			{
				if (Volatile.Read<T>(ref target) == null)
				{
					Volatile.Write<T>(ref target, valueFactory());
					if (target == null)
					{
						throw new InvalidOperationException("ValueFactory returned null.");
					}
				}
			}
			return target;
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x0006E674 File Offset: 0x0006C874
		private static object EnsureLockInitialized(ref object syncLock)
		{
			object result;
			if ((result = syncLock) == null)
			{
				result = (Interlocked.CompareExchange(ref syncLock, new object(), null) ?? syncLock);
			}
			return result;
		}
	}
}
