using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCommunicationBarringProfileModifyListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CommunicationBarringProfileReplacementList _profileName;

    [XmlElement(ElementName = "profileName", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommunicationBarringProfileReplacementList ProfileName {
        get => _profileName;
        set {
            ProfileNameSpecified = true;
            _profileName = value;
        }
    }

    [XmlIgnore]
    public bool ProfileNameSpecified { get; set; }
}
}