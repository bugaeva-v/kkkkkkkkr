using System;
using System.Runtime.Serialization;

namespace System.Text
{
	/// <summary>Предоставляет механизм обработки ошибок, называемый резервным вариантом, для входного символа, который не может быть преобразован в выходную последовательность байтов. В резервном варианте вместо первоначального входного символа используется заданная пользователем замещающая строка. Этот класс не наследуется.</summary>
	// Token: 0x020003A4 RID: 932
	[Serializable]
	public sealed class EncoderReplacementFallback : EncoderFallback, ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.EncoderReplacementFallback" />.</summary>
		// Token: 0x06002638 RID: 9784 RVA: 0x000877DB File Offset: 0x000859DB
		public EncoderReplacementFallback() : this("?")
		{
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x000877E8 File Offset: 0x000859E8
		internal EncoderReplacementFallback(SerializationInfo info, StreamingContext context)
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

		// Token: 0x0600263A RID: 9786 RVA: 0x00087834 File Offset: 0x00085A34
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("strDefault", this._strDefault);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.EncoderReplacementFallback" /> указанной замещающей строкой.</summary>
		/// <param name="replacement">Строка, которая преобразуется в операции кодирования вместо входного символа, который не может быть закодирован.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="replacement" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="replacement" /> содержит недопустимую суррогатную пару. Другими словами, суррогат не состоит из одного старшего суррогатного компонента, за которым следует один младший суррогатный компонент.</exception>
		// Token: 0x0600263B RID: 9787 RVA: 0x00087848 File Offset: 0x00085A48
		public EncoderReplacementFallback(string replacement)
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

		/// <summary>Получает замещающую строку, которая является значением объекта <see cref="T:System.Text.EncoderReplacementFallback" />.</summary>
		/// <returns>Подставляемая строка, которая используется вместо входного символа, который не может быть закодирован.</returns>
		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x000878C2 File Offset: 0x00085AC2
		public string DefaultString
		{
			get
			{
				return this._strDefault;
			}
		}

		/// <summary>Создает объект <see cref="T:System.Text.EncoderFallbackBuffer" />, который инициализируется с замещающей строкой этого объекта <see cref="T:System.Text.EncoderReplacementFallback" />.</summary>
		/// <returns>Объект <see cref="T:System.Text.EncoderFallbackBuffer" /> равный данному объекту <see cref="T:System.Text.EncoderReplacementFallback" />.</returns>
		// Token: 0x0600263D RID: 9789 RVA: 0x000878CA File Offset: 0x00085ACA
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			return new EncoderReplacementFallbackBuffer(this);
		}

		/// <summary>Получает количество символов в замещающей строке для объекта <see cref="T:System.Text.EncoderReplacementFallback" />.</summary>
		/// <returns>Количество символов в строке, используемой вместо входного символа, который не может быть закодирован.</returns>
		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x0600263E RID: 9790 RVA: 0x000878D2 File Offset: 0x00085AD2
		public override int MaxCharCount
		{
			get
			{
				return this._strDefault.Length;
			}
		}

		/// <summary>Указывает, равно ли значение заданного объекта объекту <see cref="T:System.Text.EncoderReplacementFallback" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Text.EncoderReplacementFallback" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> задает объект <see cref="T:System.Text.EncoderReplacementFallback" /> и замещающая строка этого объекта равна замещающей строке объекта <see cref="T:System.Text.EncoderReplacementFallback" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600263F RID: 9791 RVA: 0x000878E0 File Offset: 0x00085AE0
		public override bool Equals(object value)
		{
			EncoderReplacementFallback encoderReplacementFallback = value as EncoderReplacementFallback;
			return encoderReplacementFallback != null && this._strDefault == encoderReplacementFallback._strDefault;
		}

		/// <summary>Извлекает хэш-код для значения объекта <see cref="T:System.Text.EncoderReplacementFallback" />.</summary>
		/// <returns>Хэш-код значения объекта.</returns>
		// Token: 0x06002640 RID: 9792 RVA: 0x0008790A File Offset: 0x00085B0A
		public override int GetHashCode()
		{
			return this._strDefault.GetHashCode();
		}

		// Token: 0x04001DC0 RID: 7616
		private string _strDefault;
	}
}
