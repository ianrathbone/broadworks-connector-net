using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDepartmentGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _includeEnterpriseDepartments;

    [XmlElement(ElementName = "includeEnterpriseDepartments", IsNullable = false, Namespace = "")]
    public bool IncludeEnterpriseDepartments {
        get => _includeEnterpriseDepartments;
        set {
            IncludeEnterpriseDepartmentsSpecified = true;
            _includeEnterpriseDepartments = value;
        }
    }

    [XmlIgnore]
    public bool IncludeEnterpriseDepartmentsSpecified { get; set; }
}
}