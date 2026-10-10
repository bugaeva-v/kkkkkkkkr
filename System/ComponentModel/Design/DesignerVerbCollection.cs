using System;
using System.Collections;

namespace System.ComponentModel.Design
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.ComponentModel.Design.DesignerVerb" />.</summary>
	// Token: 0x0200044C RID: 1100
	public class DesignerVerbCollection : CollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.DesignerVerbCollection" />.</summary>
		// Token: 0x060023C7 RID: 9159 RVA: 0x0004E358 File Offset: 0x0004C558
		public DesignerVerbCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.DesignerVerbCollection" />, используя указанный массив объектов <see cref="T:System.ComponentModel.Design.DesignerVerb" />.</summary>
		/// <param name="value">Массив <see cref="T:System.ComponentModel.Design.DesignerVerb" />, указывающий команды конструктора, которые должны содержаться в коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060023C8 RID: 9160 RVA: 0x000813BD File Offset: 0x0007F5BD
		public DesignerVerbCollection(DesignerVerb[] value)
		{
			this.AddRange(value);
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.ComponentModel.Design.DesignerVerb" /> с заданным индексом.</summary>
		/// <param name="index">Индекс, по которому требуется получить или задать объект <see cref="T:System.ComponentModel.Design.DesignerVerb" />.</param>
		/// <returns>Объект <see cref="T:System.ComponentModel.Design.DesignerVerb" /> для каждого допустимого в коллекции индекса.</returns>
		// Token: 0x17000741 RID: 1857
		public DesignerVerb this[int index]
		{
			get
			{
				return (DesignerVerb)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>Добавляет указанный параметр <see cref="T:System.ComponentModel.Design.DesignerVerb" /> в коллекцию.</summary>
		/// <param name="value">Параметр <see cref="T:System.ComponentModel.Design.DesignerVerb" /> для добавления в коллекцию.</param>
		/// <returns>Индекс коллекции, соответствующий добавленной команде конструктора.</returns>
		// Token: 0x060023CB RID: 9163 RVA: 0x00051042 File Offset: 0x0004F242
		public int Add(DesignerVerb value)
		{
			return base.List.Add(value);
		}

		/// <summary>Добавляет заданный набор команд конструктора в коллекцию.</summary>
		/// <param name="value">Массив объектов <see cref="T:System.ComponentModel.Design.DesignerVerb" />, добавляемый в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060023CC RID: 9164 RVA: 0x000813E0 File Offset: 0x0007F5E0
		public void AddRange(DesignerVerb[] value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			for (int i = 0; i < value.Length; i++)
			{
				this.Add(value[i]);
			}
		}

		/// <summary>Добавляет в коллекцию заданную коллекцию команд конструктора.</summary>
		/// <param name="value">Объект <see cref="T:System.ComponentModel.Design.DesignerVerbCollection" /> для добавления в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060023CD RID: 9165 RVA: 0x00081414 File Offset: 0x0007F614
		public void AddRange(DesignerVerbCollection value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			int count = value.Count;
			for (int i = 0; i < count; i++)
			{
				this.Add(value[i]);
			}
		}

		/// <summary>Вставляет заданный объект <see cref="T:System.ComponentModel.Design.DesignerVerb" /> по заданному индексу.</summary>
		/// <param name="index">Индекс коллекции, по которому нужно вставить команду конструктора.</param>
		/// <param name="value">Объект <see cref="T:System.ComponentModel.Design.DesignerVerb" />, вставляемый в коллекцию.</param>
		// Token: 0x060023CE RID: 9166 RVA: 0x00051107 File Offset: 0x0004F307
		public void Insert(int index, DesignerVerb value)
		{
			base.List.Insert(index, value);
		}

		/// <summary>Получает индекс заданного ограничения <see cref="T:System.ComponentModel.Design.DesignerVerb" />.</summary>
		/// <param name="value">Объект <see cref="T:System.ComponentModel.Design.DesignerVerb" />, индекс которого в коллекции будет возвращен.</param>
		/// <returns>Индекс заданного объекта, если он найден в списке, в противном случае значение -1.</returns>
		// Token: 0x060023CF RID: 9167 RVA: 0x000510F9 File Offset: 0x0004F2F9
		public int IndexOf(DesignerVerb value)
		{
			return base.List.IndexOf(value);
		}

		/// <summary>Возвращает значение, определяющее, включен ли в коллекцию указанный объект <see cref="T:System.ComponentModel.Design.DesignerVerb" />.</summary>
		/// <param name="value">Объект <see cref="T:System.ComponentModel.Design.DesignerVerb" /> для поиска в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект присутствует в коллекции; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060023D0 RID: 9168 RVA: 0x000510DC File Offset: 0x0004F2DC
		public bool Contains(DesignerVerb value)
		{
			return base.List.Contains(value);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.ComponentModel.Design.DesignerVerb" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.ComponentModel.Design.DesignerVerb" />, который требуется удалить из коллекции.</param>
		// Token: 0x060023D1 RID: 9169 RVA: 0x00051159 File Offset: 0x0004F359
		public void Remove(DesignerVerb value)
		{
			base.List.Remove(value);
		}

		/// <summary>Копирует элементы коллекции в заданный массив объектов <see cref="T:System.ComponentModel.Design.DesignerVerb" />, начиная с заданного индекса назначения.</summary>
		/// <param name="array">Массив, в который выполняется копирование элементов коллекции.</param>
		/// <param name="index">Индекс в массиве назначения, начиная с которого нужно вставлять копируемые элементы коллекции.</param>
		// Token: 0x060023D2 RID: 9170 RVA: 0x000510EA File Offset: 0x0004F2EA
		public void CopyTo(DesignerVerb[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>Вызывает событие <see langword="Set" />.</summary>
		/// <param name="index">Индекс установки значения элемента.</param>
		/// <param name="oldValue">Прежний объект.</param>
		/// <param name="newValue">Новый объект.</param>
		// Token: 0x060023D3 RID: 9171 RVA: 0x00003917 File Offset: 0x00001B17
		protected override void OnSet(int index, object oldValue, object newValue)
		{
		}

		/// <summary>Вызывает событие <see langword="Insert" />.</summary>
		/// <param name="index">Индекс вставки элемента.</param>
		/// <param name="value">Вставляемый объект.</param>
		// Token: 0x060023D4 RID: 9172 RVA: 0x00003917 File Offset: 0x00001B17
		protected override void OnInsert(int index, object value)
		{
		}

		/// <summary>Вызывает событие <see langword="Clear" />.</summary>
		// Token: 0x060023D5 RID: 9173 RVA: 0x00003917 File Offset: 0x00001B17
		protected override void OnClear()
		{
		}

		/// <summary>Вызывает событие <see langword="Remove" />.</summary>
		/// <param name="index">Индекс удаляемого элемента.</param>
		/// <param name="value">Удаляемый объект.</param>
		// Token: 0x060023D6 RID: 9174 RVA: 0x00003917 File Offset: 0x00001B17
		protected override void OnRemove(int index, object value)
		{
		}

		/// <summary>Вызывает событие <see langword="Validate" />.</summary>
		/// <param name="value">Объект для проверки.</param>
		// Token: 0x060023D7 RID: 9175 RVA: 0x00003917 File Offset: 0x00001B17
		protected override void OnValidate(object value)
		{
		}
	}
}
