using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SMTPSecureMode{
    [XmlEnum(Name = "Disabled")]
    Disabled,
    [XmlEnum(Name = "SMTPS")]
    SMTPS,
    [XmlEnum(Name = "STARTTLS")]
    STARTTLS,
 }
}
