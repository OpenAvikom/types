
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Generic
{


    [CreateAssetMenu(menuName = "Avikom/Generic/StreamRequest")]
    public class StreamRequest : GameEvent<StreamRequest>, IGameEvent
    {
        public static Avikom.Types.Generic.StreamRequest TypeDefault = null;

        public Avikom.UnityTypes.Generic.Protocol Protocol;


        public Avikom.UnityTypes.Generic.AudioQuality AudioQuality;


        public Avikom.UnityTypes.Generic.VideoQuality VideoQuality;


        public BoolVariable SendAugmented;


        public BoolVariable ReceiveAudio;


        public BoolVariable ReceiveVideo;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Generic.StreamRequest proto)
        {

            if (Protocol == null) { Protocol = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.Protocol>(); }
            if (proto.Protocol != Avikom.UnityTypes.Generic.Protocol.TypeDefault)
            {
                Protocol.SetValue(proto.Protocol);
            }

            if (AudioQuality == null) { AudioQuality = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.AudioQuality>(); }
            if (proto.AudioQuality != Avikom.UnityTypes.Generic.AudioQuality.TypeDefault)
            {
                AudioQuality.SetValue(proto.AudioQuality);
            }

            if (VideoQuality == null) { VideoQuality = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.VideoQuality>(); }
            if (proto.VideoQuality != Avikom.UnityTypes.Generic.VideoQuality.TypeDefault)
            {
                VideoQuality.SetValue(proto.VideoQuality);
            }

            if (SendAugmented == null) { SendAugmented = ScriptableObject.CreateInstance<BoolVariable>(); }
            if (true)
            {
                SendAugmented.SetValue(proto.SendAugmented);
            }

            if (ReceiveAudio == null) { ReceiveAudio = ScriptableObject.CreateInstance<BoolVariable>(); }
            if (true)
            {
                ReceiveAudio.SetValue(proto.ReceiveAudio);
            }

            if (ReceiveVideo == null) { ReceiveVideo = ScriptableObject.CreateInstance<BoolVariable>(); }
            if (true)
            {
                ReceiveVideo.SetValue(proto.ReceiveVideo);
            }
            Raise();
        }

        public void SetValue(StreamRequest other)
        {
            if (!other) { return; }

            if (Protocol == null)
            {
                Protocol = other.Protocol;
            }
            else if (other.Protocol != null)
            {
                Protocol.SetValue(other.Protocol);
            }

            if (AudioQuality == null)
            {
                AudioQuality = other.AudioQuality;
            }
            else if (other.AudioQuality != null)
            {
                AudioQuality.SetValue(other.AudioQuality);
            }

            if (VideoQuality == null)
            {
                VideoQuality = other.VideoQuality;
            }
            else if (other.VideoQuality != null)
            {
                VideoQuality.SetValue(other.VideoQuality);
            }

            if (SendAugmented == null)
            {
                SendAugmented = other.SendAugmented;
            }
            else if (other.SendAugmented != null)
            {
                SendAugmented.SetValue(other.SendAugmented);
            }

            if (ReceiveAudio == null)
            {
                ReceiveAudio = other.ReceiveAudio;
            }
            else if (other.ReceiveAudio != null)
            {
                ReceiveAudio.SetValue(other.ReceiveAudio);
            }

            if (ReceiveVideo == null)
            {
                ReceiveVideo = other.ReceiveVideo;
            }
            else if (other.ReceiveVideo != null)
            {
                ReceiveVideo.SetValue(other.ReceiveVideo);
            }
            Raise();
        }

        public Avikom.Types.Generic.StreamRequest GetValue()
        {
            var proto = new Avikom.Types.Generic.StreamRequest();
            proto.Protocol = Protocol?.GetValue() ?? proto.Protocol;
            proto.AudioQuality = AudioQuality?.GetValue() ?? proto.AudioQuality;
            proto.VideoQuality = VideoQuality?.GetValue() ?? proto.VideoQuality;
            proto.SendAugmented = SendAugmented?.GetValue() ?? proto.SendAugmented;
            proto.ReceiveAudio = ReceiveAudio?.GetValue() ?? proto.ReceiveAudio;
            proto.ReceiveVideo = ReceiveVideo?.GetValue() ?? proto.ReceiveVideo;
            return proto;
        }
    }

}
