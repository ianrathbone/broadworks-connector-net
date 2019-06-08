using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLocationBasedCallingRestrictionsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.PhysicalLocationIndicator _physicalLocationIndicator;

    [XmlElement(ElementName = "physicalLocationIndicator", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.PhysicalLocationIndicator PhysicalLocationIndicator {
        get => _physicalLocationIndicator;
        set {
            PhysicalLocationIndicatorSpecified = true;
            _physicalLocationIndicator = value;
        }
    }

    [XmlIgnore]
    public bool PhysicalLocationIndicatorSpecified { get; set; }
    private bool _enforceMscValidation;

    [XmlElement(ElementName = "enforceMscValidation", IsNullable = false, Namespace = "")]
    public bool EnforceMscValidation {
        get => _enforceMscValidation;
        set {
            EnforceMscValidationSpecified = true;
            _enforceMscValidation = value;
        }
    }

    [XmlIgnore]
    public bool EnforceMscValidationSpecified { get; set; }
    private bool _enableOfficeZoneAnnouncement;

    [XmlElement(ElementName = "enableOfficeZoneAnnouncement", IsNullable = false, Namespace = "")]
    public bool EnableOfficeZoneAnnouncement {
        get => _enableOfficeZoneAnnouncement;
        set {
            EnableOfficeZoneAnnouncementSpecified = true;
            _enableOfficeZoneAnnouncement = value;
        }
    }

    [XmlIgnore]
    public bool EnableOfficeZoneAnnouncementSpecified { get; set; }
}
}