using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Представляет слабую ссылку, которая указывает на объект, но позволяет удалять его сборщику мусора.</summary>
	// Token: 0x0200026A RID: 618
	[ComVisible(true)]
	[Serializable]
	public class WeakReference : ISerializable
	{
		// Token: 0x06001C19 RID: 7193 RVA: 0x00069200 File Offset: 0x00067400
		private void AllocateHandle(object target)
		{
			if (this.isLongReference)
			{
				this.gcHandle = GCHandle.Alloc(target, GCHandleType.WeakTrackResurrection);
				return;
			}
			this.gcHandle = GCHandle.Alloc(target, GCHandleType.Weak);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.WeakReference" />, ссылающийся на заданный объект.</summary>
		/// <param name="target">Отслеживаемый объект или <see langword="null" />.</param>
		// Token: 0x06001C1A RID: 7194 RVA: 0x00069225 File Offset: 0x00067425
		public WeakReference(object target) : this(target, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.WeakReference" />, ссылающийся на заданный объект и использующий заданное отслеживание восстановления.</summary>
		/// <param name="target">Отслеживаемый объект.</param>
		/// <param name="trackResurrection">Указывает, когда необходимо прекратить отслеживание объекта. Если задано значение <see langword="true" />, объект отслеживается после завершения; если значение <see langword="false" />, объект отслеживается только до завершения.</param>
		// Token: 0x06001C1B RID: 7195 RVA: 0x0006922F File Offset: 0x0006742F
		public WeakReference(object target, bool trackResurrection)
		{
			this.isLongReference = trackResurrection;
			this.AllocateHandle(target);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.WeakReference" />, используя десериализованные данные из заданных объектов сериализации и потока.</summary>
		/// <param name="info">Объект, который содержит все данные, необходимые для сериализации и десериализации текущего объекта <see cref="T:System.WeakReference" />.</param>
		/// <param name="context">(Зарезервировано.) Описывает источник и назначение сериализованного потока, заданного параметра <paramref name="info" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001C1C RID: 7196 RVA: 0x00069248 File Offset: 0x00067448
		protected WeakReference(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.isLongReference = info.GetBoolean("TrackResurrection");
			object value = info.GetValue("TrackedObject", typeof(object));
			this.AllocateHandle(value);
		}

		/// <summary>Возвращает сведения о том, был ли удален сборщиком мусора объект, на который ссылается текущий объект <see cref="T:System.WeakReference" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект, на который ссылается текущий объект <see cref="T:System.WeakReference" />, не был удален сборщиком мусора и остается доступным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x00069297 File Offset: 0x00067497
		public virtual bool IsAlive
		{
			get
			{
				return this.Target != null;
			}
		}

		/// <summary>Возвращает или задает (целевой) объект, на который ссылается текущий объект <see cref="T:System.WeakReference" />.</summary>
		/// <returns>Значение <see langword="null" />, если объект, на который ссылается текущий объект <see cref="T:System.WeakReference" />, не был удален сборщиком мусора; в противном случае ссылка на объект, на который ссылается текущий объект <see cref="T:System.WeakReference" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Ссылка на целевой объект является недопустимой. Это исключение может быть создано при задании свойства, если значением является пустая ссылка или объект финализирован во время операции задания.</exception>
		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x000692A2 File Offset: 0x000674A2
		// (set) Token: 0x06001C1F RID: 7199 RVA: 0x000692BE File Offset: 0x000674BE
		public virtual object Target
		{
			get
			{
				if (!this.gcHandle.IsAllocated)
				{
					return null;
				}
				return this.gcHandle.Target;
			}
			set
			{
				this.gcHandle.Target = value;
			}
		}

		/// <summary>Возвращает сведения о том, отслеживается ли после завершения объект, на который ссылается текущий объект <see cref="T:System.WeakReference" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект, на который ссылается текущий объект <see cref="T:System.WeakReference" />, отслеживается после завершения; значение <see langword="false" />, если этот объект отслеживается только до завершения.</returns>
		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x000692CC File Offset: 0x000674CC
		public virtual bool TrackResurrection
		{
			get
			{
				return this.isLongReference;
			}
		}

		/// <summary>Удаляет ссылку на целевой объект, представленный текущим объектом <see cref="T:System.WeakReference" />.</summary>
		// Token: 0x06001C21 RID: 7201 RVA: 0x000692D4 File Offset: 0x000674D4
		~WeakReference()
		{
			this.gcHandle.Free();
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> всеми данными, необходимыми для сериализации текущего объекта <see cref="T:System.WeakReference" />.</summary>
		/// <param name="info">Объект, который содержит все данные, необходимые для сериализации и десериализации текущего объекта <see cref="T:System.WeakReference" />.</param>
		/// <param name="context">(Зарезервировано.) Область, где хранятся и откуда извлекаются сериализованные данные.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001C22 RID: 7202 RVA: 0x00069308 File Offset: 0x00067508
		[SecurityCritical]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("TrackResurrection", this.TrackResurrection);
			try
			{
				info.AddValue("TrackedObject", this.Target);
			}
			catch (Exception)
			{
				info.AddValue("TrackedObject", null);
			}
		}

		// Token: 0x040019BC RID: 6588
		private bool isLongReference;

		// Token: 0x040019BD RID: 6589
		private GCHandle gcHandle;
	}
}
