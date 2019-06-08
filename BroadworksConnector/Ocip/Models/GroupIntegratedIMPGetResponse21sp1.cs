using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupIntegratedIMPGetResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _useServiceProviderSetting;

    [XmlElement(ElementName = "useServiceProviderSetting", IsNullable = false, Namespace = "")]
    public bool UseServiceProviderSetting {
        get => _useServiceProviderSetting;
        set {
            UseServiceProviderSettingSpecified = true;
            _useServiceProviderSetting = value;
        }
    }

    [XmlIgnore]
    public bool UseServiceProviderSettingSpecified { get; set; }
    private string _serviceDomain;

    [XmlElement(ElementName = "serviceDomain", IsNullable = false, Namespace = "")]
    public string ServiceDomain {
        get => _serviceDomain;
        set {
            ServiceDomainSpecified = true;
            _serviceDomain = value;
        }
    }

    [XmlIgnore]
    public bool ServiceDomainSpecified { get; set; }
    private string _effectiveServiceDomain;

    [XmlElement(ElementName = "effectiveServiceDomain", IsNullable = false, Namespace = "")]
    public string EffectiveServiceDomain {
        get => _effectiveServiceDomain;
        set {
            EffectiveServiceDomainSpecified = true;
            _effectiveServiceDomain = value;
        }
    }

    [XmlIgnore]
    public bool EffectiveServiceDomainSpecified { get; set; }
    private bool _addServiceProviderInIMPUserId;

    [XmlElement(ElementName = "addServiceProviderInIMPUserId", IsNullable = false, Namespace = "")]
    public bool AddServiceProviderInIMPUserId {
        get => _addServiceProviderInIMPUserId;
        set {
            AddServiceProviderInIMPUserIdSpecified = true;
            _addServiceProviderInIMPUserId = value;
        }
    }

    [XmlIgnore]
    public bool AddServiceProviderInIMPUserIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.IntegratedIMPUserIDType _defaultImpIdType;

    [XmlElement(ElementName = "defaultImpIdType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.IntegratedIMPUserIDType DefaultImpIdType {
        get => _defaultImpIdType;
        set {
            DefaultImpIdTypeSpecified = true;
            _defaultImpIdType = value;
        }
    }

    [XmlIgnore]
    public bool DefaultImpIdTypeSpecified { get; set; }
}
}