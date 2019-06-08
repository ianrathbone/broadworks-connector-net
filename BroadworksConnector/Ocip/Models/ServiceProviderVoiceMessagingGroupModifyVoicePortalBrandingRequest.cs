using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderVoiceMessagingGroupModifyVoicePortalBrandingRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection _voicePortalGreetingSelection;

    [XmlElement(ElementName = "voicePortalGreetingSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoicePortalGreetingSelection {
        get => _voicePortalGreetingSelection;
        set {
            VoicePortalGreetingSelectionSpecified = true;
            _voicePortalGreetingSelection = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalGreetingSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.LabeledFileResource _voicePortalGreetingFile;

    [XmlElement(ElementName = "voicePortalGreetingFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LabeledFileResource VoicePortalGreetingFile {
        get => _voicePortalGreetingFile;
        set {
            VoicePortalGreetingFileSpecified = true;
            _voicePortalGreetingFile = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalGreetingFileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection _voiceMessagingGreetingSelection;

    [XmlElement(ElementName = "voiceMessagingGreetingSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoiceMessagingGreetingSelection {
        get => _voiceMessagingGreetingSelection;
        set {
            VoiceMessagingGreetingSelectionSpecified = true;
            _voiceMessagingGreetingSelection = value;
        }
    }

    [XmlIgnore]
    public bool VoiceMessagingGreetingSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.LabeledFileResource _voiceMessagingGreetingFile;

    [XmlElement(ElementName = "voiceMessagingGreetingFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LabeledFileResource VoiceMessagingGreetingFile {
        get => _voiceMessagingGreetingFile;
        set {
            VoiceMessagingGreetingFileSpecified = true;
            _voiceMessagingGreetingFile = value;
        }
    }

    [XmlIgnore]
    public bool VoiceMessagingGreetingFileSpecified { get; set; }
}
}