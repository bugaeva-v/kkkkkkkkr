using System;

namespace System.ComponentModel
{
	/// <summary>Указывает, что текстовое представление объекта скрыто символами, например звездочками. Этот класс не наследуется.</summary>
	// Token: 0x020003DE RID: 990
	[AttributeUsage(AttributeTargets.All)]
	public sealed class PasswordPropertyTextAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" />.</summary>
		// Token: 0x06002045 RID: 8261 RVA: 0x0006FCAA File Offset: 0x0006DEAA
		public PasswordPropertyTextAttribute() : this(false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" />, при необходимости показывая текст пароля.</summary>
		/// <param name="password">Значение <see langword="true" />, показывающее, что свойство должно показываться как текст пароля; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</param>
		// Token: 0x06002046 RID: 8262 RVA: 0x0006FCB3 File Offset: 0x0006DEB3
		public PasswordPropertyTextAttribute(bool password)
		{
			this.Password = password;
		}

		/// <summary>Возвращает значение, показывающее, должно ли свойство, для которого определен атрибут <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" />, показываться как текст пароля.</summary>
		/// <returns>Значение <see langword="true" />, если свойство должно показываться как текст пароля; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x0006FCC2 File Offset: 0x0006DEC2
		public bool Password { get; }

		/// <summary>Определяет, равны ли два экземпляра <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" />.</summary>
		/// <param name="o">Объект <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" />, с которым сравнивается текущий объект <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" /> равен текущему объекту <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002048 RID: 8264 RVA: 0x0006FCCA File Offset: 0x0006DECA
		public override bool Equals(object o)
		{
			return o is PasswordPropertyTextAttribute && ((PasswordPropertyTextAttribute)o).Password == this.Password;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" />.</returns>
		// Token: 0x06002049 RID: 8265 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Возвращает признак, показывающий, является ли этот экземпляр значением по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если этот экземпляр является атрибутом по умолчанию для класса; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600204A RID: 8266 RVA: 0x0006FCE9 File Offset: 0x0006DEE9
		public override bool IsDefaultAttribute()
		{
			return this.Equals(PasswordPropertyTextAttribute.Default);
		}

		/// <summary>Определяет, что текстовое свойство используется в качестве пароля. Это статическое (<see langword="static" />, а в Visual Basic <see langword="Shared" />) поле доступно только для чтения.</summary>
		// Token: 0x04000FBB RID: 4027
		public static readonly PasswordPropertyTextAttribute Yes = new PasswordPropertyTextAttribute(true);

		/// <summary>Определяет, что текстовое свойство не используется в качестве пароля. Это статическое (<see langword="static" />, а в Visual Basic <see langword="Shared" />) поле доступно только для чтения.</summary>
		// Token: 0x04000FBC RID: 4028
		public static readonly PasswordPropertyTextAttribute No = new PasswordPropertyTextAttribute(false);

		/// <summary>Определяет значение по умолчанию для атрибута <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" />.</summary>
		// Token: 0x04000FBD RID: 4029
		public static readonly PasswordPropertyTextAttribute Default = PasswordPropertyTextAttribute.No;
	}
}
