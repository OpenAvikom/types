
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Unity
{

    /** A message to request asset bundles from a server.
    @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/AssetBundleQuery")]
    public class AssetBundleQuery : GameEvent<AssetBundleQuery>, IGameEvent
    {
        public static Avikom.Types.Unity.AssetBundleQuery TypeDefault = null;
        // globally unique name of the bundle
        public StringVariable BundleName;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Unity.AssetBundleQuery proto)
        {

            if (BundleName == null) { BundleName = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.BundleName != StringVariable.TypeDefault)
            {
                BundleName.SetValue(proto.BundleName);
            }
            Raise();
        }

        public void SetValue(AssetBundleQuery other)
        {
            if (!other) { return; }

            if (BundleName == null)
            {
                BundleName = other.BundleName;
            }
            else if (other.BundleName != null)
            {
                BundleName.SetValue(other.BundleName);
            }
            Raise();
        }

        public Avikom.Types.Unity.AssetBundleQuery GetValue()
        {
            var proto = new Avikom.Types.Unity.AssetBundleQuery();
            proto.BundleName = BundleName?.GetValue() ?? proto.BundleName;
            return proto;
        }
    }

}
