using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField] public GameObject carPrefab;
    [SerializeField] private AudioSource CorridaFinal;
    [SerializeField] private AudioSource FimCorridaFinal;

    [SerializeField] private float Tempo;
    private float SpawnCooldown;

    private void Start()
    {
        SpawnCooldown = Tempo;
    }
    // Update is called once per frame
    void Update()
    {
       
        SpawnCooldown -= Time.deltaTime;
        
        if(SpawnCooldown <= 0 && CorridaFinal.enabled == true && FimCorridaFinal.enabled == false)
        {
            Instantiate(carPrefab, transform.position, Quaternion.identity);
            SpawnCooldown = Tempo;
            Debug.Log("Spawn");
        }

    }
}
