using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Представляет обработчик исключений в массиве байтов IL для передачи методу, такому как <see cref="M:System.Reflection.Emit.MethodBuilder.SetMethodBody(System.Byte[],System.Int32,System.Byte[],System.Collections.Generic.IEnumerable{System.Reflection.Emit.ExceptionHandler},System.Collections.Generic.IEnumerable{System.Int32})" />.</summary>
	// Token: 0x0200090B RID: 2315
	[ComVisible(false)]
	public readonly struct ExceptionHandler : IEquatable<ExceptionHandler>
	{
		/// <summary>Получает токен типа исключения, обрабатываемого данным обработчиком.</summary>
		/// <returns>Токен типа исключения, обрабатываемого этим обработчиком, или 0, если такового не существует.</returns>
		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06004E4F RID: 20047 RVA: 0x000F615F File Offset: 0x000F435F
		public int ExceptionTypeToken
		{
			get
			{
				return this.m_exceptionClass;
			}
		}

		/// <summary>Получает смещение в байтах, с которого начинается код, защищенный данным исключением.</summary>
		/// <returns>Смещение в байтах, с которого начинается код, защищенный данным обработчиком исключений.</returns>
		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06004E50 RID: 20048 RVA: 0x000F6167 File Offset: 0x000F4367
		public int TryOffset
		{
			get
			{
				return this.m_tryStartOffset;
			}
		}

		/// <summary>Получает длину (в байтах) кода, защищенного этим обработчиком исключений.</summary>
		/// <returns>Длина кода (в байтах), защищенного этим обработчиком исключений.</returns>
		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06004E51 RID: 20049 RVA: 0x000F616F File Offset: 0x000F436F
		public int TryLength
		{
			get
			{
				return this.m_tryEndOffset - this.m_tryStartOffset;
			}
		}

		/// <summary>Получает смещение в байтах, с которого начинается код фильтра для обработчика исключения.</summary>
		/// <returns>Смещение байтов, с которого начинается код фильтра, или 0, если фильтр не присутствует.</returns>
		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06004E52 RID: 20050 RVA: 0x000F617E File Offset: 0x000F437E
		public int FilterOffset
		{
			get
			{
				return this.m_filterOffset;
			}
		}

		/// <summary>Получает смещение в байтах первой инструкции обработчика исключений.</summary>
		/// <returns>Смещение в байтах первой инструкции обработчика исключений.</returns>
		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06004E53 RID: 20051 RVA: 0x000F6186 File Offset: 0x000F4386
		public int HandlerOffset
		{
			get
			{
				return this.m_handlerStartOffset;
			}
		}

		/// <summary>Получает длину обработчика исключений в байтах.</summary>
		/// <returns>Длина обработчика исключений в байтах.</returns>
		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06004E54 RID: 20052 RVA: 0x000F618E File Offset: 0x000F438E
		public int HandlerLength
		{
			get
			{
				return this.m_handlerEndOffset - this.m_handlerStartOffset;
			}
		}

		/// <summary>Возвращает значение, представляющее тип обработчика исключений, которого представляет данный объект.</summary>
		/// <returns>Одно из значений перечисления, указывающее тип обработчика исключений.</returns>
		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06004E55 RID: 20053 RVA: 0x000F619D File Offset: 0x000F439D
		public ExceptionHandlingClauseOptions Kind
		{
			get
			{
				return this.m_kind;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.Emit.ExceptionHandler" /> с заданными параметрами.</summary>
		/// <param name="tryOffset">Смещение в байтах первой инструкции, защищенной этим обработчиком исключений.</param>
		/// <param name="tryLength">Число байтов, защищенных этим обработчиком исключений.</param>
		/// <param name="filterOffset">Смещение байтов в начале кода фильтра. Код фильтра заканчивается в первой инструкции блока обработчика. Для обработчиков исключений без фильтра, укажите значение 0 (ноль) для данного параметра.</param>
		/// <param name="handlerOffset">Смещение в байтах первой инструкции этого обработчика исключений.</param>
		/// <param name="handlerLength">Число байтов в этом обработчике исключений.</param>
		/// <param name="kind">Одно из значений перечисления, указывающее тип обработчика исключений.</param>
		/// <param name="exceptionTypeToken">Токен типа исключения, обрабатываемого этим обработчиком исключений. Если не используется, укажите 0 (ноль).</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="tryOffset" />, <paramref name="filterOffset" />, <paramref name="handlerOffset" />, <paramref name="tryLength" /> или <paramref name="handlerLength" /> имеет отрицательное значение.</exception>
		// Token: 0x06004E56 RID: 20054 RVA: 0x000F61A8 File Offset: 0x000F43A8
		public ExceptionHandler(int tryOffset, int tryLength, int filterOffset, int handlerOffset, int handlerLength, ExceptionHandlingClauseOptions kind, int exceptionTypeToken)
		{
			if (tryOffset < 0)
			{
				throw new ArgumentOutOfRangeException("tryOffset", Environment.GetResourceString("Non-negative number required."));
			}
			if (tryLength < 0)
			{
				throw new ArgumentOutOfRangeException("tryLength", Environment.GetResourceString("Non-negative number required."));
			}
			if (filterOffset < 0)
			{
				throw new ArgumentOutOfRangeException("filterOffset", Environment.GetResourceString("Non-negative number required."));
			}
			if (handlerOffset < 0)
			{
				throw new ArgumentOutOfRangeException("handlerOffset", Environment.GetResourceString("Non-negative number required."));
			}
			if (handlerLength < 0)
			{
				throw new ArgumentOutOfRangeException("handlerLength", Environment.GetResourceString("Non-negative number required."));
			}
			if ((long)tryOffset + (long)tryLength > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("tryLength", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					0,
					int.MaxValue - tryOffset
				}));
			}
			if ((long)handlerOffset + (long)handlerLength > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("handlerLength", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					0,
					int.MaxValue - handlerOffset
				}));
			}
			if (kind == ExceptionHandlingClauseOptions.Clause && (exceptionTypeToken & 16777215) == 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Token {0:x} is not a valid Type token.", new object[]
				{
					exceptionTypeToken
				}), "exceptionTypeToken");
			}
			if (!ExceptionHandler.IsValidKind(kind))
			{
				throw new ArgumentOutOfRangeException("kind", Environment.GetResourceString("Enum value was out of legal range."));
			}
			this.m_tryStartOffset = tryOffset;
			this.m_tryEndOffset = tryOffset + tryLength;
			this.m_filterOffset = filterOffset;
			this.m_handlerStartOffset = handlerOffset;
			this.m_handlerEndOffset = handlerOffset + handlerLength;
			this.m_kind = kind;
			this.m_exceptionClass = exceptionTypeToken;
		}

		// Token: 0x06004E57 RID: 20055 RVA: 0x000F6342 File Offset: 0x000F4542
		internal ExceptionHandler(int tryStartOffset, int tryEndOffset, int filterOffset, int handlerStartOffset, int handlerEndOffset, int kind, int exceptionTypeToken)
		{
			this.m_tryStartOffset = tryStartOffset;
			this.m_tryEndOffset = tryEndOffset;
			this.m_filterOffset = filterOffset;
			this.m_handlerStartOffset = handlerStartOffset;
			this.m_handlerEndOffset = handlerEndOffset;
			this.m_kind = (ExceptionHandlingClauseOptions)kind;
			this.m_exceptionClass = exceptionTypeToken;
		}

		// Token: 0x06004E58 RID: 20056 RVA: 0x000F6379 File Offset: 0x000F4579
		private static bool IsValidKind(ExceptionHandlingClauseOptions kind)
		{
			return kind <= ExceptionHandlingClauseOptions.Finally || kind == ExceptionHandlingClauseOptions.Fault;
		}

		/// <summary>Служит хэш-функцией по умолчанию.</summary>
		/// <returns>Хэш-код для текущего объекта.</returns>
		// Token: 0x06004E59 RID: 20057 RVA: 0x000F6386 File Offset: 0x000F4586
		public override int GetHashCode()
		{
			return this.m_exceptionClass ^ this.m_tryStartOffset ^ this.m_tryEndOffset ^ this.m_filterOffset ^ this.m_handlerStartOffset ^ this.m_handlerEndOffset ^ (int)this.m_kind;
		}

		/// <summary>Указывает, равен ли этот экземпляр объекта <see cref="T:System.Reflection.Emit.ExceptionHandler" /> указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> и его экземпляр равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004E5A RID: 20058 RVA: 0x000F63B8 File Offset: 0x000F45B8
		public override bool Equals(object obj)
		{
			return obj is ExceptionHandler && this.Equals((ExceptionHandler)obj);
		}

		/// <summary>Указывает, равен ли данный экземпляр объекта <see cref="T:System.Reflection.Emit.ExceptionHandler" /> другому объекту <see cref="T:System.Reflection.Emit.ExceptionHandler" />.</summary>
		/// <param name="other">Объект обработчика исключений, сравниваемый с этим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="other" /> и его экземпляр равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004E5B RID: 20059 RVA: 0x000F63D0 File Offset: 0x000F45D0
		public bool Equals(ExceptionHandler other)
		{
			return other.m_exceptionClass == this.m_exceptionClass && other.m_tryStartOffset == this.m_tryStartOffset && other.m_tryEndOffset == this.m_tryEndOffset && other.m_filterOffset == this.m_filterOffset && other.m_handlerStartOffset == this.m_handlerStartOffset && other.m_handlerEndOffset == this.m_handlerEndOffset && other.m_kind == this.m_kind;
		}

		/// <summary>Определяет, равны ли два заданных экземпляра класса <see cref="T:System.Reflection.Emit.ExceptionHandler" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004E5C RID: 20060 RVA: 0x000F6441 File Offset: 0x000F4641
		public static bool operator ==(ExceptionHandler left, ExceptionHandler right)
		{
			return left.Equals(right);
		}

		/// <summary>Определяет, являются ли два заданных экземпляра класса <see cref="T:System.Reflection.Emit.ExceptionHandler" /> неравными.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004E5D RID: 20061 RVA: 0x000F644B File Offset: 0x000F464B
		public static bool operator !=(ExceptionHandler left, ExceptionHandler right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040030C5 RID: 12485
		internal readonly int m_exceptionClass;

		// Token: 0x040030C6 RID: 12486
		internal readonly int m_tryStartOffset;

		// Token: 0x040030C7 RID: 12487
		internal readonly int m_tryEndOffset;

		// Token: 0x040030C8 RID: 12488
		internal readonly int m_filterOffset;

		// Token: 0x040030C9 RID: 12489
		internal readonly int m_handlerStartOffset;

		// Token: 0x040030CA RID: 12490
		internal readonly int m_handlerEndOffset;

		// Token: 0x040030CB RID: 12491
		internal readonly ExceptionHandlingClauseOptions m_kind;
	}
}
