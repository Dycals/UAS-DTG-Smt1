using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkTrigger : MonoBehaviour
{
    MapController mc;
    public GameObject targetmap;

    // Start is called before the first frame update
    void Start()
    {
        mc = FindAnyObjectByType<MapController>();
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            mc.currentChunk = targetmap;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if(mc.currentChunk == targetmap)
            {
                mc.currentChunk = null;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
