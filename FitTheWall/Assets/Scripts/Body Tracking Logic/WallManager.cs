using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    List<GameObject> wallList;

    [SerializeField]
    private DifficultyObject[] difficulties;
    private DifficultyObject currentDifficulty;

    void Start()
    {
        //sets normal difficulty as default
        setDifficulty(DifficultyType.Normal);
    }

    void Update()
    {
        //logic to continously spawn walls here
    }

    public void setDifficulty(DifficultyType difficulty)
    {
        for(int i = 0; i < difficulties.Length; i++)
        {
            currentDifficulty = difficulty == (DifficultyType)i ? difficulties[i] : currentDifficulty;
        }
    }

    void spawnRandomWallFromList(List<GameObject> wallList, float jointPointDistanceMargin, float wallSpeed)
    {
        //logic to spawn wall here
    }


}
