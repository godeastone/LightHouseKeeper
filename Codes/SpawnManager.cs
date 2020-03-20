using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public int MaxCount;
    public int boatCount;
    private int num;
    private int BoatLevel;
    
    public float spawnTime;
    public float curTime;
    public Transform[] spawnPoints;
    public GameObject[] boat;
    public static SpawnManager _instance;

    private void Start()
    {
        _instance = this;
    }

    private void Update()
    {
        if (curTime >= spawnTime && boatCount < MaxCount)
        {
            BoatLevel = Random.Range(0, 5);
            //보트의 생성종류 컨트롤
            num = Random.Range(0, 4);
            //보트의 스폰위치 컨트롤
            SpawnBoat(num,BoatLevel);
        }
        curTime += Time.deltaTime;
    }

    public void SpawnBoat(int x, int y)
    {
        boatCount++;
        curTime = 0;
        Instantiate(boat[y], spawnPoints[x]);
    }
}
