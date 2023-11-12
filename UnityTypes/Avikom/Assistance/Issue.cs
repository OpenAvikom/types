
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** An message that contains informations about (postponed) tasks and their state.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/Issue")]
    public class Issue : GameEvent<Issue>, IGameEvent
    {
        public static Avikom.Types.Assistance.Issue TypeDefault = null;
        // id of a task; must be set for creation!
        public StringVariable Id;

        // who issued the task
        public Avikom.UnityTypes.Generic.User Issuer;

        // an optional text message
        public StringVariable Description;

        // location where the task needs to be conducted
        public Avikom.UnityTypes.Assistance.Scene Scene;

        // the task to be done
        public Avikom.UnityTypes.Assistance.Task Task;

        // users that are eligible for that task
        public Avikom.UnityTypes.Generic.User Include;

        // users that should not be eligible for that issue; only considered when include is empty
        public Avikom.UnityTypes.Generic.User Exclude;

        // this is passed to camunda
        public Avikom.UnityTypes.Generic.KeyValuePair Parameters;

        // status of the issue
        public Avikom.UnityTypes.Assistance.IssueStatus Status;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.Issue proto)
        {

            if (Id == null) { Id = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Id != StringVariable.TypeDefault)
            {
                Id.SetValue(proto.Id);
            }

            if (Issuer == null) { Issuer = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.User>(); }
            if (proto.Issuer != Avikom.UnityTypes.Generic.User.TypeDefault)
            {
                Issuer.SetValue(proto.Issuer);
            }

            if (Description == null) { Description = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Description != StringVariable.TypeDefault)
            {
                Description.SetValue(proto.Description);
            }

            if (Scene == null) { Scene = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.Scene>(); }
            if (proto.Scene != Avikom.UnityTypes.Assistance.Scene.TypeDefault)
            {
                Scene.SetValue(proto.Scene);
            }

            if (Task == null) { Task = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.Task>(); }
            if (proto.Task != Avikom.UnityTypes.Assistance.Task.TypeDefault)
            {
                Task.SetValue(proto.Task);
            }

            if (Include == null) { Include = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.User>(); }
            if (proto.Include != Avikom.UnityTypes.Generic.User.TypeDefault)
            {
                Include.SetValue(proto.Include);
            }

            if (Exclude == null) { Exclude = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.User>(); }
            if (proto.Exclude != Avikom.UnityTypes.Generic.User.TypeDefault)
            {
                Exclude.SetValue(proto.Exclude);
            }

            if (Parameters == null) { Parameters = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.KeyValuePair>(); }
            if (proto.Parameters != Avikom.UnityTypes.Generic.KeyValuePair.TypeDefault)
            {
                Parameters.SetValue(proto.Parameters);
            }

            if (Status == null) { Status = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.IssueStatus>(); }
            if (proto.Status != Avikom.UnityTypes.Assistance.IssueStatus.TypeDefault)
            {
                Status.SetValue(proto.Status);
            }
            Raise();
        }

        public void SetValue(Issue other)
        {
            if (!other) { return; }

            if (Id == null)
            {
                Id = other.Id;
            }
            else if (other.Id != null)
            {
                Id.SetValue(other.Id);
            }

            if (Issuer == null)
            {
                Issuer = other.Issuer;
            }
            else if (other.Issuer != null)
            {
                Issuer.SetValue(other.Issuer);
            }

            if (Description == null)
            {
                Description = other.Description;
            }
            else if (other.Description != null)
            {
                Description.SetValue(other.Description);
            }

            if (Scene == null)
            {
                Scene = other.Scene;
            }
            else if (other.Scene != null)
            {
                Scene.SetValue(other.Scene);
            }

            if (Task == null)
            {
                Task = other.Task;
            }
            else if (other.Task != null)
            {
                Task.SetValue(other.Task);
            }

            if (Include == null)
            {
                Include = other.Include;
            }
            else if (other.Include != null)
            {
                Include.SetValue(other.Include);
            }

            if (Exclude == null)
            {
                Exclude = other.Exclude;
            }
            else if (other.Exclude != null)
            {
                Exclude.SetValue(other.Exclude);
            }

            if (Parameters == null)
            {
                Parameters = other.Parameters;
            }
            else if (other.Parameters != null)
            {
                Parameters.SetValue(other.Parameters);
            }

            if (Status == null)
            {
                Status = other.Status;
            }
            else if (other.Status != null)
            {
                Status.SetValue(other.Status);
            }
            Raise();
        }

        public Avikom.Types.Assistance.Issue GetValue()
        {
            var proto = new Avikom.Types.Assistance.Issue();
            proto.Id = Id?.GetValue() ?? proto.Id;
            proto.Issuer = Issuer?.GetValue() ?? proto.Issuer;
            proto.Description = Description?.GetValue() ?? proto.Description;
            proto.Scene = Scene?.GetValue() ?? proto.Scene;
            proto.Task = Task?.GetValue() ?? proto.Task;
            proto.Include = Include?.GetValue() ?? proto.Include;
            proto.Exclude = Exclude?.GetValue() ?? proto.Exclude;
            proto.Parameters = Parameters?.GetValue() ?? proto.Parameters;
            proto.Status = Status?.GetValue() ?? proto.Status;
            return proto;
        }
    }

}
