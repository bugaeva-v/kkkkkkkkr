using System;
using System.Globalization;
using System.Text;

namespace System
{
	/// <summary>Представляет номер версии сборки, операционной системы или среды CLR. Этот класс не наследуется.</summary>
	// Token: 0x020001B6 RID: 438
	[Serializable]
	public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version>, ISpanFormattable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Version" /> с помощью указанных основного и дополнительного номеров версии, номера построения и номера редакции.</summary>
		/// <param name="major">Основной номер версии.</param>
		/// <param name="minor">Дополнительный номер версии.</param>
		/// <param name="build">Номер построения.</param>
		/// <param name="revision">Номер редакции сборки.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="major" />, <paramref name="minor" />, <paramref name="build" /> или <paramref name="revision" /> меньше нуля.</exception>
		// Token: 0x06001300 RID: 4864 RVA: 0x0004CEBC File Offset: 0x0004B0BC
		public Version(int major, int minor, int build, int revision)
		{
			if (major < 0)
			{
				throw new ArgumentOutOfRangeException("major", "Version's parameters must be greater than or equal to zero.");
			}
			if (minor < 0)
			{
				throw new ArgumentOutOfRangeException("minor", "Version's parameters must be greater than or equal to zero.");
			}
			if (build < 0)
			{
				throw new ArgumentOutOfRangeException("build", "Version's parameters must be greater than or equal to zero.");
			}
			if (revision < 0)
			{
				throw new ArgumentOutOfRangeException("revision", "Version's parameters must be greater than or equal to zero.");
			}
			this._Major = major;
			this._Minor = minor;
			this._Build = build;
			this._Revision = revision;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Version" /> с помощью указанных основного и дополнительного номеров версии и номера построения.</summary>
		/// <param name="major">Основной номер версии.</param>
		/// <param name="minor">Дополнительный номер версии.</param>
		/// <param name="build">Номер построения.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="major" />, <paramref name="minor" /> или <paramref name="build" /> меньше нуля.</exception>
		// Token: 0x06001301 RID: 4865 RVA: 0x0004CF4C File Offset: 0x0004B14C
		public Version(int major, int minor, int build)
		{
			if (major < 0)
			{
				throw new ArgumentOutOfRangeException("major", "Version's parameters must be greater than or equal to zero.");
			}
			if (minor < 0)
			{
				throw new ArgumentOutOfRangeException("minor", "Version's parameters must be greater than or equal to zero.");
			}
			if (build < 0)
			{
				throw new ArgumentOutOfRangeException("build", "Version's parameters must be greater than or equal to zero.");
			}
			this._Major = major;
			this._Minor = minor;
			this._Build = build;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Version" /> с помощью указанных основного и дополнительного номеров версии.</summary>
		/// <param name="major">Основной номер версии.</param>
		/// <param name="minor">Дополнительный номер версии.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="major" /> или <paramref name="minor" /> меньше нуля.</exception>
		// Token: 0x06001302 RID: 4866 RVA: 0x0004CFC0 File Offset: 0x0004B1C0
		public Version(int major, int minor)
		{
			if (major < 0)
			{
				throw new ArgumentOutOfRangeException("major", "Version's parameters must be greater than or equal to zero.");
			}
			if (minor < 0)
			{
				throw new ArgumentOutOfRangeException("minor", "Version's parameters must be greater than or equal to zero.");
			}
			this._Major = major;
			this._Minor = minor;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Version" />, используя указанную строку.</summary>
		/// <param name="version">Строка, содержащая основной и дополнительный номер версии, номер построения и номер редакции, в которой каждое число отделено точкой (.).</param>
		/// <exception cref="T:System.ArgumentException">В параметре <paramref name="version" /> содержится менее двух или более четырех компонентов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="version" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Компонент, представляющий основной или дополнительный номера версии, номер построения или редакции, меньше нуля.</exception>
		/// <exception cref="T:System.FormatException">По меньшей мере, один компонент параметра <paramref name="version" /> не распознан как десятичное число.</exception>
		/// <exception cref="T:System.OverflowException">По меньшей мере, один компонент параметра <paramref name="version" /> представляет число, превышающее <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06001303 RID: 4867 RVA: 0x0004D018 File Offset: 0x0004B218
		public Version(string version)
		{
			Version version2 = Version.Parse(version);
			this._Major = version2.Major;
			this._Minor = version2.Minor;
			this._Build = version2.Build;
			this._Revision = version2.Revision;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Version" />.</summary>
		// Token: 0x06001304 RID: 4868 RVA: 0x0004D070 File Offset: 0x0004B270
		public Version()
		{
			this._Major = 0;
			this._Minor = 0;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x0004D094 File Offset: 0x0004B294
		private Version(Version version)
		{
			this._Major = version._Major;
			this._Minor = version._Minor;
			this._Build = version._Build;
			this._Revision = version._Revision;
		}

		/// <summary>Возвращает новый объект <see cref="T:System.Version" />, значение которого совпадает со значением текущего объекта <see cref="T:System.Version" />.</summary>
		/// <returns>Новый объект <see cref="T:System.Object" />, значение которого является копией текущего объекта <see cref="T:System.Version" />.</returns>
		// Token: 0x06001306 RID: 4870 RVA: 0x0004D0E5 File Offset: 0x0004B2E5
		public object Clone()
		{
			return new Version(this);
		}

		/// <summary>Получает значение компонента текущего объекта <see cref="T:System.Version" />, представляющего в номере версии основной номер.</summary>
		/// <returns>Основной номер версии.</returns>
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x0004D0ED File Offset: 0x0004B2ED
		public int Major
		{
			get
			{
				return this._Major;
			}
		}

		/// <summary>Возвращает значение компонента текущего объекта <see cref="T:System.Version" />, представляющего в номере версии дополнительный номер.</summary>
		/// <returns>Дополнительный номер версии.</returns>
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x0004D0F5 File Offset: 0x0004B2F5
		public int Minor
		{
			get
			{
				return this._Minor;
			}
		}

		/// <summary>Возвращает значение компонента текущего объекта <see cref="T:System.Version" />, представляющего в номере версии номер построения.</summary>
		/// <returns>Номер построения или значение -1, если номер сборки не определен.</returns>
		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x0004D0FD File Offset: 0x0004B2FD
		public int Build
		{
			get
			{
				return this._Build;
			}
		}

		/// <summary>Возвращает значение компонента текущего объекта <see cref="T:System.Version" />, представляющего в номере версии номер редакции.</summary>
		/// <returns>Номер редакции или значение -1, если номер редакции не определен.</returns>
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x0004D105 File Offset: 0x0004B305
		public int Revision
		{
			get
			{
				return this._Revision;
			}
		}

		/// <summary>Возвращает старшие 16 разрядов номера редакции.</summary>
		/// <returns>16-разрядное знаковое целое число.</returns>
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x0004D10D File Offset: 0x0004B30D
		public short MajorRevision
		{
			get
			{
				return (short)(this._Revision >> 16);
			}
		}

		/// <summary>Возвращает младшие 16 разрядов номера редакции.</summary>
		/// <returns>16-разрядное знаковое целое число.</returns>
		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x0004D119 File Offset: 0x0004B319
		public short MinorRevision
		{
			get
			{
				return (short)(this._Revision & 65535);
			}
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Version" /> с заданным объектом и возвращает сведения об их относительных значениях.</summary>
		/// <param name="version">Объект для сравнения или значение <see langword="null" />.</param>
		/// <returns>Целое число со знаком, которое определяет относительные значения двух объектов, как показано в следующей таблице.  
		///   Возвращаемое значение 
		///   Значение 
		///   Меньше нуля 
		///   В текущем объекте <see cref="T:System.Version" /> указана версия, предшествующая версии, указанной в параметре <paramref name="version" />.  
		///
		///   Нуль 
		///   Версия текущего объекта <see cref="T:System.Version" /> совпадает с версией, заданной в параметре <paramref name="version" />.  
		///
		///   Больше нуля 
		///   В текущем объекте <see cref="T:System.Version" /> указана версия, следующая за версией, указанной в параметре <paramref name="version" />.  
		///
		/// - или - 
		///  Свойство <paramref name="version" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="version" /> не является параметром типа <see cref="T:System.Version" />.</exception>
		// Token: 0x0600130D RID: 4877 RVA: 0x0004D128 File Offset: 0x0004B328
		public int CompareTo(object version)
		{
			if (version == null)
			{
				return 1;
			}
			Version version2 = version as Version;
			if (version2 == null)
			{
				throw new ArgumentException("Object must be of type Version.");
			}
			return this.CompareTo(version2);
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Version" /> с заданным объектом <see cref="T:System.Version" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Объект <see cref="T:System.Version" />, сравниваемый с текущим объектом <see cref="T:System.Version" />, или значение <see langword="null" />.</param>
		/// <returns>Целое число со знаком, которое определяет относительные значения двух объектов, как показано в следующей таблице.  
		///   Возвращаемое значение 
		///   Значение 
		///   Меньше нуля 
		///   В текущем объекте <see cref="T:System.Version" /> указана версия, предшествующая версии, указанной в параметре <paramref name="value" />.  
		///
		///   Нуль 
		///   Версия текущего объекта <see cref="T:System.Version" /> совпадает с версией, заданной в параметре <paramref name="value" />.  
		///
		///   Больше нуля 
		///   В текущем объекте <see cref="T:System.Version" /> указана версия, следующая за версией, указанной в параметре <paramref name="value" />.  
		///
		/// -или- 
		///  Свойство <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		// Token: 0x0600130E RID: 4878 RVA: 0x0004D15C File Offset: 0x0004B35C
		public int CompareTo(Version value)
		{
			if (value == this)
			{
				return 0;
			}
			if (value == null)
			{
				return 1;
			}
			if (this._Major == value._Major)
			{
				if (this._Minor == value._Minor)
				{
					if (this._Build == value._Build)
					{
						if (this._Revision == value._Revision)
						{
							return 0;
						}
						if (this._Revision <= value._Revision)
						{
							return -1;
						}
						return 1;
					}
					else
					{
						if (this._Build <= value._Build)
						{
							return -1;
						}
						return 1;
					}
				}
				else
				{
					if (this._Minor <= value._Minor)
					{
						return -1;
					}
					return 1;
				}
			}
			else
			{
				if (this._Major <= value._Major)
				{
					return -1;
				}
				return 1;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, равен ли текущий объект <see cref="T:System.Version" /> указанному.</summary>
		/// <param name="obj">Объект, сравниваемый с текущим объектом <see cref="T:System.Version" />, или значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" /> если текущий объект <see cref="T:System.Version" /> и объект <paramref name="obj" /> оба являются объектами <see cref="T:System.Version" />, и все компоненты текущего объекта <see cref="T:System.Version" /> совпадают с соответствующими компонентами объекта <paramref name="obj" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600130F RID: 4879 RVA: 0x0004D1FB File Offset: 0x0004B3FB
		public override bool Equals(object obj)
		{
			return this.Equals(obj as Version);
		}

		/// <summary>Возвращает значение, позволяющее определить, представляют ли текущий объект <see cref="T:System.Version" /> и заданный объект <see cref="T:System.Version" /> одно и то же значение.</summary>
		/// <param name="obj">Объект <see cref="T:System.Version" />, сравниваемый с текущим объектом <see cref="T:System.Version" />, или значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" /> если все компоненты текущего объекта <see cref="T:System.Version" /> совпадают с соответствующими компонентами параметра <paramref name="obj" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001310 RID: 4880 RVA: 0x0004D20C File Offset: 0x0004B40C
		public bool Equals(Version obj)
		{
			return obj == this || (obj != null && this._Major == obj._Major && this._Minor == obj._Minor && this._Build == obj._Build && this._Revision == obj._Revision);
		}

		/// <summary>Возвращает хэш-код для текущего объекта <see cref="T:System.Version" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001311 RID: 4881 RVA: 0x0004D25C File Offset: 0x0004B45C
		public override int GetHashCode()
		{
			return 0 | (this._Major & 15) << 28 | (this._Minor & 255) << 20 | (this._Build & 255) << 12 | (this._Revision & 4095);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.Version" /> в эквивалентное ему представление <see cref="T:System.String" />.</summary>
		/// <returns>Представление <see cref="T:System.String" /> для значений компонентов текущего объекта <see cref="T:System.Version" />, соответствующих основному и дополнительному номерам версий, номеру построения и номеру редакции, согласно приведенному ниже формату. Все компоненты разделены точкой (.). Квадратные скобки ("[" и "]") указывают на компонент, который не будет отображаться в возвращаемом значении, если он не определен. 
		/// ОсновнойНомерВерсии.ДополнительныйНомерВерсии[.НомерПостроения[.НомерРедакции]] 
		/// Например, при создании объекта <see cref="T:System.Version" /> с помощью конструктора Version(1,1) возвращается строка "1.1". При создании объекта <see cref="T:System.Version" /> с помощью конструктора Version(1,3,4,2) возвращается строка "1.3.4.2".</returns>
		// Token: 0x06001312 RID: 4882 RVA: 0x0004D299 File Offset: 0x0004B499
		public override string ToString()
		{
			return this.ToString(this.DefaultFormatFieldCount);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.Version" /> в эквивалентное ему представление <see cref="T:System.String" />. Заданное количество обозначает число возвращаемых компонент.</summary>
		/// <param name="fieldCount">Число возвращаемых компонентов. Значение параметра <paramref name="fieldCount" /> лежит в диапазоне от 0 до 4.</param>
		/// <returns>Представление <see cref="T:System.String" /> для значений компонентов текущего объекта <see cref="T:System.Version" />, соответствующих основному и дополнительному номерам версий, номеру построения и номеру редакции, в котором все значения разделены точкой (.). Параметр <paramref name="fieldCount" /> определяет количество возвращаемых компонентов.  
		///   fieldCount 
		///   Возвращаемое значение 
		///   0 
		///   Пустая строка ("").  
		///
		///   1 
		///   основной номер версии 
		///   2 
		///   ОсновнойНомерВерсии.ДополнительныйНомерВерсии 
		///   3 
		///   ОсновнойНомерВерсии.ДополнительныйНомерВерсии.НомерПостроения 
		///   4 
		///   ОсновнойНомерВерсии.ДополнительныйНомерВерсии.НомерПостроения.НомерРедакции 
		///
		///
		///  Например, при создании объекта <see cref="T:System.Version" /> с помощью конструктора Version(1,3,5) метод ToString(2) возвращает строку "1.3", а метод ToString(4) вызывает исключение.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="fieldCount" /> меньше 0 или больше 4.  
		/// -или- 
		///  Значение параметра <paramref name="fieldCount" /> превышает число компонентов, определенных в текущем объекте <see cref="T:System.Version" />.</exception>
		// Token: 0x06001313 RID: 4883 RVA: 0x0004D2A7 File Offset: 0x0004B4A7
		public string ToString(int fieldCount)
		{
			if (fieldCount == 0)
			{
				return string.Empty;
			}
			if (fieldCount != 1)
			{
				return StringBuilderCache.GetStringAndRelease(this.ToCachedStringBuilder(fieldCount));
			}
			return this._Major.ToString();
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0004D2CE File Offset: 0x0004B4CE
		public bool TryFormat(Span<char> destination, out int charsWritten)
		{
			return this.TryFormat(destination, this.DefaultFormatFieldCount, out charsWritten);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0004D2E0 File Offset: 0x0004B4E0
		public bool TryFormat(Span<char> destination, int fieldCount, out int charsWritten)
		{
			if (fieldCount == 0)
			{
				charsWritten = 0;
				return true;
			}
			if (fieldCount == 1)
			{
				return this._Major.TryFormat(destination, out charsWritten, default(ReadOnlySpan<char>), null);
			}
			StringBuilder stringBuilder = this.ToCachedStringBuilder(fieldCount);
			if (stringBuilder.Length <= destination.Length)
			{
				stringBuilder.CopyTo(0, destination, stringBuilder.Length);
				StringBuilderCache.Release(stringBuilder);
				charsWritten = stringBuilder.Length;
				return true;
			}
			StringBuilderCache.Release(stringBuilder);
			charsWritten = 0;
			return false;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0004D350 File Offset: 0x0004B550
		bool ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			return this.TryFormat(destination, out charsWritten);
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x0004D35A File Offset: 0x0004B55A
		private int DefaultFormatFieldCount
		{
			get
			{
				if (this._Build == -1)
				{
					return 2;
				}
				if (this._Revision != -1)
				{
					return 4;
				}
				return 3;
			}
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0004D374 File Offset: 0x0004B574
		private StringBuilder ToCachedStringBuilder(int fieldCount)
		{
			if (fieldCount == 2)
			{
				StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
				stringBuilder.Append(this._Major);
				stringBuilder.Append('.');
				stringBuilder.Append(this._Minor);
				return stringBuilder;
			}
			if (this._Build == -1)
			{
				throw new ArgumentException(SR.Format("Argument must be between {0} and {1}.", "0", "2"), "fieldCount");
			}
			if (fieldCount == 3)
			{
				StringBuilder stringBuilder2 = StringBuilderCache.Acquire(16);
				stringBuilder2.Append(this._Major);
				stringBuilder2.Append('.');
				stringBuilder2.Append(this._Minor);
				stringBuilder2.Append('.');
				stringBuilder2.Append(this._Build);
				return stringBuilder2;
			}
			if (this._Revision == -1)
			{
				throw new ArgumentException(SR.Format("Argument must be between {0} and {1}.", "0", "3"), "fieldCount");
			}
			if (fieldCount == 4)
			{
				StringBuilder stringBuilder3 = StringBuilderCache.Acquire(16);
				stringBuilder3.Append(this._Major);
				stringBuilder3.Append('.');
				stringBuilder3.Append(this._Minor);
				stringBuilder3.Append('.');
				stringBuilder3.Append(this._Build);
				stringBuilder3.Append('.');
				stringBuilder3.Append(this._Revision);
				return stringBuilder3;
			}
			throw new ArgumentException(SR.Format("Argument must be between {0} and {1}.", "0", "4"), "fieldCount");
		}

		/// <summary>Преобразует строковое представление номера версии в эквивалентный объект <see cref="T:System.Version" />.</summary>
		/// <param name="input">Строка, содержащая преобразуемый номер версии.</param>
		/// <returns>Объект, эквивалентный номеру версии, который задается параметром <paramref name="input" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">В параметре <paramref name="input" /> содержится менее двух или более четырех компонентов версий.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">По крайней мере один из компонентов в <paramref name="input" /> меньше нуля.</exception>
		/// <exception cref="T:System.FormatException">По крайней мере один из компонентов в <paramref name="input" /> не является целым числом.</exception>
		/// <exception cref="T:System.OverflowException">По меньшей мере, один компонент в <paramref name="input" /> представляет число, превышающее <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06001319 RID: 4889 RVA: 0x0004D4BE File Offset: 0x0004B6BE
		public static Version Parse(string input)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return Version.ParseVersion(input.AsSpan(), true);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0004D4DA File Offset: 0x0004B6DA
		public static Version Parse(ReadOnlySpan<char> input)
		{
			return Version.ParseVersion(input, true);
		}

		/// <summary>Предпринимает попытку преобразования строкового представления номера версии в эквивалентный объект <see cref="T:System.Version" /> и возвращает значение, позволяющее определить, успешно ли выполнено преобразование.</summary>
		/// <param name="input">Строка, содержащая преобразуемый номер версии.</param>
		/// <param name="result">После выполнения этого метода содержит эквивалент типа <see cref="T:System.Version" /> числа, содержащегося в параметре <paramref name="input" />, если преобразование выполнено успешно. Если значением параметра <paramref name="input" /> является <see langword="null" /> или <see cref="F:System.String.Empty" /> или произошел сбой преобразования, метод возвращает <see langword="null" /> в параметре <paramref name="result" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="input" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600131B RID: 4891 RVA: 0x0004D4E4 File Offset: 0x0004B6E4
		public static bool TryParse(string input, out Version result)
		{
			if (input == null)
			{
				result = null;
				return false;
			}
			Version v;
			result = (v = Version.ParseVersion(input.AsSpan(), false));
			return v != null;
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0004D510 File Offset: 0x0004B710
		public static bool TryParse(ReadOnlySpan<char> input, out Version result)
		{
			Version v;
			result = (v = Version.ParseVersion(input, false));
			return v != null;
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0004D530 File Offset: 0x0004B730
		private static Version ParseVersion(ReadOnlySpan<char> input, bool throwOnFailure)
		{
			int num = input.IndexOf('.');
			if (num < 0)
			{
				if (throwOnFailure)
				{
					throw new ArgumentException("Version string portion was too short or too long.", "input");
				}
				return null;
			}
			else
			{
				int num2 = -1;
				int num3 = input.Slice(num + 1).IndexOf('.');
				if (num3 != -1)
				{
					num3 += num + 1;
					num2 = input.Slice(num3 + 1).IndexOf('.');
					if (num2 != -1)
					{
						num2 += num3 + 1;
						if (input.Slice(num2 + 1).IndexOf('.') != -1)
						{
							if (throwOnFailure)
							{
								throw new ArgumentException("Version string portion was too short or too long.", "input");
							}
							return null;
						}
					}
				}
				int major;
				if (!Version.TryParseComponent(input.Slice(0, num), "input", throwOnFailure, out major))
				{
					return null;
				}
				if (num3 != -1)
				{
					int minor;
					if (!Version.TryParseComponent(input.Slice(num + 1, num3 - num - 1), "input", throwOnFailure, out minor))
					{
						return null;
					}
					if (num2 != -1)
					{
						int build;
						int revision;
						if (!Version.TryParseComponent(input.Slice(num3 + 1, num2 - num3 - 1), "build", throwOnFailure, out build) || !Version.TryParseComponent(input.Slice(num2 + 1), "revision", throwOnFailure, out revision))
						{
							return null;
						}
						return new Version(major, minor, build, revision);
					}
					else
					{
						int build;
						if (!Version.TryParseComponent(input.Slice(num3 + 1), "build", throwOnFailure, out build))
						{
							return null;
						}
						return new Version(major, minor, build);
					}
				}
				else
				{
					int minor;
					if (!Version.TryParseComponent(input.Slice(num + 1), "input", throwOnFailure, out minor))
					{
						return null;
					}
					return new Version(major, minor);
				}
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0004D698 File Offset: 0x0004B898
		private static bool TryParseComponent(ReadOnlySpan<char> component, string componentName, bool throwOnFailure, out int parsedComponent)
		{
			if (!throwOnFailure)
			{
				return int.TryParse(component, NumberStyles.Integer, CultureInfo.InvariantCulture, out parsedComponent) && parsedComponent >= 0;
			}
			if ((parsedComponent = int.Parse(component, NumberStyles.Integer, CultureInfo.InvariantCulture)) < 0)
			{
				throw new ArgumentOutOfRangeException(componentName, "Version's parameters must be greater than or equal to zero.");
			}
			return true;
		}

		/// <summary>Определение равенства двух заданных объектов <see cref="T:System.Version" />.</summary>
		/// <param name="v1">Первый объект <see cref="T:System.Version" />.</param>
		/// <param name="v2">Второй объект <see cref="T:System.Version" />.</param>
		/// <returns>Если значение <paramref name="v1" /> равно <paramref name="v2" />, значение <see langword="true" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600131F RID: 4895 RVA: 0x0004D6E3 File Offset: 0x0004B8E3
		public static bool operator ==(Version v1, Version v2)
		{
			if (v1 == null)
			{
				return v2 == null;
			}
			return v1.Equals(v2);
		}

		/// <summary>Определение неравенства двух заданных объектов <see cref="T:System.Version" />.</summary>
		/// <param name="v1">Первый объект <see cref="T:System.Version" />.</param>
		/// <param name="v2">Второй объект <see cref="T:System.Version" />.</param>
		/// <returns>Значение <see langword="true" />, если значения параметров <paramref name="v1" /> и <paramref name="v2" /> не равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001320 RID: 4896 RVA: 0x0004D6F4 File Offset: 0x0004B8F4
		public static bool operator !=(Version v1, Version v2)
		{
			return !(v1 == v2);
		}

		/// <summary>Определяет, меньше ли значение первого указанного объекта <see cref="T:System.Version" />, чем значение второго указанного объекта <see cref="T:System.Version" />.</summary>
		/// <param name="v1">Первый объект <see cref="T:System.Version" />.</param>
		/// <param name="v2">Второй объект <see cref="T:System.Version" />.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="v1" /> меньше значения <paramref name="v2" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="v1" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001321 RID: 4897 RVA: 0x0004D700 File Offset: 0x0004B900
		public static bool operator <(Version v1, Version v2)
		{
			if (v1 == null)
			{
				throw new ArgumentNullException("v1");
			}
			return v1.CompareTo(v2) < 0;
		}

		/// <summary>Определяет, действительно ли значение первого указанного объекта <see cref="T:System.Version" /> меньше или равно значению второго указанного объекта <see cref="T:System.Version" />.</summary>
		/// <param name="v1">Первый объект <see cref="T:System.Version" />.</param>
		/// <param name="v2">Второй объект <see cref="T:System.Version" />.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="v1" /> меньше или равно значению <paramref name="v2" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="v1" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001322 RID: 4898 RVA: 0x0004D71A File Offset: 0x0004B91A
		public static bool operator <=(Version v1, Version v2)
		{
			if (v1 == null)
			{
				throw new ArgumentNullException("v1");
			}
			return v1.CompareTo(v2) <= 0;
		}

		/// <summary>Определяет, действительно ли значение первого указанного объекта <see cref="T:System.Version" /> больше значения второго указанного объекта <see cref="T:System.Version" />.</summary>
		/// <param name="v1">Первый объект <see cref="T:System.Version" />.</param>
		/// <param name="v2">Второй объект <see cref="T:System.Version" />.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="v1" /> больше <paramref name="v2" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001323 RID: 4899 RVA: 0x0004D737 File Offset: 0x0004B937
		public static bool operator >(Version v1, Version v2)
		{
			return v2 < v1;
		}

		/// <summary>Определяет, является ли значение первого указанного объекта <see cref="T:System.Version" /> большим или равным значению второго указанного объекта <see cref="T:System.Version" />.</summary>
		/// <param name="v1">Первый объект <see cref="T:System.Version" />.</param>
		/// <param name="v2">Второй объект <see cref="T:System.Version" />.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="v1" /> больше или равно значению <paramref name="v2" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001324 RID: 4900 RVA: 0x0004D740 File Offset: 0x0004B940
		public static bool operator >=(Version v1, Version v2)
		{
			return v2 <= v1;
		}

		// Token: 0x0400138A RID: 5002
		private readonly int _Major;

		// Token: 0x0400138B RID: 5003
		private readonly int _Minor;

		// Token: 0x0400138C RID: 5004
		private readonly int _Build = -1;

		// Token: 0x0400138D RID: 5005
		private readonly int _Revision = -1;
	}
}
