
using UnityEngine;
using Avikom.UnityAssets.Variables;
using Avikom.UnityAssets.Sets;
using Avikom.UnityAssets.Events;
using Google.Protobuf;


namespace Avikom.UnityTypes.Nlp
{

    /** This message is used to ask a question to be answered on the basis of the context.
     @author: Lars Schalkwijk <lars.schalkwijk@fh-bielefeld.de> */
    [CreateAssetMenu(menuName = "Avikom/Nlp/AnswerQuestionQuery")]
    public class AnswerQuestionQuery : GameEvent<AnswerQuestionQuery>, IGameEvent
    {
        public static Avikom.Types.Nlp.AnswerQuestionQuery TypeDefault = null;
        // this text string should contain the answer to the question
        public StringVariable Context;

        // the question you would like to find an answer to in the context
        public StringVariable Question;


        public void Raise()
        {
            Raise(this);
        }

        public void SetValue(Avikom.Types.Nlp.AnswerQuestionQuery proto)
        {

            if (Context == null) { Context = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Context != StringVariable.TypeDefault)
            {
                Context.SetValue(proto.Context);
            }

            if (Question == null) { Question = ScriptableObject.CreateInstance<StringVariable>(); }
            if (proto.Question != StringVariable.TypeDefault)
            {
                Question.SetValue(proto.Question);
            }
            Raise();
        }

        public void SetValue(AnswerQuestionQuery other)
        {
            if (!other) { return; }

            if (Context == null)
            {
                Context = other.Context;
            }
            else if (other.Context != null)
            {
                Context.SetValue(other.Context);
            }

            if (Question == null)
            {
                Question = other.Question;
            }
            else if (other.Question != null)
            {
                Question.SetValue(other.Question);
            }
            Raise();
        }

        public Avikom.Types.Nlp.AnswerQuestionQuery GetValue()
        {
            var proto = new Avikom.Types.Nlp.AnswerQuestionQuery();
            proto.Context = Context?.GetValue() ?? proto.Context;
            proto.Question = Question?.GetValue() ?? proto.Question;
            return proto;
        }
    }

}
