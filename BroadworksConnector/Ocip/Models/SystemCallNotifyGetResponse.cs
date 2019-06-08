using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallNotifyGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _defaultFromAddress;

    [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
    public string DefaultFromAddress {
        get => _defaultFromAddress;
        set {
            DefaultFromAddressSpecified = true;
            _defaultFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool DefaultFromAddressSpecified { get; set; }
    private bool _useShortSubjectLine;

    [XmlElement(ElementName = "useShortSubjectLine", IsNullable = false, Namespace = "")]
    public bool UseShortSubjectLine {
        get => _useShortSubjectLine;
        set {
            UseShortSubjectLineSpecified = true;
            _useShortSubjectLine = value;
        }
    }

    [XmlIgnore]
    public bool UseShortSubjectLineSpecified { get; set; }
    private bool _useDnInMailBody;

    [XmlElement(ElementName = "useDnInMailBody", IsNullable = false, Namespace = "")]
    public bool UseDnInMailBody {
        get => _useDnInMailBody;
        set {
            UseDnInMailBodySpecified = true;
            _useDnInMailBody = value;
        }
    }

    [XmlIgnore]
    public bool UseDnInMailBodySpecified { get; set; }
}
}