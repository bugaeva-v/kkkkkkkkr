using System;
using System.Globalization;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет уникальный идентификатор команды, состоящий из числового идентификатора команды (ID) и глобального уникального идентификатора группы меню (GUID).</summary>
	// Token: 0x0200043F RID: 1087
	public class CommandID
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.CommandID" />, используя указанные GUID-идентификатор группы и числовой идентификатор команды.</summary>
		/// <param name="menuGroup">GUID-идентификатор группы, к которой принадлежит данная команда меню.</param>
		/// <param name="commandID">Числовой идентификатор этой команды меню.</param>
		// Token: 0x06002387 RID: 9095 RVA: 0x00081028 File Offset: 0x0007F228
		public CommandID(Guid menuGroup, int commandID)
		{
			this.Guid = menuGroup;
			this.ID = commandID;
		}

		/// <summary>Возвращает числовой идентификатор команды.</summary>
		/// <returns>Число-идентификатор команды.</returns>
		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x0008103E File Offset: 0x0007F23E
		public virtual int ID { get; }

		/// <summary>Определяет, равны ли два экземпляра <see cref="T:System.ComponentModel.Design.CommandID" />.</summary>
		/// <param name="obj">Объект для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если заданный объект равен данному; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002389 RID: 9097 RVA: 0x00081048 File Offset: 0x0007F248
		public override bool Equals(object obj)
		{
			if (!(obj is CommandID))
			{
				return false;
			}
			CommandID commandID = (CommandID)obj;
			return commandID.Guid.Equals(this.Guid) && commandID.ID == this.ID;
		}

		/// <summary>Служит хэш-функцией для определенного типа.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Object" />.</returns>
		// Token: 0x0600238A RID: 9098 RVA: 0x0008108C File Offset: 0x0007F28C
		public override int GetHashCode()
		{
			return this.Guid.GetHashCode() << 2 | this.ID;
		}

		/// <summary>Возвращает GUID-идентификатор группы, к которой принадлежит команда, соответствующая данному идентификатору <see cref="T:System.ComponentModel.Design.CommandID" />.</summary>
		/// <returns>GUID-идентификатор группы команд, к которой принадлежит данная команда.</returns>
		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x000810B6 File Offset: 0x0007F2B6
		public virtual Guid Guid { get; }

		/// <summary>Возвращает строку (<see cref="T:System.String" />), которая представляет текущий объект.</summary>
		/// <returns>Строка, содержащая оба компонента идентификатора команды: GUID-идентификатор группы меню и целочисленный идентификатор команды.</returns>
		// Token: 0x0600238C RID: 9100 RVA: 0x000810C0 File Offset: 0x0007F2C0
		public override string ToString()
		{
			return this.Guid.ToString() + " : " + this.ID.ToString(CultureInfo.CurrentCulture);
		}
	}
}
