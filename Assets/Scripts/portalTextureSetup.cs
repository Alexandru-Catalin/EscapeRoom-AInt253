using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalTextureSetup : MonoBehaviour {

    public Camera camera_B;
    public Camera camera_A;
    public Material cameraMat_B;
    public Material cameraMat_A;

    // Use this for initialization
    void Start () {

        if(camera_A.targetTexture != null)
        {
            camera_A.targetTexture.Release();
        }
        camera_A.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMat_A.mainTexture = camera_A.targetTexture;

        if (camera_B.targetTexture != null)
        {
            camera_B.targetTexture.Release();
        }
        camera_B.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMat_B.mainTexture = camera_B.targetTexture;

	}
	
	
}
