using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace System.Reflection
{
	/// <summary>Представляет аргумент настраиваемого атрибута в контексте только для отражения или элемент аргумента массива.</summary>
	// Token: 0x020008DE RID: 2270
	public struct CustomAttributeTypedArgument
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.CustomAttributeTypedArgument" />, используя заданное значение.</summary>
		/// <param name="value">Значение аргумента настраиваемого атрибута.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B9B RID: 19355 RVA: 0x000F0D1C File Offset: 0x000EEF1C
		public CustomAttributeTypedArgument(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this.Value = CustomAttributeTypedArgument.CanonicalizeValue(value);
			this.ArgumentType = value.GetType();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> заданным типом и значением.</summary>
		/// <param name="argumentType">Тип аргумента настраиваемого атрибута.</param>
		/// <param name="value">Значение аргумента настраиваемого атрибута.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="argumentType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B9C RID: 19356 RVA: 0x000F0D44 File Offset: 0x000EEF44
		public CustomAttributeTypedArgument(Type argumentType, object value)
		{
			if (argumentType == null)
			{
				throw new ArgumentNullException("argumentType");
			}
			this.Value = ((value == null) ? null : CustomAttributeTypedArgument.CanonicalizeValue(value));
			this.ArgumentType = argumentType;
			Array array = value as Array;
			if (array != null)
			{
				Type elementType = array.GetType().GetElementType();
				CustomAttributeTypedArgument[] array2 = new CustomAttributeTypedArgument[array.GetLength(0)];
				for (int i = 0; i < array2.Length; i++)
				{
					object value2 = array.GetValue(i);
					Type argumentType2 = (elementType == typeof(object) && value2 != null) ? value2.GetType() : elementType;
					array2[i] = new CustomAttributeTypedArgument(argumentType2, value2);
				}
				this.Value = new ReadOnlyCollection<CustomAttributeTypedArgument>(array2);
			}
		}

		/// <summary>Получает тип аргумента или элемента аргумента-массива.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип аргумента или элемента массива.</returns>
		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06004B9D RID: 19357 RVA: 0x000F0DF6 File Offset: 0x000EEFF6
		public readonly Type ArgumentType { get; }

		/// <summary>Получает значение аргумента для простого аргумента или элемента аргумента-массива; получает коллекцию значений для аргумента-массива.</summary>
		/// <returns>Объект, представляющий значение аргумента или элемента, или универсальная коллекция <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> объектов <see cref="T:System.Reflection.CustomAttributeTypedArgument" />, которая представляет значения аргумента типа массива.</returns>
		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06004B9E RID: 19358 RVA: 0x000F0DFE File Offset: 0x000EEFFE
		public readonly object Value { get; }

		/// <summary>Указывает, равен ли этот экземпляр заданному объекту.</summary>
		/// <param name="obj">Другой объект, подлежащий сравнению.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="obj" /> и данный экземпляр относятся к одному типу и представляют одинаковые значения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004B9F RID: 19359 RVA: 0x000F0E06 File Offset: 0x000EF006
		public override bool Equals(object obj)
		{
			return obj == this;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>32-разрядное целое число со знаком, являющееся хэш-кодом для данного экземпляра.</returns>
		// Token: 0x06004BA0 RID: 19360 RVA: 0x000F0E16 File Offset: 0x000EF016
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Проверяет равенство двух структур <see cref="T:System.Reflection.CustomAttributeTypedArgument" />.</summary>
		/// <param name="left">Структура <see cref="T:System.Reflection.CustomAttributeTypedArgument" />, которая находится слева от оператора равенства.</param>
		/// <param name="right">Структура <see cref="T:System.Reflection.CustomAttributeTypedArgument" />, которая находится справа от оператора равенства.</param>
		/// <returns>
		///   <see langword="true" />, если обе структуры <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004BA1 RID: 19361 RVA: 0x000F0E28 File Offset: 0x000EF028
		public static bool operator ==(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
		{
			return left.Equals(right);
		}

		/// <summary>Определяет равенство двух структур <see cref="T:System.Reflection.CustomAttributeTypedArgument" />.</summary>
		/// <param name="left">Структура <see cref="T:System.Reflection.CustomAttributeTypedArgument" />, которая находится слева от оператора неравенства.</param>
		/// <param name="right">Структура <see cref="T:System.Reflection.CustomAttributeTypedArgument" />, которая находится справа от оператора неравенства.</param>
		/// <returns>
		///   <see langword="true" />, если две структуры <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> различаются; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004BA2 RID: 19362 RVA: 0x000F0E3D File Offset: 0x000EF03D
		public static bool operator !=(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
		{
			return !left.Equals(right);
		}

		/// <summary>Возвращает строку, состоящую из имени аргумента, знака равенства и строкового представления значения аргумента.</summary>
		/// <returns>Строка, состоящая из имени аргумента, знака равенства и строкового представления значения аргумента.</returns>
		// Token: 0x06004BA3 RID: 19363 RVA: 0x000F0E55 File Offset: 0x000EF055
		public override string ToString()
		{
			return this.ToString(false);
		}

		// Token: 0x06004BA4 RID: 19364 RVA: 0x000F0E60 File Offset: 0x000EF060
		internal string ToString(bool typed)
		{
			if (this.ArgumentType == null)
			{
				return base.ToString();
			}
			string result;
			try
			{
				if (this.ArgumentType.IsEnum)
				{
					result = string.Format(CultureInfo.CurrentCulture, typed ? "{0}" : "({1}){0}", this.Value, this.ArgumentType.FullNameOrDefault);
				}
				else if (this.Value == null)
				{
					result = string.Format(CultureInfo.CurrentCulture, typed ? "null" : "({0})null", this.ArgumentType.NameOrDefault);
				}
				else if (this.ArgumentType == typeof(string))
				{
					result = string.Format(CultureInfo.CurrentCulture, "\"{0}\"", this.Value);
				}
				else if (this.ArgumentType == typeof(char))
				{
					result = string.Format(CultureInfo.CurrentCulture, "'{0}'", this.Value);
				}
				else if (this.ArgumentType == typeof(Type))
				{
					result = string.Format(CultureInfo.CurrentCulture, "typeof({0})", ((Type)this.Value).FullNameOrDefault);
				}
				else if (this.ArgumentType.IsArray)
				{
					IList<CustomAttributeTypedArgument> list = this.Value as IList<CustomAttributeTypedArgument>;
					Type elementType = this.ArgumentType.GetElementType();
					string str = string.Format(CultureInfo.CurrentCulture, "new {0}[{1}] {{ ", elementType.IsEnum ? elementType.FullNameOrDefault : elementType.NameOrDefault, list.Count);
					for (int i = 0; i < list.Count; i++)
					{
						str += string.Format(CultureInfo.CurrentCulture, (i == 0) ? "{0}" : ", {0}", list[i].ToString(elementType != typeof(object)));
					}
					result = str + " }";
				}
				else
				{
					result = string.Format(CultureInfo.CurrentCulture, typed ? "{0}" : "({1}){0}", this.Value, this.ArgumentType.NameOrDefault);
				}
			}
			catch (MissingMetadataException)
			{
				result = base.ToString();
			}
			return result;
		}

		// Token: 0x06004BA5 RID: 19365 RVA: 0x000F10BC File Offset: 0x000EF2BC
		private static object CanonicalizeValue(object value)
		{
			if (value.GetType().IsEnum)
			{
				return ((Enum)value).GetValue();
			}
			return value;
		}
	}
}
