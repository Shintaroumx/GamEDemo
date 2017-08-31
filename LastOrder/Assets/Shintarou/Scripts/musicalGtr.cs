//----------------------------------------------
//            	   Koreographer                 
//    Copyright © 2014-2016 Sonic Bloom, LLC    
//----------------------------------------------

using UnityEngine;

namespace SonicBloom.Koreo.Demos
{
	//[RequireComponent (typeof(Rigidbody))]
	[AddComponentMenu ("Koreographer/Demos/Musical Impulse")]
	public class musicalGtr : MonoBehaviour
	{
		[EventID]
		public string eventID;
		//public float jumpSpeed = 3f;
		public GameObject note;
		public float testScale = 3.5f;

		//Rigidbody rigidbodyCom;

		void Start ()
		{
			// Register for Koreography Events.  This sets up the callback.
			Koreographer.Instance.RegisterForEvents (eventID, AddImpulse);

			//rigidbodyCom = GetComponent<Rigidbody> ();
		}

		void OnDestroy ()
		{
			// Sometimes the Koreographer Instance gets cleaned up before hand.
			//  No need to worry in that case.
			if (Koreographer.Instance != null) {
				Koreographer.Instance.UnregisterForAllEvents (this);
			}
		}

		void AddImpulse (KoreographyEvent evt)
		{
			// Add impulse by overriding the Vertical component of the Velocity.
			//Vector3 vel = rigidbodyCom.velocity;
			//vel.y = jumpSpeed;

			Vector2 r = Random.insideUnitCircle.normalized * testScale;
			float ranNum = Random.Range (1.0f, 2.0f);
			Instantiate (note, new Vector3 (r.x * ranNum, r.y / ranNum, 0), Quaternion.identity);
		}
	}
}
