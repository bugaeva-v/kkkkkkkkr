using System;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Предоставляет многоуровневый переключатель для управления выводом трассировки и отладки без повторной компиляции кода.</summary>
	// Token: 0x02000223 RID: 547
	public class SourceSwitch : Switch
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.SourceSwitch" />, задающего имя источника.</summary>
		/// <param name="name">Имя источника.</param>
		// Token: 0x06000FE0 RID: 4064 RVA: 0x0004645F File Offset: 0x0004465F
		public SourceSwitch(string name) : base(name, string.Empty)
		{
		}

		/// <summary>Выполняет инициализацию нового класса <see cref="T:System.Diagnostics.SourceSwitch" />, задающего для переключателя источника отображаемое имя и значение по умолчанию.</summary>
		/// <param name="displayName">Имя переключателя источника.</param>
		/// <param name="defaultSwitchValue">Значение по умолчанию для переключателя.</param>
		// Token: 0x06000FE1 RID: 4065 RVA: 0x0004646D File Offset: 0x0004466D
		public SourceSwitch(string displayName, string defaultSwitchValue) : base(displayName, string.Empty, defaultSwitchValue)
		{
		}

		/// <summary>Получает или задает уровень переключателя.</summary>
		/// <returns>Одно из значений <see cref="T:System.Diagnostics.SourceLevels" />, представляющее уровень события переключателя.</returns>
		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0004647C File Offset: 0x0004467C
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x00046484 File Offset: 0x00044684
		public SourceLevels Level
		{
			get
			{
				return (SourceLevels)base.SwitchSetting;
			}
			[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			set
			{
				base.SwitchSetting = (int)value;
			}
		}

		/// <summary>Позволяет определить на основе типа трассировки, нужно ли вызывать прослушивателей трассировки.</summary>
		/// <param name="eventType">Одно из значений <see cref="T:System.Diagnostics.TraceEventType" />.</param>
		/// <returns>Если нужно вызвать прослушиватели трассировки, значение <see langword="true" />, если нет, значение <see langword="false" />.</returns>
		// Token: 0x06000FE4 RID: 4068 RVA: 0x0004648D File Offset: 0x0004468D
		public bool ShouldTrace(TraceEventType eventType)
		{
			return (base.SwitchSetting & (int)eventType) != 0;
		}

		/// <summary>Вызывается при изменении значения свойства <see cref="P:System.Diagnostics.Switch.Value" />.</summary>
		/// <exception cref="T:System.ArgumentException">Новое значение свойства <see cref="P:System.Diagnostics.Switch.Value" /> не равно ни одному из значений <see cref="T:System.Diagnostics.SourceLevels" />.</exception>
		// Token: 0x06000FE5 RID: 4069 RVA: 0x0004649A File Offset: 0x0004469A
		protected override void OnValueChanged()
		{
			base.SwitchSetting = (int)Enum.Parse(typeof(SourceLevels), base.Value, true);
		}
	}
}
