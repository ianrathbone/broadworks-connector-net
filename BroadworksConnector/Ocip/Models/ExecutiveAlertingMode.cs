using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ExecutiveAlertingMode{
    [XmlEnum(Name = "Simultaneous")]
    Simultaneous,
    [XmlEnum(Name = "Sequential")]
    Sequential,
 }
}
