using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float time = 2f;
    float timer;
    private void Start()
    {
        timer = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= time)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // On spacebar press, send dog
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timer = 0f;
            }
        }
    }
}
