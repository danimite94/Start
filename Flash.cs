using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Flash : MonoBehaviour {

    private AndroidJavaObject javaCamera;
    private bool torchActive = false;

    void ActivateTorch()
    {
        AndroidJavaClass cameraClass = new AndroidJavaClass("android.hardware.Camera");
        int camID = 0;
        javaCamera = cameraClass.CallStatic<AndroidJavaObject>("open", camID);
        if (javaCamera != null)
        {
            AndroidJavaObject cameraParameters = javaCamera.Call<AndroidJavaObject>("getParameters");
            cameraParameters.Call("setFlashMode", "torch");
            javaCamera.Call("setParameters", cameraParameters);
            this.torchActive = true;
        }
        else
            Debug.LogError("[CameraParametersAndroid] Camera not available");

    }

    void DeactivateTorch()
    {
        if (javaCamera != null)
        {
            javaCamera.Call("stopPreview");
            javaCamera.Call("release");
            this.torchActive = false;
        }
        else
            Debug.LogError("[CameraParametersAndroid] Camera not available");
    }

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {

     
    }
        
}
