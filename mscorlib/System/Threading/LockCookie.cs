using System;
using System.Runtime.InteropServices;

namespace System.Threading
{
	/// <summary>Определяет блокировку, которая реализует семантику "один записывающий / много читающих". Это тип значения.</summary>
	// Token: 0x020002F1 RID: 753
	[ComVisible(true)]
	public struct LockCookie
	{
		// Token: 0x060020CE RID: 8398 RVA: 0x00076A8E File Offset: 0x00074C8E
		internal LockCookie(int thread_id)
		{
			this.ThreadId = thread_id;
			this.ReaderLocks = 0;
			this.WriterLocks = 0;
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00076AA5 File Offset: 0x00074CA5
		internal LockCookie(int thread_id, int reader_locks, int writer_locks)
		{
			this.ThreadId = thread_id;
			this.ReaderLocks = reader_locks;
			this.WriterLocks = writer_locks;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060020D0 RID: 8400 RVA: 0x00076ABC File Offset: 0x00074CBC
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Определяет равенство текущего экземпляра и указанного объекта <see cref="T:System.Threading.LockCookie" />.</summary>
		/// <param name="obj">
		///   <see cref="T:System.Threading.LockCookie" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно значению текущего экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060020D1 RID: 8401 RVA: 0x00076ACE File Offset: 0x00074CCE
		public bool Equals(LockCookie obj)
		{
			return this.ThreadId == obj.ThreadId && this.ReaderLocks == obj.ReaderLocks && this.WriterLocks == obj.WriterLocks;
		}

		/// <summary>Обозначает равенство указанного объекта и текущего экземпляра объекта <see cref="T:System.Threading.LockCookie" />.</summary>
		/// <param name="obj">Объект, сравниваемый с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно значению текущего экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060020D2 RID: 8402 RVA: 0x00076AFD File Offset: 0x00074CFD
		public override bool Equals(object obj)
		{
			return obj is LockCookie && obj.Equals(this);
		}

		/// <summary>Определяет равенство двух структур <see cref="T:System.Threading.LockCookie" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Threading.LockCookie" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Threading.LockCookie" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="a" /> и <paramref name="b" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060020D3 RID: 8403 RVA: 0x00076B1A File Offset: 0x00074D1A
		public static bool operator ==(LockCookie a, LockCookie b)
		{
			return a.Equals(b);
		}

		/// <summary>Указывает, действительно ли не равны две структуры <see cref="T:System.Threading.LockCookie" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Threading.LockCookie" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Threading.LockCookie" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="a" /> и <paramref name="b" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060020D4 RID: 8404 RVA: 0x00076B24 File Offset: 0x00074D24
		public static bool operator !=(LockCookie a, LockCookie b)
		{
			return !a.Equals(b);
		}

		// Token: 0x04001B6D RID: 7021
		internal int ThreadId;

		// Token: 0x04001B6E RID: 7022
		internal int ReaderLocks;

		// Token: 0x04001B6F RID: 7023
		internal int WriterLocks;
	}
}
