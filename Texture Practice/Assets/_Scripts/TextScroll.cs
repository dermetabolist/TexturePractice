using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScroll : MonoBehaviour {

    //scroll main texture based on time

    float scrollSpeed = .5f;
    float offset;
    float rotate;
 
    private void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10;
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(offset, 0));

    }


}
