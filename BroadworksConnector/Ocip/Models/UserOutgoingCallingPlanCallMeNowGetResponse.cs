using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserOutgoingCallingPlanCallMeNowGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowPermissions _userPermissions;

    [XmlElement(ElementName = "userPermissions", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowPermissions UserPermissions {
        get => _userPermissions;
        set {
            UserPermissionsSpecified = true;
            _userPermissions = value;
        }
    }

    [XmlIgnore]
    public bool UserPermissionsSpecified { get; set; }
}
}