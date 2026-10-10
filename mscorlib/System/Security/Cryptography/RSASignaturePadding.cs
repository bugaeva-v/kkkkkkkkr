using System;
using Unity;

namespace System.Security.Cryptography
{
	/// <summary>Задает режим заполнения и параметры для использования с операциями создания или проверки подписи RSA.</summary>
	// Token: 0x02000475 RID: 1141
	public sealed class RSASignaturePadding : IEquatable<RSASignaturePadding>
	{
		// Token: 0x06002E39 RID: 11833 RVA: 0x000A5FFD File Offset: 0x000A41FD
		private RSASignaturePadding(RSASignaturePaddingMode mode)
		{
			this._mode = mode;
		}

		/// <summary>Получает объект, который использует режим заполнения PKCS #1 v1.5.</summary>
		/// <returns>Объект, использующий режим заполнения <see cref="F:System.Security.Cryptography.RSASignaturePaddingMode.Pkcs1" />.</returns>
		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06002E3A RID: 11834 RVA: 0x000A600C File Offset: 0x000A420C
		public static RSASignaturePadding Pkcs1
		{
			get
			{
				return RSASignaturePadding.s_pkcs1;
			}
		}

		/// <summary>Получает объект, использующий режим заполнения PSS.</summary>
		/// <returns>Объект, который использует режим заполнения <see cref="F:System.Security.Cryptography.RSASignaturePaddingMode.Pss" /> с количеством байт случайных данных, равным размеру хэша.</returns>
		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x000A6013 File Offset: 0x000A4213
		public static RSASignaturePadding Pss
		{
			get
			{
				return RSASignaturePadding.s_pss;
			}
		}

		/// <summary>Получает режим заполнения данного экземпляра <see cref="T:System.Security.Cryptography.RSASignaturePadding" />.</summary>
		/// <returns>Режим заполнения (<see cref="F:System.Security.Cryptography.RSASignaturePaddingMode.Pkcs1" /> или <see cref="F:System.Security.Cryptography.RSASignaturePaddingMode.Pss" />) данного экземпляра.</returns>
		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06002E3C RID: 11836 RVA: 0x000A601A File Offset: 0x000A421A
		public RSASignaturePaddingMode Mode
		{
			get
			{
				return this._mode;
			}
		}

		/// <summary>Возвращает хэш-код этого экземпляра <see cref="T:System.Security.Cryptography.RSASignaturePadding" />.</summary>
		/// <returns>Хэш-код данного экземпляра <see cref="T:System.Security.Cryptography.RSASignaturePadding" />.</returns>
		// Token: 0x06002E3D RID: 11837 RVA: 0x000A6022 File Offset: 0x000A4222
		public override int GetHashCode()
		{
			return this._mode.GetHashCode();
		}

		/// <summary>Возвращает значение, показывающее, равен ли экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект равен текущему объекту; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002E3E RID: 11838 RVA: 0x000A6035 File Offset: 0x000A4235
		public override bool Equals(object obj)
		{
			return this.Equals(obj as RSASignaturePadding);
		}

		/// <summary>Возвращает значение, показывающее, равен ли экземпляр указанному объекту <see cref="T:System.Security.Cryptography.RSASignaturePadding" />.</summary>
		/// <param name="other">Объект для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект равен текущему объекту; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002E3F RID: 11839 RVA: 0x000A6043 File Offset: 0x000A4243
		public bool Equals(RSASignaturePadding other)
		{
			return other != null && this._mode == other._mode;
		}

		/// <summary>Указывает, равны ли значения двух заданных объектов <see cref="T:System.Security.Cryptography.RSASignaturePadding" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если <see langword="left" /> и <see langword="right" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002E40 RID: 11840 RVA: 0x000A605E File Offset: 0x000A425E
		public static bool operator ==(RSASignaturePadding left, RSASignaturePadding right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		/// <summary>Указывает, равны ли значения двух заданных объектов <see cref="T:System.Security.Cryptography.RSASignaturePadding" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если <see langword="left" /> и <see langword="right" /> не равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002E41 RID: 11841 RVA: 0x000A606F File Offset: 0x000A426F
		public static bool operator !=(RSASignaturePadding left, RSASignaturePadding right)
		{
			return !(left == right);
		}

		/// <summary>Возвращает строковое представление текущего экземпляра <see cref="T:System.Security.Cryptography.RSASignaturePadding" />.</summary>
		/// <returns>Строковое представление текущего объекта.</returns>
		// Token: 0x06002E42 RID: 11842 RVA: 0x000A607B File Offset: 0x000A427B
		public override string ToString()
		{
			return this._mode.ToString();
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x000173AD File Offset: 0x000155AD
		internal RSASignaturePadding()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04002123 RID: 8483
		private static readonly RSASignaturePadding s_pkcs1 = new RSASignaturePadding(RSASignaturePaddingMode.Pkcs1);

		// Token: 0x04002124 RID: 8484
		private static readonly RSASignaturePadding s_pss = new RSASignaturePadding(RSASignaturePaddingMode.Pss);

		// Token: 0x04002125 RID: 8485
		private readonly RSASignaturePaddingMode _mode;
	}
}
