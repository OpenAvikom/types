
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
        public Avikom.UnityTypes.Assistance.SceneSet Scenes;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.SceneList proto)
        {

            if (Scenes == null) { Scenes = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.SceneSet>(); }
            if (proto.Scenes.Count > 0)
            {
                Scenes.Clear();
                foreach (var value in proto.Scenes)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.Scene>();
                    tmp.SetValue(value);
                    Scenes.Add(tmp);
                }
                Scenes.Raise();
            }
        
            Raise();
        }

        public void SetValue(SceneList other)
        {
            if (!other) { return; }

            if (other.Scenes != null)
            {
                if (Scenes == null) { Scenes = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.SceneSet>(); }
                Scenes.Clear();
                foreach (var elem in other.Scenes.Items)
                {
                    Scenes.Add(elem);
                }
                Scenes.Raise();
            }
            Raise();
        }

        public Avikom.Types.Assistance.SceneList GetValue()
        {
            var proto = new Avikom.Types.Assistance.SceneList();

            foreach (var value in Scenes.Items) { proto.Scenes.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}
