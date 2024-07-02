using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public BoxCollider2D box;
    public Vector3 posSpawn;
    public GameObject player;
    public bool instantiate;
    // Start is called before the first frame update
    void Start()
    {
        instantiate = false;
        posSpawn = transform.position;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
