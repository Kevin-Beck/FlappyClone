using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    public List<GameObject> Obstacles;
    public int NumberOfObstacles;
    public int ObstacleSpacing;

    // Start is called before the first frame update
    void Start()
    {
        GameObject firstObstacle = Instantiate(Obstacles[Random.Range(0, Obstacles.Count)]);
        firstObstacle.transform.position = new Vector3(ObstacleSpacing, Random.Range(5, 7), 0);
        for (int i = 0; i < NumberOfObstacles; i++)
        {
            GameObject go = Instantiate(Obstacles[Random.Range(0, Obstacles.Count)]);
            go.transform.position = new Vector3(i * ObstacleSpacing + ObstacleSpacing * 2, Random.Range(2, 10), 0);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
