using System;
using System.Runtime.InteropServices;

namespace System.Security.Policy
{
	/// <summary>Указывает доступ к ресурсам сети, который предоставляется коду.</summary>
	// Token: 0x02000406 RID: 1030
	[ComVisible(true)]
	[Serializable]
	public class CodeConnectAccess
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.CodeConnectAccess" />.</summary>
		/// <param name="allowScheme">Схема URI, представленная текущим экземпляром.</param>
		/// <param name="allowPort">Порт, представленный текущим экземпляром.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Свойство <paramref name="allowScheme" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="allowScheme" /> является пустой строкой ("").  
		///
		/// или - 
		/// Параметр <paramref name="allowScheme" /> содержит символы, которые не разрешены в схемах.  
		///
		/// или - 
		/// Значение параметра <paramref name="allowPort" /> меньше 0.  
		///
		/// или - 
		/// Значение <paramref name="allowPort" /> больше 65 535.</exception>
		// Token: 0x06002A1B RID: 10779 RVA: 0x00098994 File Offset: 0x00096B94
		[MonoTODO("(2.0) validations incomplete")]
		public CodeConnectAccess(string allowScheme, int allowPort)
		{
			if (allowScheme == null || allowScheme.Length == 0)
			{
				throw new ArgumentOutOfRangeException("allowScheme");
			}
			if (allowPort < 0 || allowPort > 65535)
			{
				throw new ArgumentOutOfRangeException("allowPort");
			}
			this._scheme = allowScheme;
			this._port = allowPort;
		}

		/// <summary>Получает порт, представленный текущим экземпляром.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, идентифицирующее порт компьютера, используемый совместно со свойством <see cref="P:System.Security.Policy.CodeConnectAccess.Scheme" />.</returns>
		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06002A1C RID: 10780 RVA: 0x000989E2 File Offset: 0x00096BE2
		public int Port
		{
			get
			{
				return this._port;
			}
		}

		/// <summary>Получает схему URI, представленную текущим экземпляром.</summary>
		/// <returns>Объект <see cref="T:System.String" />, идентифицирующий схему URI, преобразованную в нижний регистр.</returns>
		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06002A1D RID: 10781 RVA: 0x000989EA File Offset: 0x00096BEA
		public string Scheme
		{
			get
			{
				return this._scheme;
			}
		}

		/// <summary>Возвращает значение, указывающее, представляют ли два объекта <see cref="T:System.Security.Policy.CodeConnectAccess" /> одинаковые схему и порт.</summary>
		/// <param name="o">Объект, который требуется сравнить с текущим объектом <see cref="T:System.Security.Policy.CodeConnectAccess" />.</param>
		/// <returns>Значение <see langword="true" />, если два параметра представляют одинаковые схему и порт; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002A1E RID: 10782 RVA: 0x000989F4 File Offset: 0x00096BF4
		public override bool Equals(object o)
		{
			CodeConnectAccess codeConnectAccess = o as CodeConnectAccess;
			return codeConnectAccess != null && this._scheme == codeConnectAccess._scheme && this._port == codeConnectAccess._port;
		}

		/// <summary>Служит хэш-функцией для определенного типа.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Object" />.</returns>
		// Token: 0x06002A1F RID: 10783 RVA: 0x00098A30 File Offset: 0x00096C30
		public override int GetHashCode()
		{
			return this._scheme.GetHashCode() ^ this._port;
		}

		/// <summary>Возвращает экземпляр <see cref="T:System.Security.Policy.CodeConnectAccess" />, представляющий доступ к заданному порту с использованием любой схемы.</summary>
		/// <param name="allowPort">Порт, представленный возвращенным экземпляром.</param>
		/// <returns>Экземпляр <see cref="T:System.Security.Policy.CodeConnectAccess" /> для заданного порта.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="allowPort" /> меньше 0.  
		///
		/// или - 
		/// Значение <paramref name="allowPort" /> больше 65 535.</exception>
		// Token: 0x06002A20 RID: 10784 RVA: 0x00098A44 File Offset: 0x00096C44
		public static CodeConnectAccess CreateAnySchemeAccess(int allowPort)
		{
			return new CodeConnectAccess(CodeConnectAccess.AnyScheme, allowPort);
		}

		/// <summary>Возвращает экземпляр <see cref="T:System.Security.Policy.CodeConnectAccess" />, представляющий доступ к заданному порту, используя схему начала координат для кода.</summary>
		/// <param name="allowPort">Порт, представленный возвращенным экземпляром.</param>
		/// <returns>Экземпляр <see cref="T:System.Security.Policy.CodeConnectAccess" /> для заданного порта.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="allowPort" /> меньше 0.  
		///
		/// или - 
		/// Значение <paramref name="allowPort" /> больше 65 535.</exception>
		// Token: 0x06002A21 RID: 10785 RVA: 0x00098A51 File Offset: 0x00096C51
		public static CodeConnectAccess CreateOriginSchemeAccess(int allowPort)
		{
			return new CodeConnectAccess(CodeConnectAccess.OriginScheme, allowPort);
		}

		/// <summary>Содержит строковое значение, представляющее шаблон схемы.</summary>
		// Token: 0x04001F64 RID: 8036
		public static readonly string AnyScheme = "*";

		/// <summary>Содержит значение, используемое для представления порта по умолчанию.</summary>
		// Token: 0x04001F65 RID: 8037
		public static readonly int DefaultPort = -3;

		/// <summary>Содержит значение, используемое для представления значения порта в URI, где создан код.</summary>
		// Token: 0x04001F66 RID: 8038
		public static readonly int OriginPort = -4;

		/// <summary>Содержит значение, используемое для представления схемы в URL, где создан код.</summary>
		// Token: 0x04001F67 RID: 8039
		public static readonly string OriginScheme = "$origin";

		// Token: 0x04001F68 RID: 8040
		private string _scheme;

		// Token: 0x04001F69 RID: 8041
		private int _port;
	}
}
