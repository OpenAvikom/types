
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** A list of scenes.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/SceneList")]
    public class SceneList : GameEvent<SceneList>, IGameEvent
    {
        public static Avikom.Types.Assistance.SceneList TypeDefault = null;
        // a scene list
        public Avikom.UnityTypes.Assistance.Scene Scenes;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.SceneList proto)
        {

            if (Scenes == null) { Scenes = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.Scene>(); }
            if (proto.Scenes != Avikom.UnityTypes.Assistance.Scene.TypeDefault)
            {
                Scenes.SetValue(proto.Scenes);
            }
            Raise();
        }

        public void SetValue(SceneList other)
        {
            if (!other) { return; }

            if (Scenes == null)
            {
                Scenes = other.Scenes;
            }
            else if (other.Scenes != null)
            {
                Scenes.SetValue(other.Scenes);
            }
            Raise();
        }

        public Avikom.Types.Assistance.SceneList GetValue()
        {
            var proto = new Avikom.Types.Assistance.SceneList();
            proto.Scenes = Scenes?.GetValue() ?? proto.Scenes;
            return proto;
        }
    }

}
