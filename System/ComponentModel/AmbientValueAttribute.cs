using System;

namespace System.ComponentModel
{
	/// <summary>Указывает значение, которое нужно передать в свойство, чтобы свойство получило свое значение из другого источника. Это называется окружением. Этот класс не наследуется.</summary>
	// Token: 0x0200037A RID: 890
	[AttributeUsage(AttributeTargets.All)]
	public sealed class AmbientValueAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AmbientValueAttribute" />, используя заданные значение и тип.</summary>
		/// <param name="type">Тип <see cref="T:System.Type" /> параметра <paramref name="value" />.</param>
		/// <param name="value">Значение этого атрибута.</param>
		// Token: 0x06001D47 RID: 7495 RVA: 0x00068790 File Offset: 0x00066990
		public AmbientValueAttribute(Type type, string value)
		{
			try
			{
				this.Value = TypeDescriptor.GetConverter(type).ConvertFromInvariantString(value);
			}
			catch
			{
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AmbientValueAttribute" />, используя значение знака Юникод.</summary>
		/// <param name="value">Значение этого атрибута.</param>
		// Token: 0x06001D48 RID: 7496 RVA: 0x000687CC File Offset: 0x000669CC
		public AmbientValueAttribute(char value)
		{
			this.Value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AmbientValueAttribute" />, используя заданное значение 8-разрядного целого числа без знака.</summary>
		/// <param name="value">Значение этого атрибута.</param>
		// Token: 0x06001D49 RID: 7497 RVA: 0x000687E0 File Offset: 0x000669E0
		public AmbientValueAttribute(byte value)
		{
			this.Value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AmbientValueAttribute" />, используя заданное значение 16-разрядного целого числа со знаком.</summary>
		/// <param name="value">Значение этого атрибута.</param>
		// Token: 0x06001D4A RID: 7498 RVA: 0x000687F4 File Offset: 0x000669F4
		public AmbientValueAttribute(short value)
		{
			this.Value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AmbientValueAttribute" />, используя заданное значение 32-разрядного целого числа со знаком.</summary>
		/// <param name="value">Значение этого атрибута.</param>
		// Token: 0x06001D4B RID: 7499 RVA: 0x00068808 File Offset: 0x00066A08
		public AmbientValueAttribute(int value)
		{
			this.Value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AmbientValueAttribute" />, используя заданное значение 64-разрядного целого числа со знаком.</summary>
		/// <param name="value">Значение этого атрибута.</param>
		// Token: 0x06001D4C RID: 7500 RVA: 0x0006881C File Offset: 0x00066A1C
		public AmbientValueAttribute(long value)
		{
			this.Value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AmbientValueAttribute" />, используя значение с плавающей запятой обычной точности.</summary>
		/// <param name="value">Значение этого атрибута.</param>
		// Token: 0x06001D4D RID: 7501 RVA: 0x00068830 File Offset: 0x00066A30
		public AmbientValueAttribute(float value)
		{
			this.Value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AmbientValueAttribute" />, используя значение с плавающей запятой с двойной точностью.</summary>
		/// <param name="value">Значение этого атрибута.</param>
		// Token: 0x06001D4E RID: 7502 RVA: 0x00068844 File Offset: 0x00066A44
		public AmbientValueAttribute(double value)
		{
			this.Value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AmbientValueAttribute" />, используя заданное значение типа Boolean.</summary>
		/// <param name="value">Значение этого атрибута.</param>
		// Token: 0x06001D4F RID: 7503 RVA: 0x00068858 File Offset: 0x00066A58
		public AmbientValueAttribute(bool value)
		{
			this.Value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AmbientValueAttribute" />, используя строку в качестве значения.</summary>
		/// <param name="value">Значение этого атрибута.</param>
		// Token: 0x06001D50 RID: 7504 RVA: 0x0006886C File Offset: 0x00066A6C
		public AmbientValueAttribute(string value)
		{
			this.Value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AmbientValueAttribute" />, используя в качестве значения заданный объект.</summary>
		/// <param name="value">Значение этого атрибута.</param>
		// Token: 0x06001D51 RID: 7505 RVA: 0x0006886C File Offset: 0x00066A6C
		public AmbientValueAttribute(object value)
		{
			this.Value = value;
		}

		/// <summary>Возвращает объект, который является значением этого атрибута <see cref="T:System.ComponentModel.AmbientValueAttribute" />.</summary>
		/// <returns>Объект, являющийся значением этого атрибута <see cref="T:System.ComponentModel.AmbientValueAttribute" />.</returns>
		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x0006887B File Offset: 0x00066A7B
		public object Value { get; }

		/// <summary>Определяет, равен ли указанный объект <see cref="T:System.ComponentModel.AmbientValueAttribute" /> текущему объекту <see cref="T:System.ComponentModel.AmbientValueAttribute" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.ComponentModel.AmbientValueAttribute" />, с которым сравнивается текущий объект <see cref="T:System.ComponentModel.AmbientValueAttribute" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.ComponentModel.AmbientValueAttribute" /> равен текущему объекту <see cref="T:System.ComponentModel.AmbientValueAttribute" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001D53 RID: 7507 RVA: 0x00068884 File Offset: 0x00066A84
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			AmbientValueAttribute ambientValueAttribute = obj as AmbientValueAttribute;
			if (ambientValueAttribute == null)
			{
				return false;
			}
			if (this.Value == null)
			{
				return ambientValueAttribute.Value == null;
			}
			return this.Value.Equals(ambientValueAttribute.Value);
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.AmbientValueAttribute" />.</returns>
		// Token: 0x06001D54 RID: 7508 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
