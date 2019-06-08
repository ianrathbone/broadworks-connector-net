using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class NetworkClassOfServiceCommunicationBarringProfile 
{
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private bool _isPrimary;

    [XmlElement(ElementName = "isPrimary", IsNullable = false, Namespace = "")]
    public bool IsPrimary {
        get => _isPrimary;
        set {
            IsPrimarySpecified = true;
            _isPrimary = value;
        }
    }

    [XmlIgnore]
    public bool IsPrimarySpecified { get; set; }
}
}
