using UnityEngine;

namespace Messages
{
    /// <summary>
    /// ScriptableObject that holds (Presenter) Message data
    /// </summary>
    [CreateAssetMenu(fileName = "New Message", menuName = "(Presenter) Message")]
    public class Message : ScriptableObject
    {
        // Text
        // Variable, holding data
        [SerializeField]
        private string text;
        // Text, getter
        public string Text => text;
    
        // GameEvent
        // Variable, holding data
        [SerializeField]
        private GameEvent gameEvent;
        // GameEvent, getter
        public GameEvent GameEvent => gameEvent;
    }
}
