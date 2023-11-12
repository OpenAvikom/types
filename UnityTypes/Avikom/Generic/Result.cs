
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Generic
{

    /** A message to provide feedback about sucessful or failed remote procedure calls
     @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Generic/Result")]
    public class Result : GameEvent<Result>, IGameEvent
    {
        public static Avikom.Types.Generic.Result TypeDefault = null;
        // true if sucessful, false otherwise
        public BoolVariable Success;

        // additional semantic information; specifying what went wrong or communicate results of successful operations
        public StringVariable Message;

        // specifies the type of error that occured; will only be set if success is false
        public Avikom.UnityTypes.Generic.ErrorCode Error;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Generic.Result proto)
        {

            if (Success == null) { Success = ScriptableObject.CreateInstance<BoolVariable>(); }
            if (true)
            {
                Success.SetValue(proto.Success);
            }

            if (Message == null) { Message = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Message != StringVariable.TypeDefault)
            {
                Message.SetValue(proto.Message);
            }

            if (Error == null) { Error = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.ErrorCode>(); }
            if (proto.Error != Avikom.UnityTypes.Generic.ErrorCode.TypeDefault)
            {
                Error.SetValue(proto.Error);
            }
            Raise();
        }

        public void SetValue(Result other)
        {
            if (!other) { return; }

            if (Success == null)
            {
                Success = other.Success;
            }
            else if (other.Success != null)
            {
                Success.SetValue(other.Success);
            }

            if (Message == null)
            {
                Message = other.Message;
            }
            else if (other.Message != null)
            {
                Message.SetValue(other.Message);
            }

            if (Error == null)
            {
                Error = other.Error;
            }
            else if (other.Error != null)
            {
                Error.SetValue(other.Error);
            }
            Raise();
        }

        public Avikom.Types.Generic.Result GetValue()
        {
            var proto = new Avikom.Types.Generic.Result();
            proto.Success = Success?.GetValue() ?? proto.Success;
            proto.Message = Message?.GetValue() ?? proto.Message;
            proto.Error = Error?.GetValue() ?? proto.Error;
            return proto;
        }
    }

}
