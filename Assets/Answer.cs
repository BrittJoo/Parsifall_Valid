using UnityEngine;
using UnityEngine.EventSystems;

namespace Parsifall
{
    public class Answer : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
    {
        public void Drop(Transform t)
        {
            
        }

        public void EnterDrop(Transform t)
        {
            
        }

        public void ExitDrop(Transform t)
        {
            
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = eventData.position;
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            
        }
    }
}