using UnityEngine;

namespace Presenter
{
    /// <summary>
    /// ScriptableObject that holds Presenter Animation data
    /// </summary>
    [CreateAssetMenu(fileName = "New Presenter Animation", menuName = "Presenter Animation")]
    public class PresenterAnimation : ScriptableObject
    {
        // Animation Clip
        // Variable, holding data
        [SerializeField]
        private AnimationClip animationClip;
        // AnimationClip, getter
        public AnimationClip AnimationClip => animationClip;
    
        // GameEvent
        // Variable, holding data
        [SerializeField]
        private GameEvent gameEvent;
        // GameEvent, getter
        public GameEvent GameEvent => gameEvent;
    }
}
