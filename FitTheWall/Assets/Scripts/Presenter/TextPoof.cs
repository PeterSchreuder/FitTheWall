using UnityEngine;
using UnityEngine.UI;

namespace Presenter
{
    /// <summary>
    /// Class that will handle the poof animation of Presenter's text
    /// </summary>
    public class TextPoof : MonoBehaviour
    {
        // Name of poof animation in Animator
        [SerializeField] private string poofAnimationName;
        // Image component
        private Image _image;
        // Animator component
        private Animator _animator;

        /// <summary>
        /// Initialize Image & Animator
        /// </summary>
        private void Awake()
        {
            _image = GetComponent<Image>();
            _animator = GetComponent<Animator>();
        }

        /// <summary>
        /// Hide Poof on start
        /// </summary>
        private void Start()
        {
            HidePoof();
        }

        /// <summary>
        /// Show & play poof animation
        /// </summary>
        public void PlayPoof()
        {
            ShowPoof();
            _animator.Play(poofAnimationName);
        }

        /// <summary>
        /// When poof animation is finished, hide it
        /// </summary>
        public void OnPoofFinished()
        {
            HidePoof();
        }

        /// <summary>
        /// Hide poof animation
        /// </summary>
        private void HidePoof()
        {
            _animator.enabled = false;
            _image.color = new Color(1, 1, 1, 0);
        }
        
        /// <summary>
        /// Show poof animation
        /// </summary>
        private void ShowPoof()
        {
            _animator.enabled = true;
            _image.color = new Color(1, 1, 1, 1);
        }
    }
}
