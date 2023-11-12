
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Headset
{

    /** A Mode request passed to SetMode.
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Headset/AudioPeerModeRequest")]
    public class AudioPeerModeRequest : GameEvent<AudioPeerModeRequest>, IGameEvent
    {
        public static Avikom.Types.Headset.AudioPeerModeRequest TypeDefault = null;
        // the mode the auditory peer should activate
        public Avikom.UnityTypes.Headset.Mode Mode;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Headset.AudioPeerModeRequest proto)
        {

            if (Mode == null) { Mode = ScriptableObject.CreateInstance<Avikom.UnityTypes.Headset.Mode>(); }
            if (proto.Mode != Avikom.UnityTypes.Headset.Mode.TypeDefault)
            {
                Mode.SetValue(proto.Mode);
            }
            Raise();
        }

        public void SetValue(AudioPeerModeRequest other)
        {
            if (!other) { return; }

            if (Mode == null)
            {
                Mode = other.Mode;
            }
            else if (other.Mode != null)
            {
                Mode.SetValue(other.Mode);
            }
            Raise();
        }

        public Avikom.Types.Headset.AudioPeerModeRequest GetValue()
        {
            var proto = new Avikom.Types.Headset.AudioPeerModeRequest();
            proto.Mode = Mode?.GetValue() ?? proto.Mode;
            return proto;
        }
    }

}
