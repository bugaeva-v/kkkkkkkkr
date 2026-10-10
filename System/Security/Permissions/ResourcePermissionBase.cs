using System;
using System.Collections;

namespace System.Security.Permissions
{
	/// <summary>Позволяет контролировать разрешения безопасности доступа кода.</summary>
	// Token: 0x02000296 RID: 662
	[Serializable]
	public abstract class ResourcePermissionBase : CodeAccessPermission, IUnrestrictedPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.ResourcePermissionBase" />.</summary>
		// Token: 0x060014DD RID: 5341 RVA: 0x00054A50 File Offset: 0x00052C50
		protected ResourcePermissionBase()
		{
			this._list = new ArrayList();
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Security.Permissions.ResourcePermissionBase" /> с заданным уровнем доступа к ресурсам при создании.</summary>
		/// <param name="state">Одно из значений <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="state" /> не является допустимым значением для <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x060014DE RID: 5342 RVA: 0x00054A63 File Offset: 0x00052C63
		protected ResourcePermissionBase(PermissionState state) : this()
		{
			PermissionHelper.CheckPermissionState(state, true);
			this._unrestricted = (state == PermissionState.Unrestricted);
		}

		/// <summary>Получает или задает значение перечисления, которое описывает типы доступа, предоставляемые ресурсу.</summary>
		/// <returns>Значение перечисления производное от <see cref="T:System.Type" /> описывает типы доступа, предоставляемые ресурсу.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство значения не является значением перечисления.</exception>
		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x00054A7D File Offset: 0x00052C7D
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x00054A85 File Offset: 0x00052C85
		protected Type PermissionAccessType
		{
			get
			{
				return this._type;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("PermissionAccessType");
				}
				if (!value.IsEnum)
				{
					throw new ArgumentException("!Enum", "PermissionAccessType");
				}
				this._type = value;
			}
		}

		/// <summary>Получает или задает массив строк, обозначающих защищаемый ресурс.</summary>
		/// <returns>Массив строк, обозначающих защищаемый ресурс.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Длина массива равна нулю.</exception>
		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x00054ABA File Offset: 0x00052CBA
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x00054AC2 File Offset: 0x00052CC2
		protected string[] TagNames
		{
			get
			{
				return this._tags;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("TagNames");
				}
				if (value.Length == 0)
				{
					throw new ArgumentException("Length==0", "TagNames");
				}
				this._tags = value;
			}
		}

		/// <summary>Добавляет в разрешение запись разрешения.</summary>
		/// <param name="entry">Добавляемый объект <see cref="T:System.Security.Permissions.ResourcePermissionBaseEntry" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Заданный объект <see cref="T:System.Security.Permissions.ResourcePermissionBaseEntry" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Количество элементов в свойстве <see cref="P:System.Security.Permissions.ResourcePermissionBaseEntry.PermissionAccessPath" /> не равно количеству элементов в свойстве <see cref="P:System.Security.Permissions.ResourcePermissionBase.TagNames" />.  
		/// -или- 
		/// <see cref="T:System.Security.Permissions.ResourcePermissionBaseEntry" /> уже включено в разрешение.</exception>
		// Token: 0x060014E3 RID: 5347 RVA: 0x00054AED File Offset: 0x00052CED
		protected void AddPermissionAccess(ResourcePermissionBaseEntry entry)
		{
			this.CheckEntry(entry);
			if (this.Exists(entry))
			{
				throw new InvalidOperationException(Locale.GetText("Entry already exists."));
			}
			this._list.Add(entry);
		}

		/// <summary>Удаляет разрешение добавляемых записей разрешения.</summary>
		// Token: 0x060014E4 RID: 5348 RVA: 0x00054B1C File Offset: 0x00052D1C
		protected void Clear()
		{
			this._list.Clear();
		}

		/// <summary>Создает и возвращает идентичную копию текущего объекта разрешения.</summary>
		/// <returns>Копия текущего объекта разрешения.</returns>
		// Token: 0x060014E5 RID: 5349 RVA: 0x00054B2C File Offset: 0x00052D2C
		public override IPermission Copy()
		{
			ResourcePermissionBase resourcePermissionBase = ResourcePermissionBase.CreateFromType(base.GetType(), this._unrestricted);
			if (this._tags != null)
			{
				resourcePermissionBase._tags = (string[])this._tags.Clone();
			}
			resourcePermissionBase._type = this._type;
			resourcePermissionBase._list.AddRange(this._list);
			return resourcePermissionBase;
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="securityElement">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="securityElement" /> не является допустимым элементом разрешения.  
		/// -или- 
		/// Номер версии параметра <paramref name="securityElement" /> не поддерживается.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="securityElement" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060014E6 RID: 5350 RVA: 0x00054B88 File Offset: 0x00052D88
		[MonoTODO("incomplete - need more test")]
		public override void FromXml(SecurityElement securityElement)
		{
			if (securityElement == null)
			{
				throw new ArgumentNullException("securityElement");
			}
			CodeAccessPermission.CheckSecurityElement(securityElement, "securityElement", 1, 1);
			this._list.Clear();
			this._unrestricted = PermissionHelper.IsUnrestricted(securityElement);
			if (securityElement.Children == null || securityElement.Children.Count < 1)
			{
				return;
			}
			string[] array = new string[1];
			foreach (object obj in securityElement.Children)
			{
				SecurityElement securityElement2 = (SecurityElement)obj;
				array[0] = securityElement2.Attribute("name");
				ResourcePermissionBaseEntry entry = new ResourcePermissionBaseEntry((int)Enum.Parse(this.PermissionAccessType, securityElement2.Attribute("access")), array);
				this.AddPermissionAccess(entry);
			}
		}

		/// <summary>Возвращает массив объектов <see cref="T:System.Security.Permissions.ResourcePermissionBaseEntry" />, добавляемых к разрешению.</summary>
		/// <returns>Массив объектов <see cref="T:System.Security.Permissions.ResourcePermissionBaseEntry" />, которые добавлены к этому разрешению.</returns>
		// Token: 0x060014E7 RID: 5351 RVA: 0x00054C68 File Offset: 0x00052E68
		protected ResourcePermissionBaseEntry[] GetPermissionEntries()
		{
			ResourcePermissionBaseEntry[] array = new ResourcePermissionBaseEntry[this._list.Count];
			this._list.CopyTo(array, 0);
			return array;
		}

		/// <summary>Создает и возвращает объект разрешения, представляющий собой пересечение текущего и конечного разрешений.</summary>
		/// <param name="target">Разрешение относится к тому же типу, что и текущее разрешение.</param>
		/// <returns>Новый объект разрешения, представляющий собой пересечение текущего и заданного целевого объектов. Этот объект является <see langword="null" />, если пересечение является пустым.</returns>
		/// <exception cref="T:System.ArgumentException">Данный объект не должен относиться к тому же типу, что и текущий объект разрешения.</exception>
		// Token: 0x060014E8 RID: 5352 RVA: 0x00054C94 File Offset: 0x00052E94
		public override IPermission Intersect(IPermission target)
		{
			ResourcePermissionBase resourcePermissionBase = this.Cast(target);
			if (resourcePermissionBase == null)
			{
				return null;
			}
			bool flag = this.IsUnrestricted();
			bool flag2 = resourcePermissionBase.IsUnrestricted();
			if (this.IsEmpty() && !flag2)
			{
				return null;
			}
			if (resourcePermissionBase.IsEmpty() && !flag)
			{
				return null;
			}
			ResourcePermissionBase resourcePermissionBase2 = ResourcePermissionBase.CreateFromType(base.GetType(), flag && flag2);
			foreach (object obj in this._list)
			{
				ResourcePermissionBaseEntry entry = (ResourcePermissionBaseEntry)obj;
				if (flag2 || resourcePermissionBase.Exists(entry))
				{
					resourcePermissionBase2.AddPermissionAccess(entry);
				}
			}
			foreach (object obj2 in resourcePermissionBase._list)
			{
				ResourcePermissionBaseEntry entry2 = (ResourcePermissionBaseEntry)obj2;
				if ((flag || this.Exists(entry2)) && !resourcePermissionBase2.Exists(entry2))
				{
					resourcePermissionBase2.AddPermissionAccess(entry2);
				}
			}
			return resourcePermissionBase2;
		}

		/// <summary>Определяет, является ли текущее разрешение подмножеством заданного разрешения.</summary>
		/// <param name="target">Объект разрешения, для которого требуется проверить соотношение подмножеств.</param>
		/// <returns>Значение <see langword="true" />, если текущий объект разрешений является подмножеством заданного объекта разрешений; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060014E9 RID: 5353 RVA: 0x00054DB0 File Offset: 0x00052FB0
		public override bool IsSubsetOf(IPermission target)
		{
			if (target == null)
			{
				return true;
			}
			ResourcePermissionBase resourcePermissionBase = target as ResourcePermissionBase;
			if (resourcePermissionBase == null)
			{
				return false;
			}
			if (resourcePermissionBase.IsUnrestricted())
			{
				return true;
			}
			if (this.IsUnrestricted())
			{
				return resourcePermissionBase.IsUnrestricted();
			}
			foreach (object obj in this._list)
			{
				ResourcePermissionBaseEntry entry = (ResourcePermissionBaseEntry)obj;
				if (!resourcePermissionBase.Exists(entry))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Получает значение, указывающее, является ли текущее разрешение неограниченным.</summary>
		/// <returns>
		///   <see langword="true" />, если текущее разрешение является неограниченным; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060014EA RID: 5354 RVA: 0x00054E40 File Offset: 0x00053040
		public bool IsUnrestricted()
		{
			return this._unrestricted;
		}

		/// <summary>Удаляет запись разрешения из разрешения.</summary>
		/// <param name="entry">Объект <see cref="T:System.Security.Permissions.ResourcePermissionBaseEntry" /> для удаления.</param>
		/// <exception cref="T:System.ArgumentNullException">Заданный объект <see cref="T:System.Security.Permissions.ResourcePermissionBaseEntry" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Количество элементов в свойстве <see cref="P:System.Security.Permissions.ResourcePermissionBaseEntry.PermissionAccessPath" /> не равно количеству элементов в свойстве <see cref="P:System.Security.Permissions.ResourcePermissionBase.TagNames" />.  
		/// -или- 
		/// <see cref="T:System.Security.Permissions.ResourcePermissionBaseEntry" /> не включено в разрешение.</exception>
		// Token: 0x060014EB RID: 5355 RVA: 0x00054E48 File Offset: 0x00053048
		protected void RemovePermissionAccess(ResourcePermissionBaseEntry entry)
		{
			this.CheckEntry(entry);
			for (int i = 0; i < this._list.Count; i++)
			{
				ResourcePermissionBaseEntry entry2 = (ResourcePermissionBaseEntry)this._list[i];
				if (this.Equals(entry, entry2))
				{
					this._list.RemoveAt(i);
					return;
				}
			}
			throw new InvalidOperationException(Locale.GetText("Entry doesn't exists."));
		}

		/// <summary>Создает и возвращает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x060014EC RID: 5356 RVA: 0x00054EAC File Offset: 0x000530AC
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = PermissionHelper.Element(base.GetType(), 1);
			if (this.IsUnrestricted())
			{
				securityElement.AddAttribute("Unrestricted", "true");
			}
			else
			{
				foreach (object obj in this._list)
				{
					ResourcePermissionBaseEntry resourcePermissionBaseEntry = (ResourcePermissionBaseEntry)obj;
					SecurityElement securityElement2 = securityElement;
					string text = null;
					if (this.PermissionAccessType != null)
					{
						text = Enum.Format(this.PermissionAccessType, resourcePermissionBaseEntry.PermissionAccess, "g");
					}
					for (int i = 0; i < this._tags.Length; i++)
					{
						SecurityElement securityElement3 = new SecurityElement(this._tags[i]);
						securityElement3.AddAttribute("name", resourcePermissionBaseEntry.PermissionAccessPath[i]);
						if (text != null)
						{
							securityElement3.AddAttribute("access", text);
						}
						securityElement2.AddChild(securityElement3);
					}
				}
			}
			return securityElement;
		}

		/// <summary>Создает объект разрешения, содержащий текущий объект разрешения и конечный объект разрешения.</summary>
		/// <param name="target">Объект разрешений для комбинирования с текущим объектом разрешений. Должен относиться к тому же типу, что и текущий объект разрешений.</param>
		/// <returns>Новый объект разрешения, представляющий собой объединение текущего и заданного объектов разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> объект разрешения не относится к тому же типу, что и текущий объект разрешения.</exception>
		// Token: 0x060014ED RID: 5357 RVA: 0x00054FBC File Offset: 0x000531BC
		public override IPermission Union(IPermission target)
		{
			ResourcePermissionBase resourcePermissionBase = this.Cast(target);
			if (resourcePermissionBase == null)
			{
				return this.Copy();
			}
			if (this.IsEmpty() && resourcePermissionBase.IsEmpty())
			{
				return null;
			}
			if (resourcePermissionBase.IsEmpty())
			{
				return this.Copy();
			}
			if (this.IsEmpty())
			{
				return resourcePermissionBase.Copy();
			}
			bool flag = this.IsUnrestricted() || resourcePermissionBase.IsUnrestricted();
			ResourcePermissionBase resourcePermissionBase2 = ResourcePermissionBase.CreateFromType(base.GetType(), flag);
			if (!flag)
			{
				foreach (object obj in this._list)
				{
					ResourcePermissionBaseEntry entry = (ResourcePermissionBaseEntry)obj;
					resourcePermissionBase2.AddPermissionAccess(entry);
				}
				foreach (object obj2 in resourcePermissionBase._list)
				{
					ResourcePermissionBaseEntry entry2 = (ResourcePermissionBaseEntry)obj2;
					if (!resourcePermissionBase2.Exists(entry2))
					{
						resourcePermissionBase2.AddPermissionAccess(entry2);
					}
				}
			}
			return resourcePermissionBase2;
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x000550DC File Offset: 0x000532DC
		private bool IsEmpty()
		{
			return !this._unrestricted && this._list.Count == 0;
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x000550F6 File Offset: 0x000532F6
		private ResourcePermissionBase Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			ResourcePermissionBase resourcePermissionBase = target as ResourcePermissionBase;
			if (resourcePermissionBase == null)
			{
				PermissionHelper.ThrowInvalidPermission(target, typeof(ResourcePermissionBase));
			}
			return resourcePermissionBase;
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00055116 File Offset: 0x00053316
		internal void CheckEntry(ResourcePermissionBaseEntry entry)
		{
			if (entry == null)
			{
				throw new ArgumentNullException("entry");
			}
			if (entry.PermissionAccessPath == null || entry.PermissionAccessPath.Length != this._tags.Length)
			{
				throw new InvalidOperationException(Locale.GetText("Entry doesn't match TagNames"));
			}
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00055150 File Offset: 0x00053350
		internal bool Equals(ResourcePermissionBaseEntry entry1, ResourcePermissionBaseEntry entry2)
		{
			if (entry1.PermissionAccess != entry2.PermissionAccess)
			{
				return false;
			}
			if (entry1.PermissionAccessPath.Length != entry2.PermissionAccessPath.Length)
			{
				return false;
			}
			for (int i = 0; i < entry1.PermissionAccessPath.Length; i++)
			{
				if (entry1.PermissionAccessPath[i] != entry2.PermissionAccessPath[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x000551B0 File Offset: 0x000533B0
		internal bool Exists(ResourcePermissionBaseEntry entry)
		{
			if (this._list.Count == 0)
			{
				return false;
			}
			foreach (object obj in this._list)
			{
				ResourcePermissionBaseEntry entry2 = (ResourcePermissionBaseEntry)obj;
				if (this.Equals(entry2, entry))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00055224 File Offset: 0x00053424
		internal static void ValidateMachineName(string name)
		{
			if (name == null || name.Length == 0 || name.IndexOfAny(ResourcePermissionBase.invalidChars) != -1)
			{
				string text = Locale.GetText("Invalid machine name '{0}'.");
				if (name == null)
				{
					name = "(null)";
				}
				throw new ArgumentException(string.Format(text, name), "MachineName");
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00055264 File Offset: 0x00053464
		internal static ResourcePermissionBase CreateFromType(Type type, bool unrestricted)
		{
			return (ResourcePermissionBase)Activator.CreateInstance(type, new object[]
			{
				unrestricted ? PermissionState.Unrestricted : PermissionState.None
			});
		}

		// Token: 0x04000BB9 RID: 3001
		private const int version = 1;

		// Token: 0x04000BBA RID: 3002
		private ArrayList _list;

		// Token: 0x04000BBB RID: 3003
		private bool _unrestricted;

		// Token: 0x04000BBC RID: 3004
		private Type _type;

		// Token: 0x04000BBD RID: 3005
		private string[] _tags;

		/// <summary>Задает символ, который будет использоваться для представления любого подстановочного знака.</summary>
		// Token: 0x04000BBE RID: 3006
		public const string Any = "*";

		/// <summary>Задает символ, который будет использоваться для представления локальной ссылки.</summary>
		// Token: 0x04000BBF RID: 3007
		public const string Local = ".";

		// Token: 0x04000BC0 RID: 3008
		private static char[] invalidChars = new char[]
		{
			'\t',
			'\n',
			'\v',
			'\f',
			'\r',
			' ',
			'\\',
			'Š'
		};
	}
}
