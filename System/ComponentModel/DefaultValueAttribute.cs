using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.ComponentModel
{
	/// <summary>Указывает значение свойства по умолчанию.</summary>
	// Token: 0x0200035E RID: 862
	[AttributeUsage(AttributeTargets.All)]
	public class DefaultValueAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DefaultValueAttribute" />, преобразуя при этом указанное значение к указанному типу. В качестве контекста перевода используется нейтральные настройки языка и региональных параметров.</summary>
		/// <param name="type">Тип <see cref="T:System.Type" />, задающий тип, к которому нужно преобразовать значение.</param>
		/// <param name="value">Строка <see cref="T:System.String" />, которая может быть преобразована к указанному типу с помощью преобразователя <see cref="T:System.ComponentModel.TypeConverter" /> для этого типа. Для преобразования используются языка и региональных параметров "Английский (США)".</param>
		// Token: 0x06001C94 RID: 7316 RVA: 0x00067718 File Offset: 0x00065918
		public DefaultValueAttribute(Type type, string value)
		{
			try
			{
				object value2;
				if (DefaultValueAttribute.<.ctor>g__TryConvertFromInvariantString|2_0(type, value, out value2))
				{
					this._value = value2;
				}
				else if (type.IsSubclassOf(typeof(Enum)))
				{
					this._value = Enum.Parse(type, value, true);
				}
				else if (type == typeof(TimeSpan))
				{
					this._value = TimeSpan.Parse(value);
				}
				else
				{
					this._value = Convert.ChangeType(value, type, CultureInfo.InvariantCulture);
				}
			}
			catch
			{
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DefaultValueAttribute" />, используя указанный знак Юникода.</summary>
		/// <param name="value">Знак Юникода, являющийся значением по умолчанию.</param>
		// Token: 0x06001C95 RID: 7317 RVA: 0x000677B0 File Offset: 0x000659B0
		public DefaultValueAttribute(char value)
		{
			this._value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DefaultValueAttribute" />, используя указанное 8-разрядное целое число без знака.</summary>
		/// <param name="value">8-разрядное целое число без знака, являющееся значением по умолчанию.</param>
		// Token: 0x06001C96 RID: 7318 RVA: 0x000677C4 File Offset: 0x000659C4
		public DefaultValueAttribute(byte value)
		{
			this._value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DefaultValueAttribute" />, используя указанное 16-разрядное целое число со знаком.</summary>
		/// <param name="value">16-разрядное целое число со знаком, являющееся значением по умолчанию.</param>
		// Token: 0x06001C97 RID: 7319 RVA: 0x000677D8 File Offset: 0x000659D8
		public DefaultValueAttribute(short value)
		{
			this._value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DefaultValueAttribute" />, используя указанное 32-разрядное целое число со знаком.</summary>
		/// <param name="value">32-разрядное целое число со знаком, являющееся значением по умолчанию.</param>
		// Token: 0x06001C98 RID: 7320 RVA: 0x000677EC File Offset: 0x000659EC
		public DefaultValueAttribute(int value)
		{
			this._value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DefaultValueAttribute" />, используя указанное 64-разрядное целое число со знаком.</summary>
		/// <param name="value">64-разрядное целое число со знаком, являющееся значением по умолчанию.</param>
		// Token: 0x06001C99 RID: 7321 RVA: 0x00067800 File Offset: 0x00065A00
		public DefaultValueAttribute(long value)
		{
			this._value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DefaultValueAttribute" />, используя указанное число с плавающей запятой с обычной точностью.</summary>
		/// <param name="value">Число с плавающей запятой с обычной точностью, являющееся значением по умолчанию.</param>
		// Token: 0x06001C9A RID: 7322 RVA: 0x00067814 File Offset: 0x00065A14
		public DefaultValueAttribute(float value)
		{
			this._value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DefaultValueAttribute" />, используя указанное число с плавающей запятой с удвоенной точностью.</summary>
		/// <param name="value">Число с плавающей запятой с удвоенной точностью, являющееся значением по умолчанию.</param>
		// Token: 0x06001C9B RID: 7323 RVA: 0x00067828 File Offset: 0x00065A28
		public DefaultValueAttribute(double value)
		{
			this._value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DefaultValueAttribute" />, используя указанное значение <see cref="T:System.Boolean" />.</summary>
		/// <param name="value">Значение <see cref="T:System.Boolean" />, являющееся значением по умолчанию.</param>
		// Token: 0x06001C9C RID: 7324 RVA: 0x0006783C File Offset: 0x00065A3C
		public DefaultValueAttribute(bool value)
		{
			this._value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DefaultValueAttribute" />, используя оператор <see cref="T:System.String" />.</summary>
		/// <param name="value">Значение <see cref="T:System.String" />, являющееся значением по умолчанию.</param>
		// Token: 0x06001C9D RID: 7325 RVA: 0x00067850 File Offset: 0x00065A50
		public DefaultValueAttribute(string value)
		{
			this._value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DefaultValueAttribute" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, представляющий значение по умолчанию.</param>
		// Token: 0x06001C9E RID: 7326 RVA: 0x00067850 File Offset: 0x00065A50
		public DefaultValueAttribute(object value)
		{
			this._value = value;
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0006785F File Offset: 0x00065A5F
		[CLSCompliant(false)]
		public DefaultValueAttribute(sbyte value)
		{
			this._value = value;
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x00067873 File Offset: 0x00065A73
		[CLSCompliant(false)]
		public DefaultValueAttribute(ushort value)
		{
			this._value = value;
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x00067887 File Offset: 0x00065A87
		[CLSCompliant(false)]
		public DefaultValueAttribute(uint value)
		{
			this._value = value;
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x0006789B File Offset: 0x00065A9B
		[CLSCompliant(false)]
		public DefaultValueAttribute(ulong value)
		{
			this._value = value;
		}

		/// <summary>Возвращает значение по умолчанию для свойства, с которым связан этот атрибут.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий значение по умолчанию для свойства, с которым связан этот атрибут.</returns>
		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x000678AF File Offset: 0x00065AAF
		public virtual object Value
		{
			get
			{
				return this._value;
			}
		}

		/// <summary>Возвращает значение, показывающее, равно ли значение данного объекта текущему атрибуту <see cref="T:System.ComponentModel.DefaultValueAttribute" />.</summary>
		/// <param name="obj">Объект, проверяемый на равенство.</param>
		/// <returns>Значение <see langword="true" />, если значение данного объекта равно значению текущего; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001CA4 RID: 7332 RVA: 0x000678B8 File Offset: 0x00065AB8
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DefaultValueAttribute defaultValueAttribute = obj as DefaultValueAttribute;
			if (defaultValueAttribute == null)
			{
				return false;
			}
			if (this.Value != null)
			{
				return this.Value.Equals(defaultValueAttribute.Value);
			}
			return defaultValueAttribute.Value == null;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001CA5 RID: 7333 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Задает значение по умолчанию для свойства, с которым связан этот атрибут.</summary>
		/// <param name="value">Значение по умолчанию.</param>
		// Token: 0x06001CA6 RID: 7334 RVA: 0x00067902 File Offset: 0x00065B02
		protected void SetValue(object value)
		{
			this._value = value;
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x0006790C File Offset: 0x00065B0C
		[CompilerGenerated]
		internal static bool <.ctor>g__TryConvertFromInvariantString|2_0(Type typeToConvert, string stringValue, out object conversionResult)
		{
			conversionResult = null;
			if (DefaultValueAttribute.s_convertFromInvariantString == null)
			{
				Type type = Type.GetType("System.ComponentModel.TypeDescriptor, System.ComponentModel.TypeConverter", false);
				Volatile.Write<object>(ref DefaultValueAttribute.s_convertFromInvariantString, (type == null) ? new object() : Delegate.CreateDelegate(typeof(Func<Type, string, object>), type, "ConvertFromInvariantString", false));
			}
			Func<Type, string, object> func = DefaultValueAttribute.s_convertFromInvariantString as Func<Type, string, object>;
			if (func == null)
			{
				return false;
			}
			conversionResult = func(typeToConvert, stringValue);
			return true;
		}

		// Token: 0x04000E8A RID: 3722
		private object _value;

		// Token: 0x04000E8B RID: 3723
		private static object s_convertFromInvariantString;
	}
}
