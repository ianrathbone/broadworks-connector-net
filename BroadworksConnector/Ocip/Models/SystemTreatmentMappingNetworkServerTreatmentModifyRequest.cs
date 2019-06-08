using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingNetworkServerTreatmentModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _nsTreatment;

    [XmlElement(ElementName = "nsTreatment", IsNullable = false, Namespace = "")]
    public string NsTreatment {
        get => _nsTreatment;
        set {
            NsTreatmentSpecified = true;
            _nsTreatment = value;
        }
    }

    [XmlIgnore]
    public bool NsTreatmentSpecified { get; set; }
    private string _treatmentId;

    [XmlElement(ElementName = "treatmentId", IsNullable = false, Namespace = "")]
    public string TreatmentId {
        get => _treatmentId;
        set {
            TreatmentIdSpecified = true;
            _treatmentId = value;
        }
    }

    [XmlIgnore]
    public bool TreatmentIdSpecified { get; set; }
}
}