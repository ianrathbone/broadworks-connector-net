using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPushNotificationRegistrationGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _registrationId;

    [XmlElement(ElementName = "registrationId", IsNullable = false, Namespace = "")]
    public string RegistrationId {
        get => _registrationId;
        set {
            RegistrationIdSpecified = true;
            _registrationId = value;
        }
    }

    [XmlIgnore]
    public bool RegistrationIdSpecified { get; set; }
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
}
}