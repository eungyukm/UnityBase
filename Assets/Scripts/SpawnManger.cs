using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    public GameObject zombie;
    public GameObject heart;
    public Transform[] spawnArray;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnZombie());
        StartCoroutine(SpawnHeart());
    }

    /// <summary>
    /// 좀비를 생성하는 코루틴
    /// </summary>
    /// <returns></returns>
    IEnumerator SpawnZombie()
    {
        while(true)
        {
            yield return new WaitForSeconds(1f);

            Instantiate(zombie, spawnArray[Random.Range(0, 3)]);
        }
    }

    IEnumerator SpawnHeart()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);

            Instantiate(heart, spawnArray[Random.Range(3, 6)]);
        }
    }
}
