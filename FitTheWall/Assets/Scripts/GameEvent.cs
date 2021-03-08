/// <summary>
/// Enum that indicates specific event, that will happen during the game(play)
/// </summary>
public enum GameEvent
{
    // Indicates that difficulty increases
    DIFFICULTY_HARDER,
    // Indicates player is from OUT_PLAY_FIELD -> IN_PLAY_FIELD
    PLAYER_IN_PLAY_FIELD,
    // Indicates player is from IN_PLAY_FIELD -> OUT_PLAY_FIELD
    PLAYER_OUT_PLAY_FIELD,
    // Indicates player makes a fail (not matching silhouette)
    PLAYER_FAIL_OBJECTIVE,
    // Indicates player scores a point (matching silhouette)
    PLAYER_SUCCESS_OBJECTIVE,
    // Indicates game is over
    GAME_OVER,
    // Indicates game starts
    START_GAME
}
