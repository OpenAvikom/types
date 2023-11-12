
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Unity
{

    /** Provides an interface to request AssetBundles from a server. 
    @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/AssetBundle")]
    public class AssetBundle : GameEvent<AssetBundle>, IGameEvent
    {
        public static Avikom.Types.Unity.AssetBundle TypeDefault = null;

        public Avikom.UnityTypes.Unity.AssetBundleInfo Info;


        public ByteArrayVariable Data;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Unity.AssetBundle proto)
        {

            if (Info == null) { Info = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.AssetBundleInfo>(); }
            if (proto.Info != Avikom.UnityTypes.Unity.AssetBundleInfo.TypeDefault)
            {
                Info.SetValue(proto.Info);
            }

            if (Data == null) { Data = ScriptableObject.CreateInstance<ByteArrayVariable>(); }
            if (!proto.Data.IsEmpty)
            {
                Data.SetValue(proto.Data.ToByteArray());
            }
            Raise();
        }

        public void SetValue(AssetBundle other)
        {
            if (!other) { return; }

            if (Info == null)
            {
                Info = other.Info;
            }
            else if (other.Info != null)
            {
                Info.SetValue(other.Info);
            }

            if (Data == null)
            {
                Data = other.Data;
            }
            else if (other.Data != null)
            {
                Data.SetValue(other.Data);
            }
            Raise();
        }

        public Avikom.Types.Unity.AssetBundle GetValue()
        {
            var proto = new Avikom.Types.Unity.AssetBundle();
            proto.Info = Info?.GetValue() ?? proto.Info;
            proto.Data = (Data != null) ? ByteString.CopyFrom(Data.GetValue(), 0, Data.GetValue().Length) : proto.Data;
            return proto;
        }
    }

}
