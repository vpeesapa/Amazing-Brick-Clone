using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = transform.localScale.x / 2;
        objectHeight = transform.localScale.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewPos = transform.position;
        //viewPos.x = Mathf.Clamp(viewPos.x,screenBounds.x + objectWidth,screenBounds.x * -1 - objectWidth);
        //viewPos.y = Mathf.Clamp(viewPos.y,screenBounds.y + objectHeight,screenBounds.y * -1 - objectHeight);

        if(viewPos.x + objectWidth >= screenBounds.x)
        {
            viewPos.x = screenBounds.x - objectWidth;
        }

        if(viewPos.x - objectWidth <= -1.0f * screenBounds.x)
        {
            viewPos.x = -1.0f * screenBounds.x + objectWidth;
        }

        //if (viewPos.y + objectHeight >= screenBounds.y)
        //{
        //    viewPos.y = screenBounds.y - objectHeight;
        //}

        if (viewPos.y - objectHeight <= -1.0f * screenBounds.y)
        {
            viewPos.y = -1.0f * screenBounds.y + objectHeight;
        }

        transform.position = viewPos;
    }
}
