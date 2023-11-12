
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Headset
{

    /** A FunctionalSound request that either includes a standardized functional sound or the name of 
     an audio file to be played. The audio file has to be available in the web-client data path "data/Default/Sounds".
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Headset/FunctionalSoundRequest")]
    public class FunctionalSoundRequest : GameEvent<FunctionalSoundRequest>, IGameEvent
    {
        public static Avikom.Types.Headset.FunctionalSoundRequest TypeDefault = null;
        // a set of predefined sounds to provide feedback to users
        public Avikom.UnityTypes.Headset.FunctionalSound FunctionalSound;


        public StringVariable OtherSound;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Headset.FunctionalSoundRequest proto)
        {

            if (FunctionalSound == null) { FunctionalSound = ScriptableObject.CreateInstance<Avikom.UnityTypes.Headset.FunctionalSound>(); }
            if (proto.FunctionalSound != Avikom.UnityTypes.Headset.FunctionalSound.TypeDefault)
            {
                FunctionalSound.SetValue(proto.FunctionalSound);
            }

            if (OtherSound == null) { OtherSound = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.OtherSound != StringVariable.TypeDefault)
            {
                OtherSound.SetValue(proto.OtherSound);
            }
            Raise();
        }

        public void SetValue(FunctionalSoundRequest other)
        {
            if (!other) { return; }

            if (FunctionalSound == null)
            {
                FunctionalSound = other.FunctionalSound;
            }
            else if (other.FunctionalSound != null)
            {
                FunctionalSound.SetValue(other.FunctionalSound);
            }

            if (OtherSound == null)
            {
                OtherSound = other.OtherSound;
            }
            else if (other.OtherSound != null)
            {
                OtherSound.SetValue(other.OtherSound);
            }
            Raise();
        }

        public Avikom.Types.Headset.FunctionalSoundRequest GetValue()
        {
            var proto = new Avikom.Types.Headset.FunctionalSoundRequest();
            proto.FunctionalSound = FunctionalSound?.GetValue() ?? proto.FunctionalSound;
            proto.OtherSound = OtherSound?.GetValue() ?? proto.OtherSound;
            return proto;
        }
    }

}
