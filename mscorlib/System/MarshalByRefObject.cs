using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Lifetime;
using System.Security.Permissions;

namespace System
{
	/// <summary>Разрешает доступ к объектам через границы доменов приложения в приложениях, поддерживающих удаленное взаимодействие.</summary>
	// Token: 0x0200023B RID: 571
	[ComVisible(true)]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public abstract class MarshalByRefObject
	{
		// Token: 0x06001A17 RID: 6679 RVA: 0x0005FEBC File Offset: 0x0005E0BC
		internal Identity GetObjectIdentity(MarshalByRefObject obj, out bool IsClient)
		{
			IsClient = false;
			Identity objectIdentity;
			if (RemotingServices.IsTransparentProxy(obj))
			{
				objectIdentity = RemotingServices.GetRealProxy(obj).ObjectIdentity;
				IsClient = true;
			}
			else
			{
				objectIdentity = obj.ObjectIdentity;
			}
			return objectIdentity;
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x0005FEEF File Offset: 0x0005E0EF
		// (set) Token: 0x06001A19 RID: 6681 RVA: 0x0005FEF7 File Offset: 0x0005E0F7
		internal ServerIdentity ObjectIdentity
		{
			get
			{
				return this._identity;
			}
			set
			{
				this._identity = value;
			}
		}

		/// <summary>Создает объект, который содержит всю необходимую информацию для создания прокси-сервера, используемого для взаимодействия с удаленным объектом.</summary>
		/// <param name="requestedType">Класс <see cref="T:System.Type" /> объекта, на который будет ссылаться новый объект <see cref="T:System.Runtime.Remoting.ObjRef" />.</param>
		/// <returns>Информация, необходимая для создания прокси-сервера.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Этот экземпляр не является допустимым объектом удаленного взаимодействия.</exception>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06001A1A RID: 6682 RVA: 0x0005FF00 File Offset: 0x0005E100
		[SecurityPermission(SecurityAction.LinkDemand, Infrastructure = true)]
		public virtual ObjRef CreateObjRef(Type requestedType)
		{
			if (this._identity == null)
			{
				throw new RemotingException(Locale.GetText("No remoting information was found for the object."));
			}
			return this._identity.CreateObjRef(requestedType);
		}

		/// <summary>Извлекает объект обслуживания во время существования, который управляет политикой времени существования данного экземпляра.</summary>
		/// <returns>Объект типа <see cref="T:System.Runtime.Remoting.Lifetime.ILease" />, используемый для управления политикой времени существования данного экземпляра.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06001A1B RID: 6683 RVA: 0x0005FF26 File Offset: 0x0005E126
		[SecurityPermission(SecurityAction.LinkDemand, Infrastructure = true)]
		public object GetLifetimeService()
		{
			if (this._identity == null)
			{
				return null;
			}
			return this._identity.Lease;
		}

		/// <summary>Получает объект службы времени существования для управления политикой времени существования для этого экземпляра.</summary>
		/// <returns>Объект типа <see cref="T:System.Runtime.Remoting.Lifetime.ILease" />, используемый для управления политикой времени существования данного экземпляра. Этот объект является текущим объектом обслуживания времени существования для данного экземпляра, если таковой существует; в противном случае он является новым объектом обслуживания времени существования, инициализированным значением свойства <see cref="P:System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseManagerPollTime" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06001A1C RID: 6684 RVA: 0x0005FF3D File Offset: 0x0005E13D
		[SecurityPermission(SecurityAction.LinkDemand, Infrastructure = true)]
		public virtual object InitializeLifetimeService()
		{
			if (this._identity != null && this._identity.Lease != null)
			{
				return this._identity.Lease;
			}
			return new Lease();
		}

		/// <summary>Создает неполную копию текущего объекта <see cref="T:System.MarshalByRefObject" />.</summary>
		/// <param name="cloneIdentity">Значение <see langword="false" />, чтобы удалить удостоверение текущего объекта <see cref="T:System.MarshalByRefObject" />, в результате чего при маршалинге объектов через удаленные границы будет присвоено новое удостоверение. В большинстве случаев можно использовать значение <see langword="false" />. Значение <see langword="true" /> для копирования удостоверения текущего объекта <see cref="T:System.MarshalByRefObject" /> в его клон, в результате чего вызовы удаленного клиента будут перенаправляться на объект удаленного сервера.</param>
		/// <returns>Неполная копия текущего объекта <see cref="T:System.MarshalByRefObject" />.</returns>
		// Token: 0x06001A1D RID: 6685 RVA: 0x0005FF68 File Offset: 0x0005E168
		protected MarshalByRefObject MemberwiseClone(bool cloneIdentity)
		{
			MarshalByRefObject marshalByRefObject = (MarshalByRefObject)base.MemberwiseClone();
			if (!cloneIdentity)
			{
				marshalByRefObject._identity = null;
			}
			return marshalByRefObject;
		}

		// Token: 0x0400171E RID: 5918
		[NonSerialized]
		private ServerIdentity _identity;
	}
}
