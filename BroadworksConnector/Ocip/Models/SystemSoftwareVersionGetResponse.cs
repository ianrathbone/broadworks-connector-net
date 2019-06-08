using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSoftwareVersionGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _version;

    [XmlElement(ElementName = "version", IsNullable = false, Namespace = "")]
    public string Version {
        get => _version;
        set {
            VersionSpecified = true;
            _version = value;
        }
    }

    [XmlIgnore]
    public bool VersionSpecified { get; set; }
}
}
