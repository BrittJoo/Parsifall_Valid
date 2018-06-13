using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Parsifall
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private Slider _slider;

        private readonly List<int> _choices = new List<int>();

        public void Choose()
        {
            _choices.Add((int)_slider.value);
        }
    }
}