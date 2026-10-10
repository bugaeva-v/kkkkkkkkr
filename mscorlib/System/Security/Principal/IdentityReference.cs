using System;
using System.Runtime.InteropServices;

namespace System.Security.Principal
{
	/// <summary>Представляет удостоверение и является базовым классом для классов <see cref="T:System.Security.Principal.NTAccount" /> и <see cref="T:System.Security.Principal.SecurityIdentifier" />. Этот класс не предоставляет открытый конструктор и поэтому не может быть унаследованным.</summary>
	// Token: 0x020004E4 RID: 1252
	[ComVisible(false)]
	public abstract class IdentityReference
	{
		// Token: 0x060031F2 RID: 12786 RVA: 0x0000259F File Offset: 0x0000079F
		internal IdentityReference()
		{
		}

		/// <summary>Получает строковое значение удостоверения, представленного объектом <see cref="T:System.Security.Principal.IdentityReference" />.</summary>
		/// <returns>Строковое значение удостоверения, представленного объектом <see cref="T:System.Security.Principal.IdentityReference" />.</returns>
		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060031F3 RID: 12787
		public abstract string Value { get; }

		/// <summary>Возвращает значение, показывающее, является ли указанный тип допустимым типом преобразования для класса <see cref="T:System.Security.Principal.IdentityReference" />.</summary>
		/// <param name="o">Объект, сравниваемый с данным экземпляром <see cref="T:System.Security.Principal.IdentityReference" />, или пустая ссылка.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="o" /> является объектом тех же базового типа и значения, что и данный экземпляр <see cref="T:System.Security.Principal.IdentityReference" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060031F4 RID: 12788
		public abstract override bool Equals(object o);

		/// <summary>Служит хэш-функцией для <see cref="T:System.Security.Principal.IdentityReference" />. Метод <see cref="M:System.Security.Principal.IdentityReference.GetHashCode" /> подходит для использования в алгоритмах хэширования и структурах данных, например хэш-таблицах.</summary>
		/// <returns>Хэш-код для этого объекта <see cref="T:System.Security.Principal.IdentityReference" />.</returns>
		// Token: 0x060031F5 RID: 12789
		public abstract override int GetHashCode();

		/// <summary>Возвращает значение, показывающее, является ли указанный тип допустимым типом преобразования для класса <see cref="T:System.Security.Principal.IdentityReference" />.</summary>
		/// <param name="targetType">Тип, допустимость использования которого в качестве типа преобразования из класса <see cref="T:System.Security.Principal.IdentityReference" /> требуется проверить. Допустимы следующие типы целевого объекта: 
		///  <see cref="T:System.Security.Principal.NTAccount" /><see cref="T:System.Security.Principal.SecurityIdentifier" /></param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="targetType" /> является допустимым типом преобразования для класса <see cref="T:System.Security.Principal.IdentityReference" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060031F6 RID: 12790
		public abstract bool IsValidTargetType(Type targetType);

		/// <summary>Возвращает строковое представление удостоверения, представленного объектом <see cref="T:System.Security.Principal.IdentityReference" />.</summary>
		/// <returns>Удостоверение в строковом формате.</returns>
		// Token: 0x060031F7 RID: 12791
		public abstract override string ToString();

		/// <summary>Преобразует имя учетной записи, представленное объектом <see cref="T:System.Security.Principal.IdentityReference" />, в другой тип, производный от <see cref="T:System.Security.Principal.IdentityReference" />.</summary>
		/// <param name="targetType">Тип целевого объекта для преобразования из объекта <see cref="T:System.Security.Principal.IdentityReference" />.</param>
		/// <returns>Преобразованное удостоверение.</returns>
		// Token: 0x060031F8 RID: 12792
		public abstract IdentityReference Translate(Type targetType);

		/// <summary>Сравнивает два объекта <see cref="T:System.Security.Principal.IdentityReference" /> на равенство. Объекты считаются равными, если их каноническое представление имени совпадает с представлением, возвращаемым свойством <see cref="P:System.Security.Principal.IdentityReference.Value" />, или значения обоих объектов равны <see langword="null" />.</summary>
		/// <param name="left">Левый операнд <see cref="T:System.Security.Principal.IdentityReference" />, используемый для сравнения в отношении равенства. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <param name="right">Правый операнд <see cref="T:System.Security.Principal.IdentityReference" />, используемый для сравнения в отношении равенства. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060031F9 RID: 12793 RVA: 0x000B7BB0 File Offset: 0x000B5DB0
		public static bool operator ==(IdentityReference left, IdentityReference right)
		{
			if (left == null)
			{
				return right == null;
			}
			return right != null && left.Value == right.Value;
		}

		/// <summary>Сравнивает два объекта <see cref="T:System.Security.Principal.IdentityReference" /> на неравенство. Объекты считаются неравными, если их канонические представления имени отличаются от представления, возвращаемого свойством <see cref="P:System.Security.Principal.IdentityReference.Value" />, или один из объектов имеет значение <see langword="null" />, а другой объект имеет другое значение.</summary>
		/// <param name="left">Левый операнд <see cref="T:System.Security.Principal.IdentityReference" />, используемый для сравнения в отношении неравенства. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <param name="right">Правый операнд <see cref="T:System.Security.Principal.IdentityReference" />, используемый для сравнения на неравенство. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060031FA RID: 12794 RVA: 0x000B7BD0 File Offset: 0x000B5DD0
		public static bool operator !=(IdentityReference left, IdentityReference right)
		{
			if (left == null)
			{
				return right != null;
			}
			return right == null || left.Value != right.Value;
		}
	}
}
