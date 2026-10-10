using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Представляет типизированную слабую ссылку, которая указывает на объект, но позволяет удалять его сборщику мусора.</summary>
	/// <typeparam name="T">Тип объекта, на который указывает ссылка.</typeparam>
	// Token: 0x0200026B RID: 619
	[Serializable]
	public sealed class WeakReference<T> : ISerializable where T : class
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.WeakReference`1" />, который ссылается на указанный объект.</summary>
		/// <param name="target">Объект, на который указывает ссылка, или значение <see langword="null" />.</param>
		// Token: 0x06001C23 RID: 7203 RVA: 0x00069368 File Offset: 0x00067568
		public WeakReference(T target) : this(target, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.WeakReference`1" />, который ссылается на заданный объект и использует указанное отслеживание восстановления.</summary>
		/// <param name="target">Объект, на который указывает ссылка, или значение <see langword="null" />.</param>
		/// <param name="trackResurrection">Значение <see langword="true" /> для отслеживания объекта после финализации; значение <see langword="false" /> для отслеживания объекта только до финализации.</param>
		// Token: 0x06001C24 RID: 7204 RVA: 0x00069374 File Offset: 0x00067574
		public WeakReference(T target, bool trackResurrection)
		{
			this.trackResurrection = trackResurrection;
			GCHandleType type = trackResurrection ? GCHandleType.WeakTrackResurrection : GCHandleType.Weak;
			this.handle = GCHandle.Alloc(target, type);
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x000693A8 File Offset: 0x000675A8
		private WeakReference(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.trackResurrection = info.GetBoolean("TrackResurrection");
			object value = info.GetValue("TrackedObject", typeof(T));
			GCHandleType type = this.trackResurrection ? GCHandleType.WeakTrackResurrection : GCHandleType.Weak;
			this.handle = GCHandle.Alloc(value, type);
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> всеми данными, необходимыми для сериализации текущего объекта <see cref="T:System.WeakReference`1" />.</summary>
		/// <param name="info">Объект, который содержит все данные, необходимые для сериализации или десериализации текущего объекта <see cref="T:System.WeakReference`1" />.</param>
		/// <param name="context">Расположение, где хранятся и откуда получаются сериализованные данные.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001C26 RID: 7206 RVA: 0x0006940C File Offset: 0x0006760C
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("TrackResurrection", this.trackResurrection);
			if (this.handle.IsAllocated)
			{
				info.AddValue("TrackedObject", this.handle.Target);
				return;
			}
			info.AddValue("TrackedObject", null);
		}

		/// <summary>Задает целевой объект, на который ссылается этот объект <see cref="T:System.WeakReference`1" />.</summary>
		/// <param name="target">Новый целевой объект.</param>
		// Token: 0x06001C27 RID: 7207 RVA: 0x00069468 File Offset: 0x00067668
		public void SetTarget(T target)
		{
			this.handle.Target = target;
		}

		/// <summary>Пытается извлечь целевой объект, на который ссылается текущий объект <see cref="T:System.WeakReference`1" />.</summary>
		/// <param name="target">Когда выполнение этого метода завершается, содержит целевой объект, если он доступен. Этот параметр обрабатывается как неинициализированный.</param>
		/// <returns>Значение <see langword="true" />, если целевой объект был извлечен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001C28 RID: 7208 RVA: 0x0006947B File Offset: 0x0006767B
		public bool TryGetTarget(out T target)
		{
			if (!this.handle.IsAllocated)
			{
				target = default(T);
				return false;
			}
			target = (T)((object)this.handle.Target);
			return target != null;
		}

		/// <summary>Удаляет ссылку на целевой объект, представленный текущим объектом <see cref="T:System.WeakReference`1" />.</summary>
		// Token: 0x06001C29 RID: 7209 RVA: 0x000694B8 File Offset: 0x000676B8
		~WeakReference()
		{
			this.handle.Free();
		}

		// Token: 0x040019BE RID: 6590
		private GCHandle handle;

		// Token: 0x040019BF RID: 6591
		private bool trackResurrection;
	}
}
