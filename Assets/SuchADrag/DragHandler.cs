using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class DragHandler : MonoBehaviour, IDragHandler,IBeginDragHandler, IEndDragHandler,IPointerClickHandler {

	public void OnBeginDrag(PointerEventData _data) {
		Debug.Log("Started dragging " + gameObject.name + "!");
	}

	public void OnDrag(PointerEventData _data) {
		Debug.Log("You are dragging "+gameObject.name+"!");
	}

	public void OnEndDrag(PointerEventData _data) {
		Debug.Log("Finished dragging " + gameObject.name + ".");
	}

	public void OnPointerClick(PointerEventData _data) {
		Debug.Log("You clicked " + gameObject.name + "!");
	}

}
