using System.Linq;
using Messages;
using UnityEngine;

namespace Presenter
{
    /// <summary>
    /// This class is responsible for the presenter logic:
    /// Displaying messages;
    /// Showing presenter animations;
    /// </summary>
    public class Presenter : MonoBehaviour
    {
        // Array of PresenterAnimation(s) (ScriptableObject(s))
        [SerializeField] private PresenterAnimation[] presenterAnimations;
        // Animator component
        private Animator _animator;
        // Text animation component
        private TextAnimation _textAnimation;

        /// <summary>
        /// Initialize components;
        /// Register listener function to GameManager's GameEventAction
        /// </summary>
        void Awake()
        {
            _animator = GetComponent<Animator>();
            _textAnimation = GetComponentInChildren<TextAnimation>();
            GameManager.GameEventAction += OnGameEventDispatched;
        }

        /// <summary>
        /// Listener, listening to GameManager's GameEventAction.
        /// Will be called when that (GameManager's) GameEventAction is dispatched.
        /// </summary>
        /// <param name="gameEvent">To indicate which GameEvent is dispatched</param>
        private void OnGameEventDispatched(GameEvent gameEvent)
        {
            DisplayMessageByGameEvent(gameEvent);
            // DisplayPresenterAnimationByGameEvent(gameEvent);
        }
        
        /// <summary>
        /// Display presenter message, by GameEvent
        /// </summary>
        /// <param name="gameEvent">Passed to match message</param>
        /// <returns>boolean, whether displaying message was a success</returns>
        private bool DisplayMessageByGameEvent(GameEvent gameEvent)
        {
            var messageManager = MessageManager.Instance;
            if (messageManager == null) return false;
            var message = messageManager.GetRandomMessageByGameEvent(gameEvent);
            if (message == null) return false;
            _textAnimation.PlayAnimation(message.Text);
            return true;
        }

        /// <summary>
        /// Display presenter animation, by GameEvent
        /// </summary>
        /// <param name="gameEvent">Passed to match PresenterAnimation</param>
        /// <returns>boolean, whether displaying message was a success</returns>
        private bool DisplayPresenterAnimationByGameEvent(GameEvent gameEvent)
        {
            var presenterAnimation = GetRandomPresenterAnimationByGameEvent(gameEvent);
            // Return false if there is no 'presenter animation', to be played
            if (presenterAnimation == null) return false;
            _animator.Play(presenterAnimation.AnimationClip.name);
            return true;
        }
        
        /// <summary>
        /// Get a random PresenterAnimation, by GameEvent
        /// </summary>
        /// <param name="gameEvent">Passed to match PresenterAnimation</param>
        /// <returns>PresenterAnimation that matches passed GameEvent</returns>
        private PresenterAnimation GetRandomPresenterAnimationByGameEvent(GameEvent gameEvent)
        {
            var eventMessages = presenterAnimations.Where(presenterAnimation => presenterAnimation.GameEvent == gameEvent).ToList();
            return eventMessages.Count == 0 ? null : eventMessages[Random.Range(0, eventMessages.Count)];
        }
    }
}
