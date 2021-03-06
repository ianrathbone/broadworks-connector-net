using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Call Center instance to a group.
    /// The domain is required in the serviceUserId.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// routingType
    /// enableReporting
    /// allowCallsToAgentsInWrapUp
    /// overrideAgentWrapUpTime
    /// wrapUpSeconds
    /// forceDeliveryOfCalls
    /// forceDeliveryWaitTimeSeconds
    /// enableAutomaticStateChangeForAgents
    /// agentStateAfterCall
    /// agentUnavailableCode
    /// networkClassOfService
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:1998""}]")]
    public class GroupCallCenterAddInstanceRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfileCallCenter _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfileCallCenter ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInstanceProfileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterType _type;

        [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public BroadWorksConnector.Ocip.Models.CallCenterType Type
        {
            get => _type;
            set
            {
                TypeSpecified = true;
                _type = value;
            }
        }

        [XmlIgnore]
        protected bool TypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterRoutingType _routingType;

        [XmlElement(ElementName = "routingType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public BroadWorksConnector.Ocip.Models.CallCenterRoutingType RoutingType
        {
            get => _routingType;
            set
            {
                RoutingTypeSpecified = true;
                _routingType = value;
            }
        }

        [XmlIgnore]
        protected bool RoutingTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.HuntPolicy _policy;

        [XmlElement(ElementName = "policy", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public BroadWorksConnector.Ocip.Models.HuntPolicy Policy
        {
            get => _policy;
            set
            {
                PolicySpecified = true;
                _policy = value;
            }
        }

        [XmlIgnore]
        protected bool PolicySpecified { get; set; }

        private bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public bool EnableVideo
        {
            get => _enableVideo;
            set
            {
                EnableVideoSpecified = true;
                _enableVideo = value;
            }
        }

        [XmlIgnore]
        protected bool EnableVideoSpecified { get; set; }

        private int _queueLength;

        [XmlElement(ElementName = "queueLength", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        [MinInclusive(0)]
        [MaxInclusive(525)]
        public int QueueLength
        {
            get => _queueLength;
            set
            {
                QueueLengthSpecified = true;
                _queueLength = value;
            }
        }

        [XmlIgnore]
        protected bool QueueLengthSpecified { get; set; }

        private bool _enableReporting;

        [XmlElement(ElementName = "enableReporting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public bool EnableReporting
        {
            get => _enableReporting;
            set
            {
                EnableReportingSpecified = true;
                _enableReporting = value;
            }
        }

        [XmlIgnore]
        protected bool EnableReportingSpecified { get; set; }

        private bool _allowCallerToDialEscapeDigit;

        [XmlElement(ElementName = "allowCallerToDialEscapeDigit", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public bool AllowCallerToDialEscapeDigit
        {
            get => _allowCallerToDialEscapeDigit;
            set
            {
                AllowCallerToDialEscapeDigitSpecified = true;
                _allowCallerToDialEscapeDigit = value;
            }
        }

        [XmlIgnore]
        protected bool AllowCallerToDialEscapeDigitSpecified { get; set; }

        private string _escapeDigit;

        [XmlElement(ElementName = "escapeDigit", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        [Length(1)]
        public string EscapeDigit
        {
            get => _escapeDigit;
            set
            {
                EscapeDigitSpecified = true;
                _escapeDigit = value;
            }
        }

        [XmlIgnore]
        protected bool EscapeDigitSpecified { get; set; }

        private bool _resetCallStatisticsUponEntryInQueue;

        [XmlElement(ElementName = "resetCallStatisticsUponEntryInQueue", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public bool ResetCallStatisticsUponEntryInQueue
        {
            get => _resetCallStatisticsUponEntryInQueue;
            set
            {
                ResetCallStatisticsUponEntryInQueueSpecified = true;
                _resetCallStatisticsUponEntryInQueue = value;
            }
        }

        [XmlIgnore]
        protected bool ResetCallStatisticsUponEntryInQueueSpecified { get; set; }

        private bool _allowAgentLogoff;

        [XmlElement(ElementName = "allowAgentLogoff", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public bool AllowAgentLogoff
        {
            get => _allowAgentLogoff;
            set
            {
                AllowAgentLogoffSpecified = true;
                _allowAgentLogoff = value;
            }
        }

        [XmlIgnore]
        protected bool AllowAgentLogoffSpecified { get; set; }

        private bool _allowCallWaitingForAgents;

        [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public bool AllowCallWaitingForAgents
        {
            get => _allowCallWaitingForAgents;
            set
            {
                AllowCallWaitingForAgentsSpecified = true;
                _allowCallWaitingForAgents = value;
            }
        }

        [XmlIgnore]
        protected bool AllowCallWaitingForAgentsSpecified { get; set; }

        private bool _allowCallsToAgentsInWrapUp;

        [XmlElement(ElementName = "allowCallsToAgentsInWrapUp", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public bool AllowCallsToAgentsInWrapUp
        {
            get => _allowCallsToAgentsInWrapUp;
            set
            {
                AllowCallsToAgentsInWrapUpSpecified = true;
                _allowCallsToAgentsInWrapUp = value;
            }
        }

        [XmlIgnore]
        protected bool AllowCallsToAgentsInWrapUpSpecified { get; set; }

        private bool _overrideAgentWrapUpTime;

        [XmlElement(ElementName = "overrideAgentWrapUpTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public bool OverrideAgentWrapUpTime
        {
            get => _overrideAgentWrapUpTime;
            set
            {
                OverrideAgentWrapUpTimeSpecified = true;
                _overrideAgentWrapUpTime = value;
            }
        }

        [XmlIgnore]
        protected bool OverrideAgentWrapUpTimeSpecified { get; set; }

        private int _wrapUpSeconds;

        [XmlElement(ElementName = "wrapUpSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        [MinInclusive(1)]
        [MaxInclusive(3600)]
        public int WrapUpSeconds
        {
            get => _wrapUpSeconds;
            set
            {
                WrapUpSecondsSpecified = true;
                _wrapUpSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool WrapUpSecondsSpecified { get; set; }

        private bool _forceDeliveryOfCalls;

        [XmlElement(ElementName = "forceDeliveryOfCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public bool ForceDeliveryOfCalls
        {
            get => _forceDeliveryOfCalls;
            set
            {
                ForceDeliveryOfCallsSpecified = true;
                _forceDeliveryOfCalls = value;
            }
        }

        [XmlIgnore]
        protected bool ForceDeliveryOfCallsSpecified { get; set; }

        private int _forceDeliveryWaitTimeSeconds;

        [XmlElement(ElementName = "forceDeliveryWaitTimeSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int ForceDeliveryWaitTimeSeconds
        {
            get => _forceDeliveryWaitTimeSeconds;
            set
            {
                ForceDeliveryWaitTimeSecondsSpecified = true;
                _forceDeliveryWaitTimeSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool ForceDeliveryWaitTimeSecondsSpecified { get; set; }

        private bool _enableAutomaticStateChangeForAgents;

        [XmlElement(ElementName = "enableAutomaticStateChangeForAgents", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public bool EnableAutomaticStateChangeForAgents
        {
            get => _enableAutomaticStateChangeForAgents;
            set
            {
                EnableAutomaticStateChangeForAgentsSpecified = true;
                _enableAutomaticStateChangeForAgents = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAutomaticStateChangeForAgentsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AgentACDAutomaticState _agentStateAfterCall;

        [XmlElement(ElementName = "agentStateAfterCall", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public BroadWorksConnector.Ocip.Models.AgentACDAutomaticState AgentStateAfterCall
        {
            get => _agentStateAfterCall;
            set
            {
                AgentStateAfterCallSpecified = true;
                _agentStateAfterCall = value;
            }
        }

        [XmlIgnore]
        protected bool AgentStateAfterCallSpecified { get; set; }

        private string _agentUnavailableCode;

        [XmlElement(ElementName = "agentUnavailableCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        [MinLength(1)]
        [MaxLength(10)]
        public string AgentUnavailableCode
        {
            get => _agentUnavailableCode;
            set
            {
                AgentUnavailableCodeSpecified = true;
                _agentUnavailableCode = value;
            }
        }

        [XmlIgnore]
        protected bool AgentUnavailableCodeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AudioFileCodec22 _externalPreferredAudioCodec;

        [XmlElement(ElementName = "externalPreferredAudioCodec", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public BroadWorksConnector.Ocip.Models.AudioFileCodec22 ExternalPreferredAudioCodec
        {
            get => _externalPreferredAudioCodec;
            set
            {
                ExternalPreferredAudioCodecSpecified = true;
                _externalPreferredAudioCodec = value;
            }
        }

        [XmlIgnore]
        protected bool ExternalPreferredAudioCodecSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AudioFileCodec22 _internalPreferredAudioCodec;

        [XmlElement(ElementName = "internalPreferredAudioCodec", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public BroadWorksConnector.Ocip.Models.AudioFileCodec22 InternalPreferredAudioCodec
        {
            get => _internalPreferredAudioCodec;
            set
            {
                InternalPreferredAudioCodecSpecified = true;
                _internalPreferredAudioCodec = value;
            }
        }

        [XmlIgnore]
        protected bool InternalPreferredAudioCodecSpecified { get; set; }

        private bool _playRingingWhenOfferingCall;

        [XmlElement(ElementName = "playRingingWhenOfferingCall", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        public bool PlayRingingWhenOfferingCall
        {
            get => _playRingingWhenOfferingCall;
            set
            {
                PlayRingingWhenOfferingCallSpecified = true;
                _playRingingWhenOfferingCall = value;
            }
        }

        [XmlIgnore]
        protected bool PlayRingingWhenOfferingCallSpecified { get; set; }

        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1998")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkClassOfServiceSpecified { get; set; }

    }
}
