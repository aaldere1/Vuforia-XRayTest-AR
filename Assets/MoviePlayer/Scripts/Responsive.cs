using UnityEngine;
using System.Collections;


///Developed By Indie Studio
///https://assetstore.unity.com/publishers/9268
///www.indiestd.com
///info@indiestd.com

public class Responsive : MonoBehaviour
{
		public ScaleType scaleType = ScaleType.PERCENTAGE;//scale method
		public ResponsiveMode responsiveMode = ResponsiveMode.Start;//responsive mode
		public float xscalefrac = 0.1f;//x-scale fraction
		public float yscalefrac = 0.1f;//y-scale fraction
		public float xAspectfrac = 1;//x aspect ratio fraction
		public float yAspectfrac = 1;//y aspect ratio fraction
		public bool doScale = true;
		public Camera cam;
	
		void Start ()
		{
			if (cam == null) {
					cam = Camera.main;
			}
            if (responsiveMode == ResponsiveMode.Start)
            {
                SetScale();
            }
        }
	
		void Update ()
		{
            if (responsiveMode == ResponsiveMode.UPDATE)
            {
                SetScale();
            }
         }
	
		private void SetScale ()
		{
				if (doScale) {
						if (scaleType == ScaleType.ASPECT_RATIO) {
								AspectRatioScaling ();
						} else if (scaleType == ScaleType.PERCENTAGE) {
								PercentageScaling ();
						}
				}
		}

		//Change The Scale Of Current Object Relative To Screen Width and Screen Height
		private void PercentageScaling ()
		{
				int swidth = Screen.width;
				int sheight = Screen.height;
		
				Vector3 sccaleworldvector = cam.ScreenToWorldPoint (new Vector2 (swidth, sheight));//screen pixel scale to world scale
				transform.localScale = new Vector3 (sccaleworldvector.x * xscalefrac, sccaleworldvector.y * yscalefrac, transform.localScale.z);//set new scale	
		}
	
		//Change The Scale Of Current Object Relative To Screen Aspect Ratio
		private void AspectRatioScaling ()
		{
				float aspectRatio = cam.aspect;
				transform.localScale = new Vector3 (aspectRatio * xAspectfrac, aspectRatio * yAspectfrac, 1);//set new scale	
		}
	
		public enum ScaleType
		{
				PERCENTAGE,
				ASPECT_RATIO
		}
	
		public enum ResponsiveMode
		{
				Start,
				UPDATE
		}
}