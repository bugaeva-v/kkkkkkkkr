using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.XPath;

namespace System.Xml
{
	/// <summary>
	///         Представляет средство записи, обеспечивающее быстрый прямой способ (без кэширования) создания потоков или файлов, содержащих XML-данные.
	///       </summary>
	// Token: 0x02000179 RID: 377
	public abstract class XmlWriter : IDisposable
	{
		/// <summary>
		///         Получает объект <see cref="T:System.Xml.XmlWriterSettings" />, используемый для создания данного экземпляра <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XmlWriterSettings" /> Объект, используемый для создания экземпляра модуля записи.
		///          Если это средство записи не был создан с помощью <see cref="Overload:System.Xml.XmlWriter.Create" /> метода, это свойство возвращает <see langword="null" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0001DA42 File Offset: 0x0001BC42
		public virtual XmlWriterSettings Settings
		{
			get
			{
				return null;
			}
		}

		/// <summary>
		///         Когда переопределено в производном классе, записывает объявление XML с номером версии "1.0".
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             Это не первый метод записи, вызываемый после конструктора.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D48 RID: 3400
		public abstract void WriteStartDocument();

		/// <summary>
		///         Когда переопределено в производном классе, записывает объявление XML с номером версии "1.0" и отдельным атрибутом.
		///       </summary>
		/// <param name="standalone">
		///           Если <see langword="true" />, он записывает» автономный = yes»; Если <see langword="false" />, он записывает» автономный = нет».
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Это не первый метод записи, вызываемый после конструктора.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D49 RID: 3401
		public abstract void WriteStartDocument(bool standalone);

		/// <summary>
		///         Когда переопределено в производном классе, закрывает все открытые элементы и атрибуты, возвращая средство записи в начальное состояние.
		///       </summary>
		/// <exception cref="T:System.ArgumentException">
		///             Указан недопустимый документ XML.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D4A RID: 3402
		public abstract void WriteEndDocument();

		/// <summary>
		///         Когда переопределено в производном классе, записывает объявление DOCTYPE с указанным именем и дополнительными атрибутами.
		///       </summary>
		/// <param name="name">
		///           Имя DOCTYPE.
		///            Не должно быть пустым.
		///         </param>
		/// <param name="pubid">
		///           Если ненулевое, записывается также PUBLIC «pubid» «sysid», где <paramref name="pubid" /> и <paramref name="sysid" /> заменяются значение заданных аргументов.
		///         </param>
		/// <param name="sysid">
		///           Если <paramref name="pubid" /> является <see langword="null" /> и <paramref name="sysid" /> является пустым, записывается SYSTEM «sysid», где <paramref name="sysid" /> заменяется значением данного аргумента.
		///         </param>
		/// <param name="subset">
		///           Если не равно нулю, записывает [subset], где subset замещается значением данного аргумента.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Этот метод был вызван вне пролога (после корневого элемента).
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Значение для <paramref name="name" /> приведет к недопустимый XML.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D4B RID: 3403
		public abstract void WriteDocType(string name, string pubid, string sysid, string subset);

		/// <summary>
		///         Когда переопределено в производном классе, записывает указанный открывающий тег и связывает его с заданным пространством имен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="ns">
		///           URI пространства имен, связываемый с элементом.
		///            Если пространство имен уже находится в области видимости и с ним связан префикс, средство записи автоматически запишет этот префикс.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Модуль записи закрыт.
		///           </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">
		///             Имеется символ в буфере, который является допустимым знаком XML, но недопустим для кодирования вывода.
		///              Например если кодирование вывода ASCII, только следует использовать символы из диапазона от 0 до 127 для имен элементов и атрибутов.
		///              Недопустимый символ может быть в аргументе этого метода или в аргументе предыдущих методов, которые осуществляли запись в буфер.
		///              Такие символы экранируются, ссылки на сущности знаков по возможности (например, в текстовых узлов или значений атрибута).
		///              Тем не менее ссылки на сущность символа не допускается в имена элементов и атрибутов, комментарии, инструкции по обработке или разделы CDATA.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D4C RID: 3404 RVA: 0x00057E6E File Offset: 0x0005606E
		public void WriteStartElement(string localName, string ns)
		{
			this.WriteStartElement(null, localName, ns);
		}

		/// <summary>
		///         Когда переопределено в производном классе, записывает указанный открывающий тег и связывает его с заданным пространством имен и префиксом.
		///       </summary>
		/// <param name="prefix">
		///           Префикс пространства имен элемента.
		///         </param>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="ns">
		///           URI пространства имен, связываемый с элементом.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Модуль записи закрыт.
		///           </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">
		///             Имеется символ в буфере, который является допустимым знаком XML, но недопустим для кодирования вывода.
		///              Например если кодирование вывода ASCII, только следует использовать символы из диапазона от 0 до 127 для имен элементов и атрибутов.
		///              Недопустимый символ может быть в аргументе этого метода или в аргументе предыдущих методов, которые осуществляли запись в буфер.
		///              Такие символы экранируются, ссылки на сущности знаков по возможности (например, в текстовых узлов или значений атрибута).
		///              Тем не менее ссылки на сущность символа не допускается в имена элементов и атрибутов, комментарии, инструкции по обработке или разделы CDATA.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D4D RID: 3405
		public abstract void WriteStartElement(string prefix, string localName, string ns);

		/// <summary>
		///         Когда переопределено в производном классе, записывает открывающий тег с указанным локальным именем.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Модуль записи закрыт.
		///           </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">
		///             Имеется символ в буфере, который является допустимым знаком XML, но недопустим для кодирования вывода.
		///              Например если кодирование вывода ASCII, только следует использовать символы из диапазона от 0 до 127 для имен элементов и атрибутов.
		///              Недопустимый символ может быть в аргументе этого метода или в аргументе предыдущих методов, которые осуществляли запись в буфер.
		///              Такие символы экранируются, ссылки на сущности знаков по возможности (например, в текстовых узлов или значений атрибута).
		///              Тем не менее ссылки на сущность символа не допускается в имена элементов и атрибутов, комментарии, инструкции по обработке или разделы CDATA.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D4E RID: 3406 RVA: 0x00057E79 File Offset: 0x00056079
		public void WriteStartElement(string localName)
		{
			this.WriteStartElement(null, localName, null);
		}

		/// <summary>
		///         Когда переопределено в производном классе, закрывает один элемент и извлекает из стека область видимости соответствующего пространства имен.
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             Это приводит к недопустимым XML-документа.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D4F RID: 3407
		public abstract void WriteEndElement();

		/// <summary>
		///         Когда переопределено в производном классе, закрывает один элемент и извлекает из стека область видимости соответствующего пространства имен.
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D50 RID: 3408
		public abstract void WriteFullEndElement();

		/// <summary>
		///         Когда переопределено в производном классе, записывает атрибут с указанным локальным именем, URI пространства имен и значением.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="ns">
		///           URI пространства имен, который связывается с атрибутом.
		///         </param>
		/// <param name="value">
		///           Значение атрибута.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Состояние средства записи не <see langword="WriteState.Element" /> или модуль записи закрыт.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <see langword="xml:space" /> Или <see langword="xml:lang" /> недопустимое значение атрибута.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D51 RID: 3409 RVA: 0x00057E84 File Offset: 0x00056084
		public void WriteAttributeString(string localName, string ns, string value)
		{
			this.WriteStartAttribute(null, localName, ns);
			this.WriteString(value);
			this.WriteEndAttribute();
		}

		/// <summary>
		///         Когда переопределено в производном классе, записывает атрибут с указанным локальным именем и значением.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="value">
		///           Значение атрибута.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Состояние средства записи не <see langword="WriteState.Element" /> или модуль записи закрыт.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <see langword="xml:space" /> Или <see langword="xml:lang" /> недопустимое значение атрибута.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D52 RID: 3410 RVA: 0x00057E9C File Offset: 0x0005609C
		public void WriteAttributeString(string localName, string value)
		{
			this.WriteStartAttribute(null, localName, null);
			this.WriteString(value);
			this.WriteEndAttribute();
		}

		/// <summary>
		///         Когда переопределено в производном классе, записывает атрибут с указанным префиксом, локальным именем, URI пространства имен и значением.
		///       </summary>
		/// <param name="prefix">
		///           Префикс пространства имен атрибута.
		///         </param>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="ns">
		///           Универсальный код ресурса (URI) пространства имен атрибута.
		///         </param>
		/// <param name="value">
		///           Значение атрибута.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Состояние средства записи не <see langword="WriteState.Element" /> или модуль записи закрыт.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <see langword="xml:space" /> Или <see langword="xml:lang" /> недопустимое значение атрибута.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Значение параметра <paramref name="localName" /> или <paramref name="ns" /> — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D53 RID: 3411 RVA: 0x00057EB4 File Offset: 0x000560B4
		public void WriteAttributeString(string prefix, string localName, string ns, string value)
		{
			this.WriteStartAttribute(prefix, localName, ns);
			this.WriteString(value);
			this.WriteEndAttribute();
		}

		/// <summary>
		///         Записывает начало атрибута с заданным локальным именем и URI пространства имен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="ns">
		///           Универсальный код ресурса (URI) пространства имен атрибута.
		///         </param>
		/// <exception cref="T:System.Text.EncoderFallbackException">
		///             Имеется символ в буфере, который является допустимым знаком XML, но недопустим для кодирования вывода.
		///              Например если кодирование вывода ASCII, только следует использовать символы из диапазона от 0 до 127 для имен элементов и атрибутов.
		///              Недопустимый символ может быть в аргументе этого метода или в аргументе предыдущих методов, которые осуществляли запись в буфер.
		///              Такие символы экранируются, ссылки на сущности знаков по возможности (например, в текстовых узлов или значений атрибута).
		///              Тем не менее ссылки на сущность символа не допускается в имена элементов и атрибутов, комментарии, инструкции по обработке или разделы CDATA.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D54 RID: 3412 RVA: 0x00057ECD File Offset: 0x000560CD
		public void WriteStartAttribute(string localName, string ns)
		{
			this.WriteStartAttribute(null, localName, ns);
		}

		/// <summary>
		///         Когда переопределено в производном классе, записывает начало атрибута с указанным префиксом, локальным именем и URI пространства имен.
		///       </summary>
		/// <param name="prefix">
		///           Префикс пространства имен атрибута.
		///         </param>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="ns">
		///           URI пространства имен атрибута.
		///         </param>
		/// <exception cref="T:System.Text.EncoderFallbackException">
		///             Имеется символ в буфере, который является допустимым знаком XML, но недопустим для кодирования вывода.
		///              Например если кодирование вывода ASCII, только следует использовать символы из диапазона от 0 до 127 для имен элементов и атрибутов.
		///              Недопустимый символ может быть в аргументе этого метода или в аргументе предыдущих методов, которые осуществляли запись в буфер.
		///              Такие символы экранируются, ссылки на сущности знаков по возможности (например, в текстовых узлов или значений атрибута).
		///              Тем не менее ссылки на сущность символа не допускается в имена элементов и атрибутов, комментарии, инструкции по обработке или разделы CDATA.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D55 RID: 3413
		public abstract void WriteStartAttribute(string prefix, string localName, string ns);

		/// <summary>
		///         Записывает начало атрибута с заданным локальным именем.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Модуль записи закрыт.
		///           </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">
		///             Имеется символ в буфере, который является допустимым знаком XML, но недопустим для кодирования вывода.
		///              Например если кодирование вывода ASCII, только следует использовать символы из диапазона от 0 до 127 для имен элементов и атрибутов.
		///              Недопустимый символ может быть в аргументе этого метода или в аргументе предыдущих методов, которые осуществляли запись в буфер.
		///              Такие символы экранируются, ссылки на сущности знаков по возможности (например, в текстовых узлов или значений атрибута).
		///              Тем не менее ссылки на сущность символа не допускается в имена элементов и атрибутов, комментарии, инструкции по обработке или разделы CDATA.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D56 RID: 3414 RVA: 0x00057ED8 File Offset: 0x000560D8
		public void WriteStartAttribute(string localName)
		{
			this.WriteStartAttribute(null, localName, null);
		}

		/// <summary>
		///         При переопределении в производном классе, закрывает предыдущий <see cref="M:System.Xml.XmlWriter.WriteStartAttribute(System.String,System.String)" /> вызова.
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D57 RID: 3415
		public abstract void WriteEndAttribute();

		/// <summary>
		///         Когда переопределено в производном классе, записывает блок &lt;![CDATA[...]]&gt;, содержащий заданный текст.
		///       </summary>
		/// <param name="text">
		///           Текст, записываемый в блок CDATA.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Текст приведет к плохому формированию документа XML.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D58 RID: 3416
		public abstract void WriteCData(string text);

		/// <summary>
		///         Когда переопределено в производном классе, записывает примечание &lt;!--...--&gt;, содержащее заданный текст.
		///       </summary>
		/// <param name="text">
		///           Текст, записываемый в примечание.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Текст возвращается в XML-документ без правильного формата.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D59 RID: 3417
		public abstract void WriteComment(string text);

		/// <summary>
		///         При переопределении в производном классе считывает инструкцию обработки с пробелом между именем и текстом следующим образом: &lt;? имя текст? &gt;.
		///       </summary>
		/// <param name="name">
		///           Имя инструкции по обработке.
		///         </param>
		/// <param name="text">
		///           Текст, включаемый в инструкцию по обработке.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Текст приведет к плохому формированию документа XML.
		///
		///             <paramref name="name" /> либо <see langword="null" /> или <see langword="String.Empty" />.
		///
		///             Этот метод используется для создания описания XML после <see cref="M:System.Xml.XmlWriter.WriteStartDocument" /> уже был вызван.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D5A RID: 3418
		public abstract void WriteProcessingInstruction(string name, string text);

		/// <summary>
		///         При переопределении в производном классе записывает ссылку на сущность в виде <see langword="&amp;name;" />.
		///       </summary>
		/// <param name="name">
		///           Имя ссылки на сущность.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="name" /> либо <see langword="null" /> или <see langword="String.Empty" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D5B RID: 3419
		public abstract void WriteEntityRef(string name);

		/// <summary>
		///         Когда переопределено в производном классе, вызывает создание сущности знака для указанного значения знака Юникода.
		///       </summary>
		/// <param name="ch">
		///           Знак Юникода, для которого создается сущность знака.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Символ находится в диапазоне символов суррогатной пары, <see langword="0xd800" /> - <see langword="0xdfff" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D5C RID: 3420
		public abstract void WriteCharEntity(char ch);

		/// <summary>
		///         Когда переопределено в производном классе, записывает указанный символ-разделитель.
		///       </summary>
		/// <param name="ws">
		///           Строка символов-разделителей.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Строка содержит знаки пустого пространства.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D5D RID: 3421
		public abstract void WriteWhitespace(string ws);

		/// <summary>
		///         Записывает заданное текстовое содержимое при переопределении в производном классе.
		///       </summary>
		/// <param name="text">
		///           Текст для записи.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Строка текста содержит недопустимую суррогатную пару.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D5E RID: 3422
		public abstract void WriteString(string text);

		/// <summary>
		///         Когда переопределено в производном классе, создает и записывает сущность символа-заместителя для пары символов-заместителей.
		///       </summary>
		/// <param name="lowChar">
		///           Младший заместитель.
		///            Значение должно быть в диапазоне от 0xDC00 до 0xDFFF.
		///         </param>
		/// <param name="highChar">
		///           Старший заместитель.
		///            Значение должно быть в диапазоне от 0xD800 до 0xDBFF.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Передан недопустимая суррогатной пары символов.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D5F RID: 3423
		public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);

		/// <summary>
		///         Когда переопределено в производном классе, записывает содержимое текстового буфера.
		///       </summary>
		/// <param name="buffer">
		///           Массив символов, содержащий текст для записи.
		///         </param>
		/// <param name="index">
		///           Позиция в буфере, с которой начинается запись текста.
		///         </param>
		/// <param name="count">
		///           Количество символов для записи.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="index" /> или <paramref name="count" /> меньше нуля.
		///
		///             -или-
		///
		///             Длина буфера за вычетом <paramref name="index" /> — меньше, чем <paramref name="count" />; в результате вызова пары знаков-заместителей разделению или записываемых недопустимую суррогатную пару.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="buffer" /> Недопустимое значение параметра.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D60 RID: 3424
		public abstract void WriteChars(char[] buffer, int index, int count);

		/// <summary>
		///         Когда переопределено в производном классе, вручную записывает из буфера символов необработанные данные для разметки .
		///       </summary>
		/// <param name="buffer">
		///           Массив символов, содержащий текст для записи.
		///         </param>
		/// <param name="index">
		///           Позиция в буфере, с которой начинается запись текста.
		///         </param>
		/// <param name="count">
		///           Количество символов для записи.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="index" /> или <paramref name="count" /> меньше нуля.
		///
		///             -или-
		///
		///             Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D61 RID: 3425
		public abstract void WriteRaw(char[] buffer, int index, int count);

		/// <summary>
		///         Когда переопределено в производном классе, вручную записывает из строки необработанные данные для разметки.
		///       </summary>
		/// <param name="data">
		///           Строка, содержащая текст для записи.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="data" /> либо <see langword="null" /> или <see langword="String.Empty" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D62 RID: 3426
		public abstract void WriteRaw(string data);

		/// <summary>
		///         Когда переопределено в производном классе, преобразует указанный набор двоичных байтов в кодировку Base64 и записывает получившийся текст.
		///       </summary>
		/// <param name="buffer">
		///           Кодируемый массив байтов.
		///         </param>
		/// <param name="index">
		///           Позиция в буфере, с которой начинается запись байтов.
		///         </param>
		/// <param name="count">
		///           Количество записываемых байтов.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="index" /> или <paramref name="count" /> меньше нуля.
		///
		///             -или-
		///
		///             Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D63 RID: 3427
		public abstract void WriteBase64(byte[] buffer, int index, int count);

		/// <summary>
		///         При переопределении в производном классе преобразует указанный набор двоичных байтов как <see langword="BinHex" /> и выводит получившийся текст.
		///       </summary>
		/// <param name="buffer">
		///           Кодируемый массив байтов.
		///         </param>
		/// <param name="index">
		///           Позиция в буфере, с которой начинается запись байтов.
		///         </param>
		/// <param name="count">
		///           Количество записываемых байтов.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Модуль записи закрыт или находится в состоянии ошибки.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.
		///
		///             -или-
		///
		///             Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D64 RID: 3428 RVA: 0x00057EE3 File Offset: 0x000560E3
		public virtual void WriteBinHex(byte[] buffer, int index, int count)
		{
			BinHexEncoder.Encode(buffer, index, count, this);
		}

		/// <summary>
		///         Когда переопределено в производном классе, возвращает состояние средства записи.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.WriteState" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000D65 RID: 3429
		public abstract WriteState WriteState { get; }

		/// <summary>
		///         Когда переопределено в производном классе, закрывает данный поток и базовый поток.
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             Вызов для записи дополнительных выходных данных после <see langword="Close" /> был вызван или результатом данного вызова является неверный XML-документ.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D66 RID: 3430 RVA: 0x0000B528 File Offset: 0x00009728
		public virtual void Close()
		{
		}

		/// <summary>
		///         Когда переопределено в производном классе, сохраняет в базовый поток содержимое буфера, а также сохраняет основной поток.
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D67 RID: 3431
		public abstract void Flush();

		/// <summary>
		///         Когда переопределено в производном классе, возвращает ближайший префикс, определенный в области видимости текущего пространства имен для URI пространства имен.
		///       </summary>
		/// <param name="ns">
		///           URI пространства имен, префикс которого нужно найти.
		///         </param>
		/// <returns>
		///         Соответствующий префикс или <see langword="null" /> Если отсутствует соответствующий пространства имен URI в текущей области.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="ns" /> либо <see langword="null" /> или <see langword="String.Empty" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D68 RID: 3432
		public abstract string LookupPrefix(string ns);

		/// <summary>
		///         При переопределении в производном классе получает <see cref="T:System.Xml.XmlSpace" /> представляющий текущую <see langword="xml:space" /> область.
		///       </summary>
		/// <returns>
		///         <see langword="XmlSpace" /> Представляющий текущую <see langword="xml:space" /> область.
		///
		///                 Значение 
		///
		///                 Смысл 
		///
		///                 <see langword="None" />
		///
		///                 Это значение по умолчанию, если не <see langword="xml:space" /> область существует.
		///
		///                 <see langword="Default" />
		///
		///                 Текущая область — <see langword="xml:space" />= «по умолчанию».
		///
		///                 <see langword="Preserve" />
		///
		///                 Текущая область — <see langword="xml:space" />= «preserve».
		///               </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x0001222F File Offset: 0x0001042F
		public virtual XmlSpace XmlSpace
		{
			get
			{
				return XmlSpace.Default;
			}
		}

		/// <summary>
		///         При переопределении в производном классе, возвращает текущую <see langword="xml:lang" /> область.
		///       </summary>
		/// <returns>
		///         Текущая область действия <see langword="xml:lang" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x0001E51E File Offset: 0x0001C71E
		public virtual string XmlLang
		{
			get
			{
				return string.Empty;
			}
		}

		/// <summary>
		///         Когда переопределено в производном классе, записывает указанное имя, гарантируя допустимость NmToken согласно рекомендациям W3C по языку XML версии 1.0 (http://www.w3.org/TR/1998/REC-xml-19980210#NT-Name).
		///       </summary>
		/// <param name="name">
		///           Записываемое имя.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="name" /> не является допустимым NmToken; или <paramref name="name" /> либо <see langword="null" /> или <see langword="String.Empty" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D6B RID: 3435 RVA: 0x00057EEE File Offset: 0x000560EE
		public virtual void WriteNmToken(string name)
		{
			if (name == null || name.Length == 0)
			{
				throw new ArgumentException(Res.GetString("The empty string '' is not a valid name."));
			}
			this.WriteString(XmlConvert.VerifyNMTOKEN(name, ExceptionType.ArgumentException));
		}

		/// <summary>
		///         Когда переопределено в производном классе, записывает указанное имя, гарантируя его допустимость согласно рекомендации W3C по языку XML версии 1.0 (http://www.w3.org/TR/1998/REC-xml-19980210#NT-Name).
		///       </summary>
		/// <param name="name">
		///           Записываемое имя.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="name" /> не является допустимым именем XML. или <paramref name="name" /> либо <see langword="null" /> или <see langword="String.Empty" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D6C RID: 3436 RVA: 0x00057F18 File Offset: 0x00056118
		public virtual void WriteName(string name)
		{
			this.WriteString(XmlConvert.VerifyQName(name, ExceptionType.ArgumentException));
		}

		/// <summary>
		///         При переопределении в производном классе считывает полное имя пространства имен.
		///          Этот метод выполняет поиск префикса для пространства имен в его области.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя для записи.
		///         </param>
		/// <param name="ns">
		///           URI пространства имен для имени.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="localName" /> либо <see langword="null" /> или <see langword="String.Empty" />.
		///
		///             <paramref name="localName" /> не является допустимым именем.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D6D RID: 3437 RVA: 0x00057F28 File Offset: 0x00056128
		public virtual void WriteQualifiedName(string localName, string ns)
		{
			if (ns != null && ns.Length > 0)
			{
				string text = this.LookupPrefix(ns);
				if (text == null)
				{
					throw new ArgumentException(Res.GetString("The '{0}' namespace is not defined.", new object[]
					{
						ns
					}));
				}
				this.WriteString(text);
				this.WriteString(":");
			}
			this.WriteString(localName);
		}

		/// <summary>
		///         Записывает значение объекта.
		///       </summary>
		/// <param name="value">
		///           Значение объекта для записи.
		///
		///           Примечание   с выпуском платформы .NET Framework 3.5, этот метод принимает <see cref="T:System.DateTimeOffset" /> как параметр.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Указано недопустимое значение.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение параметра <paramref name="value" /> — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Модуль записи закрыт или находится в состоянии ошибки.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D6E RID: 3438 RVA: 0x00057F7F File Offset: 0x0005617F
		public virtual void WriteValue(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this.WriteString(XmlUntypedConverter.Untyped.ToString(value, null));
		}

		/// <summary>
		///         Записывает значение <see cref="T:System.String" />.
		///       </summary>
		/// <param name="value">
		///           Значение <see cref="T:System.String" /> для записи.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Указано недопустимое значение.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D6F RID: 3439 RVA: 0x00057FA1 File Offset: 0x000561A1
		public virtual void WriteValue(string value)
		{
			if (value == null)
			{
				return;
			}
			this.WriteString(value);
		}

		/// <summary>
		///         Записывает значение <see cref="T:System.Boolean" />.
		///       </summary>
		/// <param name="value">
		///           Значение <see cref="T:System.Boolean" /> для записи.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Указано недопустимое значение.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D70 RID: 3440 RVA: 0x00057FAE File Offset: 0x000561AE
		public virtual void WriteValue(bool value)
		{
			this.WriteString(XmlConvert.ToString(value));
		}

		/// <summary>
		///         Записывает значение <see cref="T:System.DateTime" />.
		///       </summary>
		/// <param name="value">
		///           Значение <see cref="T:System.DateTime" /> для записи.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Указано недопустимое значение.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D71 RID: 3441 RVA: 0x00057FBC File Offset: 0x000561BC
		public virtual void WriteValue(DateTime value)
		{
			this.WriteString(XmlConvert.ToString(value, XmlDateTimeSerializationMode.RoundtripKind));
		}

		/// <summary>
		///         Записывает значение <see cref="T:System.DateTimeOffset" />.
		///       </summary>
		/// <param name="value">
		///           Значение <see cref="T:System.DateTimeOffset" /> для записи.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D72 RID: 3442 RVA: 0x00057FCB File Offset: 0x000561CB
		public virtual void WriteValue(DateTimeOffset value)
		{
			if (value.Offset != TimeSpan.Zero)
			{
				this.WriteValue(value.LocalDateTime);
				return;
			}
			this.WriteValue(value.UtcDateTime);
		}

		/// <summary>
		///         Записывает значение <see cref="T:System.Double" />.
		///       </summary>
		/// <param name="value">
		///           Значение <see cref="T:System.Double" /> для записи.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Указано недопустимое значение.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D73 RID: 3443 RVA: 0x00057FFB File Offset: 0x000561FB
		public virtual void WriteValue(double value)
		{
			this.WriteString(XmlConvert.ToString(value));
		}

		/// <summary>
		///         Записывает число с плавающей запятой одиночной точности.
		///       </summary>
		/// <param name="value">
		///           Число с плавающей запятой одиночной точности для записи.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Указано недопустимое значение.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D74 RID: 3444 RVA: 0x00058009 File Offset: 0x00056209
		public virtual void WriteValue(float value)
		{
			this.WriteString(XmlConvert.ToString(value));
		}

		/// <summary>
		///         Записывает значение <see cref="T:System.Decimal" />.
		///       </summary>
		/// <param name="value">
		///           Значение <see cref="T:System.Decimal" /> для записи.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Указано недопустимое значение.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D75 RID: 3445 RVA: 0x00058017 File Offset: 0x00056217
		public virtual void WriteValue(decimal value)
		{
			this.WriteString(XmlConvert.ToString(value));
		}

		/// <summary>
		///         Записывает значение <see cref="T:System.Int32" />.
		///       </summary>
		/// <param name="value">
		///           Значение <see cref="T:System.Int32" /> для записи.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Указано недопустимое значение.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D76 RID: 3446 RVA: 0x00058025 File Offset: 0x00056225
		public virtual void WriteValue(int value)
		{
			this.WriteString(XmlConvert.ToString(value));
		}

		/// <summary>
		///         Записывает значение <see cref="T:System.Int64" />.
		///       </summary>
		/// <param name="value">
		///           Значение <see cref="T:System.Int64" /> для записи.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Указано недопустимое значение.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D77 RID: 3447 RVA: 0x00058033 File Offset: 0x00056233
		public virtual void WriteValue(long value)
		{
			this.WriteString(XmlConvert.ToString(value));
		}

		/// <summary>
		///         При переопределении в производном классе записывает все атрибуты, найденные в текущей позиции в <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="reader">
		///           <see langword="XmlReader" /> Из которого необходимо скопировать атрибуты.
		///         </param>
		/// <param name="defattr">
		///           <see langword="true" /> Чтобы скопировать атрибуты по умолчанию из <see langword="XmlReader" />; в противном случае — <see langword="false" />.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="reader" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Средство чтения не позиционировано на <see langword="element" />, <see langword="attribute" /> или <see langword="XmlDeclaration" /> узла.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D78 RID: 3448 RVA: 0x00058044 File Offset: 0x00056244
		public virtual void WriteAttributes(XmlReader reader, bool defattr)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (reader.NodeType == XmlNodeType.Element || reader.NodeType == XmlNodeType.XmlDeclaration)
			{
				if (reader.MoveToFirstAttribute())
				{
					this.WriteAttributes(reader, defattr);
					reader.MoveToElement();
					return;
				}
			}
			else
			{
				if (reader.NodeType != XmlNodeType.Attribute)
				{
					throw new XmlException("The current position on the Reader is neither an element nor an attribute.", string.Empty);
				}
				do
				{
					if (defattr || !reader.IsDefaultInternal)
					{
						this.WriteStartAttribute(reader.Prefix, reader.LocalName, reader.NamespaceURI);
						while (reader.ReadAttributeValue())
						{
							if (reader.NodeType == XmlNodeType.EntityReference)
							{
								this.WriteEntityRef(reader.Name);
							}
							else
							{
								this.WriteString(reader.Value);
							}
						}
						this.WriteEndAttribute();
					}
				}
				while (reader.MoveToNextAttribute());
			}
		}

		/// <summary>
		///         Когда переопределено в производном классе, копирует все данные из средства чтения в средство записи и перемещает средство чтения к началу следующего элемента того же уровня.
		///       </summary>
		/// <param name="reader">
		///           Экземпляр <see cref="T:System.Xml.XmlReader" />, из которого выполняется чтение.
		///         </param>
		/// <param name="defattr">
		///           <see langword="true" /> Чтобы скопировать атрибуты по умолчанию из <see langword="XmlReader" />; в противном случае — <see langword="false" />.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="reader" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="reader" /> содержит недопустимые символы.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D79 RID: 3449 RVA: 0x00058104 File Offset: 0x00056304
		public virtual void WriteNode(XmlReader reader, bool defattr)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			bool canReadValueChunk = reader.CanReadValueChunk;
			int num = (reader.NodeType == XmlNodeType.None) ? -1 : reader.Depth;
			do
			{
				switch (reader.NodeType)
				{
				case XmlNodeType.Element:
					this.WriteStartElement(reader.Prefix, reader.LocalName, reader.NamespaceURI);
					this.WriteAttributes(reader, defattr);
					if (reader.IsEmptyElement)
					{
						this.WriteEndElement();
					}
					break;
				case XmlNodeType.Text:
					if (canReadValueChunk)
					{
						if (this.writeNodeBuffer == null)
						{
							this.writeNodeBuffer = new char[1024];
						}
						int count;
						while ((count = reader.ReadValueChunk(this.writeNodeBuffer, 0, 1024)) > 0)
						{
							this.WriteChars(this.writeNodeBuffer, 0, count);
						}
					}
					else
					{
						this.WriteString(reader.Value);
					}
					break;
				case XmlNodeType.CDATA:
					this.WriteCData(reader.Value);
					break;
				case XmlNodeType.EntityReference:
					this.WriteEntityRef(reader.Name);
					break;
				case XmlNodeType.ProcessingInstruction:
				case XmlNodeType.XmlDeclaration:
					this.WriteProcessingInstruction(reader.Name, reader.Value);
					break;
				case XmlNodeType.Comment:
					this.WriteComment(reader.Value);
					break;
				case XmlNodeType.DocumentType:
					this.WriteDocType(reader.Name, reader.GetAttribute("PUBLIC"), reader.GetAttribute("SYSTEM"), reader.Value);
					break;
				case XmlNodeType.Whitespace:
				case XmlNodeType.SignificantWhitespace:
					this.WriteWhitespace(reader.Value);
					break;
				case XmlNodeType.EndElement:
					this.WriteFullEndElement();
					break;
				}
			}
			while (reader.Read() && (num < reader.Depth || (num == reader.Depth && reader.NodeType == XmlNodeType.EndElement)));
		}

		/// <summary>
		///         Копирует все из <see cref="T:System.Xml.XPath.XPathNavigator" /> в модуль записи.
		///          Положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </summary>
		/// <param name="navigator">
		///           Элемент <see cref="T:System.Xml.XPath.XPathNavigator" />, из которого копируются данные.
		///         </param>
		/// <param name="defattr">
		///           <see langword="true" /> Копирование атрибутов по умолчанию; в противном случае — <see langword="false" />.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="navigator" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D7A RID: 3450 RVA: 0x000582C4 File Offset: 0x000564C4
		public virtual void WriteNode(XPathNavigator navigator, bool defattr)
		{
			if (navigator == null)
			{
				throw new ArgumentNullException("navigator");
			}
			int num = 0;
			navigator = navigator.Clone();
			for (;;)
			{
				IL_18:
				bool flag = false;
				switch (navigator.NodeType)
				{
				case XPathNodeType.Root:
					flag = true;
					break;
				case XPathNodeType.Element:
					this.WriteStartElement(navigator.Prefix, navigator.LocalName, navigator.NamespaceURI);
					if (navigator.MoveToFirstAttribute())
					{
						do
						{
							IXmlSchemaInfo schemaInfo = navigator.SchemaInfo;
							if (defattr || schemaInfo == null || !schemaInfo.IsDefault)
							{
								this.WriteStartAttribute(navigator.Prefix, navigator.LocalName, navigator.NamespaceURI);
								this.WriteString(navigator.Value);
								this.WriteEndAttribute();
							}
						}
						while (navigator.MoveToNextAttribute());
						navigator.MoveToParent();
					}
					if (navigator.MoveToFirstNamespace(XPathNamespaceScope.Local))
					{
						this.WriteLocalNamespaces(navigator);
						navigator.MoveToParent();
					}
					flag = true;
					break;
				case XPathNodeType.Text:
					this.WriteString(navigator.Value);
					break;
				case XPathNodeType.SignificantWhitespace:
				case XPathNodeType.Whitespace:
					this.WriteWhitespace(navigator.Value);
					break;
				case XPathNodeType.ProcessingInstruction:
					this.WriteProcessingInstruction(navigator.LocalName, navigator.Value);
					break;
				case XPathNodeType.Comment:
					this.WriteComment(navigator.Value);
					break;
				}
				if (flag)
				{
					if (navigator.MoveToFirstChild())
					{
						num++;
						continue;
					}
					if (navigator.NodeType == XPathNodeType.Element)
					{
						if (navigator.IsEmptyElement)
						{
							this.WriteEndElement();
						}
						else
						{
							this.WriteFullEndElement();
						}
					}
				}
				while (num != 0)
				{
					if (navigator.MoveToNext())
					{
						goto IL_18;
					}
					num--;
					navigator.MoveToParent();
					if (navigator.NodeType == XPathNodeType.Element)
					{
						this.WriteFullEndElement();
					}
				}
				break;
			}
		}

		/// <summary>
		///         Записывает элемент с заданным локальным именем и значением.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="value">
		///           Значение элемента.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="localName" /> Значение <see langword="null" /> или пустая строка.
		///
		///             -или-
		///
		///             Значения параметров недопустимы.
		///           </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">
		///             Имеется символ в буфере, который является допустимым знаком XML, но недопустим для кодирования вывода.
		///              Например если кодирование вывода ASCII, только следует использовать символы из диапазона от 0 до 127 для имен элементов и атрибутов.
		///              Недопустимый символ может быть в аргументе этого метода или в аргументе предыдущих методов, которые осуществляли запись в буфер.
		///              Такие символы экранируются, ссылки на сущности знаков по возможности (например, в текстовых узлов или значений атрибута).
		///              Тем не менее ссылки на сущность символа не допускается в имена элементов и атрибутов, комментарии, инструкции по обработке или разделы CDATA.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D7B RID: 3451 RVA: 0x00058447 File Offset: 0x00056647
		public void WriteElementString(string localName, string value)
		{
			this.WriteElementString(localName, null, value);
		}

		/// <summary>
		///         Записывает элемент с заданным локальным именем, URI пространства имен и значением.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="ns">
		///           URI пространства имен, связываемый с элементом.
		///         </param>
		/// <param name="value">
		///           Значение элемента.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="localName" /> Значение <see langword="null" /> или пустая строка.
		///
		///             -или-
		///
		///             Значения параметров недопустимы.
		///           </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">
		///             Имеется символ в буфере, который является допустимым знаком XML, но недопустим для кодирования вывода.
		///              Например если кодирование вывода ASCII, только следует использовать символы из диапазона от 0 до 127 для имен элементов и атрибутов.
		///              Недопустимый символ может быть в аргументе этого метода или в аргументе предыдущих методов, которые осуществляли запись в буфер.
		///              Такие символы экранируются, ссылки на сущности знаков по возможности (например, в текстовых узлов или значений атрибута).
		///              Тем не менее ссылки на сущность символа не допускается в имена элементов и атрибутов, комментарии, инструкции по обработке или разделы CDATA.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D7C RID: 3452 RVA: 0x00058452 File Offset: 0x00056652
		public void WriteElementString(string localName, string ns, string value)
		{
			this.WriteStartElement(localName, ns);
			if (value != null && value.Length != 0)
			{
				this.WriteString(value);
			}
			this.WriteEndElement();
		}

		/// <summary>
		///         Записывает элемент с заданным префиксом, локальным именем, универсальный кодом ресурса (URI) пространства имен и значением.
		///       </summary>
		/// <param name="prefix">
		///           Префикс элемента.
		///         </param>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="ns">
		///           Универсальный код ресурса (URI) пространства имен элемента.
		///         </param>
		/// <param name="value">
		///           Значение элемента.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="localName" /> Значение <see langword="null" /> или пустая строка.
		///
		///             -или-
		///
		///             Значения параметров недопустимы.
		///           </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">
		///             Имеется символ в буфере, который является допустимым знаком XML, но недопустим для кодирования вывода.
		///              Например если кодирование вывода ASCII, только следует использовать символы из диапазона от 0 до 127 для имен элементов и атрибутов.
		///              Недопустимый символ может быть в аргументе этого метода или в аргументе предыдущих методов, которые осуществляли запись в буфер.
		///              Такие символы экранируются, ссылки на сущности знаков по возможности (например, в текстовых узлов или значений атрибута).
		///              Тем не менее ссылки на сущность символа не допускается в имена элементов и атрибутов, комментарии, инструкции по обработке или разделы CDATA.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D7D RID: 3453 RVA: 0x00058474 File Offset: 0x00056674
		public void WriteElementString(string prefix, string localName, string ns, string value)
		{
			this.WriteStartElement(prefix, localName, ns);
			if (value != null && value.Length != 0)
			{
				this.WriteString(value);
			}
			this.WriteEndElement();
		}

		/// <summary>
		///         Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D7E RID: 3454 RVA: 0x0005849A File Offset: 0x0005669A
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>
		///         Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Xml.XmlWriter" />, а при необходимости освобождает также управляемые ресурсы.
		///       </summary>
		/// <param name="disposing">
		///           Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000D7F RID: 3455 RVA: 0x000584A3 File Offset: 0x000566A3
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this.WriteState != WriteState.Closed)
			{
				this.Close();
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x000584B8 File Offset: 0x000566B8
		private void WriteLocalNamespaces(XPathNavigator nsNav)
		{
			string localName = nsNav.LocalName;
			string value = nsNav.Value;
			if (nsNav.MoveToNextNamespace(XPathNamespaceScope.Local))
			{
				this.WriteLocalNamespaces(nsNav);
			}
			if (localName.Length == 0)
			{
				this.WriteAttributeString(string.Empty, "xmlns", "http://www.w3.org/2000/xmlns/", value);
				return;
			}
			this.WriteAttributeString("xmlns", localName, "http://www.w3.org/2000/xmlns/", value);
		}

		/// <summary>
		///         Создает новый <see cref="T:System.Xml.XmlWriter" /> экземпляра, используя указанное имя файла.
		///       </summary>
		/// <param name="outputFileName">
		///           Файл, в который будет выполняться запись.
		///           <see cref="T:System.Xml.XmlWriter" /> Создает файл по указанному пути и записывает его в синтаксис текста XML 1.0.
		///           <paramref name="outputFileName" /> Должен быть путь файловой системы.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XmlWriter" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="url" /> Значение — <see langword="null" />.
		///           </exception>
		// Token: 0x06000D81 RID: 3457 RVA: 0x00058514 File Offset: 0x00056714
		public static XmlWriter Create(string outputFileName)
		{
			return XmlWriter.Create(outputFileName, null);
		}

		/// <summary>
		///         Создает новый <see cref="T:System.Xml.XmlWriter" /> экземпляра, используя имя файла и <see cref="T:System.Xml.XmlWriterSettings" /> объекта.
		///       </summary>
		/// <param name="outputFileName">
		///           Файл, в который будет выполняться запись.
		///           <see cref="T:System.Xml.XmlWriter" /> Создает файл по указанному пути и записывает его в синтаксис текста XML 1.0.
		///           <paramref name="outputFileName" /> Должен быть путь файловой системы.
		///         </param>
		/// <param name="settings">
		///           <see cref="T:System.Xml.XmlWriterSettings" /> Объект, используемый для настройки нового <see cref="T:System.Xml.XmlWriter" /> экземпляра.
		///            Если это <see langword="null" />,  <see cref="T:System.Xml.XmlWriterSettings" /> по умолчанию используются параметры.
		///
		///           Если <see cref="T:System.Xml.XmlWriter" /> используется с <see cref="M:System.Xml.Xsl.XslCompiledTransform.Transform(System.String,System.Xml.XmlWriter)" /> то следует использовать <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> для получения свойство <see cref="T:System.Xml.XmlWriterSettings" /> объекта с правильными параметрами.
		///            Это гарантирует, что созданный <see cref="T:System.Xml.XmlWriter" /> объект имеет правильные выходные параметры.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XmlWriter" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="url" /> равно <see langword="null" />.
		///           </exception>
		// Token: 0x06000D82 RID: 3458 RVA: 0x0005851D File Offset: 0x0005671D
		public static XmlWriter Create(string outputFileName, XmlWriterSettings settings)
		{
			if (settings == null)
			{
				settings = new XmlWriterSettings();
			}
			return settings.CreateWriter(outputFileName);
		}

		/// <summary>
		///         Создает новый <see cref="T:System.Xml.XmlWriter" /> экземпляра, используя указанный поток.
		///       </summary>
		/// <param name="output">
		///           Поток, в который будет выполняться запись.
		///           <see cref="T:System.Xml.XmlWriter" /> Записывает синтаксис текста XML 1.0 и добавляет его в указанный поток.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XmlWriter" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="stream" /> Значение — <see langword="null" />.
		///           </exception>
		// Token: 0x06000D83 RID: 3459 RVA: 0x00058530 File Offset: 0x00056730
		public static XmlWriter Create(Stream output)
		{
			return XmlWriter.Create(output, null);
		}

		/// <summary>
		///         Создает новый <see cref="T:System.Xml.XmlWriter" /> экземпляра, используя поток и <see cref="T:System.Xml.XmlWriterSettings" /> объекта.
		///       </summary>
		/// <param name="output">
		///           Поток, в который будет выполняться запись.
		///           <see cref="T:System.Xml.XmlWriter" /> Записывает синтаксис текста XML 1.0 и добавляет его в указанный поток.
		///         </param>
		/// <param name="settings">
		///           <see cref="T:System.Xml.XmlWriterSettings" /> Объект, используемый для настройки нового <see cref="T:System.Xml.XmlWriter" /> экземпляра.
		///            Если это <see langword="null" />,  <see cref="T:System.Xml.XmlWriterSettings" /> по умолчанию используются параметры.
		///
		///           Если <see cref="T:System.Xml.XmlWriter" /> используется с <see cref="M:System.Xml.Xsl.XslCompiledTransform.Transform(System.String,System.Xml.XmlWriter)" /> то следует использовать <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> для получения свойство <see cref="T:System.Xml.XmlWriterSettings" /> объекта с правильными параметрами.
		///            Это гарантирует, что созданный <see cref="T:System.Xml.XmlWriter" /> объект имеет правильные выходные параметры.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XmlWriter" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="stream" /> Значение — <see langword="null" />.
		///           </exception>
		// Token: 0x06000D84 RID: 3460 RVA: 0x00058539 File Offset: 0x00056739
		public static XmlWriter Create(Stream output, XmlWriterSettings settings)
		{
			if (settings == null)
			{
				settings = new XmlWriterSettings();
			}
			return settings.CreateWriter(output);
		}

		/// <summary>
		///         Создает новый <see cref="T:System.Xml.XmlWriter" /> экземпляра, используя указанный <see cref="T:System.IO.TextWriter" />.
		///       </summary>
		/// <param name="output">
		///           <see cref="T:System.IO.TextWriter" /> Для которого требуется выполнить запись.
		///           <see cref="T:System.Xml.XmlWriter" /> Записывает синтаксис текста XML 1.0 и добавляет его в указанный <see cref="T:System.IO.TextWriter" />.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XmlWriter" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="text" /> Значение — <see langword="null" />.
		///           </exception>
		// Token: 0x06000D85 RID: 3461 RVA: 0x0005854C File Offset: 0x0005674C
		public static XmlWriter Create(TextWriter output)
		{
			return XmlWriter.Create(output, null);
		}

		/// <summary>
		///         Создает новый <see cref="T:System.Xml.XmlWriter" /> экземпляра с помощью <see cref="T:System.IO.TextWriter" /> и <see cref="T:System.Xml.XmlWriterSettings" /> объектов.
		///       </summary>
		/// <param name="output">
		///           <see cref="T:System.IO.TextWriter" /> Для которого требуется выполнить запись.
		///           <see cref="T:System.Xml.XmlWriter" /> Записывает синтаксис текста XML 1.0 и добавляет его в указанный <see cref="T:System.IO.TextWriter" />.
		///         </param>
		/// <param name="settings">
		///           <see cref="T:System.Xml.XmlWriterSettings" /> Объект, используемый для настройки нового <see cref="T:System.Xml.XmlWriter" /> экземпляра.
		///            Если это <see langword="null" />,  <see cref="T:System.Xml.XmlWriterSettings" /> по умолчанию используются параметры.
		///
		///           Если <see cref="T:System.Xml.XmlWriter" /> используется с <see cref="M:System.Xml.Xsl.XslCompiledTransform.Transform(System.String,System.Xml.XmlWriter)" /> то следует использовать <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> для получения свойство <see cref="T:System.Xml.XmlWriterSettings" /> объекта с правильными параметрами.
		///            Это гарантирует, что созданный <see cref="T:System.Xml.XmlWriter" /> объект имеет правильные выходные параметры.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XmlWriter" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="text" /> равно <see langword="null" />.
		///           </exception>
		// Token: 0x06000D86 RID: 3462 RVA: 0x00058555 File Offset: 0x00056755
		public static XmlWriter Create(TextWriter output, XmlWriterSettings settings)
		{
			if (settings == null)
			{
				settings = new XmlWriterSettings();
			}
			return settings.CreateWriter(output);
		}

		/// <summary>
		///         Создает новый <see cref="T:System.Xml.XmlWriter" /> экземпляра, используя указанный <see cref="T:System.Text.StringBuilder" />.
		///       </summary>
		/// <param name="output">
		///           <see cref="T:System.Text.StringBuilder" /> В который осуществляется запись.
		///            Автор содержимого <see cref="T:System.Xml.XmlWriter" /> добавляется к <see cref="T:System.Text.StringBuilder" />.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XmlWriter" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="builder" /> Значение — <see langword="null" />.
		///           </exception>
		// Token: 0x06000D87 RID: 3463 RVA: 0x00058568 File Offset: 0x00056768
		public static XmlWriter Create(StringBuilder output)
		{
			return XmlWriter.Create(output, null);
		}

		/// <summary>
		///         Создает новый <see cref="T:System.Xml.XmlWriter" /> экземпляра с помощью <see cref="T:System.Text.StringBuilder" /> и <see cref="T:System.Xml.XmlWriterSettings" /> объектов.
		///       </summary>
		/// <param name="output">
		///           <see cref="T:System.Text.StringBuilder" /> В который осуществляется запись.
		///            Автор содержимого <see cref="T:System.Xml.XmlWriter" /> добавляется к <see cref="T:System.Text.StringBuilder" />.
		///         </param>
		/// <param name="settings">
		///           <see cref="T:System.Xml.XmlWriterSettings" /> Объект, используемый для настройки нового <see cref="T:System.Xml.XmlWriter" /> экземпляра.
		///            Если это <see langword="null" />,  <see cref="T:System.Xml.XmlWriterSettings" /> по умолчанию используются параметры.
		///
		///           Если <see cref="T:System.Xml.XmlWriter" /> используется с <see cref="M:System.Xml.Xsl.XslCompiledTransform.Transform(System.String,System.Xml.XmlWriter)" /> то следует использовать <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> для получения свойство <see cref="T:System.Xml.XmlWriterSettings" /> объекта с правильными параметрами.
		///            Это гарантирует, что созданный <see cref="T:System.Xml.XmlWriter" /> объект имеет правильные выходные параметры.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XmlWriter" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="builder" /> Значение — <see langword="null" />.
		///           </exception>
		// Token: 0x06000D88 RID: 3464 RVA: 0x00058571 File Offset: 0x00056771
		public static XmlWriter Create(StringBuilder output, XmlWriterSettings settings)
		{
			if (settings == null)
			{
				settings = new XmlWriterSettings();
			}
			if (output == null)
			{
				throw new ArgumentNullException("output");
			}
			return settings.CreateWriter(new StringWriter(output, CultureInfo.InvariantCulture));
		}

		/// <summary>
		///         Создает новый <see cref="T:System.Xml.XmlWriter" /> экземпляра, используя указанный <see cref="T:System.Xml.XmlWriter" /> объекта.
		///       </summary>
		/// <param name="output">
		///           <see cref="T:System.Xml.XmlWriter" /> Объект, который вы хотите использовать как базовый модуль записи.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.XmlWriter" /> Объект, оболочкой указанного <see cref="T:System.Xml.XmlWriter" /> объекта.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="writer" /> равно <see langword="null" />.
		///           </exception>
		// Token: 0x06000D89 RID: 3465 RVA: 0x0005859C File Offset: 0x0005679C
		public static XmlWriter Create(XmlWriter output)
		{
			return XmlWriter.Create(output, null);
		}

		/// <summary>
		///         Создает новый <see cref="T:System.Xml.XmlWriter" /> экземпляра, используя указанный <see cref="T:System.Xml.XmlWriter" /> и <see cref="T:System.Xml.XmlWriterSettings" /> объектов.
		///       </summary>
		/// <param name="output">
		///           <see cref="T:System.Xml.XmlWriter" /> Объект, который вы хотите использовать как базовый модуль записи.
		///         </param>
		/// <param name="settings">
		///           <see cref="T:System.Xml.XmlWriterSettings" /> Объект, используемый для настройки нового <see cref="T:System.Xml.XmlWriter" /> экземпляра.
		///            Если это <see langword="null" />,  <see cref="T:System.Xml.XmlWriterSettings" /> по умолчанию используются параметры.
		///
		///           Если <see cref="T:System.Xml.XmlWriter" /> используется с <see cref="M:System.Xml.Xsl.XslCompiledTransform.Transform(System.String,System.Xml.XmlWriter)" /> то следует использовать <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> для получения свойство <see cref="T:System.Xml.XmlWriterSettings" /> объекта с правильными параметрами.
		///            Это гарантирует, что созданный <see cref="T:System.Xml.XmlWriter" /> объект имеет правильные выходные параметры.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.XmlWriter" /> Объект, оболочкой указанного <see cref="T:System.Xml.XmlWriter" /> объекта.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="writer" /> Значение — <see langword="null" />.
		///           </exception>
		// Token: 0x06000D8A RID: 3466 RVA: 0x000585A5 File Offset: 0x000567A5
		public static XmlWriter Create(XmlWriter output, XmlWriterSettings settings)
		{
			if (settings == null)
			{
				settings = new XmlWriterSettings();
			}
			return settings.CreateWriter(output);
		}

		/// <summary>
		///         Асинхронно записывает объявление XML с номером версии "1.0".
		///       </summary>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteStartDocument" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D8B RID: 3467 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteStartDocumentAsync()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно записывает объявление XML с номером версии "1.0". и отдельным атрибутом.
		///       </summary>
		/// <param name="standalone">
		///           Если <see langword="true" />, он записывает» автономный = yes»; Если <see langword="false" />, он записывает» автономный = нет».
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteStartDocument" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D8C RID: 3468 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteStartDocumentAsync(bool standalone)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно закрывает все открытые элементы и атрибуты, возвращая средство записи в начальное состояние.
		///       </summary>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteEndDocument" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D8D RID: 3469 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteEndDocumentAsync()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно записывает объявление DOCTYPE с указанным именем и дополнительными атрибутами.
		///       </summary>
		/// <param name="name">
		///           Имя DOCTYPE.
		///            Не должно быть пустым.
		///         </param>
		/// <param name="pubid">
		///           Если ненулевое, записывается также PUBLIC «pubid» «sysid», где <paramref name="pubid" /> и <paramref name="sysid" /> заменяются значение заданных аргументов.
		///         </param>
		/// <param name="sysid">
		///           Если <paramref name="pubid" /> является <see langword="null" /> и <paramref name="sysid" /> является пустым, записывается SYSTEM «sysid», где <paramref name="sysid" /> заменяется значением данного аргумента.
		///         </param>
		/// <param name="subset">
		///           Если не равно нулю, записывает [subset], где subset замещается значением данного аргумента.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteDocType" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D8E RID: 3470 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteDocTypeAsync(string name, string pubid, string sysid, string subset)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно записывает указанный открывающий тег и связывает его с заданным пространством имен и префиксом.
		///       </summary>
		/// <param name="prefix">
		///           Префикс пространства имен элемента.
		///         </param>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="ns">
		///           URI пространства имен, связываемый с элементом.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteStartElement" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D8F RID: 3471 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteStartElementAsync(string prefix, string localName, string ns)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно закрывает один элемент и извлекает из стека область видимости соответствующего пространства имен.
		///       </summary>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteEndElement" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D90 RID: 3472 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteEndElementAsync()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно закрывает один элемент и извлекает из стека область видимости соответствующего пространства имен.
		///       </summary>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteFullEndElement" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D91 RID: 3473 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteFullEndElementAsync()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно записывает атрибут с заданным префиксом, локальным именем, универсальным кодом ресурса (URI) пространства имен и значением.
		///       </summary>
		/// <param name="prefix">
		///           Префикс пространства имен атрибута.
		///         </param>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="ns">
		///           Универсальный код ресурса (URI) пространства имен атрибута.
		///         </param>
		/// <param name="value">
		///           Значение атрибута.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteAttributeString" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D92 RID: 3474 RVA: 0x000585B8 File Offset: 0x000567B8
		public Task WriteAttributeStringAsync(string prefix, string localName, string ns, string value)
		{
			Task task = this.WriteStartAttributeAsync(prefix, localName, ns);
			if (task.IsSuccess())
			{
				return this.WriteStringAsync(value).CallTaskFuncWhenFinish(new Func<Task>(this.WriteEndAttributeAsync));
			}
			return this.WriteAttributeStringAsyncHelper(task, value);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x000585FC File Offset: 0x000567FC
		private Task WriteAttributeStringAsyncHelper(Task task, string value)
		{
			XmlWriter.<WriteAttributeStringAsyncHelper>d__82 <WriteAttributeStringAsyncHelper>d__;
			<WriteAttributeStringAsyncHelper>d__.<>4__this = this;
			<WriteAttributeStringAsyncHelper>d__.task = task;
			<WriteAttributeStringAsyncHelper>d__.value = value;
			<WriteAttributeStringAsyncHelper>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAttributeStringAsyncHelper>d__.<>1__state = -1;
			<WriteAttributeStringAsyncHelper>d__.<>t__builder.Start<XmlWriter.<WriteAttributeStringAsyncHelper>d__82>(ref <WriteAttributeStringAsyncHelper>d__);
			return <WriteAttributeStringAsyncHelper>d__.<>t__builder.Task;
		}

		/// <summary>
		///         Асинхронно записывает начало атрибута с заданным префиксом, локальным именем и универсальным кодом ресурса (URI) пространства имен.
		///       </summary>
		/// <param name="prefix">
		///           Префикс пространства имен атрибута.
		///         </param>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="ns">
		///           URI пространства имен атрибута.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteStartAttribute" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D94 RID: 3476 RVA: 0x0000349C File Offset: 0x0000169C
		protected internal virtual Task WriteStartAttributeAsync(string prefix, string localName, string ns)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно закрывает предыдущий <see cref="M:System.Xml.XmlWriter.WriteStartAttribute(System.String,System.String)" /> вызова.
		///       </summary>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteEndAttribute" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D95 RID: 3477 RVA: 0x0000349C File Offset: 0x0000169C
		protected internal virtual Task WriteEndAttributeAsync()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно записывает блок &lt;![CDATA[...]]&gt;, содержащий заданный текст.
		///       </summary>
		/// <param name="text">
		///           Текст, записываемый в блок CDATA.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteCData" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D96 RID: 3478 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteCDataAsync(string text)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно записывает комментарий &lt;!--...--&gt;, содержащий заданный текст.
		///       </summary>
		/// <param name="text">
		///           Текст, записываемый в примечание.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteComment" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D97 RID: 3479 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteCommentAsync(string text)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно считывает инструкцию обработки с пробелом между именем и текстом в следующем виде: &lt;? имя текст? &gt;.
		///       </summary>
		/// <param name="name">
		///           Имя инструкции по обработке.
		///         </param>
		/// <param name="text">
		///           Текст, включаемый в инструкцию по обработке.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteProcessingInstruction" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D98 RID: 3480 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteProcessingInstructionAsync(string name, string text)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно записывает ссылку на сущность в виде <see langword="&amp;name;" />.
		///       </summary>
		/// <param name="name">
		///           Имя ссылки на сущность.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteEntityRef" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D99 RID: 3481 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteEntityRefAsync(string name)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно инициирует создание сущности знака для указанного значения знака Юникода.
		///       </summary>
		/// <param name="ch">
		///           Знак Юникода, для которого создается сущность знака.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteCharEntity" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D9A RID: 3482 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteCharEntityAsync(char ch)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно записывает указанный символ-разделитель.
		///       </summary>
		/// <param name="ws">
		///           Строка символов-разделителей.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteWhitespace" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D9B RID: 3483 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteWhitespaceAsync(string ws)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно записывает заданное текстовое содержимое.
		///       </summary>
		/// <param name="text">
		///           Текст для записи.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteString" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D9C RID: 3484 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteStringAsync(string text)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно создает и записывает сущность символа-заместителя для пары символов-заместителей.
		///       </summary>
		/// <param name="lowChar">
		///           Младший заместитель.
		///            Значение должно быть в диапазоне от 0xDC00 до 0xDFFF.
		///         </param>
		/// <param name="highChar">
		///           Старший заместитель.
		///            Значение должно быть в диапазоне от 0xD800 до 0xDBFF.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteSurrogateCharEntity" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D9D RID: 3485 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteSurrogateCharEntityAsync(char lowChar, char highChar)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно записывает содержимое текстового буфера.
		///       </summary>
		/// <param name="buffer">
		///           Массив символов, содержащий текст для записи.
		///         </param>
		/// <param name="index">
		///           Позиция в буфере, с которой начинается запись текста.
		///         </param>
		/// <param name="count">
		///           Количество символов для записи.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteChars" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D9E RID: 3486 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteCharsAsync(char[] buffer, int index, int count)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно, вручную записывает для разметки необработанные данные из буфера символов.
		///       </summary>
		/// <param name="buffer">
		///           Массив символов, содержащий текст для записи.
		///         </param>
		/// <param name="index">
		///           Позиция в буфере, с которой начинается запись текста.
		///         </param>
		/// <param name="count">
		///           Количество символов для записи.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteRaw" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000D9F RID: 3487 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteRawAsync(char[] buffer, int index, int count)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно, вручную записывает необработанные данные для разметки.
		///       </summary>
		/// <param name="data">
		///           Строка, содержащая текст для записи.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteRaw" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000DA0 RID: 3488 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteRawAsync(string data)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно преобразует указанный набор двоичных байтов в кодировку Base64 и записывает получившийся текст.
		///       </summary>
		/// <param name="buffer">
		///           Кодируемый массив байтов.
		///         </param>
		/// <param name="index">
		///           Позиция в буфере, с которой начинается запись байтов.
		///         </param>
		/// <param name="count">
		///           Количество записываемых байтов.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteBase64" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000DA1 RID: 3489 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task WriteBase64Async(byte[] buffer, int index, int count)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно преобразует указанный набор двоичных байтов как <see langword="BinHex" /> и выводит получившийся текст.
		///       </summary>
		/// <param name="buffer">
		///           Кодируемый массив байтов.
		///         </param>
		/// <param name="index">
		///           Позиция в буфере, с которой начинается запись байтов.
		///         </param>
		/// <param name="count">
		///           Количество записываемых байтов.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteBinHex" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000DA2 RID: 3490 RVA: 0x0005864F File Offset: 0x0005684F
		public virtual Task WriteBinHexAsync(byte[] buffer, int index, int count)
		{
			return BinHexEncoder.EncodeAsync(buffer, index, count, this);
		}

		/// <summary>
		///         Асинхронно записывает в базовый поток содержимое буфера и сохраняет базовый поток.
		///       </summary>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="Flush" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000DA3 RID: 3491 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task FlushAsync()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно записывает указанное имя, гарантируя, что это допустимый NmToken, согласно рекомендации W3C по языку XML версии 1.0 (http://www.w3.org/TR/1998/REC-xml-19980210#NT-Name).
		///       </summary>
		/// <param name="name">
		///           Записываемое имя.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteNmToken" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000DA4 RID: 3492 RVA: 0x0005865A File Offset: 0x0005685A
		public virtual Task WriteNmTokenAsync(string name)
		{
			if (name == null || name.Length == 0)
			{
				throw new ArgumentException(Res.GetString("The empty string '' is not a valid name."));
			}
			return this.WriteStringAsync(XmlConvert.VerifyNMTOKEN(name, ExceptionType.ArgumentException));
		}

		/// <summary>
		///         Асинхронно записывает указанное имя, гарантируя его допустимость согласно рекомендации W3C по языку XML версии 1.0 (http://www.w3.org/TR/1998/REC-xml-19980210#NT-Name).
		///       </summary>
		/// <param name="name">
		///           Записываемое имя.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteName" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000DA5 RID: 3493 RVA: 0x00058684 File Offset: 0x00056884
		public virtual Task WriteNameAsync(string name)
		{
			return this.WriteStringAsync(XmlConvert.VerifyQName(name, ExceptionType.ArgumentException));
		}

		/// <summary>
		///         Асинхронно записывает полное имя пространства имен.
		///          Этот метод выполняет поиск префикса для пространства имен в его области.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя для записи.
		///         </param>
		/// <param name="ns">
		///           URI пространства имен для имени.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteQualifiedName" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000DA6 RID: 3494 RVA: 0x00058694 File Offset: 0x00056894
		public virtual Task WriteQualifiedNameAsync(string localName, string ns)
		{
			XmlWriter.<WriteQualifiedNameAsync>d__101 <WriteQualifiedNameAsync>d__;
			<WriteQualifiedNameAsync>d__.<>4__this = this;
			<WriteQualifiedNameAsync>d__.localName = localName;
			<WriteQualifiedNameAsync>d__.ns = ns;
			<WriteQualifiedNameAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteQualifiedNameAsync>d__.<>1__state = -1;
			<WriteQualifiedNameAsync>d__.<>t__builder.Start<XmlWriter.<WriteQualifiedNameAsync>d__101>(ref <WriteQualifiedNameAsync>d__);
			return <WriteQualifiedNameAsync>d__.<>t__builder.Task;
		}

		/// <summary>
		///         Асинхронно записывает все атрибуты, найденные в текущей позиции в <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="reader">
		///           <see langword="XmlReader" /> Из которого необходимо скопировать атрибуты.
		///         </param>
		/// <param name="defattr">
		///           <see langword="true" /> Чтобы скопировать атрибуты по умолчанию из <see langword="XmlReader" />; в противном случае — <see langword="false" />.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteAttributes" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000DA7 RID: 3495 RVA: 0x000586E8 File Offset: 0x000568E8
		public virtual Task WriteAttributesAsync(XmlReader reader, bool defattr)
		{
			XmlWriter.<WriteAttributesAsync>d__102 <WriteAttributesAsync>d__;
			<WriteAttributesAsync>d__.<>4__this = this;
			<WriteAttributesAsync>d__.reader = reader;
			<WriteAttributesAsync>d__.defattr = defattr;
			<WriteAttributesAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAttributesAsync>d__.<>1__state = -1;
			<WriteAttributesAsync>d__.<>t__builder.Start<XmlWriter.<WriteAttributesAsync>d__102>(ref <WriteAttributesAsync>d__);
			return <WriteAttributesAsync>d__.<>t__builder.Task;
		}

		/// <summary>
		///         Асинхронно копирует все данные из средства чтения в средство записи и перемещает средство чтения к началу следующего элемента того же уровня.
		///       </summary>
		/// <param name="reader">
		///           Экземпляр <see cref="T:System.Xml.XmlReader" />, из которого выполняется чтение.
		///         </param>
		/// <param name="defattr">
		///           <see langword="true" /> Чтобы скопировать атрибуты по умолчанию из <see langword="XmlReader" />; в противном случае — <see langword="false" />.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteNode" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000DA8 RID: 3496 RVA: 0x0005873B File Offset: 0x0005693B
		public virtual Task WriteNodeAsync(XmlReader reader, bool defattr)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (reader.Settings != null && reader.Settings.Async)
			{
				return this.WriteNodeAsync_CallAsyncReader(reader, defattr);
			}
			return this.WriteNodeAsync_CallSyncReader(reader, defattr);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00058774 File Offset: 0x00056974
		internal Task WriteNodeAsync_CallSyncReader(XmlReader reader, bool defattr)
		{
			XmlWriter.<WriteNodeAsync_CallSyncReader>d__104 <WriteNodeAsync_CallSyncReader>d__;
			<WriteNodeAsync_CallSyncReader>d__.<>4__this = this;
			<WriteNodeAsync_CallSyncReader>d__.reader = reader;
			<WriteNodeAsync_CallSyncReader>d__.defattr = defattr;
			<WriteNodeAsync_CallSyncReader>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteNodeAsync_CallSyncReader>d__.<>1__state = -1;
			<WriteNodeAsync_CallSyncReader>d__.<>t__builder.Start<XmlWriter.<WriteNodeAsync_CallSyncReader>d__104>(ref <WriteNodeAsync_CallSyncReader>d__);
			return <WriteNodeAsync_CallSyncReader>d__.<>t__builder.Task;
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x000587C8 File Offset: 0x000569C8
		internal Task WriteNodeAsync_CallAsyncReader(XmlReader reader, bool defattr)
		{
			XmlWriter.<WriteNodeAsync_CallAsyncReader>d__105 <WriteNodeAsync_CallAsyncReader>d__;
			<WriteNodeAsync_CallAsyncReader>d__.<>4__this = this;
			<WriteNodeAsync_CallAsyncReader>d__.reader = reader;
			<WriteNodeAsync_CallAsyncReader>d__.defattr = defattr;
			<WriteNodeAsync_CallAsyncReader>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteNodeAsync_CallAsyncReader>d__.<>1__state = -1;
			<WriteNodeAsync_CallAsyncReader>d__.<>t__builder.Start<XmlWriter.<WriteNodeAsync_CallAsyncReader>d__105>(ref <WriteNodeAsync_CallAsyncReader>d__);
			return <WriteNodeAsync_CallAsyncReader>d__.<>t__builder.Task;
		}

		/// <summary>
		///         Асинхронно копирует все из <see cref="T:System.Xml.XPath.XPathNavigator" /> в модуль записи.
		///          Положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </summary>
		/// <param name="navigator">
		///           Элемент <see cref="T:System.Xml.XPath.XPathNavigator" />, из которого копируются данные.
		///         </param>
		/// <param name="defattr">
		///           <see langword="true" /> Копирование атрибутов по умолчанию; в противном случае — <see langword="false" />.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteNode" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000DAB RID: 3499 RVA: 0x0005881C File Offset: 0x00056A1C
		public virtual Task WriteNodeAsync(XPathNavigator navigator, bool defattr)
		{
			XmlWriter.<WriteNodeAsync>d__106 <WriteNodeAsync>d__;
			<WriteNodeAsync>d__.<>4__this = this;
			<WriteNodeAsync>d__.navigator = navigator;
			<WriteNodeAsync>d__.defattr = defattr;
			<WriteNodeAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteNodeAsync>d__.<>1__state = -1;
			<WriteNodeAsync>d__.<>t__builder.Start<XmlWriter.<WriteNodeAsync>d__106>(ref <WriteNodeAsync>d__);
			return <WriteNodeAsync>d__.<>t__builder.Task;
		}

		/// <summary>
		///         Асинхронно записывает элемент с заданным префиксом, локальным именем, универсальным кодом ресурса (URI) пространства имен и значением.
		///       </summary>
		/// <param name="prefix">
		///           Префикс элемента.
		///         </param>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="ns">
		///           Универсальный код ресурса (URI) пространства имен элемента.
		///         </param>
		/// <param name="value">
		///           Значение элемента.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную <see langword="WriteElementString" /> операции.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlWriter" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlWriterSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlWriterSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000DAC RID: 3500 RVA: 0x00058870 File Offset: 0x00056A70
		public Task WriteElementStringAsync(string prefix, string localName, string ns, string value)
		{
			XmlWriter.<WriteElementStringAsync>d__107 <WriteElementStringAsync>d__;
			<WriteElementStringAsync>d__.<>4__this = this;
			<WriteElementStringAsync>d__.prefix = prefix;
			<WriteElementStringAsync>d__.localName = localName;
			<WriteElementStringAsync>d__.ns = ns;
			<WriteElementStringAsync>d__.value = value;
			<WriteElementStringAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteElementStringAsync>d__.<>1__state = -1;
			<WriteElementStringAsync>d__.<>t__builder.Start<XmlWriter.<WriteElementStringAsync>d__107>(ref <WriteElementStringAsync>d__);
			return <WriteElementStringAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x000588D4 File Offset: 0x00056AD4
		private Task WriteLocalNamespacesAsync(XPathNavigator nsNav)
		{
			XmlWriter.<WriteLocalNamespacesAsync>d__108 <WriteLocalNamespacesAsync>d__;
			<WriteLocalNamespacesAsync>d__.<>4__this = this;
			<WriteLocalNamespacesAsync>d__.nsNav = nsNav;
			<WriteLocalNamespacesAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteLocalNamespacesAsync>d__.<>1__state = -1;
			<WriteLocalNamespacesAsync>d__.<>t__builder.Start<XmlWriter.<WriteLocalNamespacesAsync>d__108>(ref <WriteLocalNamespacesAsync>d__);
			return <WriteLocalNamespacesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04000EAC RID: 3756
		private char[] writeNodeBuffer;

		// Token: 0x04000EAD RID: 3757
		private const int WriteNodeBufferSize = 1024;
	}
}
