
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Assistance
{

    /** Results of a previously conducted split procedure, analyzed by CASPA (https://doi.org/10.3389/fpsyg.2020.597913).
    @author Alexander Neumann <alneuman@techfak.uni-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Assistance/SplitProcedureResult")]
    public class SplitProcedureResult : GameEvent<SplitProcedureResult>, IGameEvent
    {
        public static Avikom.Types.Assistance.SplitProcedureResult TypeDefault = null;
        // investigated user
        public Avikom.UnityTypes.Generic.User User;

        // investigated task
        public Avikom.UnityTypes.Assistance.Task Task;

        // CASPA probability matrix
        public Avikom.UnityTypes.Math.FloatMatrix Matrix;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Assistance.SplitProcedureResult proto)
        {

            if (User == null) { User = ScriptableObject.CreateInstance<Avikom.UnityTypes.Generic.User>(); }
            if (proto.User != Avikom.UnityTypes.Generic.User.TypeDefault)
            {
                User.SetValue(proto.User);
            }

            if (Task == null) { Task = ScriptableObject.CreateInstance<Avikom.UnityTypes.Assistance.Task>(); }
            if (proto.Task != Avikom.UnityTypes.Assistance.Task.TypeDefault)
            {
                Task.SetValue(proto.Task);
            }

            if (Matrix == null) { Matrix = ScriptableObject.CreateInstance<Avikom.UnityTypes.Math.FloatMatrix>(); }
            if (proto.Matrix != Avikom.UnityTypes.Math.FloatMatrix.TypeDefault)
            {
                Matrix.SetValue(proto.Matrix);
            }
            Raise();
        }

        public void SetValue(SplitProcedureResult other)
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

            if (Task == null)
            {
                Task = other.Task;
            }
            else if (other.Task != null)
            {
                Task.SetValue(other.Task);
            }

            if (Matrix == null)
            {
                Matrix = other.Matrix;
            }
            else if (other.Matrix != null)
            {
                Matrix.SetValue(other.Matrix);
            }
            Raise();
        }

        public Avikom.Types.Assistance.SplitProcedureResult GetValue()
        {
            var proto = new Avikom.Types.Assistance.SplitProcedureResult();
            proto.User = User?.GetValue() ?? proto.User;
            proto.Task = Task?.GetValue() ?? proto.Task;
            proto.Matrix = Matrix?.GetValue() ?? proto.Matrix;
            return proto;
        }
    }

}
