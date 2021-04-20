using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private void Start()
    {
        StartCoroutine("SpawnDog", 1.5f);
    }
    void Update()
    {

    }

    IEnumerator SpawnDog(float delay)
    {
        while (true)
        {
            while (!Input.GetKeyDown(KeyCode.Space))
            {
                print("Loaded");
                yield return null;
            }

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            print("Recharging...");
            yield return new WaitForSeconds(delay);
        }
    }

}
