using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Предоставляет статический метод для создания объекта <see cref="T:System.FormattableString" /> на основе строки составного формата и ее аргументов.</summary>
	// Token: 0x020007F3 RID: 2035
	public static class FormattableStringFactory
	{
		/// <summary>Создает экземпляр <see cref="T:System.FormattableString" /> на основе строки составного формата и ее аргументов.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arguments">Аргументы, строковые представления которых должны быть вставлены в строку результатов.</param>
		/// <returns>Объект, представляющий строку составного формата и ее аргументы.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="arguments" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060045FF RID: 17919 RVA: 0x000E57D3 File Offset: 0x000E39D3
		public static FormattableString Create(string format, params object[] arguments)
		{
			if (format == null)
			{
				throw new ArgumentNullException("format");
			}
			if (arguments == null)
			{
				throw new ArgumentNullException("arguments");
			}
			return new FormattableStringFactory.ConcreteFormattableString(format, arguments);
		}

		// Token: 0x020007F4 RID: 2036
		private sealed class ConcreteFormattableString : FormattableString
		{
			// Token: 0x06004600 RID: 17920 RVA: 0x000E57F8 File Offset: 0x000E39F8
			internal ConcreteFormattableString(string format, object[] arguments)
			{
				this._format = format;
				this._arguments = arguments;
			}

			// Token: 0x17000AC1 RID: 2753
			// (get) Token: 0x06004601 RID: 17921 RVA: 0x000E580E File Offset: 0x000E3A0E
			public override string Format
			{
				get
				{
					return this._format;
				}
			}

			// Token: 0x06004602 RID: 17922 RVA: 0x000E5816 File Offset: 0x000E3A16
			public override object[] GetArguments()
			{
				return this._arguments;
			}

			// Token: 0x17000AC2 RID: 2754
			// (get) Token: 0x06004603 RID: 17923 RVA: 0x000E581E File Offset: 0x000E3A1E
			public override int ArgumentCount
			{
				get
				{
					return this._arguments.Length;
				}
			}

			// Token: 0x06004604 RID: 17924 RVA: 0x000E5828 File Offset: 0x000E3A28
			public override object GetArgument(int index)
			{
				return this._arguments[index];
			}

			// Token: 0x06004605 RID: 17925 RVA: 0x000E5832 File Offset: 0x000E3A32
			public override string ToString(IFormatProvider formatProvider)
			{
				return string.Format(formatProvider, this._format, this._arguments);
			}

			// Token: 0x04002D3A RID: 11578
			private readonly string _format;

			// Token: 0x04002D3B RID: 11579
			private readonly object[] _arguments;
		}
	}
}
