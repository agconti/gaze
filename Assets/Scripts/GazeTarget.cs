using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;


public class GazeTarget : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	Renderer renderer;
	Color activeColor = Color.green;
	Color inActiveColor = Color.grey;

	void Awake () {
		renderer = GetComponent<Renderer> ();
	}

	void Start () {
		renderer.material.color = inActiveColor;
	}

	public void OnPointerEnter (PointerEventData eventData) {
		renderer.material.color = activeColor;
	}

	public void OnPointerExit (PointerEventData eventData) {
		renderer.material.color = inActiveColor;
	}
}
