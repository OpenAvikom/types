
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Unity
{

    /** A message header to send Unity asset bundles in chunks.
     Should be available in every initial message to an asset bunde receiver.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/AssetBundleInfo")]
    public class AssetBundleInfo : GameEvent<AssetBundleInfo>, IGameEvent
    {
        public static Avikom.Types.Unity.AssetBundleInfo TypeDefault = null;
        // size of the whole bundle in bytes
        public IntVariable Size;

        // the planed size of each data chunk
        public IntVariable ChunkSize;

        // globally unique name of the asset bundle in question
        public StringVariable BundleName;

        // version of the bundle to determine whether sending binary data is required or not
        public StringVariable Version;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Unity.AssetBundleInfo proto)
        {

            if (Size == null) { Size = ScriptableObject.CreateInstance<IntVariable>(); }
            if (proto.Size != IntVariable.TypeDefault)
            {
                Size.SetValue(proto.Size);
            }

            if (ChunkSize == null) { ChunkSize = ScriptableObject.CreateInstance<IntVariable>(); }
            if (proto.ChunkSize != IntVariable.TypeDefault)
            {
                ChunkSize.SetValue(proto.ChunkSize);
            }

            if (BundleName == null) { BundleName = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.BundleName != StringVariable.TypeDefault)
            {
                BundleName.SetValue(proto.BundleName);
            }

            if (Version == null) { Version = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Version != StringVariable.TypeDefault)
            {
                Version.SetValue(proto.Version);
            }
            Raise();
        }

        public void SetValue(AssetBundleInfo other)
        {
            if (!other) { return; }

            if (Size == null)
            {
                Size = other.Size;
            }
            else if (other.Size != null)
            {
                Size.SetValue(other.Size);
            }

            if (ChunkSize == null)
            {
                ChunkSize = other.ChunkSize;
            }
            else if (other.ChunkSize != null)
            {
                ChunkSize.SetValue(other.ChunkSize);
            }

            if (BundleName == null)
            {
                BundleName = other.BundleName;
            }
            else if (other.BundleName != null)
            {
                BundleName.SetValue(other.BundleName);
            }

            if (Version == null)
            {
                Version = other.Version;
            }
            else if (other.Version != null)
            {
                Version.SetValue(other.Version);
            }
            Raise();
        }

        public Avikom.Types.Unity.AssetBundleInfo GetValue()
        {
            var proto = new Avikom.Types.Unity.AssetBundleInfo();
            proto.Size = Size?.GetValue() ?? proto.Size;
            proto.ChunkSize = ChunkSize?.GetValue() ?? proto.ChunkSize;
            proto.BundleName = BundleName?.GetValue() ?? proto.BundleName;
            proto.Version = Version?.GetValue() ?? proto.Version;
            return proto;
        }
    }

}
