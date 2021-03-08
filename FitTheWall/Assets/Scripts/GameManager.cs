using System;
using System.Collections;
using UnityEngine;

/// <summary>
/// Singleton class, responsible for the main game management:
/// Dispatching GameEvent's across other (Singleton) Manager classes;
/// </summary>
public class GameManager : MonoBehaviour
{
    // GameEvent Action, responsible for dispatching GameEvent's across other (Singleton) Manager classes
    public static Action<GameEvent> GameEventAction;
    
    // Start is called before the first frame update
    void Start()
    {
        // Invoke GameEvent loop, TEST PURPOSES ONLY
        StartCoroutine(LoopGameEvents());
    }

    // TODO Remove later, pls
    /// <summary>
    /// Dispatches a new GameEvent every 3 seconds
    /// </summary>
    /// <returns>IEnumerator Action</returns>
    private IEnumerator LoopGameEvents()
    {
        var lastGameEvent = GameEvent.START_GAME;
        while (true)
        {
            switch (lastGameEvent)
            {
                case GameEvent.START_GAME:
                    lastGameEvent = GameEvent.DIFFICULTY_HARDER;
                    break;
                case GameEvent.DIFFICULTY_HARDER:
                    lastGameEvent = GameEvent.START_GAME;
                    break;
            }
            GameEventAction?.Invoke(lastGameEvent);
            yield return new WaitForSeconds(3);
        }
    }
}
