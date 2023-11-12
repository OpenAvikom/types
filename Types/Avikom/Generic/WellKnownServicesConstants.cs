namespace Avikom.Constants.Generic {
    // Well-known service topics.
    public class WellKnownServices
    {
        // Provides speech recognition input
        public const string ServiceSpeechRecognition = "ServiceSpeechRecognition";

        // Provides character-/text-recognition
        public const string ServiceOcr = "ServiceOcr";

        // Offers number input to users; may be implemented via different methods (e.g. speech or keyboard)
        public const string ServiceNumberInput = "ServiceNumberInput";

        // Offers text input to users
        public const string ServiceTextInput = "ServiceTextInput";

        // Triggers an event when a location has been reached (X)OR left
        public const string ServiceLocationEvent = "ServiceLocationEvent";
    }
}
