using System;
using System.Runtime.InteropServices;

namespace System.Security.Policy
{
	/// <summary>Представляет контекст для диспетчера доверия, рассматриваемый при принятии решения о запуске приложения и при установке параметров безопасности на новом объекте <see cref="T:System.AppDomain" />, в котором запускается приложение.</summary>
	// Token: 0x02000422 RID: 1058
	[ComVisible(true)]
	public class TrustManagerContext
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.TrustManagerContext" />.</summary>
		// Token: 0x06002B51 RID: 11089 RVA: 0x0009CB4E File Offset: 0x0009AD4E
		public TrustManagerContext() : this(TrustManagerUIContext.Run)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.TrustManagerContext" />, используя указанный объект <see cref="T:System.Security.Policy.TrustManagerUIContext" />.</summary>
		/// <param name="uiContext">Одно из значений <see cref="T:System.Security.Policy.TrustManagerUIContext" />, которое задает тип используемый интерфейс пользователя для диспетчера доверия.</param>
		// Token: 0x06002B52 RID: 11090 RVA: 0x0009CB57 File Offset: 0x0009AD57
		public TrustManagerContext(TrustManagerUIContext uiContext)
		{
			this._ignorePersistedDecision = false;
			this._noPrompt = false;
			this._keepAlive = false;
			this._persist = false;
			this._ui = uiContext;
		}

		/// <summary>Возвращает или задает значение, указывающее, должен ли диспетчер безопасности приложения игнорировать любые сохраненные решения и вызвать диспетчер доверия.</summary>
		/// <returns>Значение <see langword="true" />, чтобы вызвать диспетчер доверия; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06002B53 RID: 11091 RVA: 0x0009CB82 File Offset: 0x0009AD82
		// (set) Token: 0x06002B54 RID: 11092 RVA: 0x0009CB8A File Offset: 0x0009AD8A
		public virtual bool IgnorePersistedDecision
		{
			get
			{
				return this._ignorePersistedDecision;
			}
			set
			{
				this._ignorePersistedDecision = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, должен ли диспетчер доверия сохранить в кэше состояние для этого приложения, чтобы упростить обработку будущих запросов на определение доверия к приложению.</summary>
		/// <returns>Значение <see langword="true" />, чтобы сохранить в кэше данные о состоянии; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06002B55 RID: 11093 RVA: 0x0009CB93 File Offset: 0x0009AD93
		// (set) Token: 0x06002B56 RID: 11094 RVA: 0x0009CB9B File Offset: 0x0009AD9B
		public virtual bool KeepAlive
		{
			get
			{
				return this._keepAlive;
			}
			set
			{
				this._keepAlive = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее следует ли диспетчеру доверия запросить пользователя относительно решений о доверии.</summary>
		/// <returns>Значение <see langword="true" />, чтобы не запрашивать пользователя; значение <see langword="false" /> для запроса пользователя. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06002B57 RID: 11095 RVA: 0x0009CBA4 File Offset: 0x0009ADA4
		// (set) Token: 0x06002B58 RID: 11096 RVA: 0x0009CBAC File Offset: 0x0009ADAC
		public virtual bool NoPrompt
		{
			get
			{
				return this._noPrompt;
			}
			set
			{
				this._noPrompt = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее следует ли сохранить запрос пользователя в диалоговом окне согласия.</summary>
		/// <returns>Значение <see langword="true" />, чтобы сохранить в кэше данные о состоянии; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x0009CBB5 File Offset: 0x0009ADB5
		// (set) Token: 0x06002B5A RID: 11098 RVA: 0x0009CBBD File Offset: 0x0009ADBD
		public virtual bool Persist
		{
			get
			{
				return this._persist;
			}
			set
			{
				this._persist = value;
			}
		}

		/// <summary>Получает или задает идентификацию предыдущей идентификации приложения.</summary>
		/// <returns>Объект <see cref="T:System.ApplicationIdentity" /> представляющий предыдущий объект <see cref="T:System.ApplicationIdentity" />.</returns>
		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06002B5B RID: 11099 RVA: 0x0009CBC6 File Offset: 0x0009ADC6
		// (set) Token: 0x06002B5C RID: 11100 RVA: 0x0009CBCE File Offset: 0x0009ADCE
		public virtual ApplicationIdentity PreviousApplicationIdentity
		{
			get
			{
				return this._previousId;
			}
			set
			{
				this._previousId = value;
			}
		}

		/// <summary>Получает или задает тот тип пользовательского интерфейса для диспетчера доверия, который следует отобразить.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Security.Policy.TrustManagerUIContext" />. Значение по умолчанию — <see cref="F:System.Security.Policy.TrustManagerUIContext.Run" />.</returns>
		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06002B5D RID: 11101 RVA: 0x0009CBD7 File Offset: 0x0009ADD7
		// (set) Token: 0x06002B5E RID: 11102 RVA: 0x0009CBDF File Offset: 0x0009ADDF
		public virtual TrustManagerUIContext UIContext
		{
			get
			{
				return this._ui;
			}
			set
			{
				this._ui = value;
			}
		}

		// Token: 0x04001FBC RID: 8124
		private bool _ignorePersistedDecision;

		// Token: 0x04001FBD RID: 8125
		private bool _noPrompt;

		// Token: 0x04001FBE RID: 8126
		private bool _keepAlive;

		// Token: 0x04001FBF RID: 8127
		private bool _persist;

		// Token: 0x04001FC0 RID: 8128
		private ApplicationIdentity _previousId;

		// Token: 0x04001FC1 RID: 8129
		private TrustManagerUIContext _ui;
	}
}
