using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AutoAttendantKeyReadConfiguration19 
{
    private BroadWorksConnector.Ocip.Models.AutoAttendantMenuKey _key;

    [XmlElement(ElementName = "key", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AutoAttendantMenuKey Key {
        get => _key;
        set {
            KeySpecified = true;
            _key = value;
        }
    }

    [XmlIgnore]
    public bool KeySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfigurationReadEntry19 _entry;

    [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfigurationReadEntry19 Entry {
        get => _entry;
        set {
            EntrySpecified = true;
            _entry = value;
        }
    }

    [XmlIgnore]
    public bool EntrySpecified { get; set; }
}
}
