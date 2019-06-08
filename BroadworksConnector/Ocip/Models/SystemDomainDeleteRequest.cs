using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDomainDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _domain;

    [XmlElement(ElementName = "domain", IsNullable = false, Namespace = "")]
    public string Domain {
        get => _domain;
        set {
            DomainSpecified = true;
            _domain = value;
        }
    }

    [XmlIgnore]
    public bool DomainSpecified { get; set; }
}
}
