using UnityEngine;
using UnityEngine.EventSystems;

namespace Parsifall
{
    public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
    {
        public void OnDrop(PointerEventData eventData)
        {
            var answer = eventData.pointerDrag.GetComponent<Answer>();
            if (!answer) return;
            answer.Drop(transform);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            if (!eventData.pointerDrag) return;

            var answer = eventData.pointerDrag.GetComponent<Answer>();
            if (!answer) return;
            answer.EnterDrop(transform);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            if (!eventData.pointerDrag) return;

            var answer = eventData.pointerDrag.GetComponent<Answer>();
            if (!answer) return;
            answer.ExitDrop(transform);
        }
    }
}