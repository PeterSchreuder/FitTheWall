using System.Collections;
using TMPro;
using UnityEngine;

namespace Presenter
{
    /// <summary>
    /// This component, will handle the (Presenter's) text animation
    /// </summary>
    public class TextAnimation : MonoBehaviour
    {
        [SerializeField] private float textAnimDelay;
        // Text (cloud) poof animation
        private TextPoof _textPoof;
        // Speach text component
        private TMP_Text _speachText;

        /// <summary>
        /// Initialize components
        /// </summary>
        private void Awake()
        {
            _speachText = GetComponent<TMP_Text>();
            _textPoof = GetComponentInChildren<TextPoof>();
        }

        /// <summary>
        /// Play speach animation(s)
        /// </summary>
        /// <param name="text">to be spoken</param>
        public void PlayAnimation(string text)
        {
            _textPoof.PlayPoof();
            StartCoroutine(PlayTextAnimation(text));
        }
        
        /// <summary>
        /// Text characters animation
        /// </summary>
        /// <param name="text">to be animated</param>
        /// <returns>IEnumerator actions</returns>
        private IEnumerator PlayTextAnimation(string text)
        {
            for (var i = text.Length; i > 0; i--)
            {
                var toDisplay = text.Substring(0, text.Length - i);
                _speachText.text = toDisplay;
                yield return new WaitForSeconds(textAnimDelay);
            }
        }
    }
}
