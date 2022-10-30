using UnityEngine;
using UnityEngine.UI;

public class VolumeReg : MonoBehaviour
{
    [SerializeField] private AudioSource _audsrc;
    [SerializeField] private Slider _slider;

    private void Update()
    {
        _audsrc.volume = _slider.value;
    }


}
