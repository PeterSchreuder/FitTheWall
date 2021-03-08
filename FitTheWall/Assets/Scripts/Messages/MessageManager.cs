using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Messages
{
    /// <summary>
    /// This singleton class, will manage all of our (ScriptableObject) messages.
    /// Other classes can use this class to get a specific/random message, that fits their need.
    /// </summary>
    public class MessageManager : MonoBehaviour
    {

        // Instance of MessageManager
        // Variable, holding data
        private static MessageManager _instance;
        // MessageManager Instance, getter
        public static MessageManager Instance => _instance;
    
        // Message (ScriptableObjects) array
        [SerializeField] private Message[] messages;

        /// <summary>
        /// Set instance to this, when MessageManager gets enabled
        /// </summary>
        private void OnEnable()
        {
            _instance = this;
        }

        /// <summary>
        /// Set instance to null, when MessageManager gets disabled
        /// </summary>
        private void OnDisable()
        {
            _instance = null;
        }

        /// <summary>
        /// Get a random Message (ScriptableObjects), by GameEvent
        /// </summary>
        /// <param name="gameEvent">GameEvent that will match retrieved Message</param>
        /// <returns>Message (ScriptableObject)</returns>
        public Message GetRandomMessageByGameEvent(GameEvent gameEvent)
        {
            var eventMessages = messages.Where(message => message.GameEvent == gameEvent).ToList();
            return eventMessages.Count == 0 ? null : eventMessages[Random.Range(0, eventMessages.Count)];
        }
    }
}
