using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    [SerializeField] private float beatTempo;

    public bool isStart;

    private void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    private void Update()
    {
        if (!isStart)
        {
            if (Input.anyKeyDown)
            {
                isStart = true;
            }
        }
        else
        {
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
    }
}
