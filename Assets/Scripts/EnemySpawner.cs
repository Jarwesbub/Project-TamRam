//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int Class1SpawnNumb = 0;
    public int Class2SpawnNumb = 0;
    public int Class3SpawnNumb = 0;

    public int NewSpawnNumb = 0;
    int SpawnNumb;
    int ValueReset = 0;
    //public int ClassNumb = 1;

    // Values where Spawner will spawn enemies
    float minPosX;
    float maxPosX;
    float minPosY;
    float maxPosY;
    
    // Values for Map 1
    public float map1minX;
    public float map1maxX;
    public float map1minY;
    public float map1maxY;
    
    // Values for Map 2
    public float map2minX;
    public float map2maxX;
    public float map2minY;
    public float map2maxY;

    // Values for Map 3
    public float map3minX;
    public float map3maxX;
    public float map3minY;
    public float map3maxY;

    // Values for Map 4
    public float map4minX;
    public float map4maxX;
    public float map4minY;
    public float map4maxY;

    // Values for Map 5
    public float map5minX;
    public float map5maxX;
    public float map5minY;
    public float map5maxY;

    public float map6minX;
    public float map6maxX;
    public float map6minY;
    public float map6maxY;


    //float RandomX = 0f;
    //float RandomY = 0f;

    //public GameObject parentObject;

    public GameObject Map2parentObject;
    public GameObject Map3parentObject;
    public GameObject Map4parentObject;
    public GameObject Map5parentObject;

    public GameObject EnemyClass1;
    public GameObject EnemyClass2;
    public GameObject EnemyClass3;

    //public bool Check = false;


    // Start is called before the first frame update
    void Start()
    {
        PersistentManagerScript.Instance.WorldMapPos = 1;
        //NewSpawnNumb = 100; // TESTING
        NewSpawnNumb = 100;
    }

    // Update is called once per frame
    void Update()
    {


        if (PersistentManagerScript.Instance.MapChange == true)
        {

                for (int i = 0; i < Map2parentObject.transform.childCount; i++)
                {
                    Destroy(Map2parentObject.transform.GetChild(i).gameObject);
                }

                for (int i = 0; i < Map3parentObject.transform.childCount; i++)
                {
                    Destroy(Map3parentObject.transform.GetChild(i).gameObject);
                }

                for (int i = 0; i < Map4parentObject.transform.childCount; i++)
                {
                    Destroy(Map4parentObject.transform.GetChild(i).gameObject);
                }

                for (int i = 0; i < Map5parentObject.transform.childCount; i++)
                {
                    Destroy(Map5parentObject.transform.GetChild(i).gameObject);
                }



            SpawnNumb = 0;
            PersistentManagerScript.Instance.MapChange = false;
        }

        


        // CHEAT BUTTON
        if (Input.GetKeyDown("r"))
        {
            NewSpawnNumb += 10;
        }
        if (Input.GetKeyDown("p"))
        {
            PersistentManagerScript.Instance.WorldMapPos += 1;
            PersistentManagerScript.Instance.MapChange = true;
        }
        if (Input.GetKeyDown("o"))
        {
            PersistentManagerScript.Instance.WorldMapPos -= 1;
            PersistentManagerScript.Instance.MapChange = true;

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        if (PersistentManagerScript.Instance.WorldMapPos == 2)
        {
            for (int i = SpawnNumb; i < 50; i++) // Enemy Class 2 in Map 2
            {

                {
                    //var ClassNumb = 2;

                    var RandomX = Random.Range(map2minX, map2maxX);
                    var RandomY = Random.Range(map2minY, map2maxY);

                    var Enemy = Instantiate(EnemyClass2, new Vector2(RandomX, RandomY), Quaternion.identity);
                    Enemy.transform.SetParent(Map2parentObject.transform);
                    Enemy.SetActive(true);


                    SpawnNumb += 1;
                }
            }
        }
        if (PersistentManagerScript.Instance.WorldMapPos == 3)
        {
            for (int i = SpawnNumb; i < 50; i++) // Enemy Class 1 in Map 3
            {

                {
                    //var ClassNumb = 1;

                    var RandomX = Random.Range(map3minX, map3maxX);
                    var RandomY = Random.Range(map3minY, map3maxY);

                    var Enemy = Instantiate(EnemyClass1, new Vector2(RandomX, RandomY), Quaternion.identity);
                    Enemy.transform.SetParent(Map3parentObject.transform);
                    Enemy.SetActive(true);


                    SpawnNumb += 1;
                }

            }
        }

        if (PersistentManagerScript.Instance.WorldMapPos == 4)
        {
            for (int i = SpawnNumb; i < 50; i++) // Enemy Class 3 in Map 4
            {

                {
                    //var ClassNumb = 3;

                    var RandomX = Random.Range(map4minX, map4maxX);
                    var RandomY = Random.Range(map4minY, map4maxY);

                    var Enemy = Instantiate(EnemyClass3, new Vector2(RandomX, RandomY), Quaternion.identity);
                    Enemy.transform.SetParent(Map4parentObject.transform);
                    Enemy.SetActive(true);


                    SpawnNumb += 1;
                }

            }
        }

        if (PersistentManagerScript.Instance.WorldMapPos == 5)
        {
            for (int i = SpawnNumb; i < 50; i++) // Enemy Classes 1-3 random in Map 5
            {

                {
                    var ClassNumb = Random.Range(0, 4);



                    var RandomX = Random.Range(map5minX, map5maxX);
                    var RandomY = Random.Range(map5minY, map5maxY);



                    if (ClassNumb == 1)
                    {
                        var Enemy = Instantiate(EnemyClass1, new Vector2(RandomX, RandomY), Quaternion.identity);
                        Enemy.transform.SetParent(Map5parentObject.transform);
                        Enemy.SetActive(true);
                    }
                    if (ClassNumb == 2)
                    {
                        var Enemy = Instantiate(EnemyClass2, new Vector2(RandomX, RandomY), Quaternion.identity);
                        Enemy.transform.SetParent(Map5parentObject.transform);
                        Enemy.SetActive(true);
                    }
                    if (ClassNumb == 3)
                    {
                        var Enemy = Instantiate(EnemyClass3, new Vector2(RandomX, RandomY), Quaternion.identity);
                        Enemy.transform.SetParent(Map5parentObject.transform);
                        Enemy.SetActive(true);
                    }

                    SpawnNumb += 1;
                }
            }
        }

    }
}


/*
        //////////////////////////////////////////////////////////////////////////////
        if (PersistentManagerScript.Instance.MapChange == 2) // EnemyKillScript ->
        {
            SpawnNumb = 0;
            NewSpawnNumb = 0;


            PersistentManagerScript.Instance.MapChange = 0;
        }

        if (PersistentManagerScript.Instance.MapChange == 0)
        {
            if (PersistentManagerScript.Instance.WorldMapPos == 1)
            {
                NewSpawnNumb = 100;

                minPosX = map1minX;
                maxPosX = map1maxX;
                minPosY = map1minY;
                maxPosY = map1maxY;
            }

            if (PersistentManagerScript.Instance.WorldMapPos == 2)
            {
                NewSpawnNumb = 100;

                minPosX = map2minX;
                maxPosX = map2maxX;
                minPosY = map2minY;
                maxPosY = map2maxY;
            }

            if (PersistentManagerScript.Instance.WorldMapPos == 3)
            {
                NewSpawnNumb = 100;

                minPosX = map3minX;
                maxPosX = map3maxX;
                minPosY = map3minY;
                maxPosY = map3maxY;
            }

            if (PersistentManagerScript.Instance.WorldMapPos == 4)
            {
                NewSpawnNumb = 100;

                minPosX = map4minX;
                maxPosX = map4maxX;
                minPosY = map4minY;
                maxPosY = map4maxY;
            }

            if (PersistentManagerScript.Instance.WorldMapPos == 5)
            {
                NewSpawnNumb = 120;

                minPosX = map5minX;
                maxPosX = map5maxX;
                minPosY = map5minY;
                maxPosY = map5maxY;
            }
            if (PersistentManagerScript.Instance.WorldMapPos == 6) // WHOLE WORLD
            {
                NewSpawnNumb = 1000;

                minPosX = map6minX;
                maxPosX = map6maxX;
                minPosY = map6minY;
                maxPosY = map6maxY;
            }
            */
        /*
        // Spawn enemies by random 1-3
        for (int i = SpawnNumb; i < NewSpawnNumb; i++)
        {

            {
                ClassNumb = Random.Range(0, 4);



                var RandomX = Random.Range(minPosX, maxPosX);
                var RandomY = Random.Range(minPosY, maxPosY);



                if (ClassNumb == 1)
                {
                    var Enemy = Instantiate(EnemyClass1, new Vector2(RandomX, RandomY), Quaternion.identity);
                    Enemy.transform.SetParent(parentObject.transform);
                }
                if (ClassNumb == 2)
                {
                    var Enemy = Instantiate(EnemyClass2, new Vector2(RandomX, RandomY), Quaternion.identity);
                    Enemy.transform.SetParent(parentObject.transform);
                }
                if (ClassNumb == 3)
                {
                    var Enemy = Instantiate(EnemyClass3, new Vector2(RandomX, RandomY), Quaternion.identity);
                    Enemy.transform.SetParent(parentObject.transform);
                }

                SpawnNumb += 1;
            }
        }
        */