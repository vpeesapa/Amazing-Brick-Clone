using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private float smoothFactor = 6.0f;

    [SerializeField]
    private Transform deathBlock;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(player.transform.position.y > this.transform.position.y)
        {
            transform.position = Vector3.Lerp(transform.position,new Vector3(transform.position.x,player.transform.position.y,transform.position.z),smoothFactor * Time.fixedDeltaTime);

            // Updating the position of the death block
            Vector3 screenDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0,0));
            deathBlock.position = new Vector3(deathBlock.position.x,screenDimensions.y,deathBlock.position.z);
        }
    }
}
