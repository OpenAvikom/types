
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** This message describes a specific Task which can include several task steps.
     A task may be conducted in several locations (scenes). 
     @author: Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/Task")]
    public class Task : GameEvent<Task>, IGameEvent
    {
        public static Avikom.Types.Assistance.Task TypeDefault = null;
        // globally unique name of the task
        public StringVariable Name;

        // steps assigned to this task; steps do not need to be exclusive to a task; steps do not need to be mentioned here to be triggered by tge BPM engine
        public Avikom.UnityTypes.Assistance.TaskStepSet Steps;

        // a brief description of the current task (roughly 1-3 sentences max).
        public StringVariable Summary;

        // a more detailled description of the task at hand
        public StringVariable Description;

        // name of the BPM process that describes this task
        public StringVariable Process;

        // variables passed to the process
        public Avikom.UnityTypes.Generic.KeyValuePairSet ProcessParameters;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.Task proto)
        {

            if (Name == null) { Name = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Name != StringVariable.TypeDefault)
            {
                Name.SetValue(proto.Name);
            }

            if (Steps == null) { Steps = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.TaskStepSet>(); }
            if (proto.Steps.Count > 0)
            {
                Steps.Clear();
                foreach (var value in proto.Steps)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.TaskStep>();
                    tmp.SetValue(value);
                    Steps.Add(tmp);
                }
                Steps.Raise();
            }
        

            if (Summary == null) { Summary = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Summary != StringVariable.TypeDefault)
            {
                Summary.SetValue(proto.Summary);
            }

            if (Description == null) { Description = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Description != StringVariable.TypeDefault)
            {
                Description.SetValue(proto.Description);
            }

            if (Process == null) { Process = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Process != StringVariable.TypeDefault)
            {
                Process.SetValue(proto.Process);
            }

            if (ProcessParameters == null) { ProcessParameters = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.KeyValuePairSet>(); }
            if (proto.ProcessParameters.Count > 0)
            {
                ProcessParameters.Clear();
                foreach (var value in proto.ProcessParameters)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.KeyValuePair>();
                    tmp.SetValue(value);
                    ProcessParameters.Add(tmp);
                }
                ProcessParameters.Raise();
            }
        
            Raise();
        }

        public void SetValue(Task other)
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

            if (other.Steps != null)
            {
                if (Steps == null) { Steps = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.TaskStepSet>(); }
                Steps.Clear();
                foreach (var elem in other.Steps.Items)
                {
                    Steps.Add(elem);
                }
                Steps.Raise();
            }

            if (Summary == null)
            {
                Summary = other.Summary;
            }
            else if (other.Summary != null)
            {
                Summary.SetValue(other.Summary);
            }

            if (Description == null)
            {
                Description = other.Description;
            }
            else if (other.Description != null)
            {
                Description.SetValue(other.Description);
            }

            if (Process == null)
            {
                Process = other.Process;
            }
            else if (other.Process != null)
            {
                Process.SetValue(other.Process);
            }

            if (other.ProcessParameters != null)
            {
                if (ProcessParameters == null) { ProcessParameters = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.KeyValuePairSet>(); }
                ProcessParameters.Clear();
                foreach (var elem in other.ProcessParameters.Items)
                {
                    ProcessParameters.Add(elem);
                }
                ProcessParameters.Raise();
            }
            Raise();
        }

        public Avikom.Types.Assistance.Task GetValue()
        {
            var proto = new Avikom.Types.Assistance.Task();
            proto.Name = Name?.GetValue() ?? proto.Name;

            foreach (var value in Steps.Items) { proto.Steps.Add(value.GetValue()); }
                        
            proto.Summary = Summary?.GetValue() ?? proto.Summary;
            proto.Description = Description?.GetValue() ?? proto.Description;
            proto.Process = Process?.GetValue() ?? proto.Process;

            foreach (var value in ProcessParameters.Items) { proto.ProcessParameters.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}
