using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>Создает идентификаторы для объектов.</summary>
	// Token: 0x02000660 RID: 1632
	[ComVisible(true)]
	[Serializable]
	public class ObjectIDGenerator
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.ObjectIDGenerator" />.</summary>
		// Token: 0x06003CE5 RID: 15589 RVA: 0x000D2ACC File Offset: 0x000D0CCC
		public ObjectIDGenerator()
		{
			this.m_currentCount = 1;
			this.m_currentSize = ObjectIDGenerator.sizes[0];
			this.m_ids = new long[this.m_currentSize * 4];
			this.m_objs = new object[this.m_currentSize * 4];
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x000D2B1C File Offset: 0x000D0D1C
		private int FindElement(object obj, out bool found)
		{
			int num = RuntimeHelpers.GetHashCode(obj);
			int num2 = 1 + (num & int.MaxValue) % (this.m_currentSize - 2);
			int i;
			for (;;)
			{
				int num3 = (num & int.MaxValue) % this.m_currentSize * 4;
				for (i = num3; i < num3 + 4; i++)
				{
					if (this.m_objs[i] == null)
					{
						goto Block_1;
					}
					if (this.m_objs[i] == obj)
					{
						goto Block_2;
					}
				}
				num += num2;
			}
			Block_1:
			found = false;
			return i;
			Block_2:
			found = true;
			return i;
		}

		/// <summary>Возвращает идентификатор для заданного объекта, создавая новый идентификатор, если заданный объект уже не был идентифицирован <see cref="T:System.Runtime.Serialization.ObjectIDGenerator" />.</summary>
		/// <param name="obj">Объект, для которого необходим идентификатор.</param>
		/// <param name="firstTime">
		///   <see langword="true" />, если <paramref name="obj" /> не был ранее известен <see cref="T:System.Runtime.Serialization.ObjectIDGenerator" />; в противном случае — <see langword="false" />.</param>
		/// <returns>Идентификатор объекта используется для сериализации. Параметру <paramref name="firstTime" /> присваивается значение <see langword="true" />, если объект идентифицируется в первый раз; в противном случае присваивается значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="obj" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Сделан запрос <see cref="T:System.Runtime.Serialization.ObjectIDGenerator" /> для сохранения дорожек слишком большого количества объектов.</exception>
		// Token: 0x06003CE7 RID: 15591 RVA: 0x000D2B88 File Offset: 0x000D0D88
		public virtual long GetId(object obj, out bool firstTime)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj", Environment.GetResourceString("Object cannot be null."));
			}
			bool flag;
			int num = this.FindElement(obj, out flag);
			long result;
			if (!flag)
			{
				this.m_objs[num] = obj;
				long[] ids = this.m_ids;
				int num2 = num;
				int currentCount = this.m_currentCount;
				this.m_currentCount = currentCount + 1;
				ids[num2] = (long)currentCount;
				result = this.m_ids[num];
				if (this.m_currentCount > this.m_currentSize * 4 / 2)
				{
					this.Rehash();
				}
			}
			else
			{
				result = this.m_ids[num];
			}
			firstTime = !flag;
			return result;
		}

		/// <summary>Определяет, был ли объекту уже присвоен идентификатор.</summary>
		/// <param name="obj">Запрашиваемый объект.</param>
		/// <param name="firstTime">
		///   <see langword="true" />, если <paramref name="obj" /> не был ранее известен <see cref="T:System.Runtime.Serialization.ObjectIDGenerator" />; в противном случае — <see langword="false" />.</param>
		/// <returns>Идентификатор объекта имеет значение <paramref name="obj" />, если он был ранее известен <see cref="T:System.Runtime.Serialization.ObjectIDGenerator" />, в противном случае — ноль.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="obj" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003CE8 RID: 15592 RVA: 0x000D2C10 File Offset: 0x000D0E10
		public virtual long HasId(object obj, out bool firstTime)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj", Environment.GetResourceString("Object cannot be null."));
			}
			bool flag;
			int num = this.FindElement(obj, out flag);
			if (flag)
			{
				firstTime = false;
				return this.m_ids[num];
			}
			firstTime = true;
			return 0L;
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x000D2C54 File Offset: 0x000D0E54
		private void Rehash()
		{
			int num = 0;
			int currentSize = this.m_currentSize;
			while (num < ObjectIDGenerator.sizes.Length && ObjectIDGenerator.sizes[num] <= currentSize)
			{
				num++;
			}
			if (num == ObjectIDGenerator.sizes.Length)
			{
				throw new SerializationException(Environment.GetResourceString("The internal array cannot expand to greater than Int32.MaxValue elements."));
			}
			this.m_currentSize = ObjectIDGenerator.sizes[num];
			long[] ids = new long[this.m_currentSize * 4];
			object[] objs = new object[this.m_currentSize * 4];
			long[] ids2 = this.m_ids;
			object[] objs2 = this.m_objs;
			this.m_ids = ids;
			this.m_objs = objs;
			for (int i = 0; i < objs2.Length; i++)
			{
				if (objs2[i] != null)
				{
					bool flag;
					int num2 = this.FindElement(objs2[i], out flag);
					this.m_objs[num2] = objs2[i];
					this.m_ids[num2] = ids2[i];
				}
			}
		}

		// Token: 0x0400273C RID: 10044
		private const int numbins = 4;

		// Token: 0x0400273D RID: 10045
		internal int m_currentCount;

		// Token: 0x0400273E RID: 10046
		internal int m_currentSize;

		// Token: 0x0400273F RID: 10047
		internal long[] m_ids;

		// Token: 0x04002740 RID: 10048
		internal object[] m_objs;

		// Token: 0x04002741 RID: 10049
		private static readonly int[] sizes = new int[]
		{
			5,
			11,
			29,
			47,
			97,
			197,
			397,
			797,
			1597,
			3203,
			6421,
			12853,
			25717,
			51437,
			102877,
			205759,
			411527,
			823117,
			1646237,
			3292489,
			6584983
		};
	}
}
