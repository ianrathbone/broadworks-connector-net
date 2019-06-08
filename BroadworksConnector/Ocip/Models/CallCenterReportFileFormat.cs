using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallCenterReportFileFormat{
    [XmlEnum(Name = "PDF")]
    PDF,
    [XmlEnum(Name = "XLS")]
    XLS,
 }
}
