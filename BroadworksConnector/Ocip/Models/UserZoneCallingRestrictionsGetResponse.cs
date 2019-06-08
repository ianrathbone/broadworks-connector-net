using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserZoneCallingRestrictionsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _homeZoneName;

    [XmlElement(ElementName = "homeZoneName", IsNullable = false, Namespace = "")]
    public string HomeZoneName {
        get => _homeZoneName;
        set {
            HomeZoneNameSpecified = true;
            _homeZoneName = value;
        }
    }

    [XmlIgnore]
    public bool HomeZoneNameSpecified { get; set; }
}
}