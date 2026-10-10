using System;
using System.Collections;
using System.Collections.Specialized;

namespace System.ComponentModel.Design
{
	/// <summary>Представляет меню Windows или команду панели инструментов.</summary>
	// Token: 0x0200046F RID: 1135
	public class MenuCommand
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.MenuCommand" />.</summary>
		/// <param name="handler">Событие, вызываемое при выборе пользователем команды меню или нажатии кнопки панели инструментов.</param>
		/// <param name="command">Уникальный идентификатор команды, связывающий данную команду меню с меню среды.</param>
		// Token: 0x06002487 RID: 9351 RVA: 0x000818B6 File Offset: 0x0007FAB6
		public MenuCommand(EventHandler handler, CommandID command)
		{
			this._execHandler = handler;
			this.CommandID = command;
			this._status = 3;
		}

		/// <summary>Получает или задает значение, указывающее, отмечена ли данная команда меню.</summary>
		/// <returns>Значение <see langword="true" />, если команда отмечена флажком; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x000818D3 File Offset: 0x0007FAD3
		// (set) Token: 0x06002489 RID: 9353 RVA: 0x000818E0 File Offset: 0x0007FAE0
		public virtual bool Checked
		{
			get
			{
				return (this._status & 4) != 0;
			}
			set
			{
				this.SetStatus(4, value);
			}
		}

		/// <summary>Получает значение, показывающее, доступна ли данная команда меню.</summary>
		/// <returns>Значение <see langword="true" />, если команда включена; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x000818EA File Offset: 0x0007FAEA
		// (set) Token: 0x0600248B RID: 9355 RVA: 0x000818F7 File Offset: 0x0007FAF7
		public virtual bool Enabled
		{
			get
			{
				return (this._status & 2) != 0;
			}
			set
			{
				this.SetStatus(2, value);
			}
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x00081904 File Offset: 0x0007FB04
		private void SetStatus(int mask, bool value)
		{
			int num = this._status;
			if (value)
			{
				num |= mask;
			}
			else
			{
				num &= ~mask;
			}
			if (num != this._status)
			{
				this._status = num;
				this.OnCommandChanged(EventArgs.Empty);
			}
		}

		/// <summary>Возвращает открытые свойства, сопоставленные объекту <see cref="T:System.ComponentModel.Design.MenuCommand" />.</summary>
		/// <returns>Словарь <see cref="T:System.Collections.IDictionary" />, содержащий открытые свойства объекта <see cref="T:System.ComponentModel.Design.MenuCommand" />.</returns>
		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x00081944 File Offset: 0x0007FB44
		public virtual IDictionary Properties
		{
			get
			{
				IDictionary result;
				if ((result = this._properties) == null)
				{
					result = (this._properties = new HybridDictionary());
				}
				return result;
			}
		}

		/// <summary>Получает или задает значение, показывающее, поддерживается ли данная команда меню.</summary>
		/// <returns>Значение <see langword="true" />, если команда поддерживается (это значение установлено по умолчанию); в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x00081969 File Offset: 0x0007FB69
		// (set) Token: 0x0600248F RID: 9359 RVA: 0x00081976 File Offset: 0x0007FB76
		public virtual bool Supported
		{
			get
			{
				return (this._status & 1) != 0;
			}
			set
			{
				this.SetStatus(1, value);
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, отображается ли данная команда меню.</summary>
		/// <returns>Значение <see langword="true" />, если команда отображается на экране; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06002490 RID: 9360 RVA: 0x00081980 File Offset: 0x0007FB80
		// (set) Token: 0x06002491 RID: 9361 RVA: 0x0008198E File Offset: 0x0007FB8E
		public virtual bool Visible
		{
			get
			{
				return (this._status & 16) == 0;
			}
			set
			{
				this.SetStatus(16, !value);
			}
		}

		/// <summary>Возникает при изменении команды меню.</summary>
		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06002492 RID: 9362 RVA: 0x0008199C File Offset: 0x0007FB9C
		// (remove) Token: 0x06002493 RID: 9363 RVA: 0x000819D4 File Offset: 0x0007FBD4
		public event EventHandler CommandChanged;

		/// <summary>Получает идентификатор <see cref="T:System.ComponentModel.Design.CommandID" />, связанный с данной командой меню.</summary>
		/// <returns>Идентификатор <see cref="T:System.ComponentModel.Design.CommandID" />, связанный с данной командой меню.</returns>
		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06002494 RID: 9364 RVA: 0x00081A09 File Offset: 0x0007FC09
		public virtual CommandID CommandID { get; }

		/// <summary>Вызывает команду.</summary>
		// Token: 0x06002495 RID: 9365 RVA: 0x00081A14 File Offset: 0x0007FC14
		public virtual void Invoke()
		{
			if (this._execHandler != null)
			{
				try
				{
					this._execHandler(this, EventArgs.Empty);
				}
				catch (CheckoutException ex)
				{
					if (ex != CheckoutException.Canceled)
					{
						throw;
					}
				}
			}
		}

		/// <summary>Вызывает команду с заданным параметром.</summary>
		/// <param name="arg">Дополнительный аргумент для команды.</param>
		// Token: 0x06002496 RID: 9366 RVA: 0x00081A58 File Offset: 0x0007FC58
		public virtual void Invoke(object arg)
		{
			this.Invoke();
		}

		/// <summary>Получает код состояния команды OLE для данной команды меню.</summary>
		/// <returns>Целочисленное значение, содержащее сочетание флагов состояний, отражающих состояние данной команды меню.</returns>
		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x00081A60 File Offset: 0x0007FC60
		public virtual int OleStatus
		{
			get
			{
				return this._status;
			}
		}

		/// <summary>Вызывает событие <see cref="E:System.ComponentModel.Design.MenuCommand.CommandChanged" />.</summary>
		/// <param name="e">Объект класса <see cref="T:System.EventArgs" />, содержащий данные события.</param>
		// Token: 0x06002498 RID: 9368 RVA: 0x00081A68 File Offset: 0x0007FC68
		protected virtual void OnCommandChanged(EventArgs e)
		{
			EventHandler commandChanged = this.CommandChanged;
			if (commandChanged == null)
			{
				return;
			}
			commandChanged(this, e);
		}

		/// <summary>Возвращает строковое представление данной команды меню.</summary>
		/// <returns>Строка, содержащая значение свойства <see cref="P:System.ComponentModel.Design.MenuCommand.CommandID" />, дополненного именами всех установленных флагов, разделенными вертикальной чертой "|". Эти свойства флагов включают свойства <see cref="P:System.ComponentModel.Design.MenuCommand.Checked" />, <see cref="P:System.ComponentModel.Design.MenuCommand.Enabled" />, <see cref="P:System.ComponentModel.Design.MenuCommand.Supported" /> и <see cref="P:System.ComponentModel.Design.MenuCommand.Visible" />.</returns>
		// Token: 0x06002499 RID: 9369 RVA: 0x00081A7C File Offset: 0x0007FC7C
		public override string ToString()
		{
			string text = this.CommandID.ToString() + " : ";
			if ((this._status & 1) != 0)
			{
				text += "Supported";
			}
			if ((this._status & 2) != 0)
			{
				text += "|Enabled";
			}
			if ((this._status & 16) == 0)
			{
				text += "|Visible";
			}
			if ((this._status & 4) != 0)
			{
				text += "|Checked";
			}
			return text;
		}

		// Token: 0x040010D1 RID: 4305
		private EventHandler _execHandler;

		// Token: 0x040010D2 RID: 4306
		private int _status;

		// Token: 0x040010D3 RID: 4307
		private IDictionary _properties;

		// Token: 0x040010D4 RID: 4308
		private const int ENABLED = 2;

		// Token: 0x040010D5 RID: 4309
		private const int INVISIBLE = 16;

		// Token: 0x040010D6 RID: 4310
		private const int CHECKED = 4;

		// Token: 0x040010D7 RID: 4311
		private const int SUPPORTED = 1;
	}
}
