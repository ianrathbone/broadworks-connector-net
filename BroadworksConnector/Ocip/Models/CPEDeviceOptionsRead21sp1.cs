using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CPEDeviceOptionsRead21sp1 
{
    private bool _enableMonitoring;

    [XmlElement(ElementName = "enableMonitoring", IsNullable = false, Namespace = "")]
    public bool EnableMonitoring {
        get => _enableMonitoring;
        set {
            EnableMonitoringSpecified = true;
            _enableMonitoring = value;
        }
    }

    [XmlIgnore]
    public bool EnableMonitoringSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 _configType;

    [XmlElement(ElementName = "configType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 ConfigType {
        get => _configType;
        set {
            ConfigTypeSpecified = true;
            _configType = value;
        }
    }

    [XmlIgnore]
    public bool ConfigTypeSpecified { get; set; }
    private string _systemFileName;

    [XmlElement(ElementName = "systemFileName", IsNullable = false, Namespace = "")]
    public string SystemFileName {
        get => _systemFileName;
        set {
            SystemFileNameSpecified = true;
            _systemFileName = value;
        }
    }

    [XmlIgnore]
    public bool SystemFileNameSpecified { get; set; }
    private string _deviceFileFormat;

    [XmlElement(ElementName = "deviceFileFormat", IsNullable = false, Namespace = "")]
    public string DeviceFileFormat {
        get => _deviceFileFormat;
        set {
            DeviceFileFormatSpecified = true;
            _deviceFileFormat = value;
        }
    }

    [XmlIgnore]
    public bool DeviceFileFormatSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DeviceManagementDeviceTypeOptionsRead21sp1 _deviceManagementDeviceTypeOptions;

    [XmlElement(ElementName = "deviceManagementDeviceTypeOptions", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DeviceManagementDeviceTypeOptionsRead21sp1 DeviceManagementDeviceTypeOptions {
        get => _deviceManagementDeviceTypeOptions;
        set {
            DeviceManagementDeviceTypeOptionsSpecified = true;
            _deviceManagementDeviceTypeOptions = value;
        }
    }

    [XmlIgnore]
    public bool DeviceManagementDeviceTypeOptionsSpecified { get; set; }
}
}