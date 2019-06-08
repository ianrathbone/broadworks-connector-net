using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingInternalReleaseCauseModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.InternalReleaseCause16 _internalReleaseCause;

    [XmlElement(ElementName = "internalReleaseCause", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.InternalReleaseCause16 InternalReleaseCause {
        get => _internalReleaseCause;
        set {
            InternalReleaseCauseSpecified = true;
            _internalReleaseCause = value;
        }
    }

    [XmlIgnore]
    public bool InternalReleaseCauseSpecified { get; set; }
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
