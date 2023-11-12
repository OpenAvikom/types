
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Unity
{

    /** A query message to retrieve information about an object in the scene.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/GameObjectQuery")]
    public class GameObjectQuery : GameEvent<GameObjectQuery>, IGameEvent
    {
        public static Avikom.Types.Unity.GameObjectQuery TypeDefault = null;
        // unique name of the requested object
        public StringVariable Name;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Unity.GameObjectQuery proto)
        {

            if (Name == null) { Name = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Name != StringVariable.TypeDefault)
            {
                Name.SetValue(proto.Name);
            }
            Raise();
        }

        public void SetValue(GameObjectQuery other)
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
            Raise();
        }

        public Avikom.Types.Unity.GameObjectQuery GetValue()
        {
            var proto = new Avikom.Types.Unity.GameObjectQuery();
            proto.Name = Name?.GetValue() ?? proto.Name;
            return proto;
        }
    }

}
