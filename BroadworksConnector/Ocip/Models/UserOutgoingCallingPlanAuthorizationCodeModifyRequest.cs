using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserOutgoingCallingPlanAuthorizationCodeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _useCustomSettings;

    [XmlElement(ElementName = "useCustomSettings", IsNullable = false, Namespace = "")]
    public bool UseCustomSettings {
        get => _useCustomSettings;
        set {
            UseCustomSettingsSpecified = true;
            _useCustomSettings = value;
        }
    }

    [XmlIgnore]
    public bool UseCustomSettingsSpecified { get; set; }
}
}
