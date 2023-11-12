
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Generic
{

    /** A message specifying one of three- or a combination of three interaction modalities supported 
     for, for example, instructions, peers, user_profiles and sessions.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/Modality")]
    public class Modality : GameEvent<Modality>, IGameEvent
    {
        public static Avikom.Types.Generic.Modality TypeDefault = null;
        // things you see (Sight)
        public FloatVariable Visual;

        // things you hear (Hearing)
        public FloatVariable Auditory;

        // things you touch/feel (Touch)
        public FloatVariable Tactile;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Generic.Modality proto)
        {

            if (Visual == null) { Visual = ScriptableObject.CreateInstance<FloatVariable>(); }
            if (proto.Visual != FloatVariable.TypeDefault)
            {
                Visual.SetValue(proto.Visual);
            }

            if (Auditory == null) { Auditory = ScriptableObject.CreateInstance<FloatVariable>(); }
            if (proto.Auditory != FloatVariable.TypeDefault)
            {
                Auditory.SetValue(proto.Auditory);
            }

            if (Tactile == null) { Tactile = ScriptableObject.CreateInstance<FloatVariable>(); }
            if (proto.Tactile != FloatVariable.TypeDefault)
            {
                Tactile.SetValue(proto.Tactile);
            }
            Raise();
        }

        public void SetValue(Modality other)
        {
            if (!other) { return; }

            if (Visual == null)
            {
                Visual = other.Visual;
            }
            else if (other.Visual != null)
            {
                Visual.SetValue(other.Visual);
            }

            if (Auditory == null)
            {
                Auditory = other.Auditory;
            }
            else if (other.Auditory != null)
            {
                Auditory.SetValue(other.Auditory);
            }

            if (Tactile == null)
            {
                Tactile = other.Tactile;
            }
            else if (other.Tactile != null)
            {
                Tactile.SetValue(other.Tactile);
            }
            Raise();
        }

        public Avikom.Types.Generic.Modality GetValue()
        {
            var proto = new Avikom.Types.Generic.Modality();
            proto.Visual = Visual?.GetValue() ?? proto.Visual;
            proto.Auditory = Auditory?.GetValue() ?? proto.Auditory;
            proto.Tactile = Tactile?.GetValue() ?? proto.Tactile;
            return proto;
        }
    }

}
