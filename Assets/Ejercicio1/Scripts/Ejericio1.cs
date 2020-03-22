using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejericio1 : MonoBehaviour
{
    GameObject prefabObstacle;
    int n;

    //a)

    GameObject SpawnObstacle()
    {
        GameObject obstacle = Instantiate(prefabObstacle);    

        return obstacle;
    }

    //b)

    void SpawnObstacle2()
    {
        Instantiate(prefabObstacle);
    }

    //c)

    void Starter()
    {
        int x = 5;
        int y = 3;

        Vector2 position;
        position.x = x;
        position.y = y;

        SpawnObstacleIn(position);
    }

    void SpawnObstacleIn(Vector2 position)
    {
        Instantiate(prefabObstacle, position, Quaternion.identity);
    }

    //d)

    void Start()
    {
        SpawnObstacles(5);
    }

    void SpawnObstacles(int number)
    {
        for(int i = 0; i < n; i++)
        {
            Instantiate(prefabObstacle);
        }
    }
}
