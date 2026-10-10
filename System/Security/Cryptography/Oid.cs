using System;
using Internal.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Представляет идентификатор криптографического объекта. Этот класс не наследуется.</summary>
	// Token: 0x020002B5 RID: 693
	public sealed class Oid
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Oid" />.</summary>
		// Token: 0x060015C4 RID: 5572 RVA: 0x0000219B File Offset: 0x0000039B
		public Oid()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Oid" />, используя строковое значение объекта <see cref="T:System.Security.Cryptography.Oid" />.</summary>
		/// <param name="oid">Идентификатор объекта.</param>
		// Token: 0x060015C5 RID: 5573 RVA: 0x000575E4 File Offset: 0x000557E4
		public Oid(string oid)
		{
			string text = OidLookup.ToOid(oid, OidGroup.All, false);
			if (text == null)
			{
				text = oid;
			}
			this.Value = text;
			this._group = OidGroup.All;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Oid" />, используя заданные значение и понятное имя.</summary>
		/// <param name="value">Номер идентификатора в формате с разделением точками.</param>
		/// <param name="friendlyName">Понятное имя идентификатора.</param>
		// Token: 0x060015C6 RID: 5574 RVA: 0x00057613 File Offset: 0x00055813
		public Oid(string value, string friendlyName)
		{
			this._value = value;
			this._friendlyName = friendlyName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Oid" />, используя указанный объект <see cref="T:System.Security.Cryptography.Oid" />.</summary>
		/// <param name="oid">Информация об идентификаторе объекта, используемая для создания нового идентификатора объекта.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="oid" /> — <see langword="null" />.</exception>
		// Token: 0x060015C7 RID: 5575 RVA: 0x00057629 File Offset: 0x00055829
		public Oid(Oid oid)
		{
			if (oid == null)
			{
				throw new ArgumentNullException("oid");
			}
			this._value = oid._value;
			this._friendlyName = oid._friendlyName;
			this._group = oid._group;
		}

		/// <summary>Создает объект <see cref="T:System.Security.Cryptography.Oid" /> из понятного имени идентификатора объекта (OID), выполняя поиск указанной группы.</summary>
		/// <param name="friendlyName">Понятное имя идентификатора.</param>
		/// <param name="group">Группа, в которой выполняется поиск.</param>
		/// <returns>Объект, представляющий заданный OID.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="friendlyName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">OID не найден.</exception>
		// Token: 0x060015C8 RID: 5576 RVA: 0x00057663 File Offset: 0x00055863
		public static Oid FromFriendlyName(string friendlyName, OidGroup group)
		{
			if (friendlyName == null)
			{
				throw new ArgumentNullException("friendlyName");
			}
			string text = OidLookup.ToOid(friendlyName, group, false);
			if (text == null)
			{
				throw new CryptographicException("No OID value matches this name.");
			}
			return new Oid(text, friendlyName, group);
		}

		/// <summary>Создает объект <see cref="T:System.Security.Cryptography.Oid" /> с помощью заданного значения и группы OID.</summary>
		/// <param name="oidValue">Значение времени существования OID.</param>
		/// <param name="group">Группа, в которой выполняется поиск.</param>
		/// <returns>Новый экземпляр объекта <see cref="T:System.Security.Cryptography.Oid" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="oidValue" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Понятное имя для значения OID не найдено.</exception>
		// Token: 0x060015C9 RID: 5577 RVA: 0x00057690 File Offset: 0x00055890
		public static Oid FromOidValue(string oidValue, OidGroup group)
		{
			if (oidValue == null)
			{
				throw new ArgumentNullException("oidValue");
			}
			string text = OidLookup.ToFriendlyName(oidValue, group, false);
			if (text == null)
			{
				throw new CryptographicException("The OID value is invalid.");
			}
			return new Oid(oidValue, text, group);
		}

		/// <summary>Получает или задает номер идентификатора в формате с разделением точками.</summary>
		/// <returns>Номер идентификатора в формате с разделением точками.</returns>
		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x000576CA File Offset: 0x000558CA
		// (set) Token: 0x060015CB RID: 5579 RVA: 0x000576D2 File Offset: 0x000558D2
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		/// <summary>Получает или задает понятное имя идентификатора.</summary>
		/// <returns>Понятное имя идентификатора.</returns>
		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x000576DB File Offset: 0x000558DB
		// (set) Token: 0x060015CD RID: 5581 RVA: 0x0005770C File Offset: 0x0005590C
		public string FriendlyName
		{
			get
			{
				if (this._friendlyName == null && this._value != null)
				{
					this._friendlyName = OidLookup.ToFriendlyName(this._value, this._group, true);
				}
				return this._friendlyName;
			}
			set
			{
				this._friendlyName = value;
				if (this._friendlyName != null)
				{
					string text = OidLookup.ToOid(this._friendlyName, this._group, true);
					if (text != null)
					{
						this._value = text;
					}
				}
			}
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00057745 File Offset: 0x00055945
		private Oid(string value, string friendlyName, OidGroup group)
		{
			this._value = value;
			this._friendlyName = friendlyName;
			this._group = group;
		}

		// Token: 0x04000C32 RID: 3122
		private string _value;

		// Token: 0x04000C33 RID: 3123
		private string _friendlyName;

		// Token: 0x04000C34 RID: 3124
		private OidGroup _group;
	}
}
