using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserZoneCallingRestrictionsModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private string _homeZoneName;

    [XmlElement(ElementName = "homeZoneName", IsNullable = true, Namespace = "")]
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