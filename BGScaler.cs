using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Mime;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class BGScaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var worldHeight = Camera.main.orthographicSize * 2f;
        Debug.Log(worldHeight); //=10
        var worldWidth = worldHeight * Screen.width / Screen.height;
        // 10 * 196/327
        transform.localScale = new Vector3(worldWidth, worldHeight, 0f);

    }

}
