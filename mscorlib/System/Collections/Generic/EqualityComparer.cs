using System;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Collections.Generic
{
	/// <summary>Представляет базовый класс для реализаций универсального интерфейса <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
	/// <typeparam name="T">Тип объектов для сравнения.</typeparam>
	// Token: 0x02000AC5 RID: 2757
	[TypeDependency("System.Collections.Generic.ObjectEqualityComparer`1")]
	[Serializable]
	public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T>
	{
		/// <summary>Возвращает компаратор для типа, указанного универсальным аргументом.</summary>
		/// <returns>Экземпляр по умолчанию класса <see cref="T:System.Collections.Generic.EqualityComparer`1" /> для типа <typeparamref name="T" />.</returns>
		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x06006288 RID: 25224 RVA: 0x00149D44 File Offset: 0x00147F44
		public static EqualityComparer<T> Default
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				EqualityComparer<T> equalityComparer = EqualityComparer<T>.defaultComparer;
				if (equalityComparer == null)
				{
					equalityComparer = EqualityComparer<T>.CreateComparer();
					EqualityComparer<T>.defaultComparer = equalityComparer;
				}
				return equalityComparer;
			}
		}

		// Token: 0x06006289 RID: 25225 RVA: 0x00149D6C File Offset: 0x00147F6C
		[SecuritySafeCritical]
		private static EqualityComparer<T> CreateComparer()
		{
			RuntimeType runtimeType = (RuntimeType)typeof(T);
			if (runtimeType == typeof(byte))
			{
				return (EqualityComparer<T>)new ByteEqualityComparer();
			}
			if (typeof(IEquatable<T>).IsAssignableFrom(runtimeType))
			{
				return (EqualityComparer<T>)RuntimeType.CreateInstanceForAnotherGenericParameter(typeof(GenericEqualityComparer<>), runtimeType);
			}
			if (runtimeType.IsGenericType && runtimeType.GetGenericTypeDefinition() == typeof(Nullable<>))
			{
				RuntimeType runtimeType2 = (RuntimeType)runtimeType.GetGenericArguments()[0];
				if (typeof(IEquatable<>).MakeGenericType(new Type[]
				{
					runtimeType2
				}).IsAssignableFrom(runtimeType2))
				{
					return (EqualityComparer<T>)RuntimeType.CreateInstanceForAnotherGenericParameter(typeof(NullableEqualityComparer<>), runtimeType2);
				}
			}
			if (runtimeType.IsEnum)
			{
				switch (Type.GetTypeCode(Enum.GetUnderlyingType(runtimeType)))
				{
				case TypeCode.SByte:
					return (EqualityComparer<T>)RuntimeType.CreateInstanceForAnotherGenericParameter(typeof(SByteEnumEqualityComparer<>), runtimeType);
				case TypeCode.Byte:
				case TypeCode.UInt16:
				case TypeCode.Int32:
				case TypeCode.UInt32:
					return (EqualityComparer<T>)RuntimeType.CreateInstanceForAnotherGenericParameter(typeof(EnumEqualityComparer<>), runtimeType);
				case TypeCode.Int16:
					return (EqualityComparer<T>)RuntimeType.CreateInstanceForAnotherGenericParameter(typeof(ShortEnumEqualityComparer<>), runtimeType);
				case TypeCode.Int64:
				case TypeCode.UInt64:
					return (EqualityComparer<T>)RuntimeType.CreateInstanceForAnotherGenericParameter(typeof(LongEnumEqualityComparer<>), runtimeType);
				}
			}
			return new ObjectEqualityComparer<T>();
		}

		/// <summary>При переопределении в производном классе определяет, равны ли два объекта типа <typeparamref name="T" />.</summary>
		/// <param name="x">Первый из сравниваемых объектов.</param>
		/// <param name="y">Второй из сравниваемых объектов.</param>
		/// <returns>
		///   <see langword="true" />, если указанные объекты равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600628A RID: 25226
		public abstract bool Equals(T x, T y);

		/// <summary>При переопределении в производном классе служит хэш-функцией для указанного объекта для алгоритмов хэширования и структур данных, например хэш-таблицы.</summary>
		/// <param name="obj">Объект, для которого нужно получить хэш-код.</param>
		/// <returns>Хэш-код указанного объекта.</returns>
		/// <exception cref="T:System.ArgumentNullException">Тип <paramref name="obj" /> является ссылочным типом и <paramref name="obj" /> — <see langword="null" />.</exception>
		// Token: 0x0600628B RID: 25227
		public abstract int GetHashCode(T obj);

		// Token: 0x0600628C RID: 25228 RVA: 0x00149ED0 File Offset: 0x001480D0
		internal virtual int IndexOf(T[] array, T value, int startIndex, int count)
		{
			int num = startIndex + count;
			for (int i = startIndex; i < num; i++)
			{
				if (this.Equals(array[i], value))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600628D RID: 25229 RVA: 0x00149F04 File Offset: 0x00148104
		internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count)
		{
			int num = startIndex - count + 1;
			for (int i = startIndex; i >= num; i--)
			{
				if (this.Equals(array[i], value))
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>Возвращает хэш-код указанного объекта.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" />, для которого необходимо вернуть хэш-код.</param>
		/// <returns>Хэш-код указанного объекта.</returns>
		/// <exception cref="T:System.ArgumentNullException">Тип <paramref name="obj" /> является ссылочным типом и <paramref name="obj" /> — <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="obj" /> имеет тип, который не может быть приведен к типу <typeparamref name="T" />.</exception>
		// Token: 0x0600628E RID: 25230 RVA: 0x00149F37 File Offset: 0x00148137
		int IEqualityComparer.GetHashCode(object obj)
		{
			if (obj == null)
			{
				return 0;
			}
			if (obj is T)
			{
				return this.GetHashCode((T)((object)obj));
			}
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArgumentForComparison);
			return 0;
		}

		/// <summary>Определяет, равны ли два указанных объекта.</summary>
		/// <param name="x">Первый из сравниваемых объектов.</param>
		/// <param name="y">Второй из сравниваемых объектов.</param>
		/// <returns>
		///   <see langword="true" />, если указанные объекты равны; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="x" /> или <paramref name="y" /> имеет тип, который не может быть приведен к типу <typeparamref name="T" />.</exception>
		// Token: 0x0600628F RID: 25231 RVA: 0x00149F5A File Offset: 0x0014815A
		bool IEqualityComparer.Equals(object x, object y)
		{
			if (x == y)
			{
				return true;
			}
			if (x == null || y == null)
			{
				return false;
			}
			if (x is T && y is T)
			{
				return this.Equals((T)((object)x), (T)((object)y));
			}
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArgumentForComparison);
			return false;
		}

		// Token: 0x04003A36 RID: 14902
		private static volatile EqualityComparer<T> defaultComparer;
	}
}
