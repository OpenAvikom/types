
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Generic
{

    /** A representation of a service system to connect to or to exchange data with.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/Peer")]
    public class Peer : GameEvent<Peer>, IGameEvent
    {
        public static Avikom.Types.Generic.Peer TypeDefault = null;
        // unique identifier of peer
        public StringVariable Name;

        // the ip under which the peer can be reached
        public StringVariable Ip;

        // name of the host; only interpreted if ip not set
        public StringVariable HostName;

        // port under which the peer can be reached
        public IntVariable Port;

        // the user currently associated with that peer
        public Avikom.UnityTypes.Generic.User User;

        // the modality or combination of modalities the peer supports
        public Avikom.UnityTypes.Generic.Modality ModalFitness;

        // a gateway URL in cases where the peer cannot be reached directly
        public StringVariable Gateway;

        // a list of services the peer provides for task step resolution
        public StringVariableSet Services;

        // a list of endpoints that are provied by the peer
        public Avikom.UnityTypes.Generic.RpcEndpointSet Endpoints;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Generic.Peer proto)
        {

            if (Name == null) { Name = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Name != StringVariable.TypeDefault)
            {
                Name.SetValue(proto.Name);
            }

            if (Ip == null) { Ip = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Ip != StringVariable.TypeDefault)
            {
                Ip.SetValue(proto.Ip);
            }

            if (HostName == null) { HostName = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.HostName != StringVariable.TypeDefault)
            {
                HostName.SetValue(proto.HostName);
            }

            if (Port == null) { Port = ScriptableObject.CreateInstance<IntVariable>(); }
            if (proto.Port != IntVariable.TypeDefault)
            {
                Port.SetValue(proto.Port);
            }

            if (User == null) { User = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.User>(); }
            if (proto.User != Avikom.UnityTypes.Generic.User.TypeDefault)
            {
                User.SetValue(proto.User);
            }

            if (ModalFitness == null) { ModalFitness = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.Modality>(); }
            if (proto.ModalFitness != Avikom.UnityTypes.Generic.Modality.TypeDefault)
            {
                ModalFitness.SetValue(proto.ModalFitness);
            }

            if (Gateway == null) { Gateway = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Gateway != StringVariable.TypeDefault)
            {
                Gateway.SetValue(proto.Gateway);
            }

            if (Services == null) { Services = ScriptableObject.CreateInstance<StringVariableSet>(); }
            if (proto.Services.Count > 0)
            {
                Services.Clear();
                foreach (var value in proto.Services)
                {
                    var tmp = ScriptableObject.CreateInstance<StringVariable>();
                    tmp.SetValue(value);
                    Services.Add(tmp);
                }
                Services.Raise();
            }
        

            if (Endpoints == null) { Endpoints = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.RpcEndpointSet>(); }
            if (proto.Endpoints.Count > 0)
            {
                Endpoints.Clear();
                foreach (var value in proto.Endpoints)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.RpcEndpoint>();
                    tmp.SetValue(value);
                    Endpoints.Add(tmp);
                }
                Endpoints.Raise();
            }
        
            Raise();
        }

        public void SetValue(Peer other)
        {
            if (!other) { return; }

            if (Name == null)
            {
                Name = other.Name;
            }
            else if (other.Name != null)
            {
                Name.SetValue(other.Name);
            }

            if (Ip == null)
            {
                Ip = other.Ip;
            }
            else if (other.Ip != null)
            {
                Ip.SetValue(other.Ip);
            }

            if (HostName == null)
            {
                HostName = other.HostName;
            }
            else if (other.HostName != null)
            {
                HostName.SetValue(other.HostName);
            }

            if (Port == null)
            {
                Port = other.Port;
            }
            else if (other.Port != null)
            {
                Port.SetValue(other.Port);
            }

            if (User == null)
            {
                User = other.User;
            }
            else if (other.User != null)
            {
                User.SetValue(other.User);
            }

            if (ModalFitness == null)
            {
                ModalFitness = other.ModalFitness;
            }
            else if (other.ModalFitness != null)
            {
                ModalFitness.SetValue(other.ModalFitness);
            }

            if (Gateway == null)
            {
                Gateway = other.Gateway;
            }
            else if (other.Gateway != null)
            {
                Gateway.SetValue(other.Gateway);
            }

            if (other.Services != null)
            {
                if (Services == null) { Services = ScriptableObject.CreateInstance<StringVariableSet>(); }
                Services.Clear();
                foreach (var elem in other.Services.Items)
                {
                    Services.Add(elem);
                }
                Services.Raise();
            }

            if (other.Endpoints != null)
            {
                if (Endpoints == null) { Endpoints = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.RpcEndpointSet>(); }
                Endpoints.Clear();
                foreach (var elem in other.Endpoints.Items)
                {
                    Endpoints.Add(elem);
                }
                Endpoints.Raise();
            }
            Raise();
        }

        public Avikom.Types.Generic.Peer GetValue()
        {
            var proto = new Avikom.Types.Generic.Peer();
            proto.Name = Name?.GetValue() ?? proto.Name;
            proto.Ip = Ip?.GetValue() ?? proto.Ip;
            proto.HostName = HostName?.GetValue() ?? proto.HostName;
            proto.Port = Port?.GetValue() ?? proto.Port;
            proto.User = User?.GetValue() ?? proto.User;
            proto.ModalFitness = ModalFitness?.GetValue() ?? proto.ModalFitness;
            proto.Gateway = Gateway?.GetValue() ?? proto.Gateway;

            foreach (var value in Services.Items) { proto.Services.Add(value.GetValue()); }
                        

            foreach (var value in Endpoints.Items) { proto.Endpoints.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}
