using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System
{
	/// <summary>Предоставляет базовый класс для перечислений.</summary>
	// Token: 0x020001F5 RID: 501
	[ComVisible(true)]
	[Serializable]
	public abstract class Enum : ValueType, IComparable, IFormattable, IConvertible
	{
		// Token: 0x06001575 RID: 5493 RVA: 0x0005500C File Offset: 0x0005320C
		[SecuritySafeCritical]
		private static Enum.ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames)
		{
			Enum.ValuesAndNames valuesAndNames = enumType.GenericCache as Enum.ValuesAndNames;
			if (valuesAndNames == null || (getNames && valuesAndNames.Names == null))
			{
				ulong[] array = null;
				string[] array2 = null;
				if (!Enum.GetEnumValuesAndNames(enumType, out array, out array2))
				{
					Array.Sort<ulong, string>(array, array2, Comparer<ulong>.Default);
				}
				valuesAndNames = new Enum.ValuesAndNames(array, array2);
				enumType.GenericCache = valuesAndNames;
			}
			return valuesAndNames;
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00055060 File Offset: 0x00053260
		private static string InternalFormattedHexString(object value)
		{
			switch (Convert.GetTypeCode(value))
			{
			case TypeCode.Boolean:
				return Convert.ToByte((bool)value).ToString("X2", null);
			case TypeCode.Char:
				return ((ushort)((char)value)).ToString("X4", null);
			case TypeCode.SByte:
				return ((byte)((sbyte)value)).ToString("X2", null);
			case TypeCode.Byte:
				return ((byte)value).ToString("X2", null);
			case TypeCode.Int16:
				return ((ushort)((short)value)).ToString("X4", null);
			case TypeCode.UInt16:
				return ((ushort)value).ToString("X4", null);
			case TypeCode.Int32:
				return ((uint)((int)value)).ToString("X8", null);
			case TypeCode.UInt32:
				return ((uint)value).ToString("X8", null);
			case TypeCode.Int64:
				return ((ulong)((long)value)).ToString("X16", null);
			case TypeCode.UInt64:
				return ((ulong)value).ToString("X16", null);
			default:
				throw new InvalidOperationException(Environment.GetResourceString("Unknown enum type."));
			}
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00055198 File Offset: 0x00053398
		private static string InternalFormat(RuntimeType eT, object value)
		{
			if (eT.IsDefined(typeof(FlagsAttribute), false))
			{
				return Enum.InternalFlagsFormat(eT, value);
			}
			string name = Enum.GetName(eT, value);
			if (name == null)
			{
				return value.ToString();
			}
			return name;
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x000551D4 File Offset: 0x000533D4
		private static string InternalFlagsFormat(RuntimeType eT, object value)
		{
			ulong num = Enum.ToUInt64(value);
			Enum.ValuesAndNames cachedValuesAndNames = Enum.GetCachedValuesAndNames(eT, true);
			string[] names = cachedValuesAndNames.Names;
			ulong[] values = cachedValuesAndNames.Values;
			int num2 = values.Length - 1;
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = true;
			ulong num3 = num;
			while (num2 >= 0 && (num2 != 0 || values[num2] != 0UL))
			{
				if ((num & values[num2]) == values[num2])
				{
					num -= values[num2];
					if (!flag)
					{
						stringBuilder.Insert(0, ", ");
					}
					stringBuilder.Insert(0, names[num2]);
					flag = false;
				}
				num2--;
			}
			if (num != 0UL)
			{
				return value.ToString();
			}
			if (num3 != 0UL)
			{
				return stringBuilder.ToString();
			}
			if (values.Length != 0 && values[0] == 0UL)
			{
				return names[0];
			}
			return "0";
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x0005527C File Offset: 0x0005347C
		internal static ulong ToUInt64(object value)
		{
			ulong result;
			switch (Convert.GetTypeCode(value))
			{
			case TypeCode.Boolean:
			case TypeCode.Char:
			case TypeCode.Byte:
			case TypeCode.UInt16:
			case TypeCode.UInt32:
			case TypeCode.UInt64:
				result = Convert.ToUInt64(value, CultureInfo.InvariantCulture);
				break;
			case TypeCode.SByte:
			case TypeCode.Int16:
			case TypeCode.Int32:
			case TypeCode.Int64:
				result = (ulong)Convert.ToInt64(value, CultureInfo.InvariantCulture);
				break;
			default:
				throw new InvalidOperationException(Environment.GetResourceString("Unknown enum type."));
			}
			return result;
		}

		// Token: 0x0600157A RID: 5498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int InternalCompareTo(object o1, object o2);

		// Token: 0x0600157B RID: 5499
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern RuntimeType InternalGetUnderlyingType(RuntimeType enumType);

		// Token: 0x0600157C RID: 5500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetEnumValuesAndNames(RuntimeType enumType, out ulong[] values, out string[] names);

		// Token: 0x0600157D RID: 5501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern object InternalBoxEnum(RuntimeType enumType, long value);

		/// <summary>Преобразует строковое представление имени или числового значения одной или нескольких перечислимых констант в эквивалентный перечислимый объект. Возвращаемое значение указывает, успешно ли выполнено преобразование.</summary>
		/// <param name="value">Чувствительное к регистру строковое представление имени перечисления или базового значения для преобразования.</param>
		/// <param name="result">При возврате данного метода <paramref name="result" /> содержит объект типа TEnum, значение которого представлено параметром <paramref name="value" />, если операция анализа выполнена успешно. Если операция анализа завершается неудачно, то <paramref name="result" /> содержит значение по умолчанию базового типа TEnum. Обратите внимание, что это значение не обязательно должно быть членом перечисления TEnum. Этот параметр передается неинициализированным.</param>
		/// <typeparam name="TEnum">Тип перечисления, в который требуется преобразовать <paramref name="value" />.</typeparam>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="TEnum" /> не является типом перечисления.</exception>
		// Token: 0x0600157E RID: 5502 RVA: 0x000552EF File Offset: 0x000534EF
		public static bool TryParse<TEnum>(string value, out TEnum result) where TEnum : struct
		{
			return Enum.TryParse<TEnum>(value, false, out result);
		}

		/// <summary>Преобразует строковое представление имени или числового значения одной или нескольких перечислимых констант в эквивалентный перечислимый объект. Параметр указывает, учитывается ли в операции регистр. Возвращаемое значение указывает, успешно ли выполнено преобразование.</summary>
		/// <param name="value">Строковое представление имени перечисления или базового значения для преобразования.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы игнорировать регистр; значение <see langword="false" />, чтобы учитывать регистр.</param>
		/// <param name="result">При возврате данного метода <paramref name="result" /> содержит объект типа TEnum, значение которого представлено параметром <paramref name="value" />, если операция анализа выполнена успешно. Если операция анализа завершается неудачно, то <paramref name="result" /> содержит значение по умолчанию базового типа TEnum. Обратите внимание, что это значение не обязательно должно быть членом перечисления TEnum. Этот параметр передается неинициализированным.</param>
		/// <typeparam name="TEnum">Тип перечисления, в который требуется преобразовать <paramref name="value" />.</typeparam>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="TEnum" /> не является типом перечисления.</exception>
		// Token: 0x0600157F RID: 5503 RVA: 0x000552FC File Offset: 0x000534FC
		public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : struct
		{
			result = default(TEnum);
			Enum.EnumResult enumResult = default(Enum.EnumResult);
			enumResult.Init(false);
			bool flag = Enum.TryParseEnum(typeof(TEnum), value, ignoreCase, ref enumResult);
			if (flag)
			{
				result = (TEnum)((object)enumResult.parsedEnum);
			}
			return flag;
		}

		/// <summary>Преобразует строковое представление имени или числового значения одной или нескольких перечислимых констант в эквивалентный перечислимый объект.</summary>
		/// <param name="enumType">Тип перечисления.</param>
		/// <param name="value">Строка, содержащая имя или значение для преобразования.</param>
		/// <returns>Объект типа <paramref name="enumType" />, значение которого представлено параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="enumType" /> или <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> не является классом <see cref="T:System.Enum" />.  
		/// -или- 
		///  <paramref name="value" /> является пустой строкой ("") или содержит только пробелы.  
		/// -или- 
		///  <paramref name="value" /> — имя, но для перечисления не определено ни одной именованной константы.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> находится за пределами диапазона базового типа <paramref name="enumType" />.</exception>
		// Token: 0x06001580 RID: 5504 RVA: 0x00055347 File Offset: 0x00053547
		[ComVisible(true)]
		public static object Parse(Type enumType, string value)
		{
			return Enum.Parse(enumType, value, false);
		}

		/// <summary>Преобразует строковое представление имени или числового значения одной или нескольких перечислимых констант в эквивалентный перечислимый объект. Параметр указывает, учитывается ли в операции регистр.</summary>
		/// <param name="enumType">Тип перечисления.</param>
		/// <param name="value">Строка, содержащая имя или значение для преобразования.</param>
		/// <param name="ignoreCase">Значение <see langword="true" /> предписывает игнорировать регистр. В противном случае — значение <see langword="false" />.</param>
		/// <returns>Объект типа <paramref name="enumType" />, значение которого представлено параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="enumType" /> или <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> не является классом <see cref="T:System.Enum" />.  
		/// -или- 
		///  <paramref name="value" /> является пустой строкой ("") или содержит только пробелы.  
		/// -или- 
		///  <paramref name="value" /> — имя, но для перечисления не определено ни одной именованной константы.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> находится за пределами диапазона базового типа <paramref name="enumType" />.</exception>
		// Token: 0x06001581 RID: 5505 RVA: 0x00055354 File Offset: 0x00053554
		[ComVisible(true)]
		public static object Parse(Type enumType, string value, bool ignoreCase)
		{
			Enum.EnumResult enumResult = default(Enum.EnumResult);
			enumResult.Init(true);
			if (Enum.TryParseEnum(enumType, value, ignoreCase, ref enumResult))
			{
				return enumResult.parsedEnum;
			}
			throw enumResult.GetEnumParseException();
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x0005538C File Offset: 0x0005358C
		private static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref Enum.EnumResult parseResult)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			RuntimeType runtimeType = enumType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "enumType");
			}
			if (!enumType.IsEnum)
			{
				throw new ArgumentException(Environment.GetResourceString("Type provided must be an Enum."), "enumType");
			}
			if (value == null)
			{
				parseResult.SetFailure(Enum.ParseFailureKind.ArgumentNull, "value");
				return false;
			}
			value = value.Trim();
			if (value.Length == 0)
			{
				parseResult.SetFailure(Enum.ParseFailureKind.Argument, "Must specify valid information for parsing in the string.", null);
				return false;
			}
			ulong num = 0UL;
			if (char.IsDigit(value[0]) || value[0] == '-' || value[0] == '+')
			{
				Type underlyingType = Enum.GetUnderlyingType(enumType);
				try
				{
					object value2 = Convert.ChangeType(value, underlyingType, CultureInfo.InvariantCulture);
					parseResult.parsedEnum = Enum.ToObject(enumType, value2);
					return true;
				}
				catch (FormatException)
				{
				}
				catch (Exception failure)
				{
					if (parseResult.canThrow)
					{
						throw;
					}
					parseResult.SetFailure(failure);
					return false;
				}
			}
			string[] array = value.Split(Enum.enumSeperatorCharArray);
			Enum.ValuesAndNames cachedValuesAndNames = Enum.GetCachedValuesAndNames(runtimeType, true);
			string[] names = cachedValuesAndNames.Names;
			ulong[] values = cachedValuesAndNames.Values;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = array[i].Trim();
				bool flag = false;
				int j = 0;
				while (j < names.Length)
				{
					if (ignoreCase)
					{
						if (string.Compare(names[j], array[i], StringComparison.OrdinalIgnoreCase) == 0)
						{
							goto IL_158;
						}
					}
					else if (names[j].Equals(array[i]))
					{
						goto IL_158;
					}
					j++;
					continue;
					IL_158:
					ulong num2 = values[j];
					num |= num2;
					flag = true;
					break;
				}
				if (!flag)
				{
					parseResult.SetFailure(Enum.ParseFailureKind.ArgumentWithParameter, "Requested value '{0}' was not found.", value);
					return false;
				}
			}
			bool result;
			try
			{
				parseResult.parsedEnum = Enum.ToObject(enumType, num);
				result = true;
			}
			catch (Exception failure2)
			{
				if (parseResult.canThrow)
				{
					throw;
				}
				parseResult.SetFailure(failure2);
				result = false;
			}
			return result;
		}

		/// <summary>Возвращает базовый тип заданного перечисления.</summary>
		/// <param name="enumType">Перечисление, базовый тип которого требуется получить.</param>
		/// <returns>Базовый тип <paramref name="enumType" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> не является классом <see cref="T:System.Enum" />.</exception>
		// Token: 0x06001583 RID: 5507 RVA: 0x00055588 File Offset: 0x00053788
		[ComVisible(true)]
		public static Type GetUnderlyingType(Type enumType)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			return enumType.GetEnumUnderlyingType();
		}

		/// <summary>Возвращает массив значений констант в указанном перечислении.</summary>
		/// <param name="enumType">Тип перечисления.</param>
		/// <returns>Массив, который содержит значения констант в <paramref name="enumType" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> не является классом <see cref="T:System.Enum" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод вызывается с помощью отражения в контексте только для отражения. 
		/// -или- 
		///  <paramref name="enumType" /> является типом из сборки, загруженной в контекст только для отражения.</exception>
		// Token: 0x06001584 RID: 5508 RVA: 0x000555A4 File Offset: 0x000537A4
		[ComVisible(true)]
		public static Array GetValues(Type enumType)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			return enumType.GetEnumValues();
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x000555C0 File Offset: 0x000537C0
		internal static ulong[] InternalGetValues(RuntimeType enumType)
		{
			return Enum.GetCachedValuesAndNames(enumType, false).Values;
		}

		/// <summary>Возвращает имя константы с заданным значением из указанного перечисления.</summary>
		/// <param name="enumType">Тип перечисления.</param>
		/// <param name="value">Значение определенной перечислимой константы с учетом ее базового типа.</param>
		/// <returns>Строка, содержащая имя константы перечислимого типа в <paramref name="enumType" />, значение которой равно <paramref name="value" />, или значение <see langword="null" />, если такая константа не найдена.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="enumType" /> или <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> не является классом <see cref="T:System.Enum" />.  
		/// -или- 
		///  <paramref name="value" /> не является типом <paramref name="enumType" /> и не имеет базового типа, совпадающего с типом <paramref name="enumType" />.</exception>
		// Token: 0x06001586 RID: 5510 RVA: 0x000555CE File Offset: 0x000537CE
		[ComVisible(true)]
		public static string GetName(Type enumType, object value)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			return enumType.GetEnumName(value);
		}

		/// <summary>Возвращает массив имен констант в указанном перечислении.</summary>
		/// <param name="enumType">Тип перечисления.</param>
		/// <returns>Строковый массив имен констант в <paramref name="enumType" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> — не <see cref="T:System.Enum" />.</exception>
		// Token: 0x06001587 RID: 5511 RVA: 0x000555EB File Offset: 0x000537EB
		[ComVisible(true)]
		public static string[] GetNames(Type enumType)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			return enumType.GetEnumNames();
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00055607 File Offset: 0x00053807
		internal static string[] InternalGetNames(RuntimeType enumType)
		{
			return Enum.GetCachedValuesAndNames(enumType, true).Names;
		}

		/// <summary>Преобразует заданный объект с целочисленным значением в член перечисления.</summary>
		/// <param name="enumType">Тип перечисления, который необходимо вернуть.</param>
		/// <param name="value">Значение, которое необходимо преобразовать в член перечисления.</param>
		/// <returns>Объект перечисления, значение которого равно <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="enumType" /> или <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> не является классом <see cref="T:System.Enum" />.  
		/// -или- 
		///  <paramref name="value" /> не является типом <see cref="T:System.SByte" />, <see cref="T:System.Int16" />, <see cref="T:System.Int32" />, <see cref="T:System.Int64" />, <see cref="T:System.Byte" />, <see cref="T:System.UInt16" />, <see cref="T:System.UInt32" /> или <see cref="T:System.UInt64" />.</exception>
		// Token: 0x06001589 RID: 5513 RVA: 0x00055618 File Offset: 0x00053818
		[ComVisible(true)]
		public static object ToObject(Type enumType, object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			switch (Convert.GetTypeCode(value))
			{
			case TypeCode.Boolean:
				return Enum.ToObject(enumType, (bool)value);
			case TypeCode.Char:
				return Enum.ToObject(enumType, (char)value);
			case TypeCode.SByte:
				return Enum.ToObject(enumType, (sbyte)value);
			case TypeCode.Byte:
				return Enum.ToObject(enumType, (byte)value);
			case TypeCode.Int16:
				return Enum.ToObject(enumType, (short)value);
			case TypeCode.UInt16:
				return Enum.ToObject(enumType, (ushort)value);
			case TypeCode.Int32:
				return Enum.ToObject(enumType, (int)value);
			case TypeCode.UInt32:
				return Enum.ToObject(enumType, (uint)value);
			case TypeCode.Int64:
				return Enum.ToObject(enumType, (long)value);
			case TypeCode.UInt64:
				return Enum.ToObject(enumType, (ulong)value);
			default:
				throw new ArgumentException(Environment.GetResourceString("The value passed in must be an enum base or an underlying type for an enum, such as an Int32."), "value");
			}
		}

		/// <summary>Возвращает логическое значение, указывающее, существует ли заданное целочисленное значение или его имя в виде строки в заданном перечислении.</summary>
		/// <param name="enumType">Тип перечисления.</param>
		/// <param name="value">Значение или имя константы в <paramref name="enumType" />.</param>
		/// <returns>Значение <see langword="true" />, если константа в <paramref name="enumType" /> имеет значение <paramref name="value" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="enumType" /> или <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> не является классом <see langword="Enum" />.  
		/// -или- 
		/// Тип <paramref name="value" /> является перечислением, но не является перечислением типа <paramref name="enumType" />.  
		/// -или- 
		/// Тип <paramref name="value" /> не является базовым типом <paramref name="enumType" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="value" /> не является типом <see cref="T:System.SByte" />, <see cref="T:System.Int16" />, <see cref="T:System.Int32" />, <see cref="T:System.Int64" />, <see cref="T:System.Byte" />, <see cref="T:System.UInt16" />, <see cref="T:System.UInt32" />, <see cref="T:System.UInt64" /> или <see cref="T:System.String" />.</exception>
		// Token: 0x0600158A RID: 5514 RVA: 0x00055705 File Offset: 0x00053905
		[ComVisible(true)]
		public static bool IsDefined(Type enumType, object value)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			return enumType.IsEnumDefined(value);
		}

		/// <summary>Преобразует указанное значение заданного перечислимого типа в эквивалентное строковое представление в соответствии с заданным форматом.</summary>
		/// <param name="enumType">Тип перечисления преобразуемого значения.</param>
		/// <param name="value">Преобразуемое значение.</param>
		/// <param name="format">Используемый формат вывода.</param>
		/// <returns>Строковое представление параметра <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="enumType" />, <paramref name="value" /> или <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> не принадлежит типу <see cref="T:System.Enum" />.  
		/// -или- 
		/// <paramref name="value" /> принадлежит перечислению, которое отличается от <paramref name="enumType" /> по типу.  
		/// -или- 
		/// Тип <paramref name="value" /> не является базовым типом <paramref name="enumType" />.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="format" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="format" /> равен X, но тип перечисления неизвестен.</exception>
		// Token: 0x0600158B RID: 5515 RVA: 0x00055724 File Offset: 0x00053924
		[ComVisible(true)]
		public static string Format(Type enumType, object value, string format)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			if (!enumType.IsEnum)
			{
				throw new ArgumentException(Environment.GetResourceString("Type provided must be an Enum."), "enumType");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (format == null)
			{
				throw new ArgumentNullException("format");
			}
			RuntimeType runtimeType = enumType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "enumType");
			}
			Type type = value.GetType();
			Type underlyingType = Enum.GetUnderlyingType(enumType);
			if (type.IsEnum)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(type);
				if (!type.IsEquivalentTo(enumType))
				{
					throw new ArgumentException(Environment.GetResourceString("Object must be the same type as the enum. The type passed in was '{0}'; the enum type was '{1}'.", new object[]
					{
						type.ToString(),
						enumType.ToString()
					}));
				}
				value = ((Enum)value).GetValue();
			}
			else if (type != underlyingType)
			{
				throw new ArgumentException(Environment.GetResourceString("Enum underlying type and the object must be same type or object. Type passed in was '{0}'; the enum underlying type was '{1}'.", new object[]
				{
					type.ToString(),
					underlyingType.ToString()
				}));
			}
			if (format.Length != 1)
			{
				throw new FormatException(Environment.GetResourceString("Format String can be only \"G\", \"g\", \"X\", \"x\", \"F\", \"f\", \"D\" or \"d\"."));
			}
			char c = format[0];
			if (c == 'D' || c == 'd')
			{
				return value.ToString();
			}
			if (c == 'X' || c == 'x')
			{
				return Enum.InternalFormattedHexString(value);
			}
			if (c == 'G' || c == 'g')
			{
				return Enum.InternalFormat(runtimeType, value);
			}
			if (c == 'F' || c == 'f')
			{
				return Enum.InternalFlagsFormat(runtimeType, value);
			}
			throw new FormatException(Environment.GetResourceString("Format String can be only \"G\", \"g\", \"X\", \"x\", \"F\", \"f\", \"D\" or \"d\"."));
		}

		// Token: 0x0600158C RID: 5516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern object get_value();

		// Token: 0x0600158D RID: 5517 RVA: 0x000558AB File Offset: 0x00053AAB
		[SecuritySafeCritical]
		internal object GetValue()
		{
			return this.get_value();
		}

		// Token: 0x0600158E RID: 5518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool InternalHasFlag(Enum flags);

		// Token: 0x0600158F RID: 5519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int get_hashcode();

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром, или значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="obj" /> является значением перечисления того же типа и с тем же базовым значением, что и у этого экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001590 RID: 5520 RVA: 0x000558B3 File Offset: 0x00053AB3
		public override bool Equals(object obj)
		{
			return ValueType.DefaultEquals(this, obj);
		}

		/// <summary>Возвращает хэш-код для значения данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001591 RID: 5521 RVA: 0x000558BC File Offset: 0x00053ABC
		[SecuritySafeCritical]
		public override int GetHashCode()
		{
			return this.get_hashcode();
		}

		/// <summary>Преобразует значение этого экземпляра в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление значения этого экземпляра.</returns>
		// Token: 0x06001592 RID: 5522 RVA: 0x000558C4 File Offset: 0x00053AC4
		public override string ToString()
		{
			return Enum.InternalFormat((RuntimeType)base.GetType(), this.GetValue());
		}

		/// <summary>Эта перегрузка метода является устаревшей. Используйте <see cref="M:System.Enum.ToString(System.String)" />.</summary>
		/// <param name="format">Спецификация формата.</param>
		/// <param name="provider">(Является устаревшим.)</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметром <paramref name="format" />.</returns>
		/// <exception cref="T:System.FormatException">Формат <paramref name="format" /> не содержит допустимой спецификации формата.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="format" /> равен X, но тип перечисления неизвестен.</exception>
		// Token: 0x06001593 RID: 5523 RVA: 0x000558DC File Offset: 0x00053ADC
		[Obsolete("The provider argument is not used. Please use ToString(String).")]
		public string ToString(string format, IFormatProvider provider)
		{
			return this.ToString(format);
		}

		/// <summary>Сравнивает этот экземпляр с заданным объектом и возвращает значение, указывающее, как соотносятся значения этих объектов.</summary>
		/// <param name="target">Объект для сравнения или значение <see langword="null" />.</param>
		/// <returns>Число со знаком, представляющее относительные значения этого экземпляра и параметра <paramref name="target" />.  
		///   Значение 
		///   Значение 
		///   Меньше нуля 
		///   Значение данного экземпляра меньше значения параметра <paramref name="target" />.  
		///
		///   Нуль 
		///   Значение данного экземпляра равно значению параметра <paramref name="target" />.  
		///
		///   Больше нуля 
		///   Значение данного экземпляра больше значения параметра <paramref name="target" />.  
		///
		/// -или- 
		///  <paramref name="target" /> — <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> и этот экземпляр не принадлежат к одному типу.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот экземпляр не является типом <see cref="T:System.SByte" />, <see cref="T:System.Int16" />, <see cref="T:System.Int32" />, <see cref="T:System.Int64" />, <see cref="T:System.Byte" />, <see cref="T:System.UInt16" />, <see cref="T:System.UInt32" /> или <see cref="T:System.UInt64" />.</exception>
		/// <exception cref="T:System.NullReferenceException">Этот экземпляр имеет значение NULL.</exception>
		// Token: 0x06001594 RID: 5524 RVA: 0x000558E8 File Offset: 0x00053AE8
		[SecuritySafeCritical]
		public int CompareTo(object target)
		{
			if (this == null)
			{
				throw new NullReferenceException();
			}
			int num = Enum.InternalCompareTo(this, target);
			if (num < 2)
			{
				return num;
			}
			if (num == 2)
			{
				Type type = base.GetType();
				Type type2 = target.GetType();
				throw new ArgumentException(Environment.GetResourceString("Object must be the same type as the enum. The type passed in was '{0}'; the enum type was '{1}'.", new object[]
				{
					type2.ToString(),
					type.ToString()
				}));
			}
			throw new InvalidOperationException(Environment.GetResourceString("Unknown enum type."));
		}

		/// <summary>Преобразует числовое значение этого экземпляра в эквивалентное ему строковое представление с использованием указанного формата.</summary>
		/// <param name="format">Строка формата.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметром <paramref name="format" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> содержит недопустимую спецификацию.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="format" /> равен X, но тип перечисления неизвестен.</exception>
		// Token: 0x06001595 RID: 5525 RVA: 0x00055958 File Offset: 0x00053B58
		public string ToString(string format)
		{
			if (format == null || format.Length == 0)
			{
				format = "G";
			}
			if (string.Compare(format, "G", StringComparison.OrdinalIgnoreCase) == 0)
			{
				return this.ToString();
			}
			if (string.Compare(format, "D", StringComparison.OrdinalIgnoreCase) == 0)
			{
				return this.GetValue().ToString();
			}
			if (string.Compare(format, "X", StringComparison.OrdinalIgnoreCase) == 0)
			{
				return Enum.InternalFormattedHexString(this.GetValue());
			}
			if (string.Compare(format, "F", StringComparison.OrdinalIgnoreCase) == 0)
			{
				return Enum.InternalFlagsFormat((RuntimeType)base.GetType(), this.GetValue());
			}
			throw new FormatException(Environment.GetResourceString("Format String can be only \"G\", \"g\", \"X\", \"x\", \"F\", \"f\", \"D\" or \"d\"."));
		}

		/// <summary>Эта перегрузка метода является устаревшей. Используйте <see cref="M:System.Enum.ToString" />.</summary>
		/// <param name="provider">(Является устаревшим.)</param>
		/// <returns>Строковое представление значения этого экземпляра.</returns>
		// Token: 0x06001596 RID: 5526 RVA: 0x000559F4 File Offset: 0x00053BF4
		[Obsolete("The provider argument is not used. Please use ToString().")]
		public string ToString(IFormatProvider provider)
		{
			return this.ToString();
		}

		/// <summary>Определяет, установлены ли в текущем экземпляре одно или несколько битовых полей.</summary>
		/// <param name="flag">Значение перечисления.</param>
		/// <returns>Значение <see langword="true" />, если одно или несколько битовых полей, установленных в параметре <paramref name="flag" />, также установлены в текущем экземпляре; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="flag" /> — тип, отличный от текущего экземпляра.</exception>
		// Token: 0x06001597 RID: 5527 RVA: 0x000559FC File Offset: 0x00053BFC
		[SecuritySafeCritical]
		public bool HasFlag(Enum flag)
		{
			if (flag == null)
			{
				throw new ArgumentNullException("flag");
			}
			if (!base.GetType().IsEquivalentTo(flag.GetType()))
			{
				throw new ArgumentException(Environment.GetResourceString("The argument type, '{0}', is not the same as the enum type '{1}'.", new object[]
				{
					flag.GetType(),
					base.GetType()
				}));
			}
			return this.InternalHasFlag(flag);
		}

		/// <summary>Возвращает код типа базового типа члена этого перечисления.</summary>
		/// <returns>Код типа базового типа этого экземпляра.</returns>
		/// <exception cref="T:System.InvalidOperationException">Тип перечисления неизвестен.</exception>
		// Token: 0x06001598 RID: 5528 RVA: 0x00055A5C File Offset: 0x00053C5C
		public TypeCode GetTypeCode()
		{
			Type underlyingType = Enum.GetUnderlyingType(base.GetType());
			if (underlyingType == typeof(int))
			{
				return TypeCode.Int32;
			}
			if (underlyingType == typeof(sbyte))
			{
				return TypeCode.SByte;
			}
			if (underlyingType == typeof(short))
			{
				return TypeCode.Int16;
			}
			if (underlyingType == typeof(long))
			{
				return TypeCode.Int64;
			}
			if (underlyingType == typeof(uint))
			{
				return TypeCode.UInt32;
			}
			if (underlyingType == typeof(byte))
			{
				return TypeCode.Byte;
			}
			if (underlyingType == typeof(ushort))
			{
				return TypeCode.UInt16;
			}
			if (underlyingType == typeof(ulong))
			{
				return TypeCode.UInt64;
			}
			if (underlyingType == typeof(bool))
			{
				return TypeCode.Boolean;
			}
			if (underlyingType == typeof(char))
			{
				return TypeCode.Char;
			}
			throw new InvalidOperationException(Environment.GetResourceString("Unknown enum type."));
		}

		/// <summary>Преобразует текущее значение в логическое значение на основе его базового типа.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Этот член всегда выбрасывает исключение.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06001599 RID: 5529 RVA: 0x00055B50 File Offset: 0x00053D50
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this.GetValue(), CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует текущее значение в символ Юникода на основе его базового типа.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Этот член всегда выбрасывает исключение.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x0600159A RID: 5530 RVA: 0x00055B62 File Offset: 0x00053D62
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this.GetValue(), CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует текущее значение в 8-битовое целое число со знаком на основе его базового типа.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Преобразованное значение.</returns>
		// Token: 0x0600159B RID: 5531 RVA: 0x00055B74 File Offset: 0x00053D74
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this.GetValue(), CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует текущее значение в 8-битовое целое число без знака на основе базового типа.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Преобразованное значение.</returns>
		// Token: 0x0600159C RID: 5532 RVA: 0x00055B86 File Offset: 0x00053D86
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this.GetValue(), CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует текущее значение в 16-битовое целое число со знаком на основе его базового типа.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Преобразованное значение.</returns>
		// Token: 0x0600159D RID: 5533 RVA: 0x00055B98 File Offset: 0x00053D98
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this.GetValue(), CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует текущее значение в 16-битовое целое число без знака на основе его базового типа.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Преобразованное значение.</returns>
		// Token: 0x0600159E RID: 5534 RVA: 0x00055BAA File Offset: 0x00053DAA
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this.GetValue(), CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует текущее значение в 32-битовое целое число со знаком на основе его базового типа.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Преобразованное значение.</returns>
		// Token: 0x0600159F RID: 5535 RVA: 0x00055BBC File Offset: 0x00053DBC
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this.GetValue(), CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует текущее значение в 32-битовое целое число без знака на основе его базового типа.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Преобразованное значение.</returns>
		// Token: 0x060015A0 RID: 5536 RVA: 0x00055BCE File Offset: 0x00053DCE
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this.GetValue(), CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует текущее значение в 64-битовое целое число со знаком на основе его базового типа.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Преобразованное значение.</returns>
		// Token: 0x060015A1 RID: 5537 RVA: 0x00055BE0 File Offset: 0x00053DE0
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this.GetValue(), CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует текущее значение в 64-битовое целое число без знака на основе его базового типа.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Преобразованное значение.</returns>
		// Token: 0x060015A2 RID: 5538 RVA: 0x00055BF2 File Offset: 0x00053DF2
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this.GetValue(), CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует текущее значение в число с плавающей запятой одиночной точности на основе его базового типа.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Этот член всегда выбрасывает исключение.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x060015A3 RID: 5539 RVA: 0x00055C04 File Offset: 0x00053E04
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this.GetValue(), CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует текущее значение объекта в число двойной точности с плавающей запятой на основе его базового типа.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Этот член всегда выбрасывает исключение.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x060015A4 RID: 5540 RVA: 0x00055C16 File Offset: 0x00053E16
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this.GetValue(), CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует текущее значение в значение типа <see cref="T:System.Decimal" /> на основе его базового типа.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Этот член всегда выбрасывает исключение.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x060015A5 RID: 5541 RVA: 0x00055C28 File Offset: 0x00053E28
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this.GetValue(), CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует текущее значение в значение типа <see cref="T:System.DateTime" /> на основе его базового типа.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Этот член всегда выбрасывает исключение.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x060015A6 RID: 5542 RVA: 0x00055C3A File Offset: 0x00053E3A
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(Environment.GetResourceString("Invalid cast from '{0}' to '{1}'.", new object[]
			{
				"Enum",
				"DateTime"
			}));
		}

		/// <summary>Преобразует текущее значение к заданному типу на основе его базового типа.</summary>
		/// <param name="type">Целевой тип преобразования.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Преобразованное значение.</returns>
		// Token: 0x060015A7 RID: 5543 RVA: 0x0001931A File Offset: 0x0001751A
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		/// <summary>Преобразует значение заданного 8-разрядного знакового целого числа в член перечисления.</summary>
		/// <param name="enumType">Тип перечисления, который необходимо вернуть.</param>
		/// <param name="value">Значение, которое необходимо преобразовать в член перечисления.</param>
		/// <returns>Экземпляр перечисления, которому присвоено значение <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> не является классом <see cref="T:System.Enum" />.</exception>
		// Token: 0x060015A8 RID: 5544 RVA: 0x00055C64 File Offset: 0x00053E64
		[ComVisible(true)]
		[CLSCompliant(false)]
		[SecuritySafeCritical]
		public static object ToObject(Type enumType, sbyte value)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			if (!enumType.IsEnum)
			{
				throw new ArgumentException(Environment.GetResourceString("Type provided must be an Enum."), "enumType");
			}
			RuntimeType runtimeType = enumType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "enumType");
			}
			return Enum.InternalBoxEnum(runtimeType, (long)value);
		}

		/// <summary>Преобразует значение заданного 16-разрядного знакового целого числа в член перечисления.</summary>
		/// <param name="enumType">Тип перечисления, который необходимо вернуть.</param>
		/// <param name="value">Значение, которое необходимо преобразовать в член перечисления.</param>
		/// <returns>Экземпляр перечисления, которому присвоено значение <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> не является классом <see cref="T:System.Enum" />.</exception>
		// Token: 0x060015A9 RID: 5545 RVA: 0x00055CD0 File Offset: 0x00053ED0
		[ComVisible(true)]
		[SecuritySafeCritical]
		public static object ToObject(Type enumType, short value)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			if (!enumType.IsEnum)
			{
				throw new ArgumentException(Environment.GetResourceString("Type provided must be an Enum."), "enumType");
			}
			RuntimeType runtimeType = enumType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "enumType");
			}
			return Enum.InternalBoxEnum(runtimeType, (long)value);
		}

		/// <summary>Преобразует значение заданного 32-разрядного знакового целого числа в член перечисления.</summary>
		/// <param name="enumType">Тип перечисления, который необходимо вернуть.</param>
		/// <param name="value">Значение, которое необходимо преобразовать в член перечисления.</param>
		/// <returns>Экземпляр перечисления, которому присвоено значение <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> не является классом <see cref="T:System.Enum" />.</exception>
		// Token: 0x060015AA RID: 5546 RVA: 0x00055D3C File Offset: 0x00053F3C
		[ComVisible(true)]
		[SecuritySafeCritical]
		public static object ToObject(Type enumType, int value)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			if (!enumType.IsEnum)
			{
				throw new ArgumentException(Environment.GetResourceString("Type provided must be an Enum."), "enumType");
			}
			RuntimeType runtimeType = enumType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "enumType");
			}
			return Enum.InternalBoxEnum(runtimeType, (long)value);
		}

		/// <summary>Преобразует значение заданного 8-разрядного целого числа в член перечисления.</summary>
		/// <param name="enumType">Тип перечисления, который необходимо вернуть.</param>
		/// <param name="value">Значение, которое необходимо преобразовать в член перечисления.</param>
		/// <returns>Экземпляр перечисления, которому присвоено значение <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> не является классом <see cref="T:System.Enum" />.</exception>
		// Token: 0x060015AB RID: 5547 RVA: 0x00055DA8 File Offset: 0x00053FA8
		[ComVisible(true)]
		[SecuritySafeCritical]
		public static object ToObject(Type enumType, byte value)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			if (!enumType.IsEnum)
			{
				throw new ArgumentException(Environment.GetResourceString("Type provided must be an Enum."), "enumType");
			}
			RuntimeType runtimeType = enumType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "enumType");
			}
			return Enum.InternalBoxEnum(runtimeType, (long)((ulong)value));
		}

		/// <summary>Преобразует значение заданного 16-разрядного целого числа без знака в член перечисления.</summary>
		/// <param name="enumType">Тип перечисления, который необходимо вернуть.</param>
		/// <param name="value">Значение, которое необходимо преобразовать в член перечисления.</param>
		/// <returns>Экземпляр перечисления, которому присвоено значение <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> не является классом <see cref="T:System.Enum" />.</exception>
		// Token: 0x060015AC RID: 5548 RVA: 0x00055E14 File Offset: 0x00054014
		[CLSCompliant(false)]
		[ComVisible(true)]
		[SecuritySafeCritical]
		public static object ToObject(Type enumType, ushort value)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			if (!enumType.IsEnum)
			{
				throw new ArgumentException(Environment.GetResourceString("Type provided must be an Enum."), "enumType");
			}
			RuntimeType runtimeType = enumType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "enumType");
			}
			return Enum.InternalBoxEnum(runtimeType, (long)((ulong)value));
		}

		/// <summary>Преобразует значение заданного 32-разрядного целого числа без знака в член перечисления.</summary>
		/// <param name="enumType">Тип перечисления, который необходимо вернуть.</param>
		/// <param name="value">Значение, которое необходимо преобразовать в член перечисления.</param>
		/// <returns>Экземпляр перечисления, которому присвоено значение <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> не является классом <see cref="T:System.Enum" />.</exception>
		// Token: 0x060015AD RID: 5549 RVA: 0x00055E80 File Offset: 0x00054080
		[SecuritySafeCritical]
		[CLSCompliant(false)]
		[ComVisible(true)]
		public static object ToObject(Type enumType, uint value)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			if (!enumType.IsEnum)
			{
				throw new ArgumentException(Environment.GetResourceString("Type provided must be an Enum."), "enumType");
			}
			RuntimeType runtimeType = enumType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "enumType");
			}
			return Enum.InternalBoxEnum(runtimeType, (long)((ulong)value));
		}

		/// <summary>Преобразует значение заданного 64-разрядного знакового целого числа в член перечисления.</summary>
		/// <param name="enumType">Тип перечисления, который необходимо вернуть.</param>
		/// <param name="value">Значение, которое необходимо преобразовать в член перечисления.</param>
		/// <returns>Экземпляр перечисления, которому присвоено значение <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> не является классом <see cref="T:System.Enum" />.</exception>
		// Token: 0x060015AE RID: 5550 RVA: 0x00055EEC File Offset: 0x000540EC
		[ComVisible(true)]
		[SecuritySafeCritical]
		public static object ToObject(Type enumType, long value)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			if (!enumType.IsEnum)
			{
				throw new ArgumentException(Environment.GetResourceString("Type provided must be an Enum."), "enumType");
			}
			RuntimeType runtimeType = enumType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "enumType");
			}
			return Enum.InternalBoxEnum(runtimeType, value);
		}

		/// <summary>Преобразует значение заданного 64-разрядного целого числа без знака в член перечисления.</summary>
		/// <param name="enumType">Тип перечисления, который необходимо вернуть.</param>
		/// <param name="value">Значение, которое необходимо преобразовать в член перечисления.</param>
		/// <returns>Экземпляр перечисления, которому присвоено значение <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="enumType" /> не является классом <see cref="T:System.Enum" />.</exception>
		// Token: 0x060015AF RID: 5551 RVA: 0x00055F54 File Offset: 0x00054154
		[ComVisible(true)]
		[CLSCompliant(false)]
		[SecuritySafeCritical]
		public static object ToObject(Type enumType, ulong value)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			if (!enumType.IsEnum)
			{
				throw new ArgumentException(Environment.GetResourceString("Type provided must be an Enum."), "enumType");
			}
			RuntimeType runtimeType = enumType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "enumType");
			}
			return Enum.InternalBoxEnum(runtimeType, (long)value);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x00055FBC File Offset: 0x000541BC
		[SecuritySafeCritical]
		private static object ToObject(Type enumType, char value)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			if (!enumType.IsEnum)
			{
				throw new ArgumentException(Environment.GetResourceString("Type provided must be an Enum."), "enumType");
			}
			RuntimeType runtimeType = enumType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "enumType");
			}
			return Enum.InternalBoxEnum(runtimeType, (long)((ulong)value));
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x00056028 File Offset: 0x00054228
		[SecuritySafeCritical]
		private static object ToObject(Type enumType, bool value)
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			if (!enumType.IsEnum)
			{
				throw new ArgumentException(Environment.GetResourceString("Type provided must be an Enum."), "enumType");
			}
			RuntimeType runtimeType = enumType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "enumType");
			}
			return Enum.InternalBoxEnum(runtimeType, value ? 1L : 0L);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x00056097 File Offset: 0x00054297
		public static TEnum Parse<TEnum>(string value) where TEnum : struct
		{
			return Enum.Parse<TEnum>(value, false);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x000560A0 File Offset: 0x000542A0
		public static TEnum Parse<TEnum>(string value, bool ignoreCase) where TEnum : struct
		{
			Enum.EnumResult enumResult = new Enum.EnumResult
			{
				canThrow = true
			};
			if (Enum.TryParseEnum(typeof(TEnum), value, ignoreCase, ref enumResult))
			{
				return (TEnum)((object)enumResult.parsedEnum);
			}
			throw enumResult.GetEnumParseException();
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x000560E8 File Offset: 0x000542E8
		public static bool TryParse(Type enumType, string value, bool ignoreCase, out object result)
		{
			result = null;
			Enum.EnumResult enumResult = default(Enum.EnumResult);
			bool flag = Enum.TryParseEnum(enumType, value, ignoreCase, ref enumResult);
			if (flag)
			{
				result = enumResult.parsedEnum;
			}
			return flag;
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00056115 File Offset: 0x00054315
		public static bool TryParse(Type enumType, string value, out object result)
		{
			return Enum.TryParse(enumType, value, false, out result);
		}

		// Token: 0x0400150E RID: 5390
		private static readonly char[] enumSeperatorCharArray = new char[]
		{
			','
		};

		// Token: 0x0400150F RID: 5391
		private const string enumSeperator = ", ";

		// Token: 0x020001F6 RID: 502
		private enum ParseFailureKind
		{
			// Token: 0x04001511 RID: 5393
			None,
			// Token: 0x04001512 RID: 5394
			Argument,
			// Token: 0x04001513 RID: 5395
			ArgumentNull,
			// Token: 0x04001514 RID: 5396
			ArgumentWithParameter,
			// Token: 0x04001515 RID: 5397
			UnhandledException
		}

		// Token: 0x020001F7 RID: 503
		private struct EnumResult
		{
			// Token: 0x060015B8 RID: 5560 RVA: 0x0005613A File Offset: 0x0005433A
			internal void Init(bool canMethodThrow)
			{
				this.parsedEnum = 0;
				this.canThrow = canMethodThrow;
			}

			// Token: 0x060015B9 RID: 5561 RVA: 0x0005614F File Offset: 0x0005434F
			internal void SetFailure(Exception unhandledException)
			{
				this.m_failure = Enum.ParseFailureKind.UnhandledException;
				this.m_innerException = unhandledException;
			}

			// Token: 0x060015BA RID: 5562 RVA: 0x0005615F File Offset: 0x0005435F
			internal void SetFailure(Enum.ParseFailureKind failure, string failureParameter)
			{
				this.m_failure = failure;
				this.m_failureParameter = failureParameter;
				if (this.canThrow)
				{
					throw this.GetEnumParseException();
				}
			}

			// Token: 0x060015BB RID: 5563 RVA: 0x0005617E File Offset: 0x0005437E
			internal void SetFailure(Enum.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
			{
				this.m_failure = failure;
				this.m_failureMessageID = failureMessageID;
				this.m_failureMessageFormatArgument = failureMessageFormatArgument;
				if (this.canThrow)
				{
					throw this.GetEnumParseException();
				}
			}

			// Token: 0x060015BC RID: 5564 RVA: 0x000561A4 File Offset: 0x000543A4
			internal Exception GetEnumParseException()
			{
				switch (this.m_failure)
				{
				case Enum.ParseFailureKind.Argument:
					return new ArgumentException(Environment.GetResourceString(this.m_failureMessageID));
				case Enum.ParseFailureKind.ArgumentNull:
					return new ArgumentNullException(this.m_failureParameter);
				case Enum.ParseFailureKind.ArgumentWithParameter:
					return new ArgumentException(Environment.GetResourceString(this.m_failureMessageID, new object[]
					{
						this.m_failureMessageFormatArgument
					}));
				case Enum.ParseFailureKind.UnhandledException:
					return this.m_innerException;
				default:
					return new ArgumentException(Environment.GetResourceString("Requested value '{0}' was not found."));
				}
			}

			// Token: 0x04001516 RID: 5398
			internal object parsedEnum;

			// Token: 0x04001517 RID: 5399
			internal bool canThrow;

			// Token: 0x04001518 RID: 5400
			internal Enum.ParseFailureKind m_failure;

			// Token: 0x04001519 RID: 5401
			internal string m_failureMessageID;

			// Token: 0x0400151A RID: 5402
			internal string m_failureParameter;

			// Token: 0x0400151B RID: 5403
			internal object m_failureMessageFormatArgument;

			// Token: 0x0400151C RID: 5404
			internal Exception m_innerException;
		}

		// Token: 0x020001F8 RID: 504
		private class ValuesAndNames
		{
			// Token: 0x060015BD RID: 5565 RVA: 0x00056225 File Offset: 0x00054425
			public ValuesAndNames(ulong[] values, string[] names)
			{
				this.Values = values;
				this.Names = names;
			}

			// Token: 0x0400151D RID: 5405
			public ulong[] Values;

			// Token: 0x0400151E RID: 5406
			public string[] Names;
		}
	}
}
