
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Generic
{

    /** A message specifying the log combining the log level, the logging message and the origin
    @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/Message")]
    public class Message : GameEvent<Message>, IGameEvent
    {
        public static Avikom.Types.Generic.Message TypeDefault = null;
        // holds the log level of the message
        public Avikom.UnityTypes.Generic.LogLevel Level;

        // holds the log message
        public StringVariable Content;

        // which service issued the log
        public StringVariable Origin;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Generic.Message proto)
        {

            if (Level == null) { Level = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.LogLevel>(); }
            if (proto.Level != Avikom.UnityTypes.Generic.LogLevel.TypeDefault)
            {
                Level.SetValue(proto.Level);
            }

            if (Content == null) { Content = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Content != StringVariable.TypeDefault)
            {
                Content.SetValue(proto.Content);
            }

            if (Origin == null) { Origin = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Origin != StringVariable.TypeDefault)
            {
                Origin.SetValue(proto.Origin);
            }
            Raise();
        }

        public void SetValue(Message other)
        {
            if (!other) { return; }

            if (Level == null)
            {
                Level = other.Level;
            }
            else if (other.Level != null)
            {
                Level.SetValue(other.Level);
            }

            if (Content == null)
            {
                Content = other.Content;
            }
            else if (other.Content != null)
            {
                Content.SetValue(other.Content);
            }

            if (Origin == null)
            {
                Origin = other.Origin;
            }
            else if (other.Origin != null)
            {
                Origin.SetValue(other.Origin);
            }
            Raise();
        }

        public Avikom.Types.Generic.Message GetValue()
        {
            var proto = new Avikom.Types.Generic.Message();
            proto.Level = Level?.GetValue() ?? proto.Level;
            proto.Content = Content?.GetValue() ?? proto.Content;
            proto.Origin = Origin?.GetValue() ?? proto.Origin;
            return proto;
        }
    }

}
