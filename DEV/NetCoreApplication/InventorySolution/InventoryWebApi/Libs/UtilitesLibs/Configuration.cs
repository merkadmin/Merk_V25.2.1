[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class Configuration
{

	private configurationAdd[] appSettingsField;

	/// <remarks/>
	[System.Xml.Serialization.XmlArrayItemAttribute("add", IsNullable = false)]
	public configurationAdd[] appSettings
	{
		get
		{
			return this.appSettingsField;
		}
		set
		{
			this.appSettingsField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class configurationAdd
{

	private string keyField;

	private string valueField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string key
	{
		get
		{
			return this.keyField;
		}
		set
		{
			this.keyField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string value
	{
		get
		{
			return this.valueField;
		}
		set
		{
			this.valueField = value;
		}
	}
}