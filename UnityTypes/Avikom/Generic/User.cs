
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Generic
{

    /** A message that contains data about a user that is essential for system operation.
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de>
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/User")]
    public class User : GameEvent<User>, IGameEvent
    {
        public static Avikom.Types.Generic.User TypeDefault = null;
        // the first name is optional; will default to empty string if not
        public StringVariable FirstName;

        // the last name is optional; will default to empty string if not set
        public StringVariable LastName;

        // does not need to be set when a new user is created
        public UnsignedLongVariable Id;

        // system usernames required for certain peers, preferarbly unique to prevent imposters
        public StringVariable Usernames;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Generic.User proto)
        {

            if (FirstName == null) { FirstName = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.FirstName != StringVariable.TypeDefault)
            {
                FirstName.SetValue(proto.FirstName);
            }

            if (LastName == null) { LastName = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.LastName != StringVariable.TypeDefault)
            {
                LastName.SetValue(proto.LastName);
            }

            if (Id == null) { Id = ScriptableObject.CreateInstance<UnsignedLongVariable>(); }
            if (proto.Id != UnsignedLongVariable.TypeDefault)
            {
                Id.SetValue(proto.Id);
            }

            if (Usernames == null) { Usernames = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Usernames != StringVariable.TypeDefault)
            {
                Usernames.SetValue(proto.Usernames);
            }
            Raise();
        }

        public void SetValue(User other)
        {
            if (!other) { return; }

            if (FirstName == null)
            {
                FirstName = other.FirstName;
            }
            else if (other.FirstName != null)
            {
                FirstName.SetValue(other.FirstName);
            }

            if (LastName == null)
            {
                LastName = other.LastName;
            }
            else if (other.LastName != null)
            {
                LastName.SetValue(other.LastName);
            }

            if (Id == null)
            {
                Id = other.Id;
            }
            else if (other.Id != null)
            {
                Id.SetValue(other.Id);
            }

            if (Usernames == null)
            {
                Usernames = other.Usernames;
            }
            else if (other.Usernames != null)
            {
                Usernames.SetValue(other.Usernames);
            }
            Raise();
        }

        public Avikom.Types.Generic.User GetValue()
        {
            var proto = new Avikom.Types.Generic.User();
            proto.FirstName = FirstName?.GetValue() ?? proto.FirstName;
            proto.LastName = LastName?.GetValue() ?? proto.LastName;
            proto.Id = Id?.GetValue() ?? proto.Id;
            proto.Usernames = Usernames?.GetValue() ?? proto.Usernames;
            return proto;
        }
    }

}
