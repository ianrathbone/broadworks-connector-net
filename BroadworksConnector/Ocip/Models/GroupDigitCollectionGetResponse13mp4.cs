using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDigitCollectionGetResponse13mp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.GroupDigitCollectionSettingLevel _useSetting;

    [XmlElement(ElementName = "useSetting", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupDigitCollectionSettingLevel UseSetting {
        get => _useSetting;
        set {
            UseSettingSpecified = true;
            _useSetting = value;
        }
    }

    [XmlIgnore]
    public bool UseSettingSpecified { get; set; }
    private string _accessCode;

    [XmlElement(ElementName = "accessCode", IsNullable = false, Namespace = "")]
    public string AccessCode {
        get => _accessCode;
        set {
            AccessCodeSpecified = true;
            _accessCode = value;
        }
    }

    [XmlIgnore]
    public bool AccessCodeSpecified { get; set; }
    private string _publicDigitMap;

    [XmlElement(ElementName = "publicDigitMap", IsNullable = false, Namespace = "")]
    public string PublicDigitMap {
        get => _publicDigitMap;
        set {
            PublicDigitMapSpecified = true;
            _publicDigitMap = value;
        }
    }

    [XmlIgnore]
    public bool PublicDigitMapSpecified { get; set; }
    private string _privateDigitMap;

    [XmlElement(ElementName = "privateDigitMap", IsNullable = false, Namespace = "")]
    public string PrivateDigitMap {
        get => _privateDigitMap;
        set {
            PrivateDigitMapSpecified = true;
            _privateDigitMap = value;
        }
    }

    [XmlIgnore]
    public bool PrivateDigitMapSpecified { get; set; }
}
}