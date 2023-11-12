
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Unity
{

    /** This message describes a (virtual) object in the current scene.
     Properties have been chosen to allo Unity-based peers to create instances from such a message.
     However, this message might also be used in contexts where rendering is not necessary.
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Unity/GameObject")]
    public class GameObject : GameEvent<GameObject>, IGameEvent
    {
        public static Avikom.Types.Unity.GameObject TypeDefault = null;
        // scene name of the object
        public StringVariable Name;

        // the pose of the object relative to its parent
        public Avikom.UnityTypes.Unity.Transpose Transpose;

        // addressable uri of the (audio)visual appearance blueprint/prefab
        public StringVariable Prefab;

        // the parent's name; if not set, an object will be attached to the scene's root or an equivalent group
        public StringVariable Parent;

        // a list of nested `GameObjects`; parent will be this object if not stated differently
        public Avikom.UnityTypes.Unity.GameObjectSet Children;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Unity.GameObject proto)
        {

            if (Name == null) { Name = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Name != StringVariable.TypeDefault)
            {
                Name.SetValue(proto.Name);
            }

            if (Transpose == null) { Transpose = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.Transpose>(); }
            if (proto.Transpose != Avikom.UnityTypes.Unity.Transpose.TypeDefault)
            {
                Transpose.SetValue(proto.Transpose);
            }

            if (Prefab == null) { Prefab = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Prefab != StringVariable.TypeDefault)
            {
                Prefab.SetValue(proto.Prefab);
            }

            if (Parent == null) { Parent = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Parent != StringVariable.TypeDefault)
            {
                Parent.SetValue(proto.Parent);
            }

            if (Children == null) { Children = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.GameObjectSet>(); }
            if (proto.Children.Count > 0)
            {
                Children.Clear();
                foreach (var value in proto.Children)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.GameObject>();
                    tmp.SetValue(value);
                    Children.Add(tmp);
                }
                Children.Raise();
            }
        
            Raise();
        }

        public void SetValue(GameObject other)
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

            if (Transpose == null)
            {
                Transpose = other.Transpose;
            }
            else if (other.Transpose != null)
            {
                Transpose.SetValue(other.Transpose);
            }

            if (Prefab == null)
            {
                Prefab = other.Prefab;
            }
            else if (other.Prefab != null)
            {
                Prefab.SetValue(other.Prefab);
            }

            if (Parent == null)
            {
                Parent = other.Parent;
            }
            else if (other.Parent != null)
            {
                Parent.SetValue(other.Parent);
            }

            if (other.Children != null)
            {
                if (Children == null) { Children = ScriptableObject.CreateInstance<Avikom.UnityTypes.Unity.GameObjectSet>(); }
                Children.Clear();
                foreach (var elem in other.Children.Items)
                {
                    Children.Add(elem);
                }
                Children.Raise();
            }
            Raise();
        }

        public Avikom.Types.Unity.GameObject GetValue()
        {
            var proto = new Avikom.Types.Unity.GameObject();
            proto.Name = Name?.GetValue() ?? proto.Name;
            proto.Transpose = Transpose?.GetValue() ?? proto.Transpose;
            proto.Prefab = Prefab?.GetValue() ?? proto.Prefab;
            proto.Parent = Parent?.GetValue() ?? proto.Parent;

            foreach (var value in Children.Items) { proto.Children.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}
