
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Camunda
{

    /** A storable representation of an external task published by the BPM engine (Camunda).
     The field description has been derived from the official REST-API documentation.
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Camunda/ExternalTask")]
    public class ExternalTask : GameEvent<ExternalTask>, IGameEvent
    {
        public static Avikom.Types.Camunda.ExternalTask TypeDefault = null;
        // id of the activity that this external task belongs to
        public StringVariable ActivityId;

        // id of the activity instance that the external task belongs to
        public StringVariable ActivityInstanceId;

        // error message that was supplied when the last failure of this task was reported
        public StringVariable ErrorMessage;

        // id of the execution that the external task belongs to
        public StringVariable ExecutionId;

        // external task's id
        public StringVariable Id;

        // date that the task's most recent lock expires or has expired
        public StringVariable LockExpirationTime;

        // id of the process definition the external task is defined in
        public StringVariable ProcessDefinitionId;

        // key of the process definition the external task is defined in
        public StringVariable ProcessDefinitionKey;

        // id of the process instance the external task belongs to
        public StringVariable ProcessInstanceId;

        // id of the tenant the external task belongs to
        public StringVariable TenantId;

        // number of retries the task currently has left
        public IntVariable Retries;

        // id of the worker that posesses or posessed the most recent lock
        public StringVariable WorkerId;

        // priority of the external task
        public IntVariable Priority;

        // external task's topic name
        public StringVariable TopicName;

        // a set of local and global variables passed to the external service
        public Avikom.UnityTypes.Camunda.VariableSet Variables;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Camunda.ExternalTask proto)
        {

            if (ActivityId == null) { ActivityId = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.ActivityId != StringVariable.TypeDefault)
            {
                ActivityId.SetValue(proto.ActivityId);
            }

            if (ActivityInstanceId == null) { ActivityInstanceId = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.ActivityInstanceId != StringVariable.TypeDefault)
            {
                ActivityInstanceId.SetValue(proto.ActivityInstanceId);
            }

            if (ErrorMessage == null) { ErrorMessage = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.ErrorMessage != StringVariable.TypeDefault)
            {
                ErrorMessage.SetValue(proto.ErrorMessage);
            }

            if (ExecutionId == null) { ExecutionId = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.ExecutionId != StringVariable.TypeDefault)
            {
                ExecutionId.SetValue(proto.ExecutionId);
            }

            if (Id == null) { Id = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Id != StringVariable.TypeDefault)
            {
                Id.SetValue(proto.Id);
            }

            if (LockExpirationTime == null) { LockExpirationTime = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.LockExpirationTime != StringVariable.TypeDefault)
            {
                LockExpirationTime.SetValue(proto.LockExpirationTime);
            }

            if (ProcessDefinitionId == null) { ProcessDefinitionId = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.ProcessDefinitionId != StringVariable.TypeDefault)
            {
                ProcessDefinitionId.SetValue(proto.ProcessDefinitionId);
            }

            if (ProcessDefinitionKey == null) { ProcessDefinitionKey = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.ProcessDefinitionKey != StringVariable.TypeDefault)
            {
                ProcessDefinitionKey.SetValue(proto.ProcessDefinitionKey);
            }

            if (ProcessInstanceId == null) { ProcessInstanceId = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.ProcessInstanceId != StringVariable.TypeDefault)
            {
                ProcessInstanceId.SetValue(proto.ProcessInstanceId);
            }

            if (TenantId == null) { TenantId = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.TenantId != StringVariable.TypeDefault)
            {
                TenantId.SetValue(proto.TenantId);
            }

            if (Retries == null) { Retries = ScriptableObject.CreateInstance<IntVariable>(); }
            if (proto.Retries != IntVariable.TypeDefault)
            {
                Retries.SetValue(proto.Retries);
            }

            if (WorkerId == null) { WorkerId = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.WorkerId != StringVariable.TypeDefault)
            {
                WorkerId.SetValue(proto.WorkerId);
            }

            if (Priority == null) { Priority = ScriptableObject.CreateInstance<IntVariable>(); }
            if (proto.Priority != IntVariable.TypeDefault)
            {
                Priority.SetValue(proto.Priority);
            }

            if (TopicName == null) { TopicName = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.TopicName != StringVariable.TypeDefault)
            {
                TopicName.SetValue(proto.TopicName);
            }

            if (Variables == null) { Variables = ScriptableObject.CreateInstance<Avikom.UnityTypes.Camunda.VariableSet>(); }
            if (proto.Variables.Count > 0)
            {
                Variables.Clear();
                foreach (var value in proto.Variables)
                {
                    var tmp = ScriptableObject.CreateInstance<Avikom.UnityTypes.Camunda.Variable>();
                    tmp.SetValue(value);
                    Variables.Add(tmp);
                }
                Variables.Raise();
            }
        
            Raise();
        }

        public void SetValue(ExternalTask other)
        {
            if (!other) { return; }

            if (ActivityId == null)
            {
                ActivityId = other.ActivityId;
            }
            else if (other.ActivityId != null)
            {
                ActivityId.SetValue(other.ActivityId);
            }

            if (ActivityInstanceId == null)
            {
                ActivityInstanceId = other.ActivityInstanceId;
            }
            else if (other.ActivityInstanceId != null)
            {
                ActivityInstanceId.SetValue(other.ActivityInstanceId);
            }

            if (ErrorMessage == null)
            {
                ErrorMessage = other.ErrorMessage;
            }
            else if (other.ErrorMessage != null)
            {
                ErrorMessage.SetValue(other.ErrorMessage);
            }

            if (ExecutionId == null)
            {
                ExecutionId = other.ExecutionId;
            }
            else if (other.ExecutionId != null)
            {
                ExecutionId.SetValue(other.ExecutionId);
            }

            if (Id == null)
            {
                Id = other.Id;
            }
            else if (other.Id != null)
            {
                Id.SetValue(other.Id);
            }

            if (LockExpirationTime == null)
            {
                LockExpirationTime = other.LockExpirationTime;
            }
            else if (other.LockExpirationTime != null)
            {
                LockExpirationTime.SetValue(other.LockExpirationTime);
            }

            if (ProcessDefinitionId == null)
            {
                ProcessDefinitionId = other.ProcessDefinitionId;
            }
            else if (other.ProcessDefinitionId != null)
            {
                ProcessDefinitionId.SetValue(other.ProcessDefinitionId);
            }

            if (ProcessDefinitionKey == null)
            {
                ProcessDefinitionKey = other.ProcessDefinitionKey;
            }
            else if (other.ProcessDefinitionKey != null)
            {
                ProcessDefinitionKey.SetValue(other.ProcessDefinitionKey);
            }

            if (ProcessInstanceId == null)
            {
                ProcessInstanceId = other.ProcessInstanceId;
            }
            else if (other.ProcessInstanceId != null)
            {
                ProcessInstanceId.SetValue(other.ProcessInstanceId);
            }

            if (TenantId == null)
            {
                TenantId = other.TenantId;
            }
            else if (other.TenantId != null)
            {
                TenantId.SetValue(other.TenantId);
            }

            if (Retries == null)
            {
                Retries = other.Retries;
            }
            else if (other.Retries != null)
            {
                Retries.SetValue(other.Retries);
            }

            if (WorkerId == null)
            {
                WorkerId = other.WorkerId;
            }
            else if (other.WorkerId != null)
            {
                WorkerId.SetValue(other.WorkerId);
            }

            if (Priority == null)
            {
                Priority = other.Priority;
            }
            else if (other.Priority != null)
            {
                Priority.SetValue(other.Priority);
            }

            if (TopicName == null)
            {
                TopicName = other.TopicName;
            }
            else if (other.TopicName != null)
            {
                TopicName.SetValue(other.TopicName);
            }

            if (other.Variables != null)
            {
                if (Variables == null) { Variables = ScriptableObject.CreateInstance<Avikom.UnityTypes.Camunda.VariableSet>(); }
                Variables.Clear();
                foreach (var elem in other.Variables.Items)
                {
                    Variables.Add(elem);
                }
                Variables.Raise();
            }
            Raise();
        }

        public Avikom.Types.Camunda.ExternalTask GetValue()
        {
            var proto = new Avikom.Types.Camunda.ExternalTask();
            proto.ActivityId = ActivityId?.GetValue() ?? proto.ActivityId;
            proto.ActivityInstanceId = ActivityInstanceId?.GetValue() ?? proto.ActivityInstanceId;
            proto.ErrorMessage = ErrorMessage?.GetValue() ?? proto.ErrorMessage;
            proto.ExecutionId = ExecutionId?.GetValue() ?? proto.ExecutionId;
            proto.Id = Id?.GetValue() ?? proto.Id;
            proto.LockExpirationTime = LockExpirationTime?.GetValue() ?? proto.LockExpirationTime;
            proto.ProcessDefinitionId = ProcessDefinitionId?.GetValue() ?? proto.ProcessDefinitionId;
            proto.ProcessDefinitionKey = ProcessDefinitionKey?.GetValue() ?? proto.ProcessDefinitionKey;
            proto.ProcessInstanceId = ProcessInstanceId?.GetValue() ?? proto.ProcessInstanceId;
            proto.TenantId = TenantId?.GetValue() ?? proto.TenantId;
            proto.Retries = Retries?.GetValue() ?? proto.Retries;
            proto.WorkerId = WorkerId?.GetValue() ?? proto.WorkerId;
            proto.Priority = Priority?.GetValue() ?? proto.Priority;
            proto.TopicName = TopicName?.GetValue() ?? proto.TopicName;

            foreach (var value in Variables.Items) { proto.Variables.Add(value.GetValue()); }
                        
            return proto;
        }
    }

}
