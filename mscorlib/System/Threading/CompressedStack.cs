using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using Unity;

namespace System.Threading
{
	/// <summary>Обеспечивает методы для установки и инициализации сжатого стека в текущем потоке. Этот класс не наследуется.</summary>
	// Token: 0x020002ED RID: 749
	[Serializable]
	public sealed class CompressedStack : ISerializable
	{
		// Token: 0x0600209D RID: 8349 RVA: 0x000768DC File Offset: 0x00074ADC
		internal CompressedStack(int length)
		{
			if (length > 0)
			{
				this._list = new ArrayList(length);
			}
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x000768F4 File Offset: 0x00074AF4
		internal CompressedStack(CompressedStack cs)
		{
			if (cs != null && cs._list != null)
			{
				this._list = (ArrayList)cs._list.Clone();
			}
		}

		/// <summary>Создает копию текущего сжатого стека.</summary>
		/// <returns>Объект <see cref="T:System.Threading.CompressedStack" />, представляющий текущий сжатый стек.</returns>
		// Token: 0x0600209F RID: 8351 RVA: 0x0007691D File Offset: 0x00074B1D
		[ComVisible(false)]
		public CompressedStack CreateCopy()
		{
			return new CompressedStack(this);
		}

		/// <summary>Перехватывает сжатый стек из текущего потока.</summary>
		/// <returns>Объект <see cref="T:System.Threading.CompressedStack" />.</returns>
		// Token: 0x060020A0 RID: 8352 RVA: 0x000472C8 File Offset: 0x000454C8
		public static CompressedStack Capture()
		{
			throw new NotSupportedException();
		}

		/// <summary>Возвращает сжатый стек для текущего потока.</summary>
		/// <returns>
		///   <see cref="T:System.Threading.CompressedStack" /> для текущего потока.</returns>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.  
		/// -или- 
		/// Запрос для <see cref="T:System.Security.Permissions.StrongNameIdentityPermission" /> не прошел.</exception>
		// Token: 0x060020A1 RID: 8353 RVA: 0x000472C8 File Offset: 0x000454C8
		[SecurityCritical]
		public static CompressedStack GetCompressedStack()
		{
			throw new NotSupportedException();
		}

		/// <summary>Задает объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с информацией логического контекста, необходимой для повторного создания экземпляра данного контекста выполнения.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который будет заполняться сведениями о сериализации.</param>
		/// <param name="context">Структура <see cref="T:System.Runtime.Serialization.StreamingContext" />, представляющая контекст назначения сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060020A2 RID: 8354 RVA: 0x0005D900 File Offset: 0x0005BB00
		[MonoTODO("incomplete")]
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
		}

		/// <summary>Выполняет метод в заданном сжатом стеке в текущем потоке.</summary>
		/// <param name="compressedStack">Записываемая задача <see cref="T:System.Threading.CompressedStack" />.</param>
		/// <param name="callback">
		///   <see cref="T:System.Threading.ContextCallback" />, который представляет метод для выполнения в заданном контексте безопасности.</param>
		/// <param name="state">Данный объект передается в метод обратного вызова.</param>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="compressedStack" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060020A3 RID: 8355 RVA: 0x000472C8 File Offset: 0x000454C8
		[SecurityCritical]
		public static void Run(CompressedStack compressedStack, ContextCallback callback, object state)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x00076925 File Offset: 0x00074B25
		internal bool Equals(CompressedStack cs)
		{
			if (this.IsEmpty())
			{
				return cs.IsEmpty();
			}
			return !cs.IsEmpty() && this._list.Count == cs._list.Count;
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x0007695B File Offset: 0x00074B5B
		internal bool IsEmpty()
		{
			return this._list == null || this._list.Count == 0;
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x00076975 File Offset: 0x00074B75
		internal IList List
		{
			get
			{
				return this._list;
			}
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x000173AD File Offset: 0x000155AD
		internal CompressedStack()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001B6B RID: 7019
		private ArrayList _list;
	}
}
