using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDigitCollectionModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _accessCode;

    [XmlElement(ElementName = "accessCode", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "publicDigitMap", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "privateDigitMap", IsNullable = true, Namespace = "")]
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
