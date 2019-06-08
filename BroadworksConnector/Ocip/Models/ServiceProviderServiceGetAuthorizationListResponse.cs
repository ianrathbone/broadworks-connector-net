using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServiceGetAuthorizationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _groupServicesAuthorizationTable;

    [XmlElement(ElementName = "groupServicesAuthorizationTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable GroupServicesAuthorizationTable {
        get => _groupServicesAuthorizationTable;
        set {
            GroupServicesAuthorizationTableSpecified = true;
            _groupServicesAuthorizationTable = value;
        }
    }

    [XmlIgnore]
    public bool GroupServicesAuthorizationTableSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _userServicesAuthorizationTable;

    [XmlElement(ElementName = "userServicesAuthorizationTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable UserServicesAuthorizationTable {
        get => _userServicesAuthorizationTable;
        set {
            UserServicesAuthorizationTableSpecified = true;
            _userServicesAuthorizationTable = value;
        }
    }

    [XmlIgnore]
    public bool UserServicesAuthorizationTableSpecified { get; set; }
}
}
