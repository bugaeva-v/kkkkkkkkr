using System;
using System.Runtime.Versioning;
using Unity;

namespace System.Configuration
{
	/// <summary>Представляет группу взаимосвязанных разделов в файле конфигурации.</summary>
	// Token: 0x02000033 RID: 51
	public class ConfigurationSectionGroup
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00007064 File Offset: 0x00005264
		private Configuration Config
		{
			get
			{
				if (this.config == null)
				{
					throw new InvalidOperationException("ConfigurationSectionGroup cannot be edited until it is added to a Configuration instance as its descendant");
				}
				return this.config;
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00007080 File Offset: 0x00005280
		internal void Initialize(Configuration config, SectionGroupInfo group)
		{
			if (this.initialized)
			{
				string str = "INTERNAL ERROR: this configuration section is being initialized twice: ";
				Type type = base.GetType();
				throw new SystemException(str + ((type != null) ? type.ToString() : null));
			}
			this.initialized = true;
			this.config = config;
			this.group = group;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000070CC File Offset: 0x000052CC
		internal void SetName(string name)
		{
			this.name = name;
		}

		/// <summary>Вынуждает объявить данный объект <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</summary>
		/// <param name="force">
		///   <see langword="true" />, если объект <see cref="T:System.Configuration.ConfigurationSectionGroup" /> должен быть прописан в файле, в противном случае — <see langword="false" />.</param>
		/// <exception cref="T:System.InvalidOperationException">Данный объект <see cref="T:System.Configuration.ConfigurationSectionGroup" /> является корневой группой разделов.  
		/// -или- 
		/// Данный объект <see cref="T:System.Configuration.ConfigurationSectionGroup" /> имеет расположение.</exception>
		// Token: 0x060001D1 RID: 465 RVA: 0x000070D5 File Offset: 0x000052D5
		[MonoTODO]
		public void ForceDeclaration(bool force)
		{
			this.require_declaration = force;
		}

		/// <summary>Вынуждает объявить данный объект <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</summary>
		// Token: 0x060001D2 RID: 466 RVA: 0x000070DE File Offset: 0x000052DE
		public void ForceDeclaration()
		{
			this.ForceDeclaration(true);
		}

		/// <summary>Возвращает значение, которое указывает является ли объект <see cref="T:System.Configuration.ConfigurationSectionGroup" /> объявленным.</summary>
		/// <returns>
		///   <see langword="true" />, если этот <see cref="T:System.Configuration.ConfigurationSectionGroup" /> объявлен, в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000023BB File Offset: 0x000005BB
		[MonoTODO]
		public bool IsDeclared
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, которое указывает требуется ли объявление для данного объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</summary>
		/// <returns>
		///   <see langword="true" />, если этот <see cref="T:System.Configuration.ConfigurationSectionGroup" /> объявлен, в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x000070E7 File Offset: 0x000052E7
		[MonoTODO]
		public bool IsDeclarationRequired
		{
			get
			{
				return this.require_declaration;
			}
		}

		/// <summary>Возвращает имя свойства данного объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</summary>
		/// <returns>Имя свойства данного объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</returns>
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x000070EF File Offset: 0x000052EF
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Возвращает имя группы разделов, связанных с <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</summary>
		/// <returns>Имя группы разделов этого объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</returns>
		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000070F7 File Offset: 0x000052F7
		[MonoInternalNote("Check if this is correct")]
		public string SectionGroupName
		{
			get
			{
				return this.group.XPath;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" />, который содержит все объекты <see cref="T:System.Configuration.ConfigurationSectionGroup" />, являющиеся производными от данного объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</summary>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" />, который содержит все объекты <see cref="T:System.Configuration.ConfigurationSectionGroup" />, являющиеся производными от данного объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</returns>
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00007104 File Offset: 0x00005304
		public ConfigurationSectionGroupCollection SectionGroups
		{
			get
			{
				if (this.groups == null)
				{
					this.groups = new ConfigurationSectionGroupCollection(this.Config, this.group);
				}
				return this.groups;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Configuration.ConfigurationSectionCollection" />, который содержит все объекты <see cref="T:System.Configuration.ConfigurationSection" />, являющиеся производными от данного объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</summary>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationSectionCollection" />, который содержит все объекты <see cref="T:System.Configuration.ConfigurationSection" />, являющиеся производными от данного объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</returns>
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000712B File Offset: 0x0000532B
		public ConfigurationSectionCollection Sections
		{
			get
			{
				if (this.sections == null)
				{
					this.sections = new ConfigurationSectionCollection(this.Config, this.group);
				}
				return this.sections;
			}
		}

		/// <summary>Возвращает или задает тип для данного объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</summary>
		/// <returns>Тип этого объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Данный объект <see cref="T:System.Configuration.ConfigurationSectionGroup" /> является корневой группой разделов.  
		/// -или- 
		/// Данный объект <see cref="T:System.Configuration.ConfigurationSectionGroup" /> имеет расположение.</exception>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Раздел или группа уже определены на другом уровне.</exception>
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00007152 File Offset: 0x00005352
		// (set) Token: 0x060001DA RID: 474 RVA: 0x0000715A File Offset: 0x0000535A
		public string Type
		{
			get
			{
				return this.type_name;
			}
			set
			{
				this.type_name = value;
			}
		}

		/// <summary>Указывает, нужно ли выполнять сериализацию текущего экземпляра <see cref="T:System.Configuration.ConfigurationSectionGroup" /> во время сериализации иерархии объекта конфигурации для заданной целевой версии .NET Framework.</summary>
		/// <param name="targetFramework">Целевая версия .NET Framework.</param>
		/// <returns>Значение <see langword="true" />, если текущая группа разделов должна сериализоваться; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001DB RID: 475 RVA: 0x00007164 File Offset: 0x00005364
		protected internal virtual bool ShouldSerializeSectionGroupInTargetVersion(FrameworkName targetFramework)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		// Token: 0x040000C7 RID: 199
		private bool require_declaration;

		// Token: 0x040000C8 RID: 200
		private string name;

		// Token: 0x040000C9 RID: 201
		private string type_name;

		// Token: 0x040000CA RID: 202
		private ConfigurationSectionCollection sections;

		// Token: 0x040000CB RID: 203
		private ConfigurationSectionGroupCollection groups;

		// Token: 0x040000CC RID: 204
		private Configuration config;

		// Token: 0x040000CD RID: 205
		private SectionGroupInfo group;

		// Token: 0x040000CE RID: 206
		private bool initialized;
	}
}
