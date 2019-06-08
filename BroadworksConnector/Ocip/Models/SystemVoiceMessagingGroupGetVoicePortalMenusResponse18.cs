using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _useVoicePortalCustomization;

    [XmlElement(ElementName = "useVoicePortalCustomization", IsNullable = false, Namespace = "")]
    public bool UseVoicePortalCustomization {
        get => _useVoicePortalCustomization;
        set {
            UseVoicePortalCustomizationSpecified = true;
            _useVoicePortalCustomization = value;
        }
    }

    [XmlIgnore]
    public bool UseVoicePortalCustomizationSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18VoicePortalMainMenuKeys _voicePortalMainMenuKeys;

    [XmlElement(ElementName = "voicePortalMainMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18VoicePortalMainMenuKeys VoicePortalMainMenuKeys {
        get => _voicePortalMainMenuKeys;
        set {
            VoicePortalMainMenuKeysSpecified = true;
            _voicePortalMainMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalMainMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18VoiceMessagingMenuKeys _voiceMessagingMenuKeys;

    [XmlElement(ElementName = "voiceMessagingMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18VoiceMessagingMenuKeys VoiceMessagingMenuKeys {
        get => _voiceMessagingMenuKeys;
        set {
            VoiceMessagingMenuKeysSpecified = true;
            _voiceMessagingMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool VoiceMessagingMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18PlayGreetingMenuKeys _playGreetingMenuKeys;

    [XmlElement(ElementName = "playGreetingMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18PlayGreetingMenuKeys PlayGreetingMenuKeys {
        get => _playGreetingMenuKeys;
        set {
            PlayGreetingMenuKeysSpecified = true;
            _playGreetingMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool PlayGreetingMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18ChangeBusyOrNoAnswerGreetingMenuKeys _changeBusyOrNoAnswerGreetingMenuKeys;

    [XmlElement(ElementName = "changeBusyOrNoAnswerGreetingMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18ChangeBusyOrNoAnswerGreetingMenuKeys ChangeBusyOrNoAnswerGreetingMenuKeys {
        get => _changeBusyOrNoAnswerGreetingMenuKeys;
        set {
            ChangeBusyOrNoAnswerGreetingMenuKeysSpecified = true;
            _changeBusyOrNoAnswerGreetingMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool ChangeBusyOrNoAnswerGreetingMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18RecordNewGreetingOrPersonalizedNameMenuKeys _recordNewGreetingOrPersonalizedNameMenuKeys;

    [XmlElement(ElementName = "recordNewGreetingOrPersonalizedNameMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18RecordNewGreetingOrPersonalizedNameMenuKeys RecordNewGreetingOrPersonalizedNameMenuKeys {
        get => _recordNewGreetingOrPersonalizedNameMenuKeys;
        set {
            RecordNewGreetingOrPersonalizedNameMenuKeysSpecified = true;
            _recordNewGreetingOrPersonalizedNameMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool RecordNewGreetingOrPersonalizedNameMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18DeleteAllMessagesMenuKeys _deleteAllMessagesMenuKeys;

    [XmlElement(ElementName = "deleteAllMessagesMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18DeleteAllMessagesMenuKeys DeleteAllMessagesMenuKeys {
        get => _deleteAllMessagesMenuKeys;
        set {
            DeleteAllMessagesMenuKeysSpecified = true;
            _deleteAllMessagesMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool DeleteAllMessagesMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18CommPilotExpressProfileMenuKeys _commPilotExpressProfileMenuKeys;

    [XmlElement(ElementName = "commPilotExpressProfileMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18CommPilotExpressProfileMenuKeys CommPilotExpressProfileMenuKeys {
        get => _commPilotExpressProfileMenuKeys;
        set {
            CommPilotExpressProfileMenuKeysSpecified = true;
            _commPilotExpressProfileMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool CommPilotExpressProfileMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18PersonalizedNameMenuKeys _personalizedNameMenuKeys;

    [XmlElement(ElementName = "personalizedNameMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18PersonalizedNameMenuKeys PersonalizedNameMenuKeys {
        get => _personalizedNameMenuKeys;
        set {
            PersonalizedNameMenuKeysSpecified = true;
            _personalizedNameMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool PersonalizedNameMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18CallForwardingOptionsMenuKeys _callForwardingOptionsMenuKeys;

    [XmlElement(ElementName = "callForwardingOptionsMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18CallForwardingOptionsMenuKeys CallForwardingOptionsMenuKeys {
        get => _callForwardingOptionsMenuKeys;
        set {
            CallForwardingOptionsMenuKeysSpecified = true;
            _callForwardingOptionsMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool CallForwardingOptionsMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18ChangeCallForwardingDestinationMenuKeys _changeCallForwardingDestinationMenuKeys;

    [XmlElement(ElementName = "changeCallForwardingDestinationMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18ChangeCallForwardingDestinationMenuKeys ChangeCallForwardingDestinationMenuKeys {
        get => _changeCallForwardingDestinationMenuKeys;
        set {
            ChangeCallForwardingDestinationMenuKeysSpecified = true;
            _changeCallForwardingDestinationMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool ChangeCallForwardingDestinationMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18VoicePortalCallingMenuKeys _voicePortalCallingMenuKeys;

    [XmlElement(ElementName = "voicePortalCallingMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18VoicePortalCallingMenuKeys VoicePortalCallingMenuKeys {
        get => _voicePortalCallingMenuKeys;
        set {
            VoicePortalCallingMenuKeysSpecified = true;
            _voicePortalCallingMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalCallingMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18HotelingMenuKeys _hotelingMenuKeys;

    [XmlElement(ElementName = "hotelingMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18HotelingMenuKeys HotelingMenuKeys {
        get => _hotelingMenuKeys;
        set {
            HotelingMenuKeysSpecified = true;
            _hotelingMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool HotelingMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18PasscodeMenuKeys _passcodeMenuKeys;

    [XmlElement(ElementName = "passcodeMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18PasscodeMenuKeys PasscodeMenuKeys {
        get => _passcodeMenuKeys;
        set {
            PasscodeMenuKeysSpecified = true;
            _passcodeMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool PasscodeMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18PlayMessagesMenuKeys _playMessagesMenuKeys;

    [XmlElement(ElementName = "playMessagesMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18PlayMessagesMenuKeys PlayMessagesMenuKeys {
        get => _playMessagesMenuKeys;
        set {
            PlayMessagesMenuKeysSpecified = true;
            _playMessagesMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool PlayMessagesMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18PlayMessageMenuKeys _playMessageMenuKeys;

    [XmlElement(ElementName = "playMessageMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18PlayMessageMenuKeys PlayMessageMenuKeys {
        get => _playMessageMenuKeys;
        set {
            PlayMessageMenuKeysSpecified = true;
            _playMessageMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool PlayMessageMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18AdditionalMessageOptionsMenuKeys _additionalMessageOptionsMenuKeys;

    [XmlElement(ElementName = "additionalMessageOptionsMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18AdditionalMessageOptionsMenuKeys AdditionalMessageOptionsMenuKeys {
        get => _additionalMessageOptionsMenuKeys;
        set {
            AdditionalMessageOptionsMenuKeysSpecified = true;
            _additionalMessageOptionsMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool AdditionalMessageOptionsMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18ForwardOrComposeMessageMenuKeys _forwardOrComposeMessageMenuKeys;

    [XmlElement(ElementName = "forwardOrComposeMessageMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18ForwardOrComposeMessageMenuKeys ForwardOrComposeMessageMenuKeys {
        get => _forwardOrComposeMessageMenuKeys;
        set {
            ForwardOrComposeMessageMenuKeysSpecified = true;
            _forwardOrComposeMessageMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool ForwardOrComposeMessageMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18ReplyMessageMenuKeys _replyMessageMenuKeys;

    [XmlElement(ElementName = "replyMessageMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18ReplyMessageMenuKeys ReplyMessageMenuKeys {
        get => _replyMessageMenuKeys;
        set {
            ReplyMessageMenuKeysSpecified = true;
            _replyMessageMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool ReplyMessageMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18SendToDistributionListMenuKeys _sendToDistributionListMenuKeys;

    [XmlElement(ElementName = "sendToDistributionListMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18SendToDistributionListMenuKeys SendToDistributionListMenuKeys {
        get => _sendToDistributionListMenuKeys;
        set {
            SendToDistributionListMenuKeysSpecified = true;
            _sendToDistributionListMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool SendToDistributionListMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18SelectDistributionListMenuKeys _selectDistributionListMenuKeys;

    [XmlElement(ElementName = "selectDistributionListMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18SelectDistributionListMenuKeys SelectDistributionListMenuKeys {
        get => _selectDistributionListMenuKeys;
        set {
            SelectDistributionListMenuKeysSpecified = true;
            _selectDistributionListMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool SelectDistributionListMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18ReviewSelectedDistributionListMenuKeys _reviewSelectedDistributionListMenuKeys;

    [XmlElement(ElementName = "reviewSelectedDistributionListMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18ReviewSelectedDistributionListMenuKeys ReviewSelectedDistributionListMenuKeys {
        get => _reviewSelectedDistributionListMenuKeys;
        set {
            ReviewSelectedDistributionListMenuKeysSpecified = true;
            _reviewSelectedDistributionListMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool ReviewSelectedDistributionListMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18SendMessageToSelectedDistributionListMenuKeys _sendMessageToSelectedDistributionListMenuKeys;

    [XmlElement(ElementName = "sendMessageToSelectedDistributionListMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18SendMessageToSelectedDistributionListMenuKeys SendMessageToSelectedDistributionListMenuKeys {
        get => _sendMessageToSelectedDistributionListMenuKeys;
        set {
            SendMessageToSelectedDistributionListMenuKeysSpecified = true;
            _sendMessageToSelectedDistributionListMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool SendMessageToSelectedDistributionListMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18SendToAllGroupMembersMenuKeys _sendToAllGroupMembersMenuKeys;

    [XmlElement(ElementName = "sendToAllGroupMembersMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18SendToAllGroupMembersMenuKeys SendToAllGroupMembersMenuKeys {
        get => _sendToAllGroupMembersMenuKeys;
        set {
            SendToAllGroupMembersMenuKeysSpecified = true;
            _sendToAllGroupMembersMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool SendToAllGroupMembersMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18SendToPersonMenuKeys _sendToPersonMenuKeys;

    [XmlElement(ElementName = "sendToPersonMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18SendToPersonMenuKeys SendToPersonMenuKeys {
        get => _sendToPersonMenuKeys;
        set {
            SendToPersonMenuKeysSpecified = true;
            _sendToPersonMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool SendToPersonMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18ChangeCurrentIntroductionOrMessageOrReplyMenuKeys _changeCurrentIntroductionOrMessageOrReplyMenuKeys;

    [XmlElement(ElementName = "changeCurrentIntroductionOrMessageOrReplyMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18ChangeCurrentIntroductionOrMessageOrReplyMenuKeys ChangeCurrentIntroductionOrMessageOrReplyMenuKeys {
        get => _changeCurrentIntroductionOrMessageOrReplyMenuKeys;
        set {
            ChangeCurrentIntroductionOrMessageOrReplyMenuKeysSpecified = true;
            _changeCurrentIntroductionOrMessageOrReplyMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool ChangeCurrentIntroductionOrMessageOrReplyMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18VoicePortalLoginMenuKeys _voicePortalLoginMenuKeys;

    [XmlElement(ElementName = "voicePortalLoginMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18VoicePortalLoginMenuKeys VoicePortalLoginMenuKeys {
        get => _voicePortalLoginMenuKeys;
        set {
            VoicePortalLoginMenuKeysSpecified = true;
            _voicePortalLoginMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalLoginMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18FaxMessagingMenuKeys _faxMessagingMenuKeys;

    [XmlElement(ElementName = "faxMessagingMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18FaxMessagingMenuKeys FaxMessagingMenuKeys {
        get => _faxMessagingMenuKeys;
        set {
            FaxMessagingMenuKeysSpecified = true;
            _faxMessagingMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool FaxMessagingMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18MessageDepositMenuKeys _messageDepositMenuKeys;

    [XmlElement(ElementName = "messageDepositMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18MessageDepositMenuKeys MessageDepositMenuKeys {
        get => _messageDepositMenuKeys;
        set {
            MessageDepositMenuKeysSpecified = true;
            _messageDepositMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool MessageDepositMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18DisableMessageDepositMenuKeys _disableMessageDepositMenuKeys;

    [XmlElement(ElementName = "disableMessageDepositMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18DisableMessageDepositMenuKeys DisableMessageDepositMenuKeys {
        get => _disableMessageDepositMenuKeys;
        set {
            DisableMessageDepositMenuKeysSpecified = true;
            _disableMessageDepositMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool DisableMessageDepositMenuKeysSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18GreetingOnlyForwardingDestinationMenuKeys _greetingOnlyForwardingDestinationMenuKeys;

    [XmlElement(ElementName = "greetingOnlyForwardingDestinationMenuKeys", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18GreetingOnlyForwardingDestinationMenuKeys GreetingOnlyForwardingDestinationMenuKeys {
        get => _greetingOnlyForwardingDestinationMenuKeys;
        set {
            GreetingOnlyForwardingDestinationMenuKeysSpecified = true;
            _greetingOnlyForwardingDestinationMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool GreetingOnlyForwardingDestinationMenuKeysSpecified { get; set; }
}
}
