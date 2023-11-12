
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
        public Avikom.UnityTypes.Generic.UserSet Include;

        // users that should not be eligible for that issue; only considered when include is empty
        public Avikom.UnityTypes.Generic.UserSet Exclude;

        // this is passed to camunda
        public Avikom.UnityTypes.Generic.KeyValuePairSet Parameters;

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

            if (Include == null) { Include = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.UserSet>(); }
            if (proto.Include.Count > 0)
            {
                Include.Clear();
                foreach (var value in proto.Include)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.User>();
                    tmp.SetValue(value);
                    Include.Add(tmp);
                }
                Include.Raise();
            }
        

            if (Exclude == null) { Exclude = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.UserSet>(); }
            if (proto.Exclude.Count > 0)
            {
                Exclude.Clear();
                foreach (var value in proto.Exclude)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.User>();
                    tmp.SetValue(value);
                    Exclude.Add(tmp);
                }
                Exclude.Raise();
            }
        

            if (Parameters == null) { Parameters = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.KeyValuePairSet>(); }
            if (proto.Parameters.Count > 0)
            {
                Parameters.Clear();
                foreach (var value in proto.Parameters)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.KeyValuePair>();
                    tmp.SetValue(value);
                    Parameters.Add(tmp);
                }
                Parameters.Raise();
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

            if (other.Include != null)
            {
                if (Include == null) { Include = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.UserSet>(); }
                Include.Clear();
                foreach (var elem in other.Include.Items)
                {
                    Include.Add(elem);
                }
                Include.Raise();
            }

            if (other.Exclude != null)
            {
                if (Exclude == null) { Exclude = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.UserSet>(); }
                Exclude.Clear();
                foreach (var elem in other.Exclude.Items)
                {
                    Exclude.Add(elem);
                }
                Exclude.Raise();
            }

            if (other.Parameters != null)
            {
                if (Parameters == null) { Parameters = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.KeyValuePairSet>(); }
                Parameters.Clear();
                foreach (var elem in other.Parameters.Items)
                {
                    Parameters.Add(elem);
                }
                Parameters.Raise();
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

            foreach (var value in Include.Items) { proto.Include.Add(value.GetValue()); }
                        

            foreach (var value in Exclude.Items) { proto.Exclude.Add(value.GetValue()); }
                        

            foreach (var value in Parameters.Items) { proto.Parameters.Add(value.GetValue()); }
                        
            proto.Status = Status?.GetValue() ?? proto.Status;
            return proto;
        }
    }

}
