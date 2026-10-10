using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Включает и настраивает пул объектов для компонента. Этот класс не наследуется.</summary>
	// Token: 0x02000035 RID: 53
	[AttributeUsage(AttributeTargets.Class)]
	[ComVisible(false)]
	public sealed class ObjectPoolingAttribute : Attribute, IConfigurationAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ObjectPoolingAttribute" /> и задает значения по умолчанию для свойств <see cref="P:System.EnterpriseServices.ObjectPoolingAttribute.Enabled" />, <see cref="P:System.EnterpriseServices.ObjectPoolingAttribute.MaxPoolSize" />, <see cref="P:System.EnterpriseServices.ObjectPoolingAttribute.MinPoolSize" /> и <see cref="P:System.EnterpriseServices.ObjectPoolingAttribute.CreationTimeout" />.</summary>
		// Token: 0x060000A1 RID: 161 RVA: 0x000023FC File Offset: 0x000005FC
		public ObjectPoolingAttribute() : this(true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ObjectPoolingAttribute" /> и задает значение свойства <see cref="P:System.EnterpriseServices.ObjectPoolingAttribute.Enabled" />.</summary>
		/// <param name="enable">Значение <see langword="true" /> для включения пула объектов; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x060000A2 RID: 162 RVA: 0x00002405 File Offset: 0x00000605
		public ObjectPoolingAttribute(bool enable)
		{
			this.enabled = enable;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ObjectPoolingAttribute" /> и задает значения свойств <see cref="P:System.EnterpriseServices.ObjectPoolingAttribute.MaxPoolSize" /> и <see cref="P:System.EnterpriseServices.ObjectPoolingAttribute.MinPoolSize" />.</summary>
		/// <param name="minPoolSize">Минимальный размер пула.</param>
		/// <param name="maxPoolSize">Максимальный размер пула.</param>
		// Token: 0x060000A3 RID: 163 RVA: 0x00002414 File Offset: 0x00000614
		public ObjectPoolingAttribute(int minPoolSize, int maxPoolSize) : this(true, minPoolSize, maxPoolSize)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ObjectPoolingAttribute" /> и задает значения свойств <see cref="P:System.EnterpriseServices.ObjectPoolingAttribute.Enabled" />, <see cref="P:System.EnterpriseServices.ObjectPoolingAttribute.MaxPoolSize" /> и <see cref="P:System.EnterpriseServices.ObjectPoolingAttribute.MinPoolSize" />.</summary>
		/// <param name="enable">Значение <see langword="true" /> для включения пула объектов; в противном случае — значение <see langword="false" />.</param>
		/// <param name="minPoolSize">Минимальный размер пула.</param>
		/// <param name="maxPoolSize">Максимальный размер пула.</param>
		// Token: 0x060000A4 RID: 164 RVA: 0x0000241F File Offset: 0x0000061F
		public ObjectPoolingAttribute(bool enable, int minPoolSize, int maxPoolSize)
		{
			this.enabled = enable;
			this.minPoolSize = minPoolSize;
			this.maxPoolSize = maxPoolSize;
		}

		/// <summary>Получает или задает время ожидания доступности объекта в пуле до создания исключения. Это значение задается в миллисекундах.</summary>
		/// <returns>Значение тайм-аута в миллисекундах.</returns>
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000243C File Offset: 0x0000063C
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002444 File Offset: 0x00000644
		public int CreationTimeout
		{
			get
			{
				return this.creationTimeout;
			}
			set
			{
				this.creationTimeout = value;
			}
		}

		/// <summary>Получает или задает значение, указывающее, включен ли пул объектов.</summary>
		/// <returns>Значение <see langword="true" />, если пул объектов включен; в противном случае — значение <see langword="false" />. Значение по умолчанию: <see langword="true" />.</returns>
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000244D File Offset: 0x0000064D
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002455 File Offset: 0x00000655
		public bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				this.enabled = value;
			}
		}

		/// <summary>Возвращает или задает значение наибольшего размера пула.</summary>
		/// <returns>Максимальное число объектов в пуле.</returns>
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000245E File Offset: 0x0000065E
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00002466 File Offset: 0x00000666
		public int MaxPoolSize
		{
			get
			{
				return this.maxPoolSize;
			}
			set
			{
				this.maxPoolSize = value;
			}
		}

		/// <summary>Получает или задает значение минимального размера пула.</summary>
		/// <returns>Минимальное число объектов в пуле.</returns>
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000246F File Offset: 0x0000066F
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00002477 File Offset: 0x00000677
		public int MinPoolSize
		{
			get
			{
				return this.minPoolSize;
			}
			set
			{
				this.minPoolSize = value;
			}
		}

		/// <summary>Вызван внутренне инфраструктурой платформы .NET Framework при установке и настройке сборок в каталоге COM+.</summary>
		/// <param name="info">Хэш-таблица, содержащая внутренние объекты, на которые осуществляется ссылка посредством внутренних ключей.</param>
		/// <returns>Значение <see langword="true" />, если в метод внесены изменения.</returns>
		// Token: 0x060000AD RID: 173 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public bool AfterSaveChanges(Hashtable info)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызван внутренне инфраструктурой платформы .NET Framework при применении атрибута класса  <see cref="T:System.EnterpriseServices.ObjectPoolingAttribute" /> к обслуживаемому компоненту.</summary>
		/// <param name="info">Хэш-таблица, содержащая внутренний объект, к которому применяются свойства пула объектов, а ссылки осуществляются посредством внутреннего ключа.</param>
		/// <returns>Значение <see langword="true" />, если в метод внесены изменения, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060000AE RID: 174 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public bool Apply(Hashtable info)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывается внутренне инфраструктурой платформы .NET Framework при установке и настройке сборок в каталоге COM+.</summary>
		/// <param name="s">Строка, созданная инфраструктурой платформы .NET Framework, которая проверяет специальное значение, указывающее обслуживаемый компонент.</param>
		/// <returns>Значение <see langword="true" />, если атрибут применяется к обслуживаемому классу компонентов.</returns>
		// Token: 0x060000AF RID: 175 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public bool IsValidTarget(string s)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400006F RID: 111
		private int creationTimeout;

		// Token: 0x04000070 RID: 112
		private bool enabled;

		// Token: 0x04000071 RID: 113
		private int minPoolSize;

		// Token: 0x04000072 RID: 114
		private int maxPoolSize;
	}
}
