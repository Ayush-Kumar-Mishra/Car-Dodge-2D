using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBg : MonoBehaviour
{
    public MeshRenderer rd;
    public float speed;

    void Update()
    {
        rd.material.mainTextureOffset = new Vector2(0, speed * Time.time);
    }
}
