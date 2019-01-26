using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBeltController : MonoBehaviour
{
    private List<GameObject> prefabList = new List<GameObject>();  //List for holding asteroid prefabs
    public GameObject asteroid1;
    public GameObject asteroid2;
    public GameObject asteroid3;

    public int numberOfAsteroids;
    public float radius;


    void Start()
    {
        prefabList.Add(asteroid1);
        prefabList.Add(asteroid2);
        prefabList.Add(asteroid3);

        for (int i = 0; i < numberOfAsteroids; i++)
        {
            int randomIndex = Random.Range(0, 3);

            float angle = i * Mathf.PI * 2 / numberOfAsteroids;
            Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * 50;
            Instantiate(prefabList[randomIndex], pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
