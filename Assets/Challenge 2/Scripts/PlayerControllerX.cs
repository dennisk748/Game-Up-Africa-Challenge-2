using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float outsideVisible;
    bool waitForSeconds = false;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(WaitForSeconds());
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !waitForSeconds)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            waitForSeconds = true;
        }
    }
    IEnumerator WaitForSeconds()
    {
        if (waitForSeconds)
        {
            yield return new WaitForSeconds(2.5f);
            waitForSeconds = false;
        }
    }
}
