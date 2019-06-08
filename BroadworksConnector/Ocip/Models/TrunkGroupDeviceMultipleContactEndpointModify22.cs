using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class TrunkGroupDeviceMultipleContactEndpointModify22 
{
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private string _linePort;

    [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
    public string LinePort {
        get => _linePort;
        set {
            LinePortSpecified = true;
            _linePort = value;
        }
    }

    [XmlIgnore]
    public bool LinePortSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ReplacementContactList22 _contactList;

    [XmlElement(ElementName = "contactList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementContactList22 ContactList {
        get => _contactList;
        set {
            ContactListSpecified = true;
            _contactList = value;
        }
    }

    [XmlIgnore]
    public bool ContactListSpecified { get; set; }
}
}