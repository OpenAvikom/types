
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Generic
{

    /** A more elaborate profile of a user including additional data (i.e. "Stammdaten").
     User Attribution is mandatory, all other fields are optional
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/UserProfile")]
    public class UserProfile : GameEvent<UserProfile>, IGameEvent
    {
        public static Avikom.Types.Generic.UserProfile TypeDefault = null;
        // the user object that belongs to this profile; mandatory information
        public Avikom.UnityTypes.Generic.User User;

        // a valid e-mail address to contact the user; optional information
        public StringVariable Email;

        // the department the user works in; optional information
        public StringVariable Department;

        // a phone number under which the user can be reached; optional information
        public StringVariable PhoneNumber;

        // the job title of the user; optional information
        public StringVariable Position;

        // indicating if the user prefers a specific modality above others; optional information
        public Avikom.UnityTypes.Generic.Modality ModalPreferences;

        // the "velocity" with which amount of assistance is decreased; 0 means no decrease; 1 max. decrease?; optional information
        public FloatVariable AssistanceDecrease;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Generic.UserProfile proto)
        {

            if (User == null) { User = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.User>(); }
            if (proto.User != Avikom.UnityTypes.Generic.User.TypeDefault)
            {
                User.SetValue(proto.User);
            }

            if (Email == null) { Email = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Email != StringVariable.TypeDefault)
            {
                Email.SetValue(proto.Email);
            }

            if (Department == null) { Department = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Department != StringVariable.TypeDefault)
            {
                Department.SetValue(proto.Department);
            }

            if (PhoneNumber == null) { PhoneNumber = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.PhoneNumber != StringVariable.TypeDefault)
            {
                PhoneNumber.SetValue(proto.PhoneNumber);
            }

            if (Position == null) { Position = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Position != StringVariable.TypeDefault)
            {
                Position.SetValue(proto.Position);
            }

            if (ModalPreferences == null) { ModalPreferences = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.Modality>(); }
            if (proto.ModalPreferences != Avikom.UnityTypes.Generic.Modality.TypeDefault)
            {
                ModalPreferences.SetValue(proto.ModalPreferences);
            }

            if (AssistanceDecrease == null) { AssistanceDecrease = ScriptableObject.CreateInstance<FloatVariable>(); }
            if (proto.AssistanceDecrease != FloatVariable.TypeDefault)
            {
                AssistanceDecrease.SetValue(proto.AssistanceDecrease);
            }
            Raise();
        }

        public void SetValue(UserProfile other)
        {
            if (!other) { return; }

            if (User == null)
            {
                User = other.User;
            }
            else if (other.User != null)
            {
                User.SetValue(other.User);
            }

            if (Email == null)
            {
                Email = other.Email;
            }
            else if (other.Email != null)
            {
                Email.SetValue(other.Email);
            }

            if (Department == null)
            {
                Department = other.Department;
            }
            else if (other.Department != null)
            {
                Department.SetValue(other.Department);
            }

            if (PhoneNumber == null)
            {
                PhoneNumber = other.PhoneNumber;
            }
            else if (other.PhoneNumber != null)
            {
                PhoneNumber.SetValue(other.PhoneNumber);
            }

            if (Position == null)
            {
                Position = other.Position;
            }
            else if (other.Position != null)
            {
                Position.SetValue(other.Position);
            }

            if (ModalPreferences == null)
            {
                ModalPreferences = other.ModalPreferences;
            }
            else if (other.ModalPreferences != null)
            {
                ModalPreferences.SetValue(other.ModalPreferences);
            }

            if (AssistanceDecrease == null)
            {
                AssistanceDecrease = other.AssistanceDecrease;
            }
            else if (other.AssistanceDecrease != null)
            {
                AssistanceDecrease.SetValue(other.AssistanceDecrease);
            }
            Raise();
        }

        public Avikom.Types.Generic.UserProfile GetValue()
        {
            var proto = new Avikom.Types.Generic.UserProfile();
            proto.User = User?.GetValue() ?? proto.User;
            proto.Email = Email?.GetValue() ?? proto.Email;
            proto.Department = Department?.GetValue() ?? proto.Department;
            proto.PhoneNumber = PhoneNumber?.GetValue() ?? proto.PhoneNumber;
            proto.Position = Position?.GetValue() ?? proto.Position;
            proto.ModalPreferences = ModalPreferences?.GetValue() ?? proto.ModalPreferences;
            proto.AssistanceDecrease = AssistanceDecrease?.GetValue() ?? proto.AssistanceDecrease;
            return proto;
        }
    }

}
