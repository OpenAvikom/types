
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** A request passed to `ServiceProviderService`.
     @author Alexander McService Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/ServiceRequest")]
    public class ServiceRequest : GameEvent<ServiceRequest>, IGameEvent
    {
        public static Avikom.Types.Assistance.ServiceRequest TypeDefault = null;
        // represents the task that is related to the service request
        public StringVariable TaskId;

        // service type and configuration parameters
        public Avikom.UnityTypes.Assistance.ServiceConfiguration Configuration;

        // a list of available peers that can be used to resolve the service request
        public Avikom.UnityTypes.Generic.Peer Peers;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.ServiceRequest proto)
        {

            if (TaskId == null) { TaskId = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.TaskId != StringVariable.TypeDefault)
            {
                TaskId.SetValue(proto.TaskId);
            }

            if (Configuration == null) { Configuration = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.ServiceConfiguration>(); }
            if (proto.Configuration != Avikom.UnityTypes.Assistance.ServiceConfiguration.TypeDefault)
            {
                Configuration.SetValue(proto.Configuration);
            }

            if (Peers == null) { Peers = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.Peer>(); }
            if (proto.Peers != Avikom.UnityTypes.Generic.Peer.TypeDefault)
            {
                Peers.SetValue(proto.Peers);
            }
            Raise();
        }

        public void SetValue(ServiceRequest other)
        {
            if (!other) { return; }

            if (TaskId == null)
            {
                TaskId = other.TaskId;
            }
            else if (other.TaskId != null)
            {
                TaskId.SetValue(other.TaskId);
            }

            if (Configuration == null)
            {
                Configuration = other.Configuration;
            }
            else if (other.Configuration != null)
            {
                Configuration.SetValue(other.Configuration);
            }

            if (Peers == null)
            {
                Peers = other.Peers;
            }
            else if (other.Peers != null)
            {
                Peers.SetValue(other.Peers);
            }
            Raise();
        }

        public Avikom.Types.Assistance.ServiceRequest GetValue()
        {
            var proto = new Avikom.Types.Assistance.ServiceRequest();
            proto.TaskId = TaskId?.GetValue() ?? proto.TaskId;
            proto.Configuration = Configuration?.GetValue() ?? proto.Configuration;
            proto.Peers = Peers?.GetValue() ?? proto.Peers;
            return proto;
        }
    }

}
