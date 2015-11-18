using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;


public class GazeTarget : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public void OnPointerEnter (PointerEventData eventData) {
		Debug.LogFormat ("Entered Gaze? {0}", eventData);
	}

	public void OnPointerExit (PointerEventData eventData) {
		Debug.LogFormat ("Left Gaze? {0}", eventData);
	}
}
