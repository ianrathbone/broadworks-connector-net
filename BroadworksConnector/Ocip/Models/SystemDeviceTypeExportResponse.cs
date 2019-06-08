using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceTypeExportResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _file;

    [XmlElement(ElementName = "file", IsNullable = false, Namespace = "")]
    public string File {
        get => _file;
        set {
            FileSpecified = true;
            _file = value;
        }
    }

    [XmlIgnore]
    public bool FileSpecified { get; set; }
}
}