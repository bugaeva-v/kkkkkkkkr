using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Security;
using Microsoft.Internal.Runtime.Serialization;

namespace System.ComponentModel.Composition.Primitives
{
	/// <summary>Исключение, которое создается в случае возникновения ошибки при вызове методов для объекта <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" />.</summary>
	// Token: 0x0200008D RID: 141
	[DebuggerTypeProxy(typeof(ComposablePartExceptionDebuggerProxy))]
	[DebuggerDisplay("{Message}")]
	[Serializable]
	public class ComposablePartException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" />.</summary>
		// Token: 0x060003BB RID: 955 RVA: 0x0000AD6B File Offset: 0x00008F6B
		public ComposablePartException() : this(null, null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" /> указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, которое описывает исключение <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" />, или значение <see langword="null" /> для задания свойству <see cref="P:System.Exception.Message" /> значения по умолчанию.</param>
		// Token: 0x060003BC RID: 956 RVA: 0x0000AD76 File Offset: 0x00008F76
		public ComposablePartException(string message) : this(message, null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" /> с использованием указанного сообщения об ошибке и элемента композиции, который стал причиной данного исключения.</summary>
		/// <param name="message">Сообщение, которое описывает исключение <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" />, или значение <see langword="null" /> для задания свойству <see cref="P:System.Exception.Message" /> значения по умолчанию.</param>
		/// <param name="element">Элемент композиции, который стал причиной исключения <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" />, или <see langword="null" />, чтобы задать для свойства <see cref="P:System.ComponentModel.Composition.Primitives.ComposablePartException.Element" /> значение <see langword="null" />.</param>
		// Token: 0x060003BD RID: 957 RVA: 0x0000AD81 File Offset: 0x00008F81
		public ComposablePartException(string message, ICompositionElement element) : this(message, element, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" /> с использованием указанного сообщения об ошибке и исключения, которое стало причиной данного исключения.</summary>
		/// <param name="message">Сообщение, которое описывает исключение <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" />, или значение <see langword="null" /> для задания свойству <see cref="P:System.Exception.Message" /> значения по умолчанию.</param>
		/// <param name="innerException">Исключение, являющееся исходной причиной исключения <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" />, или значение <see langword="null" />, чтобы задать для свойства <see cref="P:System.Exception.InnerException" /> значение <see langword="null" />.</param>
		// Token: 0x060003BE RID: 958 RVA: 0x0000AD8C File Offset: 0x00008F8C
		public ComposablePartException(string message, Exception innerException) : this(message, null, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" /> с использованием указанного сообщения об ошибке, элемента композиции и исключения, которое стало причиной данного исключения.</summary>
		/// <param name="message">Сообщение, которое описывает исключение <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" />, или значение <see langword="null" /> для задания свойству <see cref="P:System.Exception.Message" /> значения по умолчанию.</param>
		/// <param name="element">Элемент композиции, который стал причиной исключения <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" />, или <see langword="null" />, чтобы задать для свойства <see cref="P:System.ComponentModel.Composition.Primitives.ComposablePartException.Element" /> значение <see langword="null" />.</param>
		/// <param name="innerException">Исключение, являющееся исходной причиной исключения <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" />, или значение <see langword="null" />, чтобы задать для свойства <see cref="P:System.Exception.InnerException" /> значение <see langword="null" />.</param>
		// Token: 0x060003BF RID: 959 RVA: 0x0000AD97 File Offset: 0x00008F97
		public ComposablePartException(string message, ICompositionElement element, Exception innerException) : base(message, innerException)
		{
			this._element = element;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" /> заданными данными сериализации.</summary>
		/// <param name="info">Объект, содержащий данные сериализованных объектов для ошибки <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" />.</param>
		/// <param name="context">Объект, содержащий контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">В параметре <paramref name="info" /> отсутствует обязательное значение.</exception>
		/// <exception cref="T:System.InvalidCastException">Параметр <paramref name="info" /> содержит значение, которое нельзя привести к правильному типу.</exception>
		// Token: 0x060003C0 RID: 960 RVA: 0x0000ADA8 File Offset: 0x00008FA8
		[SecuritySafeCritical]
		protected ComposablePartException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._element = info.GetValue("Element");
		}

		/// <summary>Получает элемент композиции, который стал причиной исключения.</summary>
		/// <returns>Элемент композиции, который стал причиной исключения <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" />. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000ADC3 File Offset: 0x00008FC3
		public ICompositionElement Element
		{
			get
			{
				return this._element;
			}
		}

		/// <summary>Получает данные сериализации для исключения.</summary>
		/// <param name="info">После вызова этого метода содержит сериализованные данные объекта, относящиеся к исключению <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException" />.</param>
		/// <param name="context">После вызова этого метода содержит контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060003C2 RID: 962 RVA: 0x0000ADCB File Offset: 0x00008FCB
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("Element", this._element.ToSerializableElement());
		}

		// Token: 0x04000177 RID: 375
		private readonly ICompositionElement _element;
	}
}
