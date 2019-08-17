using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    public List<GameObject> Obstacles;
    public int NumberOfObstacleSlots;
    public int ObstacleSpacing;
    public int ObstacleInitialOffset;
    public float SpawnChance;
    public float UpperSpawnHeight;
    public float LowerSpawnHeight;
    public bool SpawnCustomFirstSpot = false;

    // Start is called before the first frame update
    void Start()
    {
        if (SpawnCustomFirstSpot)
        {
            GameObject firstObstacle = Instantiate(Obstacles[Random.Range(0, Obstacles.Count)]);
            firstObstacle.transform.position = new Vector3(ObstacleSpacing, Random.Range(5f, 7f), 0);
        }
        for (int i = 0; i < NumberOfObstacleSlots; i++)
        {
            if (SpawnChance > Random.Range(0.0f, 1.0f))
            {
                GameObject go = Instantiate(Obstacles[Random.Range(0, Obstacles.Count)]);
                go.transform.position = new Vector3(i * ObstacleSpacing + ObstacleSpacing + ObstacleInitialOffset, Random.Range(LowerSpawnHeight, UpperSpawnHeight), 0);
            }
        }   
    }
}
