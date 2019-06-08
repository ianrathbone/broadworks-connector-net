using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAdviceOfChargeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AdviceOfChargeType _aocType;

    [XmlElement(ElementName = "aocType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AdviceOfChargeType AocType {
        get => _aocType;
        set {
            AocTypeSpecified = true;
            _aocType = value;
        }
    }

    [XmlIgnore]
    public bool AocTypeSpecified { get; set; }
}
}
