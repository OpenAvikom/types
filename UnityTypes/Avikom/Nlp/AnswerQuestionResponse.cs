
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Nlp
{

    /** This message is includes the response to the posed question and where in the context the answer was found.
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Nlp/AnswerQuestionResponse")]
    public class AnswerQuestionResponse : GameEvent<AnswerQuestionResponse>, IGameEvent
    {
        public static Avikom.Types.Nlp.AnswerQuestionResponse TypeDefault = null;
        // confidence between 0-1 that the correct answer was found
        public FloatVariable Score;

        // start position of answer in charactercount
        public IntVariable Start;

        // end position of answer in charactercount
        public IntVariable End;

        // the answer to the posed question is a text excerpt from the context
        public StringVariable Answer;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Nlp.AnswerQuestionResponse proto)
        {

            if (Score == null) { Score = ScriptableObject.CreateInstance<FloatVariable>(); }
            if (proto.Score != FloatVariable.TypeDefault)
            {
                Score.SetValue(proto.Score);
            }

            if (Start == null) { Start = ScriptableObject.CreateInstance<IntVariable>(); }
            if (proto.Start != IntVariable.TypeDefault)
            {
                Start.SetValue(proto.Start);
            }

            if (End == null) { End = ScriptableObject.CreateInstance<IntVariable>(); }
            if (proto.End != IntVariable.TypeDefault)
            {
                End.SetValue(proto.End);
            }

            if (Answer == null) { Answer = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Answer != StringVariable.TypeDefault)
            {
                Answer.SetValue(proto.Answer);
            }
            Raise();
        }

        public void SetValue(AnswerQuestionResponse other)
        {
            if (!other) { return; }

            if (Score == null)
            {
                Score = other.Score;
            }
            else if (other.Score != null)
            {
                Score.SetValue(other.Score);
            }

            if (Start == null)
            {
                Start = other.Start;
            }
            else if (other.Start != null)
            {
                Start.SetValue(other.Start);
            }

            if (End == null)
            {
                End = other.End;
            }
            else if (other.End != null)
            {
                End.SetValue(other.End);
            }

            if (Answer == null)
            {
                Answer = other.Answer;
            }
            else if (other.Answer != null)
            {
                Answer.SetValue(other.Answer);
            }
            Raise();
        }

        public Avikom.Types.Nlp.AnswerQuestionResponse GetValue()
        {
            var proto = new Avikom.Types.Nlp.AnswerQuestionResponse();
            proto.Score = Score?.GetValue() ?? proto.Score;
            proto.Start = Start?.GetValue() ?? proto.Start;
            proto.End = End?.GetValue() ?? proto.End;
            proto.Answer = Answer?.GetValue() ?? proto.Answer;
            return proto;
        }
    }

}
