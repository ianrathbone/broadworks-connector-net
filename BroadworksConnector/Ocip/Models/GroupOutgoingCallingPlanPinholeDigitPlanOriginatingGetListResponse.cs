using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternOriginatingPermissions _groupPermissions;

    [XmlElement(ElementName = "groupPermissions", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternOriginatingPermissions GroupPermissions {
        get => _groupPermissions;
        set {
            GroupPermissionsSpecified = true;
            _groupPermissions = value;
        }
    }

    [XmlIgnore]
    public bool GroupPermissionsSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternOriginatingDepartmentPermissions> _departmentPermissions;

    [XmlElement(ElementName = "departmentPermissions", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternOriginatingDepartmentPermissions> DepartmentPermissions {
        get => _departmentPermissions;
        set {
            DepartmentPermissionsSpecified = true;
            _departmentPermissions = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentPermissionsSpecified { get; set; }
}
}
