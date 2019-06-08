using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAlternateNumbersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _distinctiveRing;

    [XmlElement(ElementName = "distinctiveRing", IsNullable = false, Namespace = "")]
    public bool DistinctiveRing {
        get => _distinctiveRing;
        set {
            DistinctiveRingSpecified = true;
            _distinctiveRing = value;
        }
    }

    [XmlIgnore]
    public bool DistinctiveRingSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AlternateNumberEntry _alternateEntry01;

    [XmlElement(ElementName = "alternateEntry01", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry01 {
        get => _alternateEntry01;
        set {
            AlternateEntry01Specified = true;
            _alternateEntry01 = value;
        }
    }

    [XmlIgnore]
    public bool AlternateEntry01Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.AlternateNumberEntry _alternateEntry02;

    [XmlElement(ElementName = "alternateEntry02", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry02 {
        get => _alternateEntry02;
        set {
            AlternateEntry02Specified = true;
            _alternateEntry02 = value;
        }
    }

    [XmlIgnore]
    public bool AlternateEntry02Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.AlternateNumberEntry _alternateEntry03;

    [XmlElement(ElementName = "alternateEntry03", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry03 {
        get => _alternateEntry03;
        set {
            AlternateEntry03Specified = true;
            _alternateEntry03 = value;
        }
    }

    [XmlIgnore]
    public bool AlternateEntry03Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.AlternateNumberEntry _alternateEntry04;

    [XmlElement(ElementName = "alternateEntry04", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry04 {
        get => _alternateEntry04;
        set {
            AlternateEntry04Specified = true;
            _alternateEntry04 = value;
        }
    }

    [XmlIgnore]
    public bool AlternateEntry04Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.AlternateNumberEntry _alternateEntry05;

    [XmlElement(ElementName = "alternateEntry05", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry05 {
        get => _alternateEntry05;
        set {
            AlternateEntry05Specified = true;
            _alternateEntry05 = value;
        }
    }

    [XmlIgnore]
    public bool AlternateEntry05Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.AlternateNumberEntry _alternateEntry06;

    [XmlElement(ElementName = "alternateEntry06", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry06 {
        get => _alternateEntry06;
        set {
            AlternateEntry06Specified = true;
            _alternateEntry06 = value;
        }
    }

    [XmlIgnore]
    public bool AlternateEntry06Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.AlternateNumberEntry _alternateEntry07;

    [XmlElement(ElementName = "alternateEntry07", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry07 {
        get => _alternateEntry07;
        set {
            AlternateEntry07Specified = true;
            _alternateEntry07 = value;
        }
    }

    [XmlIgnore]
    public bool AlternateEntry07Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.AlternateNumberEntry _alternateEntry08;

    [XmlElement(ElementName = "alternateEntry08", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry08 {
        get => _alternateEntry08;
        set {
            AlternateEntry08Specified = true;
            _alternateEntry08 = value;
        }
    }

    [XmlIgnore]
    public bool AlternateEntry08Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.AlternateNumberEntry _alternateEntry09;

    [XmlElement(ElementName = "alternateEntry09", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry09 {
        get => _alternateEntry09;
        set {
            AlternateEntry09Specified = true;
            _alternateEntry09 = value;
        }
    }

    [XmlIgnore]
    public bool AlternateEntry09Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.AlternateNumberEntry _alternateEntry10;

    [XmlElement(ElementName = "alternateEntry10", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry10 {
        get => _alternateEntry10;
        set {
            AlternateEntry10Specified = true;
            _alternateEntry10 = value;
        }
    }

    [XmlIgnore]
    public bool AlternateEntry10Specified { get; set; }
}
}