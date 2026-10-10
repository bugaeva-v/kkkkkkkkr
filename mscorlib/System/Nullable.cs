using System;
using System.Runtime.Versioning;

namespace System
{
	/// <summary>Представляет тип значения, которому можно присвоить значение <see langword="null" />.</summary>
	/// <typeparam name="T">Базовый тип значения универсального типа <see cref="T:System.Nullable`1" />.</typeparam>
	// Token: 0x02000163 RID: 355
	[NonVersionable]
	[Serializable]
	public struct Nullable<T> where T : struct
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Nullable`1" /> заданным значением.</summary>
		/// <param name="value">Тип значения.</param>
		// Token: 0x06000DE8 RID: 3560 RVA: 0x00036015 File Offset: 0x00034215
		[NonVersionable]
		public Nullable(T value)
		{
			this.value = value;
			this.hasValue = true;
		}

		/// <summary>Возвращает значение, указывающее, имеет ли текущий объект <see cref="T:System.Nullable`1" /> допустимое значение своего базового типа.</summary>
		/// <returns>
		///   <see langword="true" />, если текущий объект <see cref="T:System.Nullable`1" /> имеет значение; <see langword="false" />, если текущий объект <see cref="T:System.Nullable`1" /> не имеет значения.</returns>
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x00036025 File Offset: 0x00034225
		public bool HasValue
		{
			[NonVersionable]
			get
			{
				return this.hasValue;
			}
		}

		/// <summary>Возвращает значение текущего объекта <see cref="T:System.Nullable`1" />, если ему присвоено допустимое базовое значение.</summary>
		/// <returns>Значение текущего объекта <see cref="T:System.Nullable`1" />, если свойство <see cref="P:System.Nullable`1.HasValue" /> имеет значение <see langword="true" />. Если свойство <see cref="P:System.Nullable`1.HasValue" /> имеет значение <see langword="false" />, то вызывается исключение.</returns>
		/// <exception cref="T:System.InvalidOperationException">Значение свойства <see cref="P:System.Nullable`1.HasValue" /> — <see langword="false" />.</exception>
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x0003602D File Offset: 0x0003422D
		public T Value
		{
			get
			{
				if (!this.hasValue)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue();
				}
				return this.value;
			}
		}

		/// <summary>Извлекает значение текущего объекта <see cref="T:System.Nullable`1" /> или значение базового типа этого объекта по умолчанию.</summary>
		/// <returns>Значение свойства <see cref="P:System.Nullable`1.Value" />, если свойство <see cref="P:System.Nullable`1.HasValue" /> имеет значение <see langword="true" />; в противном случае — значение базового типа по умолчанию.</returns>
		// Token: 0x06000DEB RID: 3563 RVA: 0x00036042 File Offset: 0x00034242
		[NonVersionable]
		public T GetValueOrDefault()
		{
			return this.value;
		}

		/// <summary>Извлекает значение текущего объекта <see cref="T:System.Nullable`1" /> или значение этого объекта по умолчанию.</summary>
		/// <param name="defaultValue">Значение, которое следует вернуть, если свойство <see cref="P:System.Nullable`1.HasValue" /> имеет значение <see langword="false" />.</param>
		/// <returns>Значение свойства <see cref="P:System.Nullable`1.Value" />, если свойство <see cref="P:System.Nullable`1.HasValue" /> имеет значение <see langword="true" />; в противном случае значение параметра <paramref name="defaultValue" />.</returns>
		// Token: 0x06000DEC RID: 3564 RVA: 0x0003604A File Offset: 0x0003424A
		[NonVersionable]
		public T GetValueOrDefault(T defaultValue)
		{
			if (!this.hasValue)
			{
				return defaultValue;
			}
			return this.value;
		}

		/// <summary>Указывает, равен ли текущий объект <see cref="T:System.Nullable`1" /> указанному объекту.</summary>
		/// <param name="other">Объект.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="other" /> равно текущему объекту <see cref="T:System.Nullable`1" />, в противном случае — <see langword="false" />.  
		/// В следующей таблице описывается, как определяется равенство сравниваемых значений. 
		///   Возвращаемое значение 
		///   Описание: 
		///  <see langword="true" /> Свойство <see cref="P:System.Nullable`1.HasValue" /> имеет значение <see langword="false" />, а <paramref name="other" /> параметр имеет значение <see langword="null" />. То есть, два значения null равны по определению.  
		///
		/// или - 
		/// Свойство <see cref="P:System.Nullable`1.HasValue" /> имеет значение <see langword="true" />, а значение, возвращаемое свойством <see cref="P:System.Nullable`1.Value" />, равно значению параметра <paramref name="other" />.  
		///
		///  <see langword="false" /> Свойство <see cref="P:System.Nullable`1.HasValue" /> текущей структуры <see cref="T:System.Nullable`1" /> имеет значение <see langword="true" />, а параметр <paramref name="other" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <see cref="P:System.Nullable`1.HasValue" /> текущей структуры <see cref="T:System.Nullable`1" /> имеет значение <see langword="false" />, а значением параметра <paramref name="other" /> не является <see langword="null" />.  
		///
		/// или - 
		/// Свойство <see cref="P:System.Nullable`1.HasValue" /> текущей структуры <see cref="T:System.Nullable`1" /> имеет значение <see langword="true" />, а значение, возвращаемое свойством <see cref="P:System.Nullable`1.Value" />, не равно значению параметра <paramref name="other" />.</returns>
		// Token: 0x06000DED RID: 3565 RVA: 0x0003605C File Offset: 0x0003425C
		public override bool Equals(object other)
		{
			if (!this.hasValue)
			{
				return other == null;
			}
			return other != null && this.value.Equals(other);
		}

		/// <summary>Извлекает хэш-код объекта, возвращенного свойством <see cref="P:System.Nullable`1.Value" />.</summary>
		/// <returns>Хэш-код объекта, возвращенного свойством <see cref="P:System.Nullable`1.Value" />, если свойство <see cref="P:System.Nullable`1.HasValue" /> имеет значение <see langword="true" />, или нуль, если свойство <see cref="P:System.Nullable`1.HasValue" /> имеет значение <see langword="false" />.</returns>
		// Token: 0x06000DEE RID: 3566 RVA: 0x00036082 File Offset: 0x00034282
		public override int GetHashCode()
		{
			if (!this.hasValue)
			{
				return 0;
			}
			return this.value.GetHashCode();
		}

		/// <summary>Возвращает текстовое представление значения текущего объекта <see cref="T:System.Nullable`1" />.</summary>
		/// <returns>Текстовое представление значения текущего объекта <see cref="T:System.Nullable`1" />, если свойство <see cref="P:System.Nullable`1.HasValue" /> имеет значение <see langword="true" />, или пустая строка (""), если свойство <see cref="P:System.Nullable`1.HasValue" /> имеет значение <see langword="false" />.</returns>
		// Token: 0x06000DEF RID: 3567 RVA: 0x0003609F File Offset: 0x0003429F
		public override string ToString()
		{
			if (!this.hasValue)
			{
				return "";
			}
			return this.value.ToString();
		}

		/// <summary>Создает новый объект <see cref="T:System.Nullable`1" />, инициализированный заданным значением.</summary>
		/// <param name="value">Тип значения.</param>
		/// <returns>Объект <see cref="T:System.Nullable`1" />, свойство <see cref="P:System.Nullable`1.Value" /> которого инициализируется значением параметра <paramref name="value" />.</returns>
		// Token: 0x06000DF0 RID: 3568 RVA: 0x000360C0 File Offset: 0x000342C0
		[NonVersionable]
		public static implicit operator T?(T value)
		{
			return new T?(value);
		}

		/// <summary>Определяет явное преобразование экземпляра <see cref="T:System.Nullable`1" /> в его базовое значение.</summary>
		/// <param name="value">Значение, допускающее значения NULL.</param>
		/// <returns>Значение свойства <see cref="P:System.Nullable`1.Value" /> для параметра <paramref name="value" />.</returns>
		// Token: 0x06000DF1 RID: 3569 RVA: 0x000360C8 File Offset: 0x000342C8
		[NonVersionable]
		public static explicit operator T(T? value)
		{
			return value.Value;
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x000360D1 File Offset: 0x000342D1
		private static object Box(T? o)
		{
			if (!o.hasValue)
			{
				return null;
			}
			return o.value;
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x000360E8 File Offset: 0x000342E8
		private static T? Unbox(object o)
		{
			if (o == null)
			{
				return null;
			}
			return new T?((T)((object)o));
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00036110 File Offset: 0x00034310
		private static T? UnboxExact(object o)
		{
			if (o == null)
			{
				return null;
			}
			if (o.GetType() != typeof(T))
			{
				throw new InvalidCastException();
			}
			return new T?((T)((object)o));
		}

		// Token: 0x04001285 RID: 4741
		private readonly bool hasValue;

		// Token: 0x04001286 RID: 4742
		internal T value;
	}
}
