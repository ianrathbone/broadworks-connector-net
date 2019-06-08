using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _resellerName;

    [XmlElement(ElementName = "resellerName", IsNullable = false, Namespace = "")]
    public string ResellerName {
        get => _resellerName;
        set {
            ResellerNameSpecified = true;
            _resellerName = value;
        }
    }

    [XmlIgnore]
    public bool ResellerNameSpecified { get; set; }
}
}