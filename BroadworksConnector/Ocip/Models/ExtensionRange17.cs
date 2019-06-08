using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ExtensionRange17 
{
    private string _minExtension;

    [XmlElement(ElementName = "minExtension", IsNullable = false, Namespace = "")]
    public string MinExtension {
        get => _minExtension;
        set {
            MinExtensionSpecified = true;
            _minExtension = value;
        }
    }

    [XmlIgnore]
    public bool MinExtensionSpecified { get; set; }
    private string _maxExtension;

    [XmlElement(ElementName = "maxExtension", IsNullable = false, Namespace = "")]
    public string MaxExtension {
        get => _maxExtension;
        set {
            MaxExtensionSpecified = true;
            _maxExtension = value;
        }
    }

    [XmlIgnore]
    public bool MaxExtensionSpecified { get; set; }
}
}