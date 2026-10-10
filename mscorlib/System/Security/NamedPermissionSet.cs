using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security
{
	/// <summary>Определяет набор разрешений, с которым связаны имя и описание. Этот класс не наследуется.</summary>
	// Token: 0x020003E1 RID: 993
	[ComVisible(true)]
	[Serializable]
	public sealed class NamedPermissionSet : PermissionSet
	{
		// Token: 0x060028B6 RID: 10422 RVA: 0x000933FE File Offset: 0x000915FE
		internal NamedPermissionSet()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.NamedPermissionSet" /> с заданным именем на основании набора разрешений.</summary>
		/// <param name="name">Имя именованного набора разрешений.</param>
		/// <param name="permSet">Набор разрешений, значение из которого помещается в новый именованный набор разрешений.</param>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="name" /> — <see langword="null" /> или пустая строка ("").</exception>
		// Token: 0x060028B7 RID: 10423 RVA: 0x00093406 File Offset: 0x00091606
		public NamedPermissionSet(string name, PermissionSet permSet) : base(permSet)
		{
			this.Name = name;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.NamedPermissionSet" /> с заданным именем либо в состоянии без ограничений, либо в состоянии полного ограничения.</summary>
		/// <param name="name">Имя нового именованного набора разрешений.</param>
		/// <param name="state">Одно из значений <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="name" /> — <see langword="null" /> или пустая строка ("").</exception>
		// Token: 0x060028B8 RID: 10424 RVA: 0x00093416 File Offset: 0x00091616
		public NamedPermissionSet(string name, PermissionState state) : base(state)
		{
			this.Name = name;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.NamedPermissionSet" /> на основе другого именованного набора разрешений.</summary>
		/// <param name="permSet">Именованный набор разрешений, из которого создается новый экземпляр.</param>
		// Token: 0x060028B9 RID: 10425 RVA: 0x00093426 File Offset: 0x00091626
		public NamedPermissionSet(NamedPermissionSet permSet) : base(permSet)
		{
			this.name = permSet.name;
			this.description = permSet.description;
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Security.NamedPermissionSet" /> с указанным именем.</summary>
		/// <param name="name">Имя нового именованного набора разрешений.</param>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="name" /> — <see langword="null" /> или пустая строка ("").</exception>
		// Token: 0x060028BA RID: 10426 RVA: 0x00093447 File Offset: 0x00091647
		public NamedPermissionSet(string name) : this(name, PermissionState.Unrestricted)
		{
		}

		/// <summary>Получает или задает текстовое описание текущего именованного набора разрешений.</summary>
		/// <returns>Текстовое описание именованного набора разрешений.</returns>
		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x00093451 File Offset: 0x00091651
		// (set) Token: 0x060028BC RID: 10428 RVA: 0x00093459 File Offset: 0x00091659
		public string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
			}
		}

		/// <summary>Получает или задает имя текущего именованного набора разрешений.</summary>
		/// <returns>Имя именованного набора разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Имя представляет собой пустую строку ("") или значение <see langword="null" />.</exception>
		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x00093462 File Offset: 0x00091662
		// (set) Token: 0x060028BE RID: 10430 RVA: 0x0009346A File Offset: 0x0009166A
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (value == null || value == string.Empty)
				{
					throw new ArgumentException(Locale.GetText("invalid name"));
				}
				this.name = value;
			}
		}

		/// <summary>Создает копию набора разрешений из именованного набора разрешений.</summary>
		/// <returns>Набор разрешений, являющийся копией разрешений из именованного набора.</returns>
		// Token: 0x060028BF RID: 10431 RVA: 0x00093493 File Offset: 0x00091693
		public override PermissionSet Copy()
		{
			return new NamedPermissionSet(this);
		}

		/// <summary>Создает копию именованного набора разрешений с другим именем, но с теми же разрешениями.</summary>
		/// <param name="name">Имя нового именованного набора разрешений.</param>
		/// <returns>Копия именованного набора разрешений с новым именем.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="name" /> — <see langword="null" /> или пустая строка ("").</exception>
		// Token: 0x060028C0 RID: 10432 RVA: 0x0009349B File Offset: 0x0009169B
		public NamedPermissionSet Copy(string name)
		{
			return new NamedPermissionSet(this)
			{
				Name = name
			};
		}

		/// <summary>Восстанавливает именованный набор разрешений с определенным состоянием из кода XML.</summary>
		/// <param name="et">Элемент безопасности, содержащий XML-представление именованного набора разрешений.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="et" /> не является допустимым представлением именованного набора разрешений.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="et" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060028C1 RID: 10433 RVA: 0x000934AA File Offset: 0x000916AA
		public override void FromXml(SecurityElement et)
		{
			base.FromXml(et);
			this.name = et.Attribute("Name");
			this.description = et.Attribute("Description");
			if (this.description == null)
			{
				this.description = string.Empty;
			}
		}

		/// <summary>Создает описание именованного набора разрешений в виде элемента XML.</summary>
		/// <returns>XML-представление именованного набора разрешений.</returns>
		// Token: 0x060028C2 RID: 10434 RVA: 0x000934E8 File Offset: 0x000916E8
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = base.ToXml();
			if (this.name != null)
			{
				securityElement.AddAttribute("Name", this.name);
			}
			if (this.description != null)
			{
				securityElement.AddAttribute("Description", this.description);
			}
			return securityElement;
		}

		/// <summary>Определяет, равен ли заданный объект <see cref="T:System.Security.NamedPermissionSet" /> текущему объекту <see cref="T:System.Security.NamedPermissionSet" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Security.NamedPermissionSet" />, который требуется сравнить с текущим объектом <see cref="T:System.Security.NamedPermissionSet" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Security.NamedPermissionSet" /> равен текущему объекту <see cref="T:System.Security.NamedPermissionSet" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060028C3 RID: 10435 RVA: 0x00093530 File Offset: 0x00091730
		[ComVisible(false)]
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			NamedPermissionSet namedPermissionSet = obj as NamedPermissionSet;
			return namedPermissionSet != null && this.name == namedPermissionSet.Name && base.Equals(obj);
		}

		/// <summary>Возвращает хэш-код для объекта <see cref="T:System.Security.NamedPermissionSet" />, который можно использовать в алгоритмах хэширования и структурах данных, например в хэш-таблице.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Security.NamedPermissionSet" />.</returns>
		// Token: 0x060028C4 RID: 10436 RVA: 0x0009356C File Offset: 0x0009176C
		[ComVisible(false)]
		public override int GetHashCode()
		{
			int num = base.GetHashCode();
			if (this.name != null)
			{
				num ^= this.name.GetHashCode();
			}
			return num;
		}

		// Token: 0x04001EBF RID: 7871
		private string name;

		// Token: 0x04001EC0 RID: 7872
		private string description;
	}
}
