using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeKey : MonoBehaviour
{
   int blendShapeCount;
    SkinnedMeshRenderer skinnedMeshRenderer;
    Mesh skinnedMesh;
    int time = 0;

    int playIndex = 0; 

    void Start()
    {
         skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer> ();
        skinnedMesh = GetComponent<SkinnedMeshRenderer> ().sharedMesh;
         blendShapeCount = skinnedMesh.blendShapeCount;
    }

    // Update is called once per frame
    void Update()
    {   
        if (time < 2) {
            time ++ ;
        }
        else{
            if (playIndex > 0) skinnedMeshRenderer.SetBlendShapeWeight(playIndex-1,0);
            if (playIndex == 0) skinnedMeshRenderer.SetBlendShapeWeight(blendShapeCount-1,0);
            skinnedMeshRenderer.SetBlendShapeWeight(playIndex,100f);
            playIndex ++; 
            if (playIndex > blendShapeCount-1) playIndex = 0;
            time = 0;
        }
       
    }
}
