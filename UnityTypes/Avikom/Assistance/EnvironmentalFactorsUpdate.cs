
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** A message to update current environmental factors such as brightness and/or volume for a user session or a scene.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/EnvironmentalFactorsUpdate")]
    public class EnvironmentalFactorsUpdate : GameEvent<EnvironmentalFactorsUpdate>, IGameEvent
    {
        public static Avikom.Types.Assistance.EnvironmentalFactorsUpdate TypeDefault = null;
        // scene/location name where data has been tracked
        public StringVariable SceneName;

        // when set, relates info to the current session of the user
        public UnsignedLongVariable UserId;

        // when set, relates info the this specific session
        public StringVariable SessionId;

        // environmental lightning/brightness in lumen
        public FloatVariable Brightness;

        // environmental loudness/volume in dbA
        public FloatVariable Volume;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.EnvironmentalFactorsUpdate proto)
        {

            if (SceneName == null) { SceneName = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.SceneName != StringVariable.TypeDefault)
            {
                SceneName.SetValue(proto.SceneName);
            }

            if (UserId == null) { UserId = ScriptableObject.CreateInstance<UnsignedLongVariable>(); }
            if (proto.UserId != UnsignedLongVariable.TypeDefault)
            {
                UserId.SetValue(proto.UserId);
            }

            if (SessionId == null) { SessionId = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.SessionId != StringVariable.TypeDefault)
            {
                SessionId.SetValue(proto.SessionId);
            }

            if (Brightness == null) { Brightness = ScriptableObject.CreateInstance<FloatVariable>(); }
            if (proto.Brightness != FloatVariable.TypeDefault)
            {
                Brightness.SetValue(proto.Brightness);
            }

            if (Volume == null) { Volume = ScriptableObject.CreateInstance<FloatVariable>(); }
            if (proto.Volume != FloatVariable.TypeDefault)
            {
                Volume.SetValue(proto.Volume);
            }
            Raise();
        }

        public void SetValue(EnvironmentalFactorsUpdate other)
        {
            if (!other) { return; }

            if (SceneName == null)
            {
                SceneName = other.SceneName;
            }
            else if (other.SceneName != null)
            {
                SceneName.SetValue(other.SceneName);
            }

            if (UserId == null)
            {
                UserId = other.UserId;
            }
            else if (other.UserId != null)
            {
                UserId.SetValue(other.UserId);
            }

            if (SessionId == null)
            {
                SessionId = other.SessionId;
            }
            else if (other.SessionId != null)
            {
                SessionId.SetValue(other.SessionId);
            }

            if (Brightness == null)
            {
                Brightness = other.Brightness;
            }
            else if (other.Brightness != null)
            {
                Brightness.SetValue(other.Brightness);
            }

            if (Volume == null)
            {
                Volume = other.Volume;
            }
            else if (other.Volume != null)
            {
                Volume.SetValue(other.Volume);
            }
            Raise();
        }

        public Avikom.Types.Assistance.EnvironmentalFactorsUpdate GetValue()
        {
            var proto = new Avikom.Types.Assistance.EnvironmentalFactorsUpdate();
            proto.SceneName = SceneName?.GetValue() ?? proto.SceneName;
            proto.UserId = UserId?.GetValue() ?? proto.UserId;
            proto.SessionId = SessionId?.GetValue() ?? proto.SessionId;
            proto.Brightness = Brightness?.GetValue() ?? proto.Brightness;
            proto.Volume = Volume?.GetValue() ?? proto.Volume;
            return proto;
        }
    }

}
