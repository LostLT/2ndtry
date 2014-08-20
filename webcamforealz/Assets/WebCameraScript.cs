using UnityEngine;

public class WebCameraScript : MonoBehaviour 
{
	public GameObject myCameraTexture;
	private WebCamTexture webCameraTexture;
	void Start () 
	{
		for (int cameraIndex = 0; cameraIndex < WebCamTexture.devices.Length; cameraIndex++) 
		{
			Debug.Log ("Cam:"+WebCamTexture.devices[cameraIndex].name+WebCamTexture.devices[cameraIndex].isFrontFacing);
			if(WebCamTexture.devices[cameraIndex].isFrontFacing)
			{
				Debug.Log ("Selected cam:"+WebCamTexture.devices[cameraIndex].name+WebCamTexture.devices[cameraIndex].isFrontFacing);
				webCameraTexture = new WebCamTexture (WebCamTexture.devices[cameraIndex].name);
				break;
			}
		}    
		myCameraTexture.renderer.material.mainTexture = webCameraTexture;
		webCameraTexture.Play ();
		Debug.Log (webCameraTexture.videoVerticallyMirrored);

	}
}