using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeManager : MonoBehaviour
{

    public GameObject TubeParent, TubeToSpawn;
    public float XSpawnPos, XDespawnPos;

    List<GameObject> TubesInGame = new List<GameObject>();

    private void Start() {
        XSpawnPos = 14f;

        SpawnTube();
        SpawnTube();
        SpawnTube();
        SpawnTube();
    }

    float _ffXSpawnPos = 14f;
    void SpawnTube(){

        GameObject SpawnedTube = Instantiate(TubeToSpawn, new Vector3(_ffXSpawnPos, Random.Range(2.5f, -2.5f)), Quaternion.Euler(new Vector3(0, 0, 0)), TubeParent.transform);
        TubesInGame.Add(SpawnedTube);
        _ffXSpawnPos += 7;
    }

    void FixedUpdate()
    {
        RelocateTube();
        MoveTubes();
    }


    void RelocateTube(){
        GameObject[] tubes = TubesInGame.ToArray();

        for (int i = 0; i < tubes.Length; i++)
        {
            if(tubes[i].transform.position.x < -14f)
            {
                tubes[i].transform.position = new Vector3(XSpawnPos, Random.Range(2.5f, -2.5f));
            }
        }
    }

    void MoveTubes()
    {
        GameObject[] tubes = TubesInGame.ToArray();

        for (int i = 0; i < tubes.Length; i++)
        {
            tubes[i].transform.position -= new Vector3(2.5f, 0, 0) * Time.fixedDeltaTime;
        }
    }

}
