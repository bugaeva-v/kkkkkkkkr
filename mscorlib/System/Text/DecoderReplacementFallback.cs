using System;
using System.Runtime.Serialization;

namespace System.Text
{
	/// <summary>Предоставляет механизм обработки ошибок, называемый резервным вариантом, закодированной входной последовательности байтов, которая не может быть преобразована в выходной символ. В резервном варианте вместо декодированной последовательности байтов выпускается заданная пользователем замещающая строка. Этот класс не наследуется.</summary>
	// Token: 0x02000399 RID: 921
	[Serializable]
	public sealed class DecoderReplacementFallback : DecoderFallback, ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.DecoderReplacementFallback" />.</summary>
		// Token: 0x060025D7 RID: 9687 RVA: 0x0008665C File Offset: 0x0008485C
		public DecoderReplacementFallback() : this("?")
		{
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x0008666C File Offset: 0x0008486C
		internal DecoderReplacementFallback(SerializationInfo info, StreamingContext context)
		{
			try
			{
				this._strDefault = info.GetString("strDefault");
			}
			catch
			{
				this._strDefault = info.GetString("_strDefault");
			}
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x000866B8 File Offset: 0x000848B8
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("strDefault", this._strDefault);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.DecoderReplacementFallback" /> указанной замещающей строкой.</summary>
		/// <param name="replacement">Строка, которая выпущена в операции декодирования вместо входной последовательности байтов, которая не может быть декодирована.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="replacement" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="replacement" /> содержит недопустимую суррогатную пару. Другими словами, суррогатная пара не состоит из одного старшего суррогатного компонента, за которым следует один младший суррогатный компонент.</exception>
		// Token: 0x060025DA RID: 9690 RVA: 0x000866CC File Offset: 0x000848CC
		public DecoderReplacementFallback(string replacement)
		{
			if (replacement == null)
			{
				throw new ArgumentNullException("replacement");
			}
			bool flag = false;
			for (int i = 0; i < replacement.Length; i++)
			{
				if (char.IsSurrogate(replacement, i))
				{
					if (char.IsHighSurrogate(replacement, i))
					{
						if (flag)
						{
							break;
						}
						flag = true;
					}
					else
					{
						if (!flag)
						{
							flag = true;
							break;
						}
						flag = false;
					}
				}
				else if (flag)
				{
					break;
				}
			}
			if (flag)
			{
				throw new ArgumentException(SR.Format("String contains invalid Unicode code points.", "replacement"));
			}
			this._strDefault = replacement;
		}

		/// <summary>Получает замещающую строку, которая является значением объекта <see cref="T:System.Text.DecoderReplacementFallback" />.</summary>
		/// <returns>Замещающая строка, которая выпущена вместо входной последовательности байтов, которая не может быть декодирована.</returns>
		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x060025DB RID: 9691 RVA: 0x00086746 File Offset: 0x00084946
		public string DefaultString
		{
			get
			{
				return this._strDefault;
			}
		}

		/// <summary>Создает объект <see cref="T:System.Text.DecoderFallbackBuffer" />, который инициализируется с замещающей строкой этого объекта <see cref="T:System.Text.DecoderReplacementFallback" />.</summary>
		/// <returns>Объект <see cref="T:System.Text.DecoderFallbackBuffer" />, указывающий строку, которую следует использовать вместо исходной входной последовательности операции декодирования.</returns>
		// Token: 0x060025DC RID: 9692 RVA: 0x0008674E File Offset: 0x0008494E
		public override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			return new DecoderReplacementFallbackBuffer(this);
		}

		/// <summary>Получает количество символов в замещающей строке для объекта <see cref="T:System.Text.DecoderReplacementFallback" />.</summary>
		/// <returns>Количество символов в строке, выпущенное вместо последовательности байтов, которое не может быть декодировано, то есть, является длиной строки, возвращенное свойством <see cref="P:System.Text.DecoderReplacementFallback.DefaultString" />.</returns>
		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060025DD RID: 9693 RVA: 0x00086756 File Offset: 0x00084956
		public override int MaxCharCount
		{
			get
			{
				return this._strDefault.Length;
			}
		}

		/// <summary>Указывает, равно ли значение заданного объекта объекту <see cref="T:System.Text.DecoderReplacementFallback" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Text.DecoderReplacementFallback" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> является объектом <see cref="T:System.Text.DecoderReplacementFallback" /> со свойством <see cref="P:System.Text.DecoderReplacementFallback.DefaultString" />, равным свойству <see cref="P:System.Text.DecoderReplacementFallback.DefaultString" /> текущего объекта <see cref="T:System.Text.DecoderReplacementFallback" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060025DE RID: 9694 RVA: 0x00086764 File Offset: 0x00084964
		public override bool Equals(object value)
		{
			DecoderReplacementFallback decoderReplacementFallback = value as DecoderReplacementFallback;
			return decoderReplacementFallback != null && this._strDefault == decoderReplacementFallback._strDefault;
		}

		/// <summary>Извлекает хэш-код для значения объекта <see cref="T:System.Text.DecoderReplacementFallback" />.</summary>
		/// <returns>Хэш-код значения объекта.</returns>
		// Token: 0x060025DF RID: 9695 RVA: 0x0008678E File Offset: 0x0008498E
		public override int GetHashCode()
		{
			return this._strDefault.GetHashCode();
		}

		// Token: 0x04001DA0 RID: 7584
		private string _strDefault;
	}
}
